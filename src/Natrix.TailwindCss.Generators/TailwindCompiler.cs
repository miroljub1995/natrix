using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Jint;
using Jint.Native;
using Jint.Runtime;

namespace Natrix.TailwindCss.Generators;

/// <summary>The outcome of a Tailwind compilation.</summary>
internal readonly struct CompileResult
{
    private CompileResult(CompileStatus status, string payload)
    {
        Status = status;
        Payload = payload;
    }

    public CompileStatus Status { get; }

    /// <summary>The compiled CSS on success, otherwise the error message.</summary>
    public string Payload { get; }

    public static CompileResult Success(string css) => new(CompileStatus.Success, css);

    public static CompileResult StylesheetError(string message) => new(CompileStatus.StylesheetError, message);

    public static CompileResult EngineError(string message) => new(CompileStatus.EngineError, message);
}

internal enum CompileStatus
{
    Success,

    /// <summary>Tailwind rejected the input: bad CSS, unresolved import, unsupported plugin.</summary>
    StylesheetError,

    /// <summary>The JavaScript engine itself failed: the bundle did not parse, or a limit was hit.</summary>
    EngineError,
}

/// <summary>
/// Runs the bundled Tailwind CSS compiler in Jint, a JavaScript interpreter written
/// in .NET.
/// </summary>
/// <remarks>
/// The bundle is parsed once per process and shared. Every build gets a fresh
/// <see cref="Engine"/>: that costs well under a millisecond, keeps each compilation
/// independent, and leaves the parsed script as the only shared state, which Jint
/// allows. So concurrent generator runs need no lock.
/// </remarks>
internal static class TailwindCompiler
{
    /// <summary>
    /// The deepest JavaScript call stack allowed. Tailwind 4.3 needs 9.
    /// </summary>
    /// <remarks>
    /// Jint has no stack guard of its own: it recurses on the CLR stack, a few KB
    /// per JavaScript frame, and an overflow is not catchable, so it would take the
    /// whole compiler server down. This limit turns runaway recursion into an
    /// error well before <see cref="StackSize"/> runs out. Measured with a
    /// deliberately frame-heavy recursion: 256 fits in 1 MB, and a 16 MB stack
    /// holds 2048.
    /// </remarks>
    internal const int MaxCallDepth = 256;

    /// <summary>
    /// The stack every compilation runs on. Fixed rather than inherited, because
    /// the compiler host's threads differ: a Windows thread-pool thread has 1 MB.
    /// </summary>
    private const int StackSize = 16 * 1024 * 1024;

    /// <summary>
    /// How long one compilation may take, including waiting for its promise. A
    /// warm compile takes ~90 ms and a cold one ~1.2 s; this only ends one that
    /// would otherwise never finish, which a command-line build has no other way
    /// to stop.
    /// </summary>
    internal static readonly TimeSpan Timeout = TimeSpan.FromSeconds(30);

    private static readonly Lazy<Prepared<Acornima.Ast.Script>> Bundle = new(
        static () => Engine.PrepareScript(TailwindResources.BundleJs, "tailwind.bundle.js"),
        LazyThreadSafetyMode.ExecutionAndPublication);

    /// <summary>
    /// Compiles <paramref name="css"/> into a stylesheet containing the utilities
    /// used by <paramref name="candidates"/>.
    /// </summary>
    /// <exception cref="OperationCanceledException"><paramref name="cancellationToken"/> was cancelled.</exception>
    public static CompileResult Compile(
        string css,
        string basePath,
        IReadOnlyList<string> candidates,
        Func<string, string, StylesheetResult> loadStylesheet,
        CancellationToken cancellationToken = default)
    {
        try
        {
            return OnCompilerThread(() => CompileOnThisThread(css, basePath, candidates, loadStylesheet, cancellationToken));
        }
        catch (OperationCanceledException)
        {
            throw new OperationCanceledException(cancellationToken);
        }
        catch (Exception ex)
        {
            return CompileResult.EngineError(ex.Message);
        }
    }

    /// <summary>
    /// Runs <paramref name="work"/> on a thread with <see cref="StackSize"/> of
    /// stack, rethrowing whatever it throws.
    /// </summary>
    /// <remarks>
    /// A new thread per compilation costs ~45 µs against a ~90 ms compile. Not the
    /// thread pool: its stack size is the compiler host's, not ours to raise.
    /// </remarks>
    internal static T OnCompilerThread<T>(Func<T> work)
    {
        T result = default!;
        Exception? failure = null;

        var thread = new Thread(
            () =>
            {
                try
                {
                    result = work();
                }
                catch (Exception ex)
                {
                    failure = ex;
                }
            },
            StackSize)
        {
            IsBackground = true,
            Name = "Natrix.TailwindCss compiler",
        };

        thread.Start();
        thread.Join();

        if (failure is not null)
            System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(failure).Throw();

        return result;
    }

    /// <summary>An engine with the limits every compilation runs under.</summary>
    /// <remarks>
    /// The token stops execution as well as waiting. Roslyn cancels a generator run
    /// as soon as the source changes again, so an IDE never waits for a compile it
    /// no longer needs.
    /// </remarks>
    internal static Engine CreateEngine(CancellationToken cancellationToken) =>
        new(options => options
            .LimitRecursion(MaxCallDepth)
            .CancellationToken(cancellationToken));

    private static CompileResult CompileOnThisThread(
        string css,
        string basePath,
        IReadOnlyList<string> candidates,
        Func<string, string, StylesheetResult> loadStylesheet,
        CancellationToken cancellationToken)
    {
        Prepared<Acornima.Ast.Script> bundle;
        try
        {
            bundle = Bundle.Value;
        }
        catch (Exception ex)
        {
            return CompileResult.EngineError("The Tailwind bundle could not be parsed: " + ex.Message);
        }

        return Run(
            engine =>
            {
                engine.Execute(bundle);

                var candidateArray = new JsArray(engine, candidates.Select(static candidate => (JsValue)candidate).ToArray());
                return engine.Invoke("natrixTailwindBuild", css, basePath, candidateArray, loadStylesheet);
            },
            Timeout,
            cancellationToken);
    }

    /// <summary>
    /// Creates an engine, lets <paramref name="start"/> call into it, and waits for
    /// the value it returns to settle if it is a promise.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The wait is real, not a check: <c>UnwrapIfPromise</c> runs the engine's
    /// pending jobs on this thread and blocks until the promise settles, so work
    /// the host finishes later (a <see cref="System.Threading.Tasks.Task"/> handed
    /// back to JavaScript, say) is awaited, and its continuations still run on this
    /// thread and its stack. Waiting asynchronously would gain nothing: the generator
    /// is synchronous, and an <c>await</c> could resume the engine on a thread-pool
    /// thread without <see cref="StackSize"/>.
    /// </para>
    /// <para>
    /// One deadline bounds both executing and waiting: Roslyn's token, or
    /// <paramref name="timeout"/>, whichever comes first. The overload taking a
    /// token is used because it waits as long as the token allows; the
    /// parameterless one gives up after a fixed 10 seconds of its own.
    /// </para>
    /// <para>
    /// What the engine cannot provide is a timer: Jint has no <c>setTimeout</c>. A
    /// Tailwind that started using one would fail with a <c>ReferenceError</c>
    /// (<c>TWCSS001</c>), not hang, and would need a shim in <c>shims.js</c>.
    /// </para>
    /// </remarks>
    internal static CompileResult Run(Func<Engine, JsValue> start, TimeSpan timeout, CancellationToken cancellationToken)
    {
        using var deadline = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        deadline.CancelAfter(timeout);

        try
        {
            var result = start(CreateEngine(deadline.Token)).UnwrapIfPromise(deadline.Token);

            return result.IsString()
                ? CompileResult.Success(result.AsString())
                : CompileResult.StylesheetError("Tailwind returned no CSS.");
        }
        catch (Exception ex) when (ex is ExecutionCanceledException or OperationCanceledException)
        {
            if (cancellationToken.IsCancellationRequested)
                throw new OperationCanceledException(cancellationToken);

            return CompileResult.EngineError(
                $"Tailwind did not finish within {timeout.TotalSeconds:0.###} s.");
        }
        catch (JavaScriptException ex)
        {
            return CompileResult.StylesheetError(Describe(ex.Error, ex.Message));
        }
        catch (PromiseRejectedException ex)
        {
            return CompileResult.StylesheetError(Describe(ex.RejectedValue, ex.Message));
        }
        catch (RecursionDepthOverflowException)
        {
            return CompileResult.EngineError(
                $"Tailwind exceeded the JavaScript call depth limit of {MaxCallDepth}.");
        }
        catch (Exception ex)
        {
            return CompileResult.EngineError(ex.InnerException is null
                ? ex.Message
                : ex.Message + " -> " + ex.InnerException.Message);
        }
    }

    /// <summary>The message of a thrown JavaScript value: an Error's message, or the value itself.</summary>
    private static string Describe(JsValue thrown, string fallback)
    {
        if (thrown.IsObject())
        {
            var message = thrown.AsObject().Get("message");
            if (message.IsString())
                return message.AsString();
        }

        return thrown.IsUndefined() || thrown.IsNull() ? fallback : thrown.ToString();
    }
}
