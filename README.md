# <img src="icon.svg" alt="" width="24" height="24"> Natrix

**Website and docs: [natrix.wiki](https://natrix.wiki)**

Natrix is a .NET WebAssembly toolkit for building browser applications in C#. It combines a JavaScript interop foundation, generated browser API bindings, and an experimental component layer for reactive UI rendering.

The repository is split into a few focused projects:

- [src/Natrix.JSCore](src/Natrix.JSCore/) provides the JavaScript proxy system, type marshalling, and low-level interop utilities.
- [src/Natrix.StdWeb](src/Natrix.StdWeb/) contains generated C# bindings for standard Web APIs such as DOM, Fetch, Canvas, WebGL, and related browser interfaces.
- [src/Natrix.Core](src/Natrix.Core/) contains the component model, DOM components, render roots, and feature infrastructure.
- [src/Natrix.Ssr](src/Natrix.Ssr/) contains server-side rendering helpers for ASP.NET Core hosted Natrix applications.
- [src/Natrix.CoreExample](src/Natrix.CoreExample/) is a browser WebAssembly client app that exercises the Core component layer.
- [src/Natrix.Signals](src/Natrix.Signals/) provides reactive primitives used by the component layer.
- [src/Natrix.Swr](src/Natrix.Swr/) provides stale-while-revalidate data fetching for components, ported from React SWR.
- [src/Natrix.WebIDLGenerator](src/Natrix.WebIDLGenerator/) generates C# bindings from WebIDL definitions.

## Documentation

- [src/Natrix.StdWeb/README.md](src/Natrix.StdWeb/README.md) explains the generated browser API bindings and direct DOM-style usage.
- [src/Natrix.Core/README.md](src/Natrix.Core/README.md) explains the component framework and rendering model.
- [src/Natrix.Swr/README.md](src/Natrix.Swr/README.md) explains stale-while-revalidate data fetching.
- [docs/Natrix.Docs](docs/Natrix.Docs/) is the documentation site, including runnable examples, published at [natrix.wiki](https://natrix.wiki).

## Requirements

- .NET 9.0 or later
- Browser with WebAssembly support

## Status

Natrix is under active development. APIs may change as the core abstractions, generated bindings, and packaging mature.

## License

This project is licensed under the MIT License. See [LICENSE](LICENSE) for details.
