using System.Runtime.ExceptionServices;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization.Metadata;
using Natrix.Signals;

namespace Natrix.Swr;

/// <summary>
/// Everything the library knows about one key: the last value fetched for it, the last error,
/// whether a request is in flight, and the request itself.
///
/// State lives here — on the entry shared by every resource using the key — rather than on the
/// resources, which is what makes two components asking for <c>["user", "1"]</c> issue one
/// request and see one another's updates. The fetcher and options are <em>not</em> stored: they
/// belong to whichever resource triggered the current request, and are passed in per call.
/// </summary>
internal sealed class SwrCacheEntry<TData>(SwrKey key, JsonTypeInfo<TData> typeInfo) : ISwrCacheEntry
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
    /// request. <see cref="MutateAsync"/> is the one operation that must not join — a response
    /// already on its way would undo the mutation — and it cancels and restarts on its own.
    /// </summary>
    /// <param name="throwOnError">
    /// Rethrows the failure once retries are exhausted, instead of only recording it on the
    /// entry. The error is recorded either way.
    /// </param>
    public Task RevalidateAsync(
        Func<SwrKey, CancellationToken, Task<TData>> fetcher,
        SwrOptions options,
        bool throwOnError) =>
        _run is { } existing
            ? existing.Task ?? Task.CompletedTask
            : StartRun(fetcher, options, throwOnError);

    /// <summary>
    /// Fetches only when the entry has nothing, which is what server-side prefetching needs: two
    /// components on one key must not each cost a request, and a key already carrying a value
    /// has nothing to prefetch.
    /// </summary>
    /// <remarks>
    /// Retries are disabled for this path regardless of the caller's options, and the failure is
    /// thrown rather than only recorded. A request that fails during server rendering would
    /// otherwise hold the response open for the whole backoff sequence, and a page rendered
    /// without data it asked for is a broken page: the exception leaves the prefetch drain, which
    /// is what turns it into an error response instead.
    /// </remarks>
    public Task EnsureLoadedAsync(Func<SwrKey, CancellationToken, Task<TData>> fetcher, SwrOptions options)
    {
        var state = PeekState();
        if (state.HasData)
        {
            return Task.CompletedTask;
        }

        // Never joins a run in flight. One started from Setup — an explicit revalidation or a
        // mutation — carries its caller's retries and swallows its failure, which are the two
        // things a server run must not do.
        CancelPending();

        // A request for this key already failed on this render. Another would only cost the
        // upstream a second call for a response that is not going to be served; the same failure
        // is raised again so the drain sees it whichever callback reaches the key first.
        if (state.Error is { } error)
        {
            ExceptionDispatchInfo.Throw(error);
        }

        return StartRun(fetcher, options with { ShouldRetryOnError = false }, throwOnError: true);
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

        return revalidate ? StartRun(fetcher, options, throwOnError: false) : Task.CompletedTask;
    }

    /// <summary>
    /// Seeds the entry from the payload the server sent with the page, so the first client
    /// render matches the markup instead of flashing a loading state over it.
    /// </summary>
    public void Hydrate(JsonNode? node)
    {
        _state.Value = new SwrEntryState<TData>(true, JsonSerializer.Deserialize(node, typeInfo), null);
        IsHydrated = true;
    }

    /// <summary>
    /// The value was seeded from the page's payload. Only consulted while the cache's hydration
    /// pass is open, which is why it is never cleared: a value the cache held from before the
    /// page — one an earlier host fetched into a cache that outlived it — is not the server's
    /// render, and must not be mistaken for it just because it is present.
    /// </summary>
    public bool IsHydrated { get; private set; }

    public bool TryDehydrate(out JsonNode? node)
    {
        node = null;

        var state = PeekState();
        if (!state.HasData)
        {
            return false;
        }

        node = JsonSerializer.SerializeToNode(state.Data!, typeInfo);
        return true;
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

    private Task StartRun(Func<SwrKey, CancellationToken, Task<TData>> fetcher, SwrOptions options, bool throwOnError)
    {
        var run = new Run(new CancellationTokenSource());
        _run = run;

        var task = RunAsync(run, fetcher, options, throwOnError);
        run.Task = task;

        return task;
    }

    private async Task RunAsync(
        Run run,
        Func<SwrKey, CancellationToken, Task<TData>> fetcher,
        SwrOptions options,
        bool throwOnError)
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
                        if (throwOnError)
                        {
                            throw;
                        }

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
