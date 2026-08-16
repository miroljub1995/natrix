using System.Collections.Immutable;

namespace Natrix.TailwindCss.Tests;

public class StylesheetResolverTests
{
    private static StylesheetResolver Resolver(params (string Path, string Content)[] stylesheets) =>
        new(new EquatableArray<Stylesheet>(
            [.. stylesheets.Select(sheet => new Stylesheet(sheet.Path, sheet.Content, null))]));

    /// <summary>A resolver where one file is the entry point of a named module.</summary>
    private static StylesheetResolver WithModule(
        string module, string modulePath, params (string Path, string Content)[] stylesheets) =>
        new(new EquatableArray<Stylesheet>(
            [.. stylesheets.Select(sheet => new Stylesheet(
                sheet.Path, sheet.Content, sheet.Path == modulePath ? module : null))]));

    [Test]
    [Arguments("Styles/app.css", "Styles/app.css")]
    [Arguments("./Styles/app.css", "Styles/app.css")]
    [Arguments("Styles/../Styles/app.css", "Styles/app.css")]
    [Arguments("Styles\\app.css", "Styles/app.css")]
    [Arguments("a/b/../../c.css", "c.css")]
    [Arguments("../outside.css", "../outside.css")]
    [Arguments("/abs/path.css", "/abs/path.css")]
    public async Task NormalizesPaths(string input, string expected) =>
        await Assert.That(StylesheetResolver.Normalize(input)).IsEqualTo(expected);

    [Test]
    [Arguments("/proj/Styles", "./parts/button.css", "/proj/Styles/parts/button.css")]
    [Arguments("/proj/Styles", "../shared/tokens.css", "/proj/shared/tokens.css")]
    [Arguments("/proj/Styles", "components.css", "/proj/Styles/components.css")]
    [Arguments("/proj/Styles", "sub\\button.css", "/proj/Styles/sub/button.css")]
    // Already absolute, so the base is irrelevant.
    [Arguments("/proj/Styles", "/elsewhere/theme.css", "/elsewhere/theme.css")]
    public async Task ResolvesSpecifiersAgainstTheGivenBase(string basePath, string specifier, string expected) =>
        await Assert.That(StylesheetResolver.Resolve(basePath, specifier)).IsEqualTo(expected);

    [Test]
    public async Task ResolvesRelativeImportsAgainstTheImportingFile()
    {
        var resolver = Resolver(("/proj/Styles/parts/button.css", ".btn { }"));

        var result = resolver.Load("./parts/button.css", "/proj/Styles");

        await Assert.That(result.Content).Contains(".btn");
        // The base handed back is the directory of the resolved file, so the
        // file's own relative imports resolve from the right place.
        await Assert.That(result.Base).IsEqualTo("/proj/Styles/parts");
    }

    [Test]
    public async Task ResolvesParentRelativeImports()
    {
        var resolver = Resolver(("/proj/shared/tokens.css", ":root { }"));

        await Assert.That(resolver.Load("../shared/tokens.css", "/proj/Styles").Content).Contains(":root");
    }

    [Test]
    public async Task ResolvesImportsThatClimbOutOfTheProject()
    {
        // Nothing about this case is special any more: every stylesheet is keyed
        // by its absolute path, so climbing above the project is just a "..".
        var resolver = Resolver(("/work/Shared/theme.css", ":root { --shared: 1px; }"));

        // From /work/app/Styles/app.css, the file is two levels up and across.
        var result = resolver.Load("../../Shared/theme.css", "/work/app/Styles");

        await Assert.That(result.Error).IsNull();
        await Assert.That(result.Content).Contains("--shared");
    }

    [Test]
    public async Task TreatsRootedImportsAsAbsolutePaths()
    {
        var resolver = Resolver(("/proj/Styles/app.css", ".app { }"));

        await Assert.That(resolver.Load("/proj/Styles/app.css", "/proj/Styles/nested").Content)
            .Contains(".app");
    }

    /// <summary>
    /// A package laid out and exported the way the shipped Tailwind one is: each
    /// id declared explicitly, both with and without the extension, plus an
    /// internal file that is deliberately not exported.
    /// </summary>
    private static StylesheetResolver PackageResolver() =>
        new(new EquatableArray<Stylesheet>(
        [
            new Stylesheet("/pkg/tailwind/index.css", "@import \"./internal.css\";\n.index { }",
                "tailwindcss,tailwindcss/index,tailwindcss/index.css"),
            new Stylesheet("/pkg/tailwind/theme.css", ".theme { }",
                "tailwindcss/theme,tailwindcss/theme.css"),
            new Stylesheet("/pkg/tailwind/utilities.css", ".utilities { }",
                "tailwindcss/utilities,tailwindcss/utilities.css"),
            new Stylesheet("/pkg/tailwind/internal.css", ".internal { }", null),
        ]));

    [Test]
    [Arguments("tailwindcss", ".index")]
    [Arguments("tailwindcss/index", ".index")]
    [Arguments("tailwindcss/index.css", ".index")]
    [Arguments("tailwindcss/theme", ".theme")]
    [Arguments("tailwindcss/theme.css", ".theme")]
    [Arguments("tailwindcss/utilities", ".utilities")]
    public async Task ResolvesEveryDeclaredModuleId(string id, string expected)
    {
        var result = PackageResolver().Load(id, "");

        await Assert.That(result.Error).IsNull();
        await Assert.That(result.Content).Contains(expected);
    }

    [Test]
    [Arguments("tailwindcss/internal")]
    [Arguments("tailwindcss/internal.css")]
    [Arguments("tailwindcss/nested/anything")]
    public async Task DoesNotExposeUndeclaredFilesInsideAModule(string id)
    {
        // Module ids are an exports list, not a browsable directory: a package
        // file that was not declared stays unreachable from outside, exactly as
        // an npm "exports" map gates deep imports.
        await Assert.That(PackageResolver().Load(id, "").Error).IsNotNull();
    }

    [Test]
    public async Task AModuleCanStillReachItsOwnUnexportedFiles()
    {
        // The other half of the rule: gating applies to callers, not to the
        // package itself, because the base handed back is its own directory.
        var resolver = PackageResolver();

        var moduleBase = resolver.Load("tailwindcss", "").Base!;

        await Assert.That(resolver.Load("./internal.css", moduleBase).Content).Contains(".internal");
    }

    [Test]
    public async Task ReportsTheModulesOwnDirectoryAsBase()
    {
        // The base handed back must be where the module lives, not the project
        // root, or the module's own relative imports resolve in the wrong place.
        var result = PackageResolver().Load("tailwindcss", "");

        await Assert.That(result.Base).IsEqualTo("/pkg/tailwind");
    }

    [Test]
    public async Task ResolvesAModulesRelativeImportsAgainstItsOwnDirectory()
    {
        var resolver = PackageResolver();

        // Exactly what Tailwind does next: it re-enters with the base we returned.
        var moduleBase = resolver.Load("tailwindcss", "").Base!;

        await Assert.That(resolver.Load("./theme.css", moduleBase).Content).Contains(".theme");
    }

    [Test]
    public async Task ResolvesAModuleWhenNothingSitsBesideTheImporter()
    {
        // The ordinary case: nothing named tailwindcss.css is anywhere near the
        // importing file, so the id can only be the package.
        var resolver = WithModule(
            "tailwindcss", "/pkg/tailwind/index.css",
            ("/pkg/tailwind/index.css", ".real { }"),
            ("/proj/elsewhere/tailwindcss.css", ".decoy { }"));

        var content = resolver.Load("tailwindcss", "/proj/Styles").Content;

        await Assert.That(content).Contains(".real");
        await Assert.That(content).DoesNotContain(".decoy");
    }

    [Test]
    public async Task TrimsWhitespaceAroundModuleIds()
    {
        // Comma separates and whitespace is only trimmed, the way MSBuild
        // tokenizes an item list - so an attribute wrapped across lines in the
        // XML still reads as the list it was written as.
        var resolver = WithModule(
            "design-system,\n  design-system/index ,\tdesign-system/index.css",
            "/pkg/ds/index.css",
            ("/pkg/ds/index.css", ".ds { }"));

        await Assert.That(resolver.Load("design-system", "").Content).Contains(".ds");
        await Assert.That(resolver.Load("design-system/index", "").Content).Contains(".ds");
        await Assert.That(resolver.Load("design-system/index.css", "").Content).Contains(".ds");
    }

    [Test]
    public async Task ReportsUnknownModules()
    {
        var result = PackageResolver().Load("some-other-package", "");

        await Assert.That(result.Error).IsNotNull();
    }

    [Test]
    public async Task ResolvesABareSpecifierRelatively()
    {
        // A bare specifier is tried against the importing file before it is
        // treated as a package, which is what @tailwindcss/vite does by creating
        // its CSS resolver with preferRelative.
        var resolver = Resolver(("/proj/Styles/components.css", ".btn { }"));

        await Assert.That(resolver.Load("components.css", "/proj/Styles").Content).Contains(".btn");
        await Assert.That(resolver.Load("components", "/proj/Styles").Content).Contains(".btn");
    }

    [Test]
    public async Task ASameNamedFileBesideTheImporterShadowsTheModule()
    {
        // The other side of that order, and the case that pins it down: with a
        // tailwindcss.css sitting next to the importer, that file wins over the
        // package. Upstream allows this deliberately - preferRelative is set on
        // the resolver Tailwind consults before its node_modules lookup.
        var resolver = WithModule(
            "tailwindcss", "/pkg/tailwind/index.css",
            ("/pkg/tailwind/index.css", ".real { }"),
            ("/proj/Styles/tailwindcss.css", ".decoy { }"));

        await Assert.That(resolver.Load("tailwindcss", "/proj/Styles").Content).Contains(".decoy");
    }

    [Test]
    public async Task ReportsUnresolvedImports()
    {
        var result = Resolver().Load("./missing.css", "/proj/Styles");

        await Assert.That(result.Error).IsNotNull();
        await Assert.That(result.Error!).Contains("./missing.css");
        await Assert.That(result.Content).IsNull();
    }

    [Test]
    public async Task PassesContentThroughVerbatim()
    {
        // Quotes, backslashes and newlines cross into JavaScript as a marshalled
        // string, so nothing needs escaping and nothing may be mangled.
        const string awkward = "/* \" \\ \n \t */";
        var resolver = Resolver(("/proj/a.css", awkward));

        await Assert.That(resolver.Load("./a.css", "/proj").Content).IsEqualTo(awkward);
    }
}
