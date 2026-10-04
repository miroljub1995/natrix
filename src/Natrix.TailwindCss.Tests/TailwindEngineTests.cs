using System.Diagnostics.CodeAnalysis;

namespace Natrix.TailwindCss.Tests;

/// <summary>
/// Exercises the JavaScript engine directly.
/// </summary>
/// <remarks>
/// Without this, a bundle Jint cannot run shows up as every generator test
/// failing with a Tailwind-shaped error message rather than the real cause.
/// </remarks>
public class TailwindEngineTests
{
    private const string Entry = """@import "tailwindcss";""";

    private static readonly string IndexCss =
        File.ReadAllText(Path.Combine(Harness.TailwindCssDir, "index.css"));

    private static StylesheetResult Resolve(string id, string _) => id == "tailwindcss"
        ? StylesheetResult.Found("index.css", "", IndexCss)
        : StylesheetResult.NotFound($"unexpected import '{id}'");

    [Test]
    public async Task CompilesCssThroughJint()
    {
        var result = TailwindCompiler.Compile(Entry, basePath: "", ["flex", "p-4"], Resolve);

        await Assert.That(result.Status).IsEqualTo(CompileStatus.Success);
        await Assert.That(result.Payload).Contains(".flex");
        await Assert.That(result.Payload).Contains(".p-4");
    }

    [Test]
    public async Task EmitsExactlyTheCandidatesGiven()
    {
        // Each call is independent: nothing from a previous build leaks in.
        var wide = TailwindCompiler.Compile(Entry, basePath: "", ["flex", "p-4"], Resolve);
        var narrow = TailwindCompiler.Compile(Entry, basePath: "", ["flex"], Resolve);

        await Assert.That(wide.Payload).Contains(".p-4");
        await Assert.That(narrow.Payload).Contains(".flex");
        await Assert.That(narrow.Payload).DoesNotContain(".p-4");
    }

    [Test]
    public async Task ReportsStylesheetErrorsWithoutThrowing()
    {
        var result = TailwindCompiler.Compile(
            """@import "does-not-exist";""",
            basePath: "",
            ["flex"],
            (id, _) => StylesheetResult.NotFound($"Could not resolve '{id}'."));

        await Assert.That(result.Status).IsEqualTo(CompileStatus.StylesheetError);
        await Assert.That(result.Payload).Contains("does-not-exist");
    }

    [Test]
    public async Task ReusesTheParsedBundleAcrossCompilations()
    {
        // The parsed bundle is process-wide; re-parsing 272 KB per compilation
        // would dominate the generator's cost in an IDE.
        for (var i = 0; i < 3; i++)
        {
            var result = TailwindCompiler.Compile(Entry, basePath: "", [$"p-{i + 1}"], Resolve);

            await Assert.That(result.Status).IsEqualTo(CompileStatus.Success);
            await Assert.That(result.Payload).Contains($".p-{i + 1}");
        }
    }

    [Test]
    public async Task CompilesConcurrently()
    {
        // No lock: each compilation has an engine of its own and only the parsed
        // bundle is shared. Results must not bleed between threads.
        var results = await Task.WhenAll(Enumerable.Range(1, 8).Select(i => Task.Run(() =>
            (Index: i, Result: TailwindCompiler.Compile(Entry, basePath: "", [$"p-{i}"], Resolve)))));

        foreach (var (index, result) in results)
        {
            await Assert.That(result.Status).IsEqualTo(CompileStatus.Success);
            await Assert.That(result.Payload).Contains($".p-{index}");
            await Assert.That(result.Payload).DoesNotContain($".p-{index % 8 + 1} ");
        }
    }

    [Test]
    public async Task StopsWhenCancelled()
    {
        // Roslyn cancels a generator run as soon as the source changes again.
        using var cancelled = new CancellationTokenSource();
        await cancelled.CancelAsync();

        await Assert.That(() => TailwindCompiler.Compile(Entry, basePath: "", ["flex"], Resolve, cancelled.Token))
            .Throws<OperationCanceledException>();
    }

    [Test]
    public async Task RunawayRecursionIsAnErrorNotAStackOverflow()
    {
        // Jint recurses on the CLR stack and has no guard of its own, and a stack
        // overflow cannot be caught: it would kill the compiler server. The call
        // depth limit has to trip long before the compiler thread's stack runs
        // out. This recursion is deliberately heavier per frame than Tailwind's.
        // If this test crashes the test host, MaxCallDepth is too high for
        // StackSize.
        const string Runaway = """
            function f(n) {
                const o = { a: [1, 2, 3].map(x => x + n) };
                return [o].map(v => f(n + 1) + v.a[0])[0];
            }
            f(0);
            """;

        var outcome = TailwindCompiler.OnCompilerThread(() =>
        {
            try
            {
                TailwindCompiler.CreateEngine(CancellationToken.None).Evaluate(Runaway);
                return "returned";
            }
            catch (Jint.Runtime.RecursionDepthOverflowException)
            {
                return "limited";
            }
        });

        await Assert.That(outcome).IsEqualTo("limited");
    }

    [Test]
    [UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Tests are never trimmed.")]
    [UnconditionalSuppressMessage("Trimming", "IL2111", Justification = "Tests are never trimmed.")]
    public async Task AwaitsWorkTheHostFinishesLater()
    {
        // A promise still pending once the microtasks have run is waited for, not
        // an error, and what JavaScript does after the await still runs on the
        // compiler thread, with its stack.
        var (result, compilerThread) = TailwindCompiler.OnCompilerThread(() =>
            (TailwindCompiler.Run(
                engine =>
                {
                    engine.SetValue("later", new Func<Task<string>>(async () =>
                    {
                        await Task.Delay(200);
                        return "done";
                    }));
                    engine.SetValue("thread", new Func<int>(() => Environment.CurrentManagedThreadId));
                    return engine.Evaluate("(async () => (await later()) + ':' + thread())()");
                },
                TimeSpan.FromSeconds(30),
                CancellationToken.None),
            Environment.CurrentManagedThreadId));

        await Assert.That(result.Status).IsEqualTo(CompileStatus.Success);
        await Assert.That(result.Payload).IsEqualTo($"done:{compilerThread}");
    }

    [Test]
    public async Task GivesUpOnAPromiseThatNeverSettles()
    {
        var result = TailwindCompiler.Run(
            engine => engine.Evaluate("new Promise(() => {})"),
            TimeSpan.FromMilliseconds(300),
            CancellationToken.None);

        await Assert.That(result.Status).IsEqualTo(CompileStatus.EngineError);
        await Assert.That(result.Payload).Contains("did not finish");
    }

    [Test]
    public async Task StopsAnInfiniteLoopAtTheDeadline()
    {
        // A command-line build has no cancellation, so the deadline is all that
        // keeps a runaway script from hanging it.
        var result = TailwindCompiler.Run(
            engine => engine.Evaluate("for (;;) {}"),
            TimeSpan.FromMilliseconds(300),
            CancellationToken.None);

        await Assert.That(result.Status).IsEqualTo(CompileStatus.EngineError);
        await Assert.That(result.Payload).Contains("did not finish");
    }

    [Test]
    public async Task StopsWaitingWhenCancelled()
    {
        // Cancellation while waiting is still cancellation, not a timeout error.
        using var cancellation = new CancellationTokenSource(TimeSpan.FromMilliseconds(300));

        await Assert.That(() => TailwindCompiler.Run(
                engine => engine.Evaluate("new Promise(() => {})"),
                TimeSpan.FromSeconds(30),
                cancellation.Token))
            .Throws<OperationCanceledException>();
    }
}
