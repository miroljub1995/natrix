# Natrix.TailwindCss

Tailwind CSS for Natrix, compiled at build time by a source generator. No Node,
no npm, no CLI, no build step: the generator runs Tailwind itself and emits the
finished stylesheet as a C# string.

## Install

```sh
dotnet add package Natrix.TailwindCss
```

## Use

Tell the generator which stylesheets it can see:

```xml
<ItemGroup>
  <AdditionalFiles Include="Styles\**\*.css" />
</ItemGroup>
```

Write an entry stylesheet in there:

```css
/* Styles/app.css */
@import "tailwindcss";
```

Point a partial method at it:

```csharp
using Natrix.TailwindCss;

public static partial class Styles
{
    [GeneratedTailwindCss("Styles/app.css")]
    public static partial string GetCss();
}
```

The path is relative to the source file the attribute is written in — so
`Styles.cs` at the project root points at `Styles/app.css`, and a `Styles.cs`
inside `Styles/` would just say `app.css`.

`Styles.GetCss()` now returns the compiled CSS. Render it into a `<style>`
element, or serve it however you like.

Every stylesheet you listed is available to `@import`, and editing any of them
re-runs the compilation:

```css
/* Styles/app.css */
@import "tailwindcss";
@import "./components.css";
@import "../shared/tokens.css";
```

Tailwind's own stylesheets ship with the package and are importable as
`tailwindcss`, `tailwindcss/theme`, `tailwindcss/preflight` and
`tailwindcss/utilities` — each also with a `.css` suffix if you prefer.

Your own stylesheets are reached by relative import, as above. Bare specifiers
like `tailwindcss` are *modules*, and they come from packages — see
[Shipping a stylesheet package](#shipping-a-stylesheet-package) if you are
writing one. An import is matched against your own files first, so a stylesheet
sitting next to the importing one wins over a package of the same name.

## Which utilities get generated

Tailwind only emits a utility when something uses it. This generator collects
candidates by splitting **every string literal in the compilation** on
whitespace, so anything you write as a normal C# string is picked up:

```csharp
var css = "flex items-center gap-2 rounded-md";
```

Two consequences worth knowing:

- Class lists want their own string. In `"""<div class="flex gap-2">"""` the
  first candidate is `class="flex`, not `flex`, so that utility is never
  generated. Keep class lists in their own literal and interpolate them into
  markup.
- Names assembled at runtime (`"p-" + size`) cannot be seen. Write the full
  class names out, as with any other Tailwind setup.

There is no file scanning, so `@source` is ignored and reports a warning
(`TWCSS004`).

## Controlling which stylesheets are visible

The package adds no stylesheets of its own beyond Tailwind's. Whatever you list
as `AdditionalFiles` is what the generator can see — a directory, individual
files, or anything outside the project:

```xml
<ItemGroup>
  <AdditionalFiles Include="Styles\**\*.css" />
  <AdditionalFiles Include="..\Shared\theme.css" />
</ItemGroup>
```

Import a file outside the project the way you would any relative path. Imports
resolve against the importing stylesheet, so from `Styles/app.css` the shared
file is two levels up:

```css
@import "../../Shared/theme.css";
```

Nothing else is scanned. That keeps the set small and explicit: only the files
you listed are read, and only their edits re-run the compilation — so a large
vendored stylesheet or a `wwwroot` full of served assets costs you nothing unless
you ask for it.

## Shipping a stylesheet package

For library authors, not applications. A package exposes stylesheets by adding
them from its own `.targets` with `TailwindModule` metadata, which lists the ids
each file answers to:

```xml
<ItemGroup>
  <AdditionalFiles Include="$(MSBuildThisFileDirectory)..\css\index.css"
                   TailwindModule="design-system,design-system/index" />
  <AdditionalFiles Include="$(MSBuildThisFileDirectory)..\css\tokens.css"
                   TailwindModule="design-system/tokens,design-system/tokens.css" />
  <!-- visible to the package's own relative imports, but not importable by id -->
  <AdditionalFiles Include="$(MSBuildThisFileDirectory)..\css\internal.css" />
</ItemGroup>
```

Consumers then write:

```css
@import "design-system";
@import "design-system/tokens";
```

Three rules worth knowing:

- **Ids are comma-separated, not semicolon-separated.** This metadata travels via
  an editorconfig, whose reader strips `;` and `#` as inline comments — either
  character silently truncates the list, keeping only the first id.
- **Matching is exact**, like a `package.json` `"exports"` map. A file you do not
  declare cannot be imported by id, so a package controls its public surface.
- **A consumer's own file wins**, if one sits next to the stylesheet doing the
  importing. This is what Tailwind itself does under Vite.
- **A package can still reach its own files** with relative imports, because the
  base handed back is the module's own directory.

This is exactly how `tailwindcss` itself is provided.

## Diagnostics

| Id | Meaning |
| --- | --- |
| `TWCSS001` | Tailwind rejected the stylesheet: a syntax error, an unresolved `@import`, or an unsupported `@plugin`/`@config` |
| `TWCSS002` | The entry stylesheet named in the attribute — resolved relative to the source file — is not among the project's stylesheets |
| `TWCSS003` | The Tailwind engine could not start on this platform |
| `TWCSS004` | `@source` is ignored; candidates come from string literals |
| `TWCSS005` | The annotated method must be `partial`, return `string`, and take no parameters |

## Limitations

- JavaScript plugins (`@plugin`, `@config`) are not supported. The engine runs
  Tailwind in an isolated JavaScript VM with no module loader or filesystem
  access, which is also what makes the build hermetic.
- Supported build hosts: `osx-arm64`, `osx-x64`, `linux-arm64`, `linux-x64`,
  `win-x64`, `win-arm64`. This is about the machine running the build; the app
  you are building can target anything.

## Upgrading from 0.3.x

`[GeneratedTailwindCss]` used to take the entry CSS inline plus a flat list of
import id/content pairs, which meant passing `TailwindCssDefaults.IndexCss`
through an attribute argument to make `@import "tailwindcss"` work. Stylesheets
are now real files.

```csharp
// 0.3.x
[GeneratedTailwindCss("""@import "tailwindcss";""", "tailwindcss", TailwindCssDefaults.IndexCss)]
public static partial string GetCss();

// 0.4.0 — move the CSS into Styles/app.css
[GeneratedTailwindCss("Styles/app.css")]
public static partial string GetCss();
```

`TailwindCssDefaults` is gone; Tailwind's stylesheets ship with the package and
are supplied to the compiler automatically.
