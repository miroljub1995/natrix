namespace Natrix.Query;

/// <summary>
/// Callbacks that fire for every mutation in a cache — the counterpart of the configuration
/// TanStack Query's <c>MutationCache</c> takes. Each runs before the mutation's own callback of
/// the same name, and is awaited, so a global handler can do real work before the mutation is
/// reported as settled.
/// </summary>
public sealed class MutationCacheConfig
{
    /// <summary>Runs before any mutation, ahead of its own <c>OnMutate</c>.</summary>
    public Func<object?, Mutation, Task>? OnMutate { get; init; }

    /// <summary>Runs after any mutation succeeds.</summary>
    public Func<object?, object?, object?, Mutation, Task>? OnSuccess { get; init; }

    /// <summary>Runs after any mutation fails — where a global error toast belongs.</summary>
    public Func<Exception, object?, object?, Mutation, Task>? OnError { get; init; }

    /// <summary>Runs after any mutation settles, either way.</summary>
    public Func<object?, Exception?, object?, object?, Mutation, Task>? OnSettled { get; init; }
}

/// <summary>What happened to a mutation, for subscribers of <see cref="MutationCache.Subscribe"/>.</summary>
public enum MutationCacheNotifyEventType
{
    /// <summary>A mutation was added.</summary>
    Added,

    /// <summary>A mutation was removed.</summary>
    Removed,

    /// <summary>A mutation's state changed.</summary>
    Updated,

    /// <summary>An observer started watching a mutation.</summary>
    ObserverAdded,

    /// <summary>An observer stopped watching a mutation.</summary>
    ObserverRemoved,
}

/// <summary>A single mutation notification.</summary>
/// <param name="Type">What happened.</param>
/// <param name="Mutation">The mutation it happened to.</param>
public sealed record MutationCacheNotifyEvent(MutationCacheNotifyEventType Type, Mutation Mutation);

/// <summary>
/// The record of every mutation a client has run — the counterpart of TanStack Query's
/// <c>MutationCache</c>.
/// </summary>
/// <remarks>
/// It caches nothing in the query sense: mutations are not addressed by key and are never
/// replayed from here. What it provides is the list <c>IsMutating</c> counts, the ordering that
/// makes <see cref="MutationScope"/> serialise, and the set that
/// <see cref="ResumePausedMutationsAsync"/> resumes when the connection returns.
/// </remarks>
public sealed class MutationCache(MutationCacheConfig? config = null)
{
    private readonly List<Mutation> _mutations = [];
    private readonly List<Action<MutationCacheNotifyEvent>> _listeners = [];
    private int _nextMutationId;

    /// <summary>The callbacks that fire for every mutation here.</summary>
    public MutationCacheConfig Config { get; } = config ?? new MutationCacheConfig();

    /// <summary>Every mutation currently held.</summary>
    public IReadOnlyList<Mutation> GetAll() => _mutations.ToArray();

    /// <summary>Creates a mutation and adds it.</summary>
    public Mutation Build(QueryClient client, ResolvedMutationOptions options, MutationState? state = null)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(options);

        var mutation = new Mutation(this, client, client.Scheduler, options, state);
        Add(mutation);
        return mutation;
    }

    /// <summary>Adds a mutation built elsewhere.</summary>
    public void Add(Mutation mutation)
    {
        ArgumentNullException.ThrowIfNull(mutation);

        _mutations.Add(mutation);
        Notify(new MutationCacheNotifyEvent(MutationCacheNotifyEventType.Added, mutation));
    }

    /// <summary>Removes a mutation.</summary>
    public void Remove(Mutation mutation)
    {
        ArgumentNullException.ThrowIfNull(mutation);

        if (!_mutations.Remove(mutation))
        {
            return;
        }

        mutation.Destroy();
        Notify(new MutationCacheNotifyEvent(MutationCacheNotifyEventType.Removed, mutation));
    }

    /// <summary>Empties the cache.</summary>
    public void Clear()
    {
        foreach (var mutation in GetAll())
        {
            Remove(mutation);
        }
    }

    /// <summary>The first mutation matching <paramref name="filters"/>.</summary>
    public Mutation? Find(MutationFilters filters)
    {
        ArgumentNullException.ThrowIfNull(filters);
        return _mutations.FirstOrDefault(filters.Matches);
    }

    /// <summary>Every mutation matching <paramref name="filters"/>, or all of them when it is <c>null</c>.</summary>
    public IReadOnlyList<Mutation> FindAll(MutationFilters? filters = null) =>
        filters is null ? GetAll() : _mutations.Where(filters.Matches).ToArray();

    /// <summary>Subscribes to everything that happens here; dispose to unsubscribe.</summary>
    public IDisposable Subscribe(Action<MutationCacheNotifyEvent> listener)
    {
        ArgumentNullException.ThrowIfNull(listener);
        _listeners.Add(listener);
        return new Subscription(this, listener);
    }

    /// <summary>
    /// Resumes every mutation that paused while offline, in the order they were fired.
    /// Failures are swallowed — each mutation reports its own outcome to whoever is watching it.
    /// </summary>
    public async Task ResumePausedMutationsAsync()
    {
        var paused = _mutations.Where(mutation => mutation.State.IsPaused).ToArray();

        foreach (var mutation in paused)
        {
            try
            {
                await mutation.ContinueAsync().ConfigureAwait(true);
            }
            catch (Exception)
            {
                // Already recorded on the mutation itself.
            }
        }
    }

    internal int NextMutationId() => ++_nextMutationId;

    internal void Notify(MutationCacheNotifyEvent notifyEvent)
    {
        foreach (var listener in _listeners.ToArray())
        {
            listener(notifyEvent);
        }
    }

    /// <summary>
    /// Whether <paramref name="mutation"/> may run now: only the oldest pending mutation in a
    /// scope does, which is what makes two writes to the same resource queue instead of race.
    /// </summary>
    internal bool CanRun(Mutation mutation)
    {
        var firstPending = _mutations.FirstOrDefault(other =>
            other.ScopeId == mutation.ScopeId && other.State.Status == MutationStatus.Pending);

        return firstPending is null || ReferenceEquals(firstPending, mutation);
    }

    /// <summary>Lets the next mutation waiting on this one's scope proceed.</summary>
    internal void RunNext(Mutation mutation)
    {
        var next = _mutations.FirstOrDefault(other =>
            !ReferenceEquals(other, mutation) && other.ScopeId == mutation.ScopeId && other.State.IsPaused);

        if (next is not null)
        {
            _ = next.ContinueAsync().ContinueWith(
                static task => _ = task.Exception,
                CancellationToken.None,
                TaskContinuationOptions.OnlyOnFaulted | TaskContinuationOptions.ExecuteSynchronously,
                TaskScheduler.Default);
        }
    }

    private sealed class Subscription(MutationCache cache, Action<MutationCacheNotifyEvent> listener) : IDisposable
    {
        public void Dispose() => cache._listeners.Remove(listener);
    }
}
