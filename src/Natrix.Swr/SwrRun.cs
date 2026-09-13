using Natrix.Signals;

namespace Natrix.Swr;

/// <summary>
/// One request for a key, from the first attempt to the last retry. Started by its constructor,
/// finished when <see cref="Task"/> completes, abandoned through <see cref="Cancel"/>. Its
/// outcome — a value, or the error it gave up on — is written to the state it was given, never
/// thrown: a caller that needs the failure reads it back from there.
/// </summary>
/// <remarks>
/// <para>
/// <b>The fetcher is never called synchronously.</b> The run yields to the event loop first,
/// whoever started it and however fast the fetcher is. A binding starts its request from inside
/// the parent's render, and a mutation or an explicit revalidation from wherever user code
/// happens to be; a fetcher that completed on the spot would write the entry's state into the
/// middle of that. The yield also means a run is always still in flight when its constructor
/// returns, so the entry can publish it after construction without ever publishing a run that
/// has already finished.
/// </para>
/// <para>
/// The run knows nothing about the entry's slot for it. It writes the outcome to the state it was
/// given and completes; which run is current, and clearing it when it finishes, is the entry's
/// business.
/// </para>
/// </remarks>
internal sealed class SwrRun<TData>
{
    private readonly CancellationTokenSource _cts = new();

    public SwrRun(
        SwrKey key,
        Signal<SwrEntryState<TData>> state,
        Func<SwrKey, CancellationToken, Task<TData>> fetcher,
        SwrOptions options,
        Func<Task> yieldAsync)
    {
        Task = RunAsync(key, state, fetcher, options, yieldAsync);
    }

    /// <summary>
    /// Completes when the run succeeds, gives up, or is cancelled. Never faults on the run's own
    /// account.
    /// </summary>
    public Task Task { get; }

    /// <summary>
    /// Abandons the run: the fetcher's token fires, and whatever it returns afterwards is
    /// ignored. Safe to call more than once, and after the run has finished.
    /// </summary>
    public void Cancel()
    {
        // The source is disposed once the run finishes, and there is nothing left to cancel by
        // then anyway.
        if (!Task.IsCompleted)
        {
            _cts.Cancel();
        }
    }

    private async Task RunAsync(
        SwrKey key,
        Signal<SwrEntryState<TData>> state,
        Func<SwrKey, CancellationToken, Task<TData>> fetcher,
        SwrOptions options,
        Func<Task> yieldAsync)
    {
        var token = _cts.Token;
        var attempt = 0;

        try
        {
            // Deliberately not ConfigureAwait(false), here and below: the continuations write
            // signals, which re-runs effects and touches the DOM, so they have to come back to
            // the context the request started on.
            await yieldAsync();

            // Superseded, or nobody left watching, before it even began.
            if (token.IsCancellationRequested)
            {
                return;
            }

            while (true)
            {
                try
                {
                    var data = await fetcher(key, token);

                    if (token.IsCancellationRequested)
                    {
                        return;
                    }

                    state.Value = new SwrEntryState<TData>(true, data, null);
                    return;
                }
                catch (Exception exception)
                {
                    // Covers the fetcher observing our token as much as it does a real failure;
                    // either way a superseded run must not touch the entry.
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }

                    // The last good value is kept on purpose — showing stale data next to an
                    // error beats blanking the screen.
                    state.Value = Peek(state) with { Error = exception };

                    if (!options.ShouldRetryOnError || attempt >= options.ErrorRetryCount)
                    {
                        return;
                    }

                    try
                    {
                        await Task.Delay(options.GetRetryDelay(attempt), token);
                    }
                    catch (OperationCanceledException)
                    {
                        return;
                    }

                    attempt++;
                }
            }
        }
        finally
        {
            _cts.Dispose();
        }
    }

    /// <summary>
    /// The run's own reads must never register a dependency. They happen on whatever stack
    /// resumed the request — which, when the fetcher completes inside an effect, is a stack with
    /// that unrelated effect installed as the active consumer.
    /// </summary>
    private static SwrEntryState<TData> Peek(Signal<SwrEntryState<TData>> state)
    {
        using var untracked = new UntrackedScope();
        return state.Value;
    }
}
