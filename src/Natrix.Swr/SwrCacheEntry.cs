using System.Runtime.ExceptionServices;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization.Metadata;
using Natrix.Signals;

namespace Natrix.Swr;

/// <summary>
/// Everything the library knows about one key: the last value fetched for it, the last error,
/// and the request in flight for it.
///
/// State lives here — on the entry shared by every resource using the key — rather than on the
/// resources, which is what makes two components asking for <c>["user", "1"]</c> issue one
/// request and see one another's updates. The fetcher and options are <em>not</em> stored: they
/// belong to whichever resource triggered the current request, and are passed in per call.
/// </summary>
internal sealed class SwrCacheEntry<TData> : ISwrCacheEntry
{
    private readonly Signal<SwrEntryState<TData>> _state = new(SwrEntryState<TData>.Empty);

    /// <summary>
    /// The request in flight, or null when there is none. A signal rather than a field with a
    /// separate "validating" flag beside it: the flag would only ever mirror whether this is
    /// set, and a mirror is one more thing to keep in step across every start, finish and
    /// cancellation.
    /// </summary>
    private readonly Signal<SwrRun<TData>?> _run = new(null);

    private readonly JsonTypeInfo<TData> _typeInfo;
    private readonly Func<Task> _yieldAsync;
    private int _subscribers;

    public SwrCacheEntry(SwrKey key, JsonTypeInfo<TData> typeInfo, Func<Task> yieldAsync)
    {
        Key = key;
        _typeInfo = typeInfo;
        _yieldAsync = yieldAsync;
        IsValidating = new Computed<bool>(() => _run.Value is not null);
    }

    public SwrKey Key { get; }

    public IReadOnlySignal<SwrEntryState<TData>> State => _state;

    /// <summary>
    /// True from the moment a request starts until it succeeds or gives up — retries included,
    /// since the entry is still working on the value.
    /// </summary>
    public IReadOnlySignal<bool> IsValidating { get; }

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
    /// A failure is recorded on the entry, not thrown.
    /// </summary>
    public Task RevalidateAsync(Func<SwrKey, CancellationToken, Task<TData>> fetcher, SwrOptions options) =>
        PeekRun() is { } existing
            ? existing.Task
            : StartRun(fetcher, options);

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
    public async Task EnsureLoadedAsync(Func<SwrKey, CancellationToken, Task<TData>> fetcher, SwrOptions options)
    {
        var state = PeekState();
        if (state.HasData)
        {
            return;
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

        await StartRun(fetcher, options with { ShouldRetryOnError = false });

        // The run writes its outcome rather than throwing it. There was no value when this
        // started, so one now means success, an error without one means the single attempt
        // failed, and neither means the run was superseded — which is the next callback's
        // problem, not this one's.
        if (PeekState() is { HasData: false, Error: { } failure })
        {
            ExceptionDispatchInfo.Throw(failure);
        }
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
    /// Seeds the entry from the payload the server sent with the page, so the first client
    /// render matches the markup instead of flashing a loading state over it.
    /// </summary>
    public void Hydrate(JsonNode? node)
    {
        _state.Value = new SwrEntryState<TData>(true, JsonSerializer.Deserialize(node, _typeInfo), null);
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

        node = JsonSerializer.SerializeToNode(state.Data!, _typeInfo);
        return true;
    }

    /// <summary>
    /// Reads the current value without registering a dependency, for updater-style mutations
    /// that derive the new value from the old one.
    /// </summary>
    public TData? PeekData() => PeekState().Data;

    /// <summary>
    /// The entry's own reads must never register a dependency. They happen on whatever stack
    /// resumed a request — which, when a fetch completes inside an effect, is a stack with that
    /// unrelated effect installed as the active consumer — or on the stack of a resource's
    /// imperative operation, which user code may well call from inside an effect.
    /// </summary>
    private SwrEntryState<TData> PeekState()
    {
        using var untracked = new UntrackedScope();
        return _state.Value;
    }

    /// <inheritdoc cref="PeekState"/>
    private SwrRun<TData>? PeekRun()
    {
        using var untracked = new UntrackedScope();
        return _run.Value;
    }

    /// <summary>
    /// Abandons the request in flight, if any. Safe to call when there is none.
    /// </summary>
    public void CancelPending()
    {
        var run = PeekRun();
        if (run is null)
        {
            return;
        }

        // Cleared before cancelling, so the slot is free for whoever comes next by the time the
        // abandoned run's continuations see the cancellation.
        _run.Value = null;
        run.Cancel();
    }

    private Task StartRun(Func<SwrKey, CancellationToken, Task<TData>> fetcher, SwrOptions options)
    {
        var run = new SwrRun<TData>(Key, _state, fetcher, options, _yieldAsync);

        // The run yields before it does anything, so it is still in flight here whatever the
        // fetcher does: publishing it after construction never publishes a finished run.
        _run.Value = run;
        _ = ClearWhenDoneAsync(run);

        return run.Task;
    }

    /// <summary>
    /// Frees the slot when its run finishes. Registered before the run's task is handed to
    /// anyone, so it is the first continuation to see the outcome, and a caller awaiting the run
    /// finds the slot already cleared.
    /// </summary>
    private async Task ClearWhenDoneAsync(SwrRun<TData> run)
    {
        try
        {
            await run.Task;
        }
        catch (Exception)
        {
            // A run records its failures rather than throwing them. What can still fault the
            // task is an effect throwing while the outcome lands, which is not the slot's
            // business: the run is over either way.
        }

        // A superseded run owns none of this any more; the run that replaced it does.
        if (ReferenceEquals(PeekRun(), run))
        {
            _run.Value = null;
        }
    }
}
