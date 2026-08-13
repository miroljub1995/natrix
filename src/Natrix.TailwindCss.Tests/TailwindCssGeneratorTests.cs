using Microsoft.CodeAnalysis;
using static VerifyTUnit.Verifier;

namespace Natrix.TailwindCss.Tests;

public class TailwindCssGeneratorTests
{
    private const string AppCss = """@import "tailwindcss";""";

    private static string Source(string stylesheetPath = "Styles/app.css", string classes = "flex items-center p-4") =>
        $$""""
        using Natrix.TailwindCss;

        namespace MyApp;

        public partial class Styles
        {
            [GeneratedTailwindCss("{{stylesheetPath}}")]
            public static partial string GetCss();

            void Use() { var classes = "{{classes}}"; }
        }
        """";

    [Test]
    public Task EmitsAttribute()
    {
        var driver = Harness.CreateDriver()
            .RunGenerators(Harness.CreateCompilation("namespace MyApp; public partial class Styles { }"));

        return Verify(driver);
    }

    [Test]
    public Task GeneratesNothingWithoutAttribute()
    {
        var driver = Harness.CreateDriver(("Styles/app.css", AppCss))
            .RunGenerators(Harness.CreateCompilation("""
                namespace MyApp;
                public partial class Styles { void Use() { var x = "flex p-4"; } }
                """));

        return Verify(driver);
    }

    [Test]
    public Task ResolvesEntryStylesheetFromAdditionalFiles()
    {
        var driver = Harness.CreateDriver(("Styles/app.css", AppCss))
            .RunGenerators(Harness.CreateCompilation(Source()));

        return Verify(driver);
    }

    [Test]
    public async Task ResolvesRelativeImports()
    {
        var driver = Harness.CreateDriver(
                ("Styles/app.css", """
                    @import "tailwindcss";
                    @import "./components.css";
                    @import "../shared/tokens.css";
                    """),
                ("Styles/components.css", ".btn { padding: 1rem; }"),
                ("shared/tokens.css", ":root { --brand: rebeccapurple; }"))
            .RunGenerators(Harness.CreateCompilation(Source()));

        var css = Harness.GeneratedCss(driver, "MyApp.Styles.GetCss.g.cs");

        // Both imports resolved and their contents reached the output.
        await Assert.That(css).Contains(".btn");
        await Assert.That(css).Contains("--brand: rebeccapurple");
    }

    [Test]
    public async Task ResolvesNestedImports()
    {
        // Two levels deep, with the second import relative to the *importing*
        // file rather than the entry point. This is what the base returned from
        // loadStylesheet is for: resolve it against the entry directory instead
        // and 'tokens.css' is not found.
        var driver = Harness.CreateDriver(
                ("Styles/app.css", """
                    @import "tailwindcss";
                    @import "./parts/buttons.css";
                    """),
                ("Styles/parts/buttons.css", """
                    @import "./tokens.css";
                    .btn { border-radius: var(--btn-radius); }
                    """),
                ("Styles/parts/tokens.css", ":root { --btn-radius: 3px; }"))
            .RunGenerators(Harness.CreateCompilation(Source()));

        var css = Harness.GeneratedCss(driver, "MyApp.Styles.GetCss.g.cs");

        await Assert.That(css).Contains(".btn");
        await Assert.That(css).Contains("--btn-radius: 3px");
    }

    [Test]
    public async Task ResolvesDirectoryImportToIndexCss()
    {
        var driver = Harness.CreateDriver(
                ("Styles/app.css", """
                    @import "tailwindcss";
                    @import "./theme";
                    """),
                ("Styles/theme/index.css", ":root { --brand: rebeccapurple; }"))
            .RunGenerators(Harness.CreateCompilation(Source()));

        await Assert.That(Harness.GeneratedCss(driver, "MyApp.Styles.GetCss.g.cs"))
            .Contains("--brand: rebeccapurple");
    }

    [Test]
    public async Task IgnoresStylesheetsThatAreNotImported()
    {
        // Every .css file in the project is visible to the resolver, but only
        // what the entry stylesheet actually imports reaches the output.
        var driver = Harness.CreateDriver(
                ("Styles/app.css", AppCss),
                ("Styles/orphan.css", ".orphan-marker { color: red; }"))
            .RunGenerators(Harness.CreateCompilation(Source()));

        await Assert.That(Harness.GeneratedCss(driver, "MyApp.Styles.GetCss.g.cs"))
            .DoesNotContain(".orphan-marker");
    }

    [Test]
    public async Task ResolvesImportWithoutCssExtension()
    {
        var driver = Harness.CreateDriver(
                ("Styles/app.css", """
                    @import "tailwindcss";
                    @import "./components";
                    """),
                ("Styles/components.css", ".btn { padding: 1rem; }"))
            .RunGenerators(Harness.CreateCompilation(Source()));

        await Assert.That(Harness.GeneratedCss(driver, "MyApp.Styles.GetCss.g.cs")).Contains(".btn");
    }

    [Test]
    public Task ResolvesTailwindSubpathImports()
    {
        var driver = Harness.CreateDriver(("Styles/app.css", """
                @import "tailwindcss/theme" layer(theme);
                @import "tailwindcss/utilities" layer(utilities);
                """))
            .RunGenerators(Harness.CreateCompilation(Source(classes: "p-4 bg-red-500")));

        return Verify(driver);
    }

    [Test]
    public async Task GeneratesUtilitiesForCandidatesInStringLiterals()
    {
        var driver = Harness.CreateDriver(("Styles/app.css", AppCss))
            .RunGenerators(Harness.CreateCompilation(Source(classes: "flex p-4")));

        var css = Harness.GeneratedCss(driver, "MyApp.Styles.GetCss.g.cs");

        await Assert.That(css).Contains(".flex");
        await Assert.That(css).Contains(".p-4");
        // Not referenced anywhere, so Tailwind must not emit it.
        await Assert.That(css).DoesNotContain(".grid-cols-7");
    }

    [Test]
    public Task GeneratesInstanceMethod()
    {
        var driver = Harness.CreateDriver(("Styles/app.css", AppCss))
            .RunGenerators(Harness.CreateCompilation("""
                using Natrix.TailwindCss;

                namespace MyApp;

                public partial class Styles
                {
                    [GeneratedTailwindCss("Styles/app.css")]
                    internal partial string GetCss();

                    void Use() { var classes = "flex"; }
                }
                """));

        return Verify(driver);
    }

    [Test]
    public Task GeneratesWithoutNamespace()
    {
        var driver = Harness.CreateDriver(("app.css", AppCss))
            .RunGenerators(Harness.CreateCompilation("""
                using Natrix.TailwindCss;

                public partial class GlobalStyles
                {
                    [GeneratedTailwindCss("app.css")]
                    public static partial string GetCss();

                    void Use() { var classes = "flex"; }
                }
                """));

        return Verify(driver);
    }

    [Test]
    public Task ReportsMissingEntryStylesheet()
    {
        var driver = Harness.CreateDriver(("Styles/app.css", AppCss))
            .RunGenerators(Harness.CreateCompilation(Source("Styles/missing.css")));

        return Verify(driver);
    }

    [Test]
    public Task ReportsUnresolvedImport()
    {
        var driver = Harness.CreateDriver(("Styles/app.css", """
                @import "tailwindcss";
                @import "./nope.css";
                """))
            .RunGenerators(Harness.CreateCompilation(Source()));

        return Verify(driver);
    }

    [Test]
    public Task ReportsPluginNotSupported()
    {
        var driver = Harness.CreateDriver(("Styles/app.css", """
                @import "tailwindcss";
                @plugin "@tailwindcss/typography";
                """))
            .RunGenerators(Harness.CreateCompilation(Source()));

        return Verify(driver);
    }

    [Test]
    public Task ReportsInvalidMethodSignature()
    {
        var driver = Harness.CreateDriver(("Styles/app.css", AppCss))
            .RunGenerators(Harness.CreateCompilation("""
                using Natrix.TailwindCss;

                namespace MyApp;

                public partial class Styles
                {
                    [GeneratedTailwindCss("Styles/app.css")]
                    public static partial int GetCss();
                }
                """));

        return Verify(driver);
    }

    [Test]
    public Task WarnsOnSourceDirective()
    {
        var driver = Harness.CreateDriver(("Styles/app.css", """
                @import "tailwindcss";
                @source "../**/*.razor";
                """))
            .RunGenerators(Harness.CreateCompilation(Source()));

        return Verify(driver);
    }

    [Test]
    public async Task WidensRawStringFenceForQuotedContent()
    {
        // Four consecutive quotes in the CSS would terminate a fixed """ fence
        // early and produce a file that does not compile.
        var driver = Harness.CreateDriver(("Styles/app.css", """""
                @import "tailwindcss";
                @utility quoted {
                  content: '""""';
                }
                """""))
            .RunGenerators(Harness.CreateCompilation(Source(classes: "quoted")));

        var runResult = driver.GetRunResult();
        var generated = runResult.Results
            .SelectMany(result => result.GeneratedSources)
            .Single(source => source.HintName == "MyApp.Styles.GetCss.g.cs")
            .SourceText.ToString();

        // Five quotes, because the CSS itself contains a run of four.
        await Assert.That(generated).Contains("\"\"\"\"\"");

        // The real assertion: the generated file compiles alongside its own
        // partial declaration.
        var errors = Harness
            .CreateCompilation([
                Source(classes: "quoted"),
                generated,
                .. runResult.Results.SelectMany(result => result.GeneratedSources)
                    .Where(source => source.HintName == "GeneratedTailwindCssAttribute.g.cs")
                    .Select(source => source.SourceText.ToString()),
            ])
            .GetDiagnostics()
            .Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error)
            .Select(diagnostic => diagnostic.ToString())
            .ToList();

        await Assert.That(errors).IsEmpty();
    }
}
