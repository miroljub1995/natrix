# Natrix

Natrix is a .NET WebAssembly toolkit for building browser applications in C#. It combines a JavaScript interop foundation, generated browser API bindings, and an experimental component layer for reactive UI rendering.

The repository is split into a few focused projects:

- [src/Natrix.JSCore](src/Natrix.JSCore/) provides the JavaScript proxy system, type marshalling, and low-level interop utilities.
- [src/Natrix.StdWeb](src/Natrix.StdWeb/) contains generated C# bindings for standard Web APIs such as DOM, Fetch, Canvas, WebGL, and related browser interfaces.
- [src/Natrix.Core](src/Natrix.Core/) contains the component model, DOM components, render roots, and feature infrastructure.
- [src/Natrix.Ssr](src/Natrix.Ssr/) contains server-side rendering helpers for ASP.NET Core hosted Natrix applications.
- [src/Natrix.CoreExample](src/Natrix.CoreExample/) is a browser WebAssembly client app that exercises the Core component layer.
- [src/Natrix.Signals](src/Natrix.Signals/) provides reactive primitives used by the component layer.
- [src/Natrix.WebIDLGenerator](src/Natrix.WebIDLGenerator/) generates C# bindings from WebIDL definitions.

## Documentation

- [src/Natrix.StdWeb/README.md](src/Natrix.StdWeb/README.md) explains the generated browser API bindings and direct DOM-style usage.
- [src/Natrix.Core/README.md](src/Natrix.Core/README.md) explains the component framework and rendering model.
- [docs/Natrix.Docs](docs/Natrix.Docs/) is the documentation site, including runnable examples.

## Quick Start

Create a WebAssembly browser project and reference the Natrix package that matches the layer you want to use:

```bash
dotnet new wasmbrowser
dotnet add package Natrix.StdWeb
```

For direct browser API access, initialize StdWeb and get typed proxies for browser globals:

```csharp
using System.Runtime.InteropServices.JavaScript;
using Natrix.JSCore;
using Natrix.StdWeb;

await StdWebProxyFactory.InitializeAsync();

var window = JSObjectProxyFactory.GetProxy<Window>(JSHost.GlobalThis);
var document = window.Document;

var div = document.CreateElement("div");
div.TextContent = "Hello from Natrix";
document.Body?.AppendChild(div);
```

See [src/Natrix.StdWeb/README.md](src/Natrix.StdWeb/README.md) for the full StdWeb overview.
For component-based browser client apps, see [src/Natrix.Core/README.md](src/Natrix.Core/README.md).

You can also bootstrap a docs-style Natrix app (server + client + Tailwind) with the template package:

```bash
dotnet new install Natrix.Templates
dotnet new natrix -n MyNatrixApp
dotnet run --project MyNatrixApp/MyNatrixApp.csproj
```

## Requirements

- .NET 9.0 or later
- Browser with WebAssembly support

## Status

Natrix is under active development. APIs may change as the core abstractions, generated bindings, and packaging mature.

## License

This project is licensed under the MIT License. See [LICENSE](LICENSE) for details.
