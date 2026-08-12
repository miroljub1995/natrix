# Tailwind CSS Source Generator

Covers five projects that are one subsystem: `Natrix.TailwindCss` (the package),
`Natrix.TailwindCss.Generators` (this one), `Natrix.TailwindCss.Engine.Abstractions`
(the contract), `Natrix.TailwindCss.Engine` (the ClearScript bridge) and
`Natrix.TailwindCss.Generators.Tests`. Read this before changing any of them.
[`ARCHITECTURE.md`](ARCHITECTURE.md) has the same structure as diagrams if you
prefer to see it.

`[GeneratedTailwindCss("Styles/app.css")]` turns a partial method into the compiled
Tailwind stylesheet for that entry file. The generator runs the **real Tailwind
compiler** — the actual JavaScript, bundled by esbuild and executed in a V8 isolate
via ClearScript — during the build. Consumers need no Node, no CLI and no watcher.

## Projects

| Project | Target frameworks | Role |
| --- | --- | --- |
| `Natrix.TailwindCss` | `net9.0;net10.0` | The shipped package. **Contains no source** — it only assembles the analyzer, targets and engine payload. |
| `Natrix.TailwindCss.Generators` | `netstandard2.0` | The incremental generator: Roslyn pipeline, stylesheet resolution, embedded Tailwind bundle. |
| `Natrix.TailwindCss.Engine.Abstractions` | `netstandard2.0` | `ITailwindEngine`, `StylesheetResult` and the two exception types. |
| `Natrix.TailwindCss.Engine` | `net462;net8.0` | The bridge. The **only** code that names a ClearScript type. Built once per compiler-host runtime. |
| `Natrix.TailwindCss.Generators.Tests` | `net9.0;net10.0` | TUnit + Verify. 66 tests. |

Plus `src/Natrix.TailwindCss.Generators/js/` — the esbuild bundle sources
(`tailwindcss` and `esbuild` are the only npm dependencies).

## Why it is split this way

A source generator does not run in the application's process. It runs inside the
compiler host, and that host is **not always the same runtime**:

- `dotnet build`, Rider, VS Code → VBCSCompiler on modern .NET
- Visual Studio → `devenv.exe` / `MSBuild.exe` on .NET Framework 4.7.x

That is why Roslyn's **RS1041** requires generators to target `netstandard2.0`, and
it is on by default — not something this repo opted into.

ClearScript has **no `netstandard2.0` asset**, and .NET Framework cannot load its
`netstandard2.1` one. So the analyzer cannot reference ClearScript in either
direction. Hence the bridge: built for both host runtimes and reflection-loaded,
with a public surface of BCL types plus the two contract types
(`ITailwindEngine.Build` takes `string`, `string[]` and a
`Func<string, string, StylesheetResult>`). Type identity unifies across the load
boundary because those contract types come from a single assembly that loads
exactly once — see the rule below.

## Rules that are easy to break

**The analyzer must never reference a ClearScript type.** It references only
`Natrix.TailwindCss.Engine.Abstractions`; reflection is used exactly once, to
`Activator.CreateInstance` the engine type and cast it to `ITailwindEngine`.
Everything after that is a normal interface call. (Before the contract existed
this needed a `[MethodImpl(MethodImplOptions.NoInlining)]` boundary, because the
JIT resolves assembly references when it compiles the *method that mentions the
type*. Naming a ClearScript type in the analyzer would bring that hazard back.)

**Exactly one copy of the contract assembly may ever load.** It ships in
`analyzers/dotnet/cs/` beside the analyzer and is explicitly excluded from both
engine flavor directories. A second copy would give `ITailwindEngine` two
identities and the cast in `TailwindCompiler` would throw `InvalidCastException`.
The exclusion lives in `StageTailwindPayload`; the packaged-consumer test is what
proves it end to end.

**Each compilation is independent — do not cache the parsed stylesheet.** It is
tempting, because `compile()` costs roughly 28 ms against 11 ms for `build()`
warm. It is also wrong: Tailwind's `build()` is incremental and returns the
*union* of every candidate it has ever seen, so a reused compilation keeps
emitting classes that were deleted from the source. A previous attempt guarded
this with a "reuse only while the candidate set grows" check; it worked, but the
subtlety was not worth the ~28 ms.

**Do not add periodic recycling of the V8 runtime.** It looks prudent and is not:
measured over 400 consecutive builds the isolate's heap is flat (~31-34 MB used,
~71-87 MB total), because each build's engine is disposed and `MaxOldSpaceSize`
caps the rest. The one-time ~830 ms cost is loading the native library, not
constructing the runtime — a second `V8Runtime` costs ~0 ms — so neither the fear
nor the cost estimate that motivated it held up.

**Nothing crosses the boundary as JSON.** `css`, `base` and the candidate array
are marshalled directly, and an `@import` is answered with a `StylesheetResult`
host object read as `result.Error` / `result.Path` in JavaScript. The candidate
array arrives as a host array, hence `Array.from(candidates)` before handing it
to Tailwind.

**The entry point is `async` and its promise is converted to a `Task`.**
`V8ScriptEngineFlags.EnableTaskPromiseConversion` plus `GetAwaiter().GetResult()`
replaces the old poll-a-state-object loop. Blocking is safe only because nothing
in the chain needs a macrotask — `compile()` awaits just the synchronous host
callback, so the promise is already settled when `Invoke` returns. Introducing a
timer or real I/O into that path would deadlock.

**Never hand-list the engine's assemblies.** `StageTailwindPayload` globs the
engine's real build output (`CopyLocalLockFileAssemblies=true`). ClearScript's
`net462` asset needs `Microsoft.Bcl.AsyncInterfaces`, `System.Memory`,
`System.ValueTuple` and ~11 more facades — 17 assemblies versus 4 for `net8.0`.
A curated list silently omits one and Visual Studio fails at runtime.
`ClearScriptLoader` correspondingly resolves *anything* present in the flavor
directory rather than matching a fixed allowlist.

**`HostSettings.AuxiliarySearchPath` is not sufficient** for the native V8 library.
ClearScript uses it to decide the library exists, then `dlopen`s it by bare name,
which only ever finds the application directory — i.e. the compiler host. The
native must be injected via `NativeLibrary.SetDllImportResolver` (`net8.0`) or a
pre-emptive `LoadLibrary` (`net462`). See `NativeV8Loader`. This is why the modern
flavor is `net8.0` rather than `netstandard2.1`: that API does not exist in
netstandard.

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
`tools/tailwind/css/`, and the targets file hands them to the generator as
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
editing a `.css` file re-run generation, and it keeps RS1035 honest.

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
On a clean tree the engine has not been built when the project is evaluated, so a
top-level glob matches nothing and silently produces an empty payload. Both
`StageTailwindPayload` and `AddTailwindPayloadToPackage` glob at execution time and
`Error` if the result is empty.

**The pack hook is `BeforeTargets="_GetPackageFiles"`**, not `GenerateNuspec` —
the latter runs *after* package files have been collected, so items added there are
dropped and you get a package with no engine in it.

**Central Package Management does not cover `PackageDownload`.** Its version must be
literal, so `$(ClearScriptVersion)` in `Directory.Packages.props` is the source of
truth and the `PackageVersion` entry consumes it. The reverse is not expressible:
MSBuild evaluates *every property before any item*, so a property can never read
`@(PackageVersion)`.

**The engine is built via an `MSBuild` task, not a `ProjectReference`**, because both
TFMs are needed and a `ProjectReference` resolves exactly one. The `Restore` call
passes `RemoveProperties="TargetFramework"` — otherwise this project's TFM flows in
as a global property and ClearScript is resolved against `netstandard2.0`.

**Payload staging uses `Copy`, not `None` with `CopyToOutputDirectory`**, which would
flow transitively into every referencing project's output — a quarter of a gigabyte
each time. `StageTailwindPayload` is also guarded on `'$(TargetFramework)' != ''`,
because the cross-targeting outer build leaves `$(OutDir)` empty and would drop the
payload into the source tree.

**The engine payload lives under `tools/`, never `analyzers/`.** NuGet hands every
assembly below `analyzers/` to Roslyn as an analyzer, which would try to load
ClearScript into a compiler that cannot run it.

## Building

**Node.js and npm are required.** `src/Natrix.TailwindCss.Generators/Resources/` is
generated output and is gitignored; `BundleTailwind` runs `npm ci` and esbuild before
`AssignTargetPaths`. `npm ci` is deliberately unconditional — guarding it on
`node_modules` existing meant a Tailwind version bump silently re-bundled the old
version.

To bump Tailwind: change the version in `js/package.json`, run `npm install` to
refresh the lockfile, commit the lockfile. The next build reinstalls and rebundles.
The Verify snapshots embed the version banner (`/*! tailwindcss v4.3.0 */`), so they
will fail until re-accepted — that is intended, it puts the upgrade in review.

Shipped build-host RIDs: `osx-arm64`, `osx-x64`, `linux-arm64`, `linux-x64`,
`win-x64`, `win-arm64`. Anything else gets a `TWCSS003` diagnostic.

## Diagnostics

| Id | Meaning |
| --- | --- |
| `TWCSS001` | Tailwind rejected the stylesheet — syntax error, unresolved `@import`, or `@plugin`/`@config` |
| `TWCSS002` | Entry stylesheet not among the project's stylesheets |
| `TWCSS003` | The engine could not start on this build host |
| `TWCSS004` | `@source` ignored; candidates come from string literals |
| `TWCSS005` | The annotated method must be `partial`, return `string`, take no parameters |

## Candidate collection

Candidates are **every string literal in the compilation, split on whitespace**.
There is no file scanning, so `@source` is ignored. Two consequences worth knowing
when writing tests or docs: a class list embedded in markup
(`"""<div class="flex">"""`) yields `class="flex`, not `flex`, so class lists want
their own literal; and names assembled at runtime (`"p-" + size`) cannot be seen.

## Already evaluated — do not redo

**Hosting ClearScript in a NativeAOT library** with `[UnmanagedCallersOnly]` exports,
P/Invoked from the analyzer. It *works*, including marshalling the host delegate.
Rejected because NativeAOT cannot cross-compile (six RIDs would need a three-OS CI
matrix and no single machine could produce a package), the AOT library *adds to*
rather than replaces the 34 MB native, and ILC reports an `IL3054` generic-recursion
abort in ClearScript's `V8FastProxy` types.

**Multi-targeting the analyzer** (`net462;net8.0`) with `@(Analyzer)` injected from
the targets file by `$(MSBuildRuntimeType)`. Possible — NuGet's
`analyzers/{framework}/{language}` path only accepts `dotnet`, so the convention
cannot select per host — but it trades a tested loader for an unverified assumption
that `$(MSBuildRuntimeType)` tracks the compiler host's runtime.

## Unverified

The `net462` flavor is built, packaged and complete, but has not been exercised on a
real .NET Framework compiler host. **Visual Studio and Rider on Windows are the gap.**
If the assembly-loading shim ever misbehaves there, that is the trigger to revisit
the alternatives above.
