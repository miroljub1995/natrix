# Tailwind CSS Source Generator

Covers three projects that are one subsystem: `Natrix.TailwindCss` (the package),
`Natrix.TailwindCss.Generators` (this one) and `Natrix.TailwindCss.Tests`. Read
this before changing any of them. [`ARCHITECTURE.md`](ARCHITECTURE.md) has the
same structure as diagrams if you prefer to see it.

`[GeneratedTailwindCss("Styles/app.css")]` turns a partial method into the compiled
Tailwind stylesheet for that entry file. The generator runs the **real Tailwind
compiler** — the actual JavaScript, bundled by esbuild — during the build, in
[Jint](https://github.com/sebastienros/jint), a JavaScript interpreter written in
.NET. Consumers need no Node, no CLI and no watcher.

## Projects

| Project | Target frameworks | Role |
| --- | --- | --- |
| `Natrix.TailwindCss` | `net9.0;net10.0` | The shipped package. Assembles the analyzer, its three dependencies, the targets and Tailwind's stylesheets, and carries the only runtime code in the subsystem: `HotReload/`, which pushes a regenerated stylesheet into the browser. That is why it — and only it — references `Natrix.Core` and `Natrix.StdWeb`. |
| `Natrix.TailwindCss.Generators` | `netstandard2.0` | The incremental generator: Roslyn pipeline, stylesheet resolution, embedded Tailwind bundle, `TailwindCompiler`, which runs the bundle in Jint, and `CssMinifier`. |
| `Natrix.TailwindCss.Tests` | `net9.0;net10.0` | TUnit + Verify. 83 tests, covering the generator and the package's runtime half. |

Plus `src/Natrix.TailwindCss.Generators/js/` — the esbuild bundle sources
(`tailwindcss` and `esbuild` are the only npm dependencies).

## Why it is built this way

A source generator does not run in the application's process. It runs inside the
compiler host, and that host is **not always the same runtime**:

- `dotnet build`, Rider, VS Code → VBCSCompiler on modern .NET
- Visual Studio → `devenv.exe` / `MSBuild.exe` on .NET Framework 4.7.x

That is why Roslyn's **RS1041** requires generators to target `netstandard2.0`.
Jint has a `netstandard2.0` build and is pure managed code, so it is an ordinary
analyzer dependency: referenced directly, shipped beside the analyzer in
`analyzers/dotnet/cs/`, and the same on every host and platform. There is nothing
native, nothing per RID, and no reflection boundary. Until October 2026 the engine
was V8 through ClearScript, which needed all three; see *History* for why it went.

## Rules that are easy to break

**Jint, Acornima and NUglify ship beside the analyzer, and nothing else does.**
The generator references all three with `PrivateAssets="all"`, so none flows into
a consuming app (the browser app would otherwise ship a JavaScript interpreter it
never calls). Three mechanisms deliver them to Roslyn, one per kind of consumer:
the package packs them into `analyzers/dotnet/cs/`;
`GetNatrixAnalyzerDependencyTargetPaths` hands them to an in-repo
`OutputItemType="Analyzer"` project reference, which otherwise receives only the
generator itself; and `StageTailwindStylesheets` copies them into the generator's
`bin/`, which the package packs from. The last two read the
`NatrixAnalyzerDependency` items, the package lists each file itself, so a new
dependency needs both. The test project runs the generator in-process, so it
references Jint and NUglify itself. Acornima's `netstandard2.0` build also needs
`System.Memory` and `System.Runtime.CompilerServices.Unsafe`. Those are
deliberately *not* shipped: every compiler host already has them, because Roslyn
depends on them, and a second copy beside the analyzer is how binding conflicts
start. Bump `Jint` and `Acornima` together in `Directory.Packages.props`; Acornima
must stay at the version Jint depends on.

**Every compilation runs on its own 16 MB thread under a call-depth limit.** Jint
interprets on the CLR stack, a few KB per JavaScript frame, and has no stack guard
of its own. A stack overflow cannot be caught, so in VBCSCompiler it would kill the
compiler server for every project on the machine. `MaxCallDepth` (256) turns
runaway recursion into a `TWCSS003` error long before `StackSize` (16 MB) runs out.
Measured with a deliberately frame-heavy recursion: a limit of 512 overflowed even a
1.5 MB stack, 256 fit in 1 MB, and 16 MB held 2048. Tailwind 4.3 itself needs a
depth of 9 and runs on a 64 KB stack. The stack is fixed rather than inherited
because hosts differ (a Windows thread-pool thread has 1 MB). A new thread per
compile costs ~45 µs against a ~90 ms compile (a thread-pool hop is ~2 µs). Do not
move compiles onto the thread pool: its stack size belongs to the compiler host and
cannot be raised from an analyzer, so the call-depth limit would have to be tuned
to a stack we cannot see, and getting that wrong kills the compiler server. A
long-lived worker thread with a queue would save the same ~45 µs at the cost of
the queue, cross-thread exception plumbing and a thread that lives as long as the
server.
`RunawayRecursionIsAnErrorNotAStackOverflow` guards the pair: raise the limit too
far, or drop the thread, and it crashes the test host rather than passing.

**The parsed bundle is shared; the engine is not.** `Engine.PrepareScript` runs
once per process, and every compilation gets a fresh `Engine`, executes the
prepared bundle in it and calls the entry point. Creating the engine and running
the bundle costs under a millisecond, and a prepared script is safe to share
between engines and threads. So there is no lock, and concurrent generator runs
(one per attributed method, or several projects in one server) compile in
parallel. `CompilesConcurrently` covers it.

**Each compilation is independent — do not cache Tailwind's compiled
stylesheet.** It is tempting, because `compile()` is most of the cost. It is also
wrong: Tailwind's `build()` is incremental and returns the *union* of every
candidate it has ever seen, so a reused compilation keeps emitting classes that
were deleted from the source. A previous attempt guarded this with a "reuse only
while the candidate set grows" check; it worked, but the subtlety was not worth
the cost.

**One deadline bounds every compilation: Roslyn's token or 30 seconds.**
`TailwindCompiler.Run` links `spc.CancellationToken` with `Timeout` and hands the
result to Jint both as the engine's cancellation constraint and as the token the
promise is awaited with. So an IDE never waits for a compile it no longer needs,
and a command-line build, which has no cancellation at all, cannot hang on an
infinite loop or a promise that never settles; it gets `TWCSS003` instead. A
cancelled token surfaces as `OperationCanceledException`, which is what Roslyn
expects. Only a timeout becomes `TWCSS003`, because swallowing a cancellation
would report a spurious error. `StopsAnInfiniteLoopAtTheDeadline`,
`GivesUpOnAPromiseThatNeverSettles` and `StopsWaitingWhenCancelled` cover the
three outcomes.

**Nothing crosses the boundary as JSON.** `css` and `base` are passed as strings,
the candidates as a real JavaScript array (`JsArray`), and an `@import` is
answered with a `StylesheetResult` host object read as `result.Error` /
`result.Path` in JavaScript. `StylesheetResult` carries a failure rather than
throwing, because a .NET exception thrown inside a callback unwinds through the
engine instead of becoming a JavaScript error Tailwind can report.

**The entry point is `async`, and its promise is genuinely awaited.**
`UnwrapIfPromise(token)` runs the engine's pending jobs and blocks until the
promise settles. A promise that is still pending after the microtasks have run is
waited for, not treated as an error, so if Tailwind (or our entry point) ever
awaits work the host finishes later, such as a `Task` returned to JavaScript, it
just works. `AwaitsWorkTheHostFinishesLater` pins this down, including that the
JavaScript after the `await` resumes on the compiler thread. Use the overload
that takes a token: the parameterless one gives up after a fixed 10 seconds that
`Constraints.PromiseTimeout` does not change. Do not switch to
`UnwrapIfPromiseAsync`: the generator is synchronous, so it would only block on the
`Task`, and an `await` could resume the engine on a thread-pool thread without the
16 MB stack. The one kind of async Jint cannot provide is a timer: there is no
`setTimeout`. A Tailwind that started using one would fail with a `ReferenceError`
(`TWCSS001`) rather than hang, and would need a timer shim in `shims.js`.

**The bundle targets ES2022, and Jint is not V8.** Every Verify snapshot was
byte-identical when the engine moved from V8 to Jint, but Jint is an independent
ECMAScript implementation, and Tailwind leans hard on regular expressions, which
Jint translates to .NET ones. A Tailwind upgrade can reach a corner Jint handles
differently. The snapshots are the guard, and `CompilesCssThroughJint` keeps an
engine failure from masquerading as a Tailwind one.

**The output is minified unless `DEBUG` is defined.** Tailwind's CLI minifies
with Lightning CSS, which is native (Rust) and so cannot run in the compiler for
the reasons in *History*. NUglify stands in: pure managed, `netstandard2.0`, no
dependencies. The switch is `DEBUG` in the parse options rather than an MSBuild
property, so a Release build minifies with no configuration and a Debug build,
where hot reload runs, keeps the CSS readable. `ParseOptionsProvider` is projected
to a `bool` before it joins the pipeline, so changing any other parse option does
not re-run the output step (`CachesWhenAnotherParseOptionChanges`). Minifying runs
after the compile, outside Jint, on the compiler thread; on the docs app it costs
~10 ms warm and ~110 ms on first use, against the ~90 ms compile. If NUglify cannot
parse the stylesheet (it rejects some valid CSS, such as a `{}` block as a custom
property value) the CSS is emitted unminified with a `TWCSS006` warning rather
than failing the build. Checked on the docs app by parsing both stylesheets in
Chromium: the same 895 rules, differing only in two places that Lightning CSS
rewrites the same way (`initial-value: 0px` → `0` in `@property`, `red` → `#f00`
in `@supports`). The tests run Debug by default (`Harness.Debug`), so every
snapshot except `MinifiesWhenDebugIsNotDefined` shows readable CSS.

**Combining `AnalyzerConfigOptionsProvider` into the per-file pipeline is safe
only because the `Select` projects to an equatable value.** That provider has no
value equality, so the per-file step re-runs on every compilation; because it
produces a `Stylesheet`, downstream steps still compare by value and the
expensive compile stays cached. Never let the provider itself flow further down.
This is what makes `CompilerVisibleItemMetadata` (the `TailwindModule` metadata)
usable at all.

**Everything leaving `.Collect()` must be wrapped in `EquatableArray<T>`.**
`ImmutableArray<T>` compares by backing-array identity, so identical contents come
out unequal and the expensive Tailwind compile re-runs on every keystroke.
`IncrementalityTests` guards this.

**Do not store a `Location` in a pipeline model.** It holds a `SyntaxTree` alive and
breaks caching; use the `LocationInfo` record and rebuild via `Location.Create`.

**Tailwind's own stylesheets are not special-cased.** They ship as real files in
`tools/tailwindcss/`, and the targets file hands them to the generator as
`AdditionalFiles` carrying `TailwindModule` metadata. Nothing in the resolver
mentions Tailwind; any CSS package is exposed the same way. Only the JavaScript
bundle is still an embedded resource.

**`TailwindModule` is an exports list, not a directory.** Matching is exact: an
id resolves only if some file declared it. `tailwindcss/theme` works because
`theme.css` declares it, *not* because it sits beside `index.css` — an earlier
version split on `/` and walked the module's directory, which let callers reach
files a package never meant to expose. npm gates deep imports behind its
`exports` map and so do we. A package's own stylesheets can still reach its
unexported files, because the `base` handed back is the module's own directory.

**The ids are comma-separated, not semicolon-separated.** One file may declare
several (`"tailwindcss/theme,tailwindcss/theme.css"`), mirroring how an exports
map aliases. Semicolons look like the natural MSBuild list separator and are a
trap. Measured with a generator that echoes the raw metadata: MSBuild writes the
value out intact, but Roslyn's editorconfig reader strips `;` and `#` as *inline*
comments, so `a;b` arrives as `a`. Escaping does not help either — MSBuild
unescapes `%3B` back into a `;` before writing. The failure is silent, because
the first id still works. An id may contain neither character; a comma survives
untouched.

`TailwindModule` is a mechanism for *packages*, added by their targets. An
application never sets it — its own stylesheets are reached by relative import.

**Every stylesheet is keyed by its absolute path, and the resolver holds no
project directory.** Resolution is a pure function of `(base, specifier)`, where
`base` is the directory of the importing file — the same value Tailwind hands
back to `loadStylesheet`. An earlier design keyed files project-relative and kept
a `projectDir` to reconcile the two forms, because a file outside the project
could only be keyed absolutely while `@import "../../Shared/theme.css"`
normalized to a project-relative string, and the two never met. Making the key
absolute removes the mismatch rather than patching it;
`ResolvesImportsThatClimbOutOfTheProject` still guards the case.

**The entry stylesheet is named relative to the source file the attribute is
written in**, not to the project. `MethodInfo.SourceDirectory` comes from
`ctx.TargetNode.SyntaxTree.FilePath`, and the base handed to `compile()` is the
entry file's own directory — so from that point on the resolver only ever sees a
base that Tailwind gave it. Tests must parse their sources **with a path**, or
there is no directory to resolve against.

**Relative resolution comes first, modules second — do not "fix" this.** It
looks backwards, and an earlier version had it the other way with the comment
"so a stray `tailwindcss.css` cannot shadow the real package". Upstream allows
that shadowing on purpose: `@tailwindcss/vite` builds its CSS resolver with
`preferRelative: true`, and `@tailwindcss/node` consults that `customCssResolver`
*before* its own `node_modules` lookup. So a file sitting next to the importer
beats a package of the same name, and a bare `@import "components.css"` resolves
relatively. `ASameNamedFileBesideTheImporterShadowsTheModule` pins the order
down. Only the CLI/PostCSS path (plain `enhanced-resolve`, no custom resolver)
treats a bare specifier as package-only.

**The targets file must never glob the consumer's stylesheets.** A project
declares its own `<AdditionalFiles Include="Styles\**\*.css" />`. Globbing them
for the consumer was removed deliberately: item metadata reaches the compiler
through a generated editorconfig keyed by file path, so re-adding a file that is
already an `AdditionalFile` collapses into the same section and erases whatever
metadata was on it - including metadata belonging to an unrelated analyzer whose
file the glob merely happened to match. Leaving the set to the project also keeps
bin/obj, wwwroot and tooling caches out without maintaining an exclusion list.

**Stylesheet resolution must never touch the filesystem.** Every import is answered
from the `AdditionalFiles` snapshot Roslyn supplied. That is exactly what makes
editing a `.css` file re-run generation. The generator touches no files at all,
so RS1035 (no file I/O in analyzers) is enforced, not suppressed — keep it that
way.

**The pipeline carries every `.css` file; only imported ones reach the output.**
All of them are read into memory and held in the `Stylesheets` step, while
`StylesheetResolver.Load` serves only what the entry stylesheet imports. The
consequence is that editing *any* stylesheet — even one nothing imports —
invalidates the step and re-runs the Tailwind compile. That is inherent to the
incremental model: steps compare by value, and there is no way to express "only
the subset I read matters". `RecompilesWhenAnUnimportedStylesheetChanges` pins the
behaviour down. It is cheap for a handful of files; a large vendored stylesheet in
the project would make every keystroke pay for it.

### MSBuild specifics

**Globs over generated output belong inside a target, not a top-level `ItemGroup`.**
On a clean tree the bundle has not been built when the project is evaluated, so a
top-level glob matches nothing and silently produces an empty result. Both
`StageTailwindStylesheets` and `AddTailwindStylesheetsToPackage` glob at execution
time and `Error` if the result is empty.

**The pack hook is `BeforeTargets="_GetPackageFiles"`**, not `GenerateNuspec` —
the latter runs *after* package files have been collected, so items added there are
dropped and you get a package without Tailwind's stylesheets.

**Staging uses `Copy`, not `None` with `CopyToOutputDirectory`**, which would flow
transitively into every referencing project's output. `StageTailwindStylesheets`
is also guarded on `'$(TargetFramework)' != ''`, because the cross-targeting outer
build leaves `$(OutDir)` empty and would drop the files into the source tree.

**Tailwind's stylesheets ship under `tools/tailwindcss/`**, not `content/` or
`contentFiles/`, so they never land in a consumer's output. The targets file points
`NatrixTailwindCssDir` there; in-repo consumers set it to the generator's
`bin/<Configuration>/netstandard2.0/tailwindcss/`.

## Building

**Node.js and npm are required.** `src/Natrix.TailwindCss.Generators/Resources/` is
generated output and is gitignored; `BundleTailwind` runs `npm ci` and esbuild before
`AssignTargetPaths`. `npm ci` is deliberately unconditional — guarding it on
`node_modules` existing meant a Tailwind version bump silently re-bundled the old
version.

To bump Tailwind: change the version in `js/package.json`, run `npm install` to
refresh the lockfile, commit the lockfile. The next build reinstalls and rebundles.
The Verify snapshots embed the version banner (`/*! tailwindcss v4.3.0 */`), so they
will fail until re-accepted — that is intended, it puts the upgrade in review. Read
any other snapshot difference as a possible Jint incompatibility, not just a
Tailwind change.

## Diagnostics

| Id | Meaning |
| --- | --- |
| `TWCSS001` | Tailwind rejected the stylesheet — syntax error, unresolved `@import`, or `@plugin`/`@config` |
| `TWCSS002` | Entry stylesheet not among the project's stylesheets |
| `TWCSS003` | The JavaScript engine failed — the bundle did not parse, or the call-depth limit was hit |
| `TWCSS004` | `@source` ignored; candidates come from string literals |
| `TWCSS005` | The annotated method must be `partial`, return `string`, take no parameters |
| `TWCSS006` | Warning: NUglify could not minify the stylesheet, so it is emitted unminified |

## Candidate collection

Candidates are **every string literal in the compilation, split on whitespace**.
There is no file scanning, so `@source` is ignored. Two consequences worth knowing
when writing tests or docs: a class list embedded in markup
(`"""<div class="flex">"""`) yields `class="flex`, not `flex`, so class lists want
their own literal; and names assembled at runtime (`"p-" + size`) cannot be seen.

## History — do not redo

**V8 through ClearScript, replaced by Jint in October 2026.** The generator used to
run the bundle in V8. ClearScript has no `netstandard2.0` asset, so that took a
separate bridge assembly built for `net462` and `net8.0`, reflection-loaded from a
payload directory, a contract assembly that had to load exactly once, a native
library per RID injected through `NativeLibrary.SetDllImportResolver`, and a
package of roughly a quarter of a gigabyte. The breaking point was a compiler-server
hang. VBCSCompiler is shared by every worktree and configuration, and Roslyn loads
each analyzer path into its own load context, so each copy loaded its own V8
native. On macOS the second one wedged the server permanently. The dylib exports
~5,900 weak `v8::` symbols, dyld binds weak definitions to the first image that
provides them, so the second copy ran partly on the first copy's code, faulted, and
the CLR re-dispatched the fault forever. One copy survived 60 builds; the first
build that loaded a second copy hung, every time. Making the engine process-wide
fixed it but added a cross-version contract between analyzer copies. Jint removes
the whole class of problem. Measured on the docs app (440 candidates) before
switching: byte-identical output; cold start about equal (~1.2 s, Jint warm-up and
parse versus native load); warm builds ~90–100 ms on Jint versus ~13–17 ms on V8.
The ~80 ms per recompile was judged worth deleting the bridge, the payload and
every native-loading rule. Going back to V8 means solving one-native-per-process
first.

**Hosting ClearScript in a NativeAOT library** was evaluated while V8 was still the
engine, and rejected: NativeAOT cannot cross-compile, the AOT library added to the
34 MB native rather than replacing it, and ILC aborted on ClearScript's generic
recursion (`IL3054`). It is moot now.

## Unverified

**A .NET Framework compiler host (Visual Studio, Rider on Windows) has not run the
generator.** Jint's `netstandard2.0` build should load there like any analyzer
dependency, with `System.Memory` and `System.Runtime.CompilerServices.Unsafe`
coming from the host, but nobody has watched it happen. If those two ever fail to
bind there, shipping them beside the analyzer is the first thing to try.

**Large applications.** The ~90 ms figure is for 440 candidates. `build()` grows
with the candidate count, and a project with thousands of distinct string tokens
has not been measured. In an IDE that cost is paid whenever a string literal
changes.
