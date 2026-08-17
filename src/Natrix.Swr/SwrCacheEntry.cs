using Natrix.Signals;

namespace Natrix.Swr;

/// <summary>
/// The type-erased face of a cache entry, so <see cref="SwrCache"/> can hold entries of mixed
/// data types and still stop their pending work on eviction.
/// </summary>
internal interface ISwrCacheEntry
{
    void CancelPending();
}

/// <summary>
/// The outcome of fetching a key, as a single value.
///
/// Data and error are one signal rather than two because effects re-run on every signal write:
/// published separately, an effect would observe the moment where the error is already cleared
/// but the new value has not landed yet, and render a spurious loading state between two frames
/// of real content. <see cref="HasData"/> carries what <c>Data</c> alone cannot, that a fetch
/// legitimately returned <c>default</c>.
/// </summary>
internal sealed record SwrEntryState<TData>(bool HasData, TData? Data, Exception? Error)
{
    public static readonly SwrEntryState<TData> Empty = new(false, default, null);
}

/// <summary>
/// Everything the library knows about one key: the last value fetched for it, the last error,
/// whether a request is in flight, and the request itself.
///
/// State lives here — on the entry shared by every resource using the key — rather than on the
/// resources, which is what makes two components asking for <c>["user", "1"]</c> issue one
/// request and see one another's updates. The fetcher and options are <em>not</em> stored: they
/// belong to whichever resource triggered the current request, and are passed in per call.
/// </summary>
internal sealed class SwrCacheEntry<TData>(SwrKey key) : ISwrCacheEntry
{
    /// <summary>
    /// One request, from the first attempt to the last retry. Holds the cancellation source that
    /// supersedes it and the task callers join for deduplication.
    /// </summary>
    private sealed class Run(CancellationTokenSource cts)
    {
        public CancellationTokenSource Cts { get; } = cts;

        /// <summary>
        /// Assigned immediately after <c>RunAsync</c> is started, so it is only null during the
        /// synchronous prefix of that call.
        /// </summary>
        public Task? Task { get; set; }
    }

    private readonly Signal<SwrEntryState<TData>> _state = new(SwrEntryState<TData>.Empty);
    private readonly Signal<bool> _isValidating = new(false);

    private Run? _run;
    private int _subscribers;

    public SwrKey Key => key;

    public IReadOnlySignal<SwrEntryState<TData>> State => _state;

    /// <summary>
    /// True from the moment a request starts until it succeeds or gives up — retries included,
    /// since the entry is still working on the value.
    /// </summary>
    public IReadOnlySignal<bool> IsValidating => _isValidating;

    public void AddSubscriber() => Interlocked.Increment(ref _subscribers);

    /// <summary>
    /// Drops a resource's claim on the entry. The cached value survives — that is the point of
    /// the cache — but once nobody is watching, a request in flight and any retry still queued
    /// behind it have no audience, so they are cancelled rather than left running.
    /// </summary>
    public void RemoveSubscriber()
    {
        if (Interlocked.Decrement(ref _subscribers) <= 0)
        {
            Interlocked.Exchange(ref _subscribers, 0);
            CancelPending();
        }
    }

    /// <summary>
    /// Fetches unless an identical request is already running, in which case the caller joins it.
    /// This is the deduplication: a hundred components mounting with the same key issue one
    /// request.
    /// </summary>
    /// <param name="force">
    /// Starts a fresh request even when one is in flight, cancelling it. Used after a local
    /// mutation, whose value the older response would otherwise overwrite.
    /// </param>
    public Task RevalidateAsync(
        Func<SwrKey, CancellationToken, Task<TData>> fetcher,
        SwrOptions options,
        bool force)
    {
        if (!force && _run is { } existing)
        {
            return existing.Task ?? Task.CompletedTask;
        }

        CancelPending();
        return StartRun(fetcher, options);
    }

    /// <summary>
    /// Writes a value locally and optionally refetches. The pending request is cancelled first:
    /// a response that was already on its way describes the state before this mutation, so
    /// letting it land would undo it.
    /// </summary>
    public Task MutateAsync(
        TData data,
        bool revalidate,
        Func<SwrKey, CancellationToken, Task<TData>> fetcher,
        SwrOptions options)
    {
        CancelPending();
        _state.Value = new SwrEntryState<TData>(true, data, null);

        return revalidate ? StartRun(fetcher, options) : Task.CompletedTask;
    }

    /// <summary>
    /// Reads the current value without registering a dependency, for updater-style mutations
    /// that derive the new value from the old one.
    /// </summary>
    public TData? PeekData() => PeekState().Data;

    /// <summary>
    /// The entry's own reads must never register a dependency. They happen on whatever stack
    /// resumed the request — which, when a fetch completes synchronously inside an effect, is a
    /// stack with that unrelated effect installed as the active consumer.
    /// </summary>
    private SwrEntryState<TData> PeekState()
    {
        using var untracked = new UntrackedScope();
        return _state.Value;
    }

    /// <summary>
    /// Abandons the request in flight, if any. Safe to call when there is none.
    /// </summary>
    public void CancelPending()
    {
        var run = _run;
        if (run is null)
        {
            return;
        }

        // Cleared before cancelling so the run's own teardown sees it is no longer current and
        // leaves the flags to whoever comes next.
        _run = null;
        run.Cts.Cancel();
        _isValidating.Value = false;
    }

    private Task StartRun(Func<SwrKey, CancellationToken, Task<TData>> fetcher, SwrOptions options)
    {
        var run = new Run(new CancellationTokenSource());
        _run = run;

        var task = RunAsync(run, fetcher, options);
        run.Task = task;

        return task;
    }

    private async Task RunAsync(
        Run run,
        Func<SwrKey, CancellationToken, Task<TData>> fetcher,
        SwrOptions options)
    {
        var token = run.Cts.Token;
        var attempt = 0;

        _isValidating.Value = true;

        try
        {
            while (true)
            {
                try
                {
                    // Deliberately not ConfigureAwait(false): the continuation writes signals,
                    // which re-runs effects and touches the DOM, so it has to come back to the
                    // context the request started on.
                    var data = await fetcher(key, token);

                    if (token.IsCancellationRequested)
                    {
                        return;
                    }

                    _state.Value = new SwrEntryState<TData>(true, data, null);
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
                    _state.Value = PeekState() with { Error = exception };

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
            // A superseded run owns none of this any more; the run that replaced it does.
            if (ReferenceEquals(_run, run))
            {
                _run = null;
                _isValidating.Value = false;
            }

            run.Cts.Dispose();
        }
    }
}
