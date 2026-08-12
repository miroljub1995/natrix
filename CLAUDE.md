# Natrix

A .NET framework for building web UIs that run in the browser on WebAssembly,
with server-side rendering. Reactive primitives (`Natrix.Signals`), a DOM layer
generated from WebIDL (`Natrix.StdWeb`), SSR (`Natrix.Ssr`), and a build-time
Tailwind CSS integration.

## Working in this repo

- Solution is `Natrix.slnx`; projects target `net9.0;net10.0` unless they
  override it. `LangVersion` is 14.0, nullable and implicit usings are on.
- `TreatWarningsAsErrors` is set for every configuration except `Debug`, so
  check Release before declaring a change done.
- Package versions are centrally managed in `Directory.Packages.props`.
- Tests use **TUnit** with Microsoft.Testing.Platform, not xUnit or VSTest.
- Building requires **Node.js and npm** on `PATH` — the Tailwind generator
  bundles its JavaScript from source during the build.

## Subsystem notes

- **Tailwind CSS generator** — `src/Natrix.TailwindCss.Generators/CLAUDE.md`.
  Loaded automatically when working in that directory. Read it before touching
  any of the five `Natrix.TailwindCss*` projects: the subsystem is split the way
  it is for constraints that are not obvious from the code. Diagrams live
  alongside it in `src/Natrix.TailwindCss.Generators/ARCHITECTURE.md`.

- **Browser-WASM tests** — `.github/instructions/testing.instructions.md`,
  imported below. `Natrix.Browser.Tests` and `Natrix.WebIDLGenerator.Tests`
  cannot be run with `dotnet test`.

@.github/instructions/testing.instructions.md
