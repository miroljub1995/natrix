using System.Collections.Immutable;
using System.Reflection;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Text;

namespace Natrix.TailwindCss.Generators.Tests;

/// <summary>A stylesheet supplied to the generator without touching disk.</summary>
internal sealed class InMemoryAdditionalText(string path, string text) : AdditionalText
{
    public override string Path { get; } = path;

    public override SourceText GetText(CancellationToken cancellationToken = default) =>
        SourceText.From(text, Encoding.UTF8);
}

internal sealed class TestAnalyzerConfigOptions(Dictionary<string, string> values) : AnalyzerConfigOptions
{
    public static readonly TestAnalyzerConfigOptions Empty = new([]);

    public override IEnumerable<string> Keys => values.Keys;

    public override bool TryGetValue(string key, out string value) => values.TryGetValue(key, out value!);
}

internal sealed class TestOptionsProvider(
    Dictionary<string, string> globalOptions,
    Dictionary<string, string>? modulesByPath = null) : AnalyzerConfigOptionsProvider
{
    public override AnalyzerConfigOptions GlobalOptions { get; } = new TestAnalyzerConfigOptions(globalOptions);

    public override AnalyzerConfigOptions GetOptions(SyntaxTree tree) => TestAnalyzerConfigOptions.Empty;

    /// <summary>Stands in for <c>TailwindModule</c> metadata on the AdditionalFiles item.</summary>
    public override AnalyzerConfigOptions GetOptions(AdditionalText textFile) =>
        modulesByPath is not null && modulesByPath.TryGetValue(textFile.Path, out var module)
            ? new TestAnalyzerConfigOptions(new() { ["build_metadata.AdditionalFiles.TailwindModule"] = module })
            : TestAnalyzerConfigOptions.Empty;
}

internal static class Harness
{
    /// <summary>
    /// A fake project root. Nothing is ever read from disk, and using a fixed
    /// path keeps generated output and snapshots identical across machines.
    /// </summary>
    public const string ProjectDir = "/proj";

    /// <summary>
    /// Where the engine and native V8 binaries live, injected by the build so the
    /// tests do not need their own copy of the payload.
    /// </summary>
    public static readonly string EngineDir = typeof(Harness).Assembly
        .GetCustomAttributes<AssemblyMetadataAttribute>()
        .First(attribute => attribute.Key == "TailwindEngineDir")
        .Value!;

    /// <summary>
    /// Sources are given real file paths under the fake project root: the entry
    /// stylesheet is named relative to the file the attribute sits in, so a tree
    /// with no path could not resolve one.
    /// </summary>
    public static CSharpCompilation CreateCompilation(params string[] sources) =>
        FromTrees(sources.Select((source, index) =>
            CSharpSyntaxTree.ParseText(source, path: $"{ProjectDir}/Source{index}.cs")));

    /// <summary>A compilation with one source at an exact path.</summary>
    public static CSharpCompilation CreateCompilationAt(string path, string source) =>
        FromTrees([CSharpSyntaxTree.ParseText(source, path: path)]);

    private static CSharpCompilation FromTrees(IEnumerable<SyntaxTree> trees) =>
        CSharpCompilation.Create(
            assemblyName: "TestAssembly",
            syntaxTrees: trees,
            references: [MetadataReference.CreateFromFile(typeof(object).Assembly.Location)],
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

    /// <summary>
    /// Tailwind's own stylesheets, exactly as the packaged targets file supplies
    /// them: real files carrying <c>TailwindModule="tailwindcss"</c> on the entry.
    /// </summary>
    private static readonly string TailwindCssDir = Path.Combine(EngineDir, "css");

    /// <summary>
    /// The module ids for each shipped stylesheet, mirroring what the targets file
    /// declares: every subpath both with and without the extension, and the bare
    /// package name for index.css.
    /// </summary>
    private static Dictionary<string, string> TailwindModules() =>
        Directory.EnumerateFiles(TailwindCssDir, "*.css").ToDictionary(
            path => path.Replace('\\', '/'),
            path =>
            {
                var name = Path.GetFileNameWithoutExtension(path);
                var ids = $"tailwindcss/{name},tailwindcss/{name}.css";
                return name == "index" ? $"tailwindcss,{ids}" : ids;
            });

    private static IEnumerable<AdditionalText> TailwindModuleTexts() =>
        Directory.EnumerateFiles(TailwindCssDir, "*.css")
            .Select(path => (AdditionalText)new InMemoryAdditionalText(
                path.Replace('\\', '/'), File.ReadAllText(path)));

    public static GeneratorDriver CreateDriver(params (string Path, string Text)[] stylesheets) =>
        CSharpGeneratorDriver.Create(
            generators: [new TailwindCssGenerator().AsSourceGenerator()],
            additionalTexts: ToAdditionalTexts(stylesheets),
            parseOptions: null,
            optionsProvider: new TestOptionsProvider(
                new Dictionary<string, string>
                {
                    ["build_property.NatrixTailwindEngineDir"] = EngineDir,
                },
                TailwindModules()),
            driverOptions: new GeneratorDriverOptions(
                IncrementalGeneratorOutputKind.None,
                trackIncrementalGeneratorSteps: true));

    public static ImmutableArray<AdditionalText> ToAdditionalTexts(
        params (string Path, string Text)[] stylesheets) =>
        [
            .. stylesheets.Select(sheet =>
                (AdditionalText)new InMemoryAdditionalText($"{ProjectDir}/{sheet.Path}", sheet.Text)),
            .. TailwindModuleTexts(),
        ];

    /// <summary>The CSS emitted for the given method, with the C# wrapper stripped.</summary>
    public static string GeneratedCss(GeneratorDriver driver, string hintName)
    {
        var source = driver.GetRunResult().Results
            .SelectMany(result => result.GeneratedSources)
            .Single(generated => generated.HintName == hintName)
            .SourceText.ToString();

        var lines = source.Split('\n');
        var open = Array.FindIndex(lines, line => line.StartsWith("\"\"\"", StringComparison.Ordinal));
        var close = Array.FindLastIndex(lines, line => line.StartsWith("\"\"\"", StringComparison.Ordinal));

        return string.Join("\n", lines[(open + 1)..close]);
    }

    /// <summary>The run reasons recorded for a tracked pipeline step.</summary>
    public static IReadOnlyList<IncrementalStepRunReason> StepReasons(GeneratorDriver driver, string trackingName) =>
    [
        .. driver.GetRunResult().Results
            .SelectMany(result => result.TrackedSteps.TryGetValue(trackingName, out var steps)
                ? steps
                : [])
            .SelectMany(step => step.Outputs)
            .Select(output => output.Reason),
    ];
}
