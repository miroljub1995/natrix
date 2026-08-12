using Microsoft.CodeAnalysis;

namespace Natrix.TailwindCss.Generators.Tests;

/// <summary>
/// Guards the pipeline's caching behaviour.
/// </summary>
/// <remarks>
/// Compiling Tailwind is the expensive part of this generator and the IDE re-runs
/// it on every keystroke, so a step that reports Modified when nothing relevant
/// changed is a real performance bug. These are also the tests that would catch a
/// regression to reference equality in <c>EquatableArray</c>.
/// </remarks>
public class IncrementalityTests
{
    private const string AppCss = """@import "tailwindcss";""";

    private const string Source = """"
        using Natrix.TailwindCss;

        namespace MyApp;

        public partial class Styles
        {
            [GeneratedTailwindCss("Styles/app.css")]
            public static partial string GetCss();

            void Use() { var classes = "flex p-4"; }
        }
        """";

    private static bool AllCached(IReadOnlyList<IncrementalStepRunReason> reasons) =>
        reasons.Count > 0 && reasons.All(reason =>
            reason is IncrementalStepRunReason.Cached or IncrementalStepRunReason.Unchanged);

    [Test]
    public async Task CachesWhenAnUnrelatedFileIsAdded()
    {
        var compilation = Harness.CreateCompilation(Source);
        var driver = Harness.CreateDriver(("Styles/app.css", AppCss)).RunGenerators(compilation);

        // No string literals, so the candidate set is untouched.
        var updated = compilation.AddSyntaxTrees(
            Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParseText("namespace MyApp; class Unrelated { }"));

        driver = driver.RunGenerators(updated);

        await Assert.That(AllCached(Harness.StepReasons(driver, TrackingNames.Stylesheets))).IsTrue();
        await Assert.That(AllCached(Harness.StepReasons(driver, TrackingNames.Candidates))).IsTrue();
        await Assert.That(AllCached(Harness.StepReasons(driver, TrackingNames.Methods))).IsTrue();
    }

    [Test]
    public async Task RecompilesWhenAStylesheetChanges()
    {
        var compilation = Harness.CreateCompilation(Source);
        var driver = Harness.CreateDriver(("Styles/app.css", AppCss)).RunGenerators(compilation);
        var before = Harness.GeneratedCss(driver, "MyApp.Styles.GetCss.g.cs");

        driver = driver
            .ReplaceAdditionalTexts(Harness.ToAdditionalTexts(
                ("Styles/app.css", AppCss + "\n.custom-marker { color: red; }")))
            .RunGenerators(compilation);

        await Assert.That(Harness.StepReasons(driver, TrackingNames.Stylesheets))
            .Contains(IncrementalStepRunReason.Modified);

        var after = Harness.GeneratedCss(driver, "MyApp.Styles.GetCss.g.cs");
        await Assert.That(after).Contains(".custom-marker");
        await Assert.That(after).IsNotEqualTo(before);
    }

    [Test]
    public async Task RecompilesWhenTheDeclaringFileMoves()
    {
        // The entry stylesheet is named relative to the file the attribute sits
        // in, so the same attribute text means a different stylesheet once the
        // file moves. Both the resolved directory and the diagnostic location
        // change, and either alone is enough to make the model compare unequal.
        var driver = Harness.CreateDriver(("Styles/app.css", AppCss))
            .RunGenerators(Harness.CreateCompilationAt($"{Harness.ProjectDir}/Styles.cs", Source));

        driver = driver.RunGenerators(
            Harness.CreateCompilationAt($"{Harness.ProjectDir}/Nested/Styles.cs", Source));

        await Assert.That(Harness.StepReasons(driver, TrackingNames.Methods))
            .Contains(IncrementalStepRunReason.Modified);

        // And it really is a different request: nothing resolves from Nested/.
        await Assert.That(driver.GetRunResult().Diagnostics.Select(d => d.Id)).Contains("TWCSS002");
    }

    [Test]
    public async Task RecompilesWhenTheAttributeMovesWithinItsFile()
    {
        // The model carries a LocationInfo so diagnostics can point at the
        // attribute, and that location includes the text span. Inserting a line
        // above the attribute shifts the span, so the method model compares
        // unequal and Tailwind re-runs even though nothing about the request
        // changed. The cost of pointing diagnostics somewhere useful.
        var driver = Harness.CreateDriver(("Styles/app.css", AppCss))
            .RunGenerators(Harness.CreateCompilation(Source));

        var shifted = Source.Replace(
            "public partial class Styles",
            "// a comment that pushes everything down\npublic partial class Styles");

        driver = driver.RunGenerators(Harness.CreateCompilation(shifted));

        await Assert.That(Harness.StepReasons(driver, TrackingNames.Methods))
            .Contains(IncrementalStepRunReason.Modified);
    }

    [Test]
    public async Task RecompilesWhenAnUnimportedStylesheetChanges()
    {
        // Documents a real cost of the current design: the pipeline carries every
        // .css file in the project, so editing one the entry stylesheet never
        // imports still invalidates and re-runs the Tailwind compile. Roslyn
        // compares step inputs by value and has no way to express "only the
        // subset I happened to read matters".
        var compilation = Harness.CreateCompilation(Source);
        var driver = Harness
            .CreateDriver(("Styles/app.css", AppCss), ("Styles/orphan.css", ".orphan { color: red; }"))
            .RunGenerators(compilation);

        var before = Harness.GeneratedCss(driver, "MyApp.Styles.GetCss.g.cs");

        driver = driver
            .ReplaceAdditionalTexts(Harness.ToAdditionalTexts(
                ("Styles/app.css", AppCss),
                ("Styles/orphan.css", ".orphan { color: blue; }")))
            .RunGenerators(compilation);

        await Assert.That(Harness.StepReasons(driver, TrackingNames.Stylesheets))
            .Contains(IncrementalStepRunReason.Modified);

        // The output is unchanged, because the file was never imported - the
        // work was wasted, not wrong.
        await Assert.That(Harness.GeneratedCss(driver, "MyApp.Styles.GetCss.g.cs")).IsEqualTo(before);
    }

    [Test]
    public async Task CachesWhenAStylesheetIsRewrittenIdentically()
    {
        var compilation = Harness.CreateCompilation(Source);
        var driver = Harness.CreateDriver(("Styles/app.css", AppCss)).RunGenerators(compilation);

        // Different AdditionalText instances, identical content: the pipeline
        // compares by value, so nothing downstream should re-run.
        driver = driver
            .ReplaceAdditionalTexts(Harness.ToAdditionalTexts(("Styles/app.css", AppCss)))
            .RunGenerators(compilation);

        await Assert.That(AllCached(Harness.StepReasons(driver, TrackingNames.Stylesheets))).IsTrue();
    }

    [Test]
    public async Task RecompilesWhenANewCandidateAppears()
    {
        var compilation = Harness.CreateCompilation(Source);
        var driver = Harness.CreateDriver(("Styles/app.css", AppCss)).RunGenerators(compilation);
        var before = Harness.GeneratedCss(driver, "MyApp.Styles.GetCss.g.cs");

        var updated = compilation.AddSyntaxTrees(
            Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParseText(
                """namespace MyApp; class More { string Classes = "bg-red-500"; }"""));

        driver = driver.RunGenerators(updated);

        await Assert.That(Harness.StepReasons(driver, TrackingNames.Candidates))
            .Contains(IncrementalStepRunReason.Modified);

        var after = Harness.GeneratedCss(driver, "MyApp.Styles.GetCss.g.cs");
        await Assert.That(after).Contains(".bg-red-500");
        await Assert.That(after.Length).IsGreaterThan(before.Length);
    }

    [Test]
    public async Task CachesWhenAStringLiteralRepeatsAnExistingCandidate()
    {
        var compilation = Harness.CreateCompilation(Source);
        var driver = Harness.CreateDriver(("Styles/app.css", AppCss)).RunGenerators(compilation);

        // "p-4 flex" is the same candidate set as "flex p-4"; deduplicating and
        // sorting is what keeps this from re-running Tailwind.
        var updated = compilation.AddSyntaxTrees(
            Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParseText(
                """namespace MyApp; class More { string Classes = "p-4 flex"; }"""));

        driver = driver.RunGenerators(updated);

        await Assert.That(AllCached(Harness.StepReasons(driver, TrackingNames.Candidates))).IsTrue();
    }
}
