namespace Natrix.Query;

/// <summary>
/// The store behind a <see cref="QueryClient"/>: every query, indexed by the hash of its key,
/// plus the notification stream describing what happens to them. The counterpart of TanStack
/// Query's <c>QueryCache</c>.
/// </summary>
/// <remarks>
/// Sharing one cache between clients is how a server-rendered request hands its data to
/// another client, and how tests inspect state that no component is watching.
/// </remarks>
public sealed class QueryCache
{
    private readonly Dictionary<string, Query> _queries = new(StringComparer.Ordinal);
    private readonly List<Action<QueryCacheNotifyEvent>> _listeners = [];

    /// <summary>Every query currently in the cache.</summary>
    public IReadOnlyList<Query> GetAll() => _queries.Values.ToArray();

    /// <summary>The query stored under <paramref name="queryHash"/>, if any.</summary>
    public Query? Get(string queryHash)
    {
        ArgumentNullException.ThrowIfNull(queryHash);
        return _queries.GetValueOrDefault(queryHash);
    }

    /// <summary>
    /// Returns the entry for <paramref name="options"/>, creating it if this key has not been
    /// seen. Existing entries keep the options they already have; only their observers'
    /// options change.
    /// </summary>
    public Query Build(QueryClient client, ResolvedQueryOptions options, QueryState? state = null)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(options);

        if (_queries.TryGetValue(options.QueryHash, out var existing))
        {
            return existing;
        }

        var query = new Query(this, client, client.Scheduler, options, state);
        Add(query);
        return query;
    }

    /// <summary>Adds a query built elsewhere, e.g. when restoring dehydrated state.</summary>
    public void Add(Query query)
    {
        ArgumentNullException.ThrowIfNull(query);

        if (_queries.ContainsKey(query.QueryHash))
        {
            return;
        }

        _queries[query.QueryHash] = query;
        Notify(new QueryCacheNotifyEvent(QueryCacheNotifyEventType.Added, query, null));
    }

    /// <summary>Removes a query and stops everything it had running.</summary>
    public void Remove(Query query)
    {
        ArgumentNullException.ThrowIfNull(query);

        if (_queries.TryGetValue(query.QueryHash, out var stored))
        {
            query.Destroy();

            // Only drop the entry when it is still the one being removed: a rebuild may
            // already have replaced it under the same hash.
            if (ReferenceEquals(stored, query))
            {
                _queries.Remove(query.QueryHash);
            }

            Notify(new QueryCacheNotifyEvent(QueryCacheNotifyEventType.Removed, query, null));
        }
    }

    /// <summary>Empties the cache.</summary>
    public void Clear()
    {
        foreach (var query in GetAll())
        {
            Remove(query);
        }
    }

    /// <summary>The first query matching <paramref name="filters"/>.</summary>
    public Query? Find(QueryFilters filters)
    {
        ArgumentNullException.ThrowIfNull(filters);

        // An exact-key lookup is the common case and does not need a scan.
        if (filters is { QueryKey: { } key, Exact: true, Type: QueryTypeFilter.All, Stale: null, FetchStatus: null, Predicate: null })
        {
            return Get(key.Hash);
        }

        return _queries.Values.FirstOrDefault(filters.Matches);
    }

    /// <summary>Every query matching <paramref name="filters"/>, or all of them when it is <c>null</c>.</summary>
    public IReadOnlyList<Query> FindAll(QueryFilters? filters = null) =>
        filters is null ? GetAll() : _queries.Values.Where(filters.Matches).ToArray();

    /// <summary>Subscribes to everything that happens in the cache; dispose to unsubscribe.</summary>
    public IDisposable Subscribe(Action<QueryCacheNotifyEvent> listener)
    {
        ArgumentNullException.ThrowIfNull(listener);
        _listeners.Add(listener);
        return new Subscription(this, listener);
    }

    internal void Notify(QueryCacheNotifyEvent notifyEvent)
    {
        // A snapshot, because a listener may subscribe or unsubscribe while being notified.
        foreach (var listener in _listeners.ToArray())
        {
            listener(notifyEvent);
        }
    }

    internal void OnFocus()
    {
        foreach (var query in GetAll())
        {
            query.OnFocus();
        }
    }

    internal void OnOnline()
    {
        foreach (var query in GetAll())
        {
            query.OnOnline();
        }
    }

    private sealed class Subscription(QueryCache cache, Action<QueryCacheNotifyEvent> listener) : IDisposable
    {
        public void Dispose() => cache._listeners.Remove(listener);
    }
}
