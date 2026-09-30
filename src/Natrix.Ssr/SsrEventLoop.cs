namespace Natrix.Ssr;

/// <summary>
/// Runs a server render the way the browser runs the app: as a single-threaded event loop, one
/// per request.
/// </summary>
/// <remarks>
/// <para>
/// Signals, effects and the render tree are not thread-safe, and do not need to be in the
/// browser, where there is one thread. On the server every <c>await</c> resumes on whichever
/// thread-pool thread is free, so a request whose fetches write signals as they land would have
/// several threads in the same tree at once. Everything a request does — mount, the prefetches
/// it starts, their continuations, and writing the response — therefore runs inside this loop,
/// whose <see cref="SynchronizationContext"/> runs one continuation at a time. Fetches still
/// overlap on the network; only what happens when each one comes back is serialized.
/// </para>
/// <para>
/// Wrap the whole request handler, not part of it. Mounting outside the loop would let the
/// prefetches a component registers during its <c>Setup</c> resume while the tree is still
/// being built, and <c>ServerPrefetchFeature</c> refuses to register from outside the loop for
/// that reason.
/// </para>
/// <para>
/// The same rule as the browser applies inside: never block synchronously on a task —
/// <c>.Result</c>, <c>.Wait()</c>, <c>GetAwaiter().GetResult()</c> — whose continuation has to
/// come through the loop, because the loop is the caller, and it is waiting on itself.
/// </para>
/// </remarks>
public static class SsrEventLoop
{
    /// <summary>
    /// Runs <paramref name="body"/> on a fresh per-request loop and completes when it has. A call
    /// from inside a loop joins it rather than starting a nested one, so middleware and a handler
    /// can both wrap a request without contending.
    /// </summary>
    /// <returns>
    /// A task that completes when the body has, faulted with the body's exception if it threw.
    /// It also faults, without waiting for the body, when an <c>async void</c> callback on the
    /// loop throws: there is no task for such a failure to travel on, and a render whose callback
    /// failed part way is not one to keep serving.
    /// </returns>
    public static Task RunAsync(Func<Task> body)
    {
        ArgumentNullException.ThrowIfNull(body);

        if (SynchronizationContext.Current is SerialSynchronizationContext)
        {
            return body();
        }

        var context = new SerialSynchronizationContext();
        var completion = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);

        context.UnhandledException += exception => completion.TrySetException(exception);

        // Posted rather than run under a merely installed context: installing the context on this
        // thread would route continuations through the gate without holding it, and the first
        // one to become ready would run alongside the body. Posting takes the gate for the body's
        // first segment as for every later one. The gate is free, so that segment runs on the
        // calling thread before Post returns.
        context.Post(static state =>
        {
            var (body, completion) = ((Func<Task>, TaskCompletionSource))state!;
            _ = RunBodyAsync(body, completion);
        }, (body, completion));

        return completion.Task;
    }

    private static async Task RunBodyAsync(Func<Task> body, TaskCompletionSource completion)
    {
        try
        {
            await body();
            completion.TrySetResult();
        }
        catch (Exception exception)
        {
            completion.TrySetException(exception);
        }
    }
}
