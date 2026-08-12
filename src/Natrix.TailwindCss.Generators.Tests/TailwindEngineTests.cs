using Natrix.TailwindCss.Engine.Abstractions;

namespace Natrix.TailwindCss.Generators.Tests;

/// <summary>
/// Exercises the ClearScript layer directly.
/// </summary>
/// <remarks>
/// Without this, a missing or unloadable native payload shows up as every
/// generator test failing with a Tailwind-shaped error message rather than the
/// real cause.
/// </remarks>
public class TailwindEngineTests
{
    private const string Entry = """@import "tailwindcss";""";

    private static string EngineDir => Harness.EngineDir;

    private static readonly string IndexCss =
        File.ReadAllText(Path.Combine(Harness.EngineDir, "css", "index.css"));

    private static StylesheetResult Resolve(string id, string _) => id == "tailwindcss"
        ? StylesheetResult.Found("index.css", "", IndexCss)
        : StylesheetResult.NotFound($"unexpected import '{id}'");

    [Test]
    public async Task CompilesCssThroughV8()
    {
        var result = TailwindCompiler.Compile(EngineDir, Entry, basePath: "", ["flex", "p-4"], Resolve);

        await Assert.That(result.Status).IsEqualTo(CompileStatus.Success);
        await Assert.That(result.Payload).Contains(".flex");
        await Assert.That(result.Payload).Contains(".p-4");
    }

    [Test]
    public async Task EmitsExactlyTheCandidatesGiven()
    {
        // Each call is independent: nothing from a previous build leaks in.
        var wide = TailwindCompiler.Compile(EngineDir, Entry, basePath: "", ["flex", "p-4"], Resolve);
        var narrow = TailwindCompiler.Compile(EngineDir, Entry, basePath: "", ["flex"], Resolve);

        await Assert.That(wide.Payload).Contains(".p-4");
        await Assert.That(narrow.Payload).Contains(".flex");
        await Assert.That(narrow.Payload).DoesNotContain(".p-4");
    }

    [Test]
    public async Task ReportsStylesheetErrorsWithoutThrowing()
    {
        var result = TailwindCompiler.Compile(
            EngineDir,
            """@import "does-not-exist";""",
            basePath: "",
            ["flex"],
            (id, _) => StylesheetResult.NotFound($"Could not resolve '{id}'."));

        await Assert.That(result.Status).IsEqualTo(CompileStatus.StylesheetError);
        await Assert.That(result.Payload).Contains("does-not-exist");
    }

    [Test]
    public async Task ReusesTheEngineAcrossCompilations()
    {
        // The V8 runtime and the parsed bundle are process-wide; reloading them
        // per compilation would dominate the generator's cost in an IDE.
        for (var i = 0; i < 3; i++)
        {
            var result = TailwindCompiler.Compile(EngineDir, Entry, basePath: "", [$"p-{i + 1}"], Resolve);

            await Assert.That(result.Status).IsEqualTo(CompileStatus.Success);
            await Assert.That(result.Payload).Contains($".p-{i + 1}");
        }
    }

    [Test]
    public async Task ResolvesTheRuntimeIdentifierForThisHost()
    {
        var arm64 = System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture
            == System.Runtime.InteropServices.Architecture.Arm64;

        var expected = OperatingSystem.IsMacOS() ? (arm64 ? "osx-arm64" : "osx-x64")
            : OperatingSystem.IsLinux() ? (arm64 ? "linux-arm64" : "linux-x64")
            : arm64 ? "win-arm64" : "win-x64";

        await Assert.That(TailwindCompiler.GetRuntimeIdentifier()).IsEqualTo(expected);
    }
}
