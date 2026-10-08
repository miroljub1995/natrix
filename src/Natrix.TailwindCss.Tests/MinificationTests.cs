using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using static VerifyTUnit.Verifier;

namespace Natrix.TailwindCss.Tests;

/// <summary>
/// The stylesheet is minified unless DEBUG is defined, the way a Release build
/// differs from a Debug one.
/// </summary>
public class MinificationTests
{
    private const string AppCss = """@import "tailwindcss";""";

    private const string HintName = "MyApp.Styles.GetCss.g.cs";

    private static string Source(string classes = "flex items-center p-4") =>
        $$""""
        using Natrix.TailwindCss;

        namespace MyApp;

        public partial class Styles
        {
            [GeneratedTailwindCss("Styles/app.css")]
            public static partial string GetCss();

            void Use() { var classes = "{{classes}}"; }
        }
        """";

    private static string Generate(CSharpParseOptions parseOptions, string css = AppCss, string classes = "flex") =>
        Harness.GeneratedCss(
            Harness.CreateDriver(parseOptions, ("Styles/app.css", css))
                .RunGenerators(Harness.CreateCompilation(Source(classes))),
            HintName);

    [Test]
    public Task MinifiesWhenDebugIsNotDefined()
    {
        var driver = Harness.CreateDriver(Harness.Release, ("Styles/app.css", AppCss))
            .RunGenerators(Harness.CreateCompilation(Source()));

        return Verify(driver);
    }

    [Test]
    public async Task DoesNotMinifyWhenDebugIsDefined()
    {
        var debug = Generate(Harness.Debug);
        var release = Generate(Harness.Release);

        await Assert.That(debug).Contains("  display: flex;");
        await Assert.That(release).Contains(".flex{display:flex}");
        await Assert.That(release.Length).IsLessThan(debug.Length);
    }

    [Test]
    public async Task KeepsTheLicenseBanner()
    {
        var css = Generate(Harness.Release);

        await Assert.That(css).StartsWith("/*! tailwindcss v");
    }

    [Test]
    public async Task KeepsEscapedSelectorsAndNesting()
    {
        // Tailwind leaves nesting for the minifier to lower or keep; NUglify keeps
        // it. Escapes in class names must survive untouched.
        var css = Generate(Harness.Release, classes: "hover:underline w-1/2");

        await Assert.That(css).Contains(@".hover\:underline{&:hover{@media(hover:hover){text-decoration-line:underline;}}}");
        await Assert.That(css).Contains(@".w-1\/2{width:calc(1/2*100%)}");
    }

    [Test]
    public async Task EmitsTheCssAsIsWhenItCannotBeMinified()
    {
        // Valid CSS, a block as a custom property value, that NUglify cannot parse.
        // The build still gets a working stylesheet, plus a warning.
        var driver = Harness.CreateDriver(Harness.Release, ("Styles/app.css", AppCss + "\n.block-value { --x: {a:b}; }"))
            .RunGenerators(Harness.CreateCompilation(Source()));

        var diagnostic = driver.GetRunResult().Diagnostics.Single();
        var css = Harness.GeneratedCss(driver, HintName);

        await Assert.That(diagnostic.Id).IsEqualTo("TWCSS006");
        await Assert.That(diagnostic.Severity).IsEqualTo(DiagnosticSeverity.Warning);
        await Assert.That(css).Contains("  display: flex;");
    }
}
