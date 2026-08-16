namespace Natrix.Query;

/// <summary>
/// Watches a list of queries whose length is not known up front, keeping one observer per
/// entry and reusing observers across list changes. The counterpart of TanStack Query's
/// <c>QueriesObserver</c>, behind <see cref="NatrixQuery.UseQueries{TQueryFnData}(Func{IReadOnlyList{UseQueryOptions{TQueryFnData}}})"/>.
/// </summary>
/// <remarks>
/// Reuse is matched on the query hash: a list that keeps a key and adds another one leaves the
/// first query untouched — no re-mount, no refetch — while the new one starts loading.
/// </remarks>
public sealed class QueriesObserver<TQueryFnData> : IDisposable
{
    private readonly QueryClient _client;
    private readonly List<Entry> _entries = [];
    private readonly List<Action<IReadOnlyList<QueryObserverResult<TQueryFnData>>>> _listeners = [];
    private bool _disposed;
    private bool _suppressNotifications;

    public QueriesObserver(QueryClient client, IReadOnlyList<UseQueryOptions<TQueryFnData>> queries)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(queries);

        _client = client;
        SetQueries(queries);
    }

    /// <summary>The current result of every query, in the order they were listed.</summary>
    public IReadOnlyList<QueryObserverResult<TQueryFnData>> CurrentResults =>
        _entries.Select(entry => entry.Observer.CurrentResult).ToArray();

    /// <summary>The observers, in the order their queries were listed.</summary>
    public IReadOnlyList<QueryObserver<TQueryFnData, TQueryFnData>> Observers =>
        _entries.Select(entry => entry.Observer).ToArray();

    /// <summary>
    /// Reconciles the watched list with <paramref name="queries"/>: keys still present keep
    /// their observer, keys that are gone are disposed, and new keys get a fresh observer.
    /// </summary>
    public void SetQueries(IReadOnlyList<UseQueryOptions<TQueryFnData>> queries)
    {
        ArgumentNullException.ThrowIfNull(queries);
        ObjectDisposedException.ThrowIf(_disposed, this);

        var previous = _entries.ToList();
        var reordered = new List<Entry>(queries.Count);

        // A batch of adds and removes should surface as one result list, not as one per step.
        _suppressNotifications = true;
        try
        {
            foreach (var options in queries)
            {
                var hash = options.QueryKey.Hash;
                var match = previous.FirstOrDefault(entry => entry.Hash == hash);

                if (match is not null)
                {
                    previous.Remove(match);
                    match.Observer.SetOptions(options);
                    reordered.Add(match);
                    continue;
                }

                var observer = new QueryObserver<TQueryFnData, TQueryFnData>(_client, options);
                var entry = new Entry(hash, observer);
                entry.Subscription = observer.Subscribe(_ => Notify());
                reordered.Add(entry);
            }

            foreach (var stale in previous)
            {
                stale.Subscription?.Dispose();
                stale.Observer.Dispose();
            }

            _entries.Clear();
            _entries.AddRange(reordered);
        }
        finally
        {
            _suppressNotifications = false;
        }

        Notify();
    }

    /// <summary>Subscribes to the combined results; dispose to unsubscribe.</summary>
    public IDisposable Subscribe(Action<IReadOnlyList<QueryObserverResult<TQueryFnData>>> listener)
    {
        ArgumentNullException.ThrowIfNull(listener);
        _listeners.Add(listener);
        return new Subscription(this, listener);
    }

    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        _disposed = true;
        _listeners.Clear();

        foreach (var entry in _entries)
        {
            entry.Subscription?.Dispose();
            entry.Observer.Dispose();
        }

        _entries.Clear();
    }

    private void Notify()
    {
        if (_suppressNotifications)
        {
            return;
        }

        var results = CurrentResults;
        foreach (var listener in _listeners.ToArray())
        {
            listener(results);
        }
    }

    private sealed class Entry(string hash, QueryObserver<TQueryFnData, TQueryFnData> observer)
    {
        public string Hash { get; } = hash;

        public QueryObserver<TQueryFnData, TQueryFnData> Observer { get; } = observer;

        public IDisposable? Subscription { get; set; }
    }

    private sealed class Subscription(
        QueriesObserver<TQueryFnData> observer,
        Action<IReadOnlyList<QueryObserverResult<TQueryFnData>>> listener) : IDisposable
    {
        public void Dispose() => observer._listeners.Remove(listener);
    }
}
