# Natrix.Templates

dotnet new templates for bootstrapping Natrix applications.

## Included templates

- `natrix`: docs-style Natrix web app with server + WebAssembly client projects, Tailwind CSS integration, and minimal Home/About routing.

## Install from NuGet

```bash
dotnet new install Natrix.Templates
```

Create an app:

```bash
dotnet new natrix -n MyNatrixApp
```

Run it:

```bash
dotnet run --project MyNatrixApp/MyNatrixApp.csproj
```

## Local development

Build and pack:

```bash
dotnet pack src/Natrix.Templates/Natrix.Templates.csproj -c Release -o artifacts/nuget
```

Install local package:

```bash
dotnet new install artifacts/nuget/Natrix.Templates.*.nupkg
```

Reinstall during development:

```bash
dotnet new uninstall Natrix.Templates
dotnet new install artifacts/nuget/Natrix.Templates.*.nupkg
```