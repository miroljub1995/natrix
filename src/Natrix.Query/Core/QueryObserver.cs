namespace Natrix.Query;

/// <summary>
/// Watches one query on behalf of one consumer and turns its state into a result: applying
/// <c>Select</c>, filling in placeholder data, deciding staleness against this consumer's own
/// stale time, and driving mount refetches, focus refetches and polling. The counterpart of
/// TanStack Query's <c>QueryObserver</c>.
/// </summary>
/// <remarks>
/// <c>UseQuery</c> creates one of these per component and republishes its results as signals.
/// Use it directly only outside a component — a background poller, a test — and dispose it
/// when done, since an undisposed observer keeps its query alive and polling.
/// </remarks>
public sealed class QueryObserver<TQueryFnData, TData> : QueryObserverBase, IDisposable
{
    private readonly QueryClient _client;
    private readonly List<Action<QueryObserverResult<TData>>> _listeners = [];

    private UseQueryOptions<TQueryFnData, TData> _typedOptions;
    private ResolvedQueryOptions _resolvedOptions;
    private Query _currentQuery;
    private QueryState _currentQueryInitialState;
    private QueryObserverResult<TData>? _currentResult;
    private QueryState? _currentResultState;
    private Query? _lastQueryWithDefinedData;

    private object? _placeholderSourceData;
    private Query? _placeholderSourceQuery;
    private TData? _placeholderResult;
    private bool _hasPlaceholderResult;

    private Func<TQueryFnData, TData>? _selectFn;
    private TData? _selectResult;
    private Exception? _selectError;

    private IDisposable? _staleTimer;
    private IDisposable? _refetchIntervalTimer;
    private TimeSpan? _currentRefetchInterval;
    private bool _disposed;

    public QueryObserver(QueryClient client, UseQueryOptions<TQueryFnData, TData> options)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(options);

        _client = client;
        _typedOptions = options;
        _resolvedOptions = Resolve(options);
        _currentQuery = _client.QueryCache.Build(_client, _resolvedOptions);
        _currentQueryInitialState = _currentQuery.State;

        SetOptions(options);
    }

    /// <summary>The most recently computed result.</summary>
    public QueryObserverResult<TData> CurrentResult => _currentResult ??= CreateResult(_currentQuery, _resolvedOptions);

    /// <summary>The query this observer is currently watching.</summary>
    public Query CurrentQuery => _currentQuery;

    internal override ResolvedQueryOptions Options => _resolvedOptions;

    /// <summary>
    /// Starts watching. The first subscriber is what makes the observer live: it attaches to
    /// the query, kicks off the mount fetch and starts the timers. Dispose to stop.
    /// </summary>
    public IDisposable Subscribe(Action<QueryObserverResult<TData>> listener)
    {
        ArgumentNullException.ThrowIfNull(listener);
        ObjectDisposedException.ThrowIf(_disposed, this);

        _listeners.Add(listener);

        if (_listeners.Count == 1)
        {
            _currentQuery.AddObserver(this);

            if (ShouldFetchOnMount(_currentQuery, _resolvedOptions))
            {
                _ = ExecuteFetchAsync();
            }
            else
            {
                UpdateResult();
            }

            UpdateTimers();
        }

        return new Subscription(this, listener);
    }

    /// <summary>Whether anything is watching this observer.</summary>
    public bool HasListeners => _listeners.Count > 0;

    /// <summary>
    /// Reconfigures the observer. Changing the key moves it to another cache entry; changing
    /// anything that affects freshness re-evaluates the timers, and may fetch immediately.
    /// </summary>
    public void SetOptions(UseQueryOptions<TQueryFnData, TData> options)
    {
        ArgumentNullException.ThrowIfNull(options);

        var prevOptions = _resolvedOptions;
        var prevQuery = _currentQuery;

        if (!ReferenceEquals(_typedOptions, options))
        {
            // A different options object may carry a different placeholder, so the memoised
            // one cannot be trusted any more.
            _hasPlaceholderResult = false;
            _placeholderSourceData = null;
            _placeholderSourceQuery = null;
        }

        _typedOptions = options;
        _resolvedOptions = Resolve(options);

        UpdateQuery();
        _currentQuery.SetOptions(_resolvedOptions);

        var mounted = HasListeners;

        if (mounted && ShouldFetchOptionally(_currentQuery, prevQuery, _resolvedOptions, prevOptions))
        {
            _ = ExecuteFetchAsync();
        }

        UpdateResult();

        if (mounted && (!ReferenceEquals(_currentQuery, prevQuery)
            || _resolvedOptions.Enabled.Resolve(_currentQuery) != prevOptions.Enabled.Resolve(_currentQuery)
            || _resolvedOptions.StaleTime.Resolve(_currentQuery) != prevOptions.StaleTime.Resolve(_currentQuery)))
        {
            UpdateStaleTimeout();
        }

        var nextRefetchInterval = ComputeRefetchInterval();

        if (mounted && (!ReferenceEquals(_currentQuery, prevQuery)
            || _resolvedOptions.Enabled.Resolve(_currentQuery) != prevOptions.Enabled.Resolve(_currentQuery)
            || nextRefetchInterval != _currentRefetchInterval))
        {
            UpdateRefetchInterval(nextRefetchInterval);
        }
    }

    /// <summary>
    /// Fetches regardless of freshness, and completes when the result is in. This is what an
    /// explicit "reload" button calls.
    /// </summary>
    public async Task<QueryObserverResult<TData>> RefetchAsync(RefetchOptions? options = null)
    {
        await ExecuteFetchAsync(new FetchOptions { CancelRefetch = options?.CancelRefetch ?? true })
            .ConfigureAwait(true);

        UpdateResult();
        return CurrentResult;
    }

    /// <summary>
    /// Resolves once the query has data — fetching it first if the cache cannot answer. This
    /// is what makes a server-rendered page wait for its queries.
    /// </summary>
    public async Task<QueryObserverResult<TData>> SuspenseAsync()
    {
        if (!_resolvedOptions.Enabled.Resolve(_currentQuery))
        {
            return CurrentResult;
        }

        if (_currentQuery.State.HasData
            && !_currentQuery.IsStaleByTime(_resolvedOptions.StaleTime.Resolve(_currentQuery)))
        {
            return CurrentResult;
        }

        await ExecuteFetchAsync().ConfigureAwait(true);

        UpdateResult();
        return CurrentResult;
    }

    /// <summary>Stops watching, releases the query, and clears the timers.</summary>
    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        _disposed = true;
        _listeners.Clear();
        ClearStaleTimeout();
        ClearRefetchInterval();
        _currentQuery.RemoveObserver(this);
    }

    internal override void OnQueryUpdate()
    {
        UpdateResult();

        if (HasListeners)
        {
            UpdateTimers();
        }
    }

    internal override bool ShouldFetchOnWindowFocus() =>
        ShouldFetchOn(_currentQuery, _resolvedOptions, _resolvedOptions.RefetchOnWindowFocus);

    internal override bool ShouldFetchOnReconnect() =>
        ShouldFetchOn(_currentQuery, _resolvedOptions, _resolvedOptions.RefetchOnReconnect);

    internal override bool CurrentResultIsStale => CurrentResult.IsStale;

    internal override Task RefetchCoreAsync(RefetchOptions? options) => RefetchAsync(options);

    private ResolvedQueryOptions Resolve(UseQueryOptions<TQueryFnData, TData> options)
    {
        if (options.Select is null && typeof(TData) != typeof(TQueryFnData))
        {
            throw new InvalidOperationException(
                $"A query returning '{typeof(TQueryFnData)}' cannot be observed as '{typeof(TData)}' " +
                "without a Select projection.");
        }

        return _client.ResolveOptions(options);
    }

    private void UpdateQuery()
    {
        var query = _client.QueryCache.Build(_client, _resolvedOptions);

        if (ReferenceEquals(query, _currentQuery))
        {
            return;
        }

        var prevQuery = _currentQuery;
        _currentQuery = query;
        _currentQueryInitialState = query.State;

        if (HasListeners)
        {
            prevQuery.RemoveObserver(this);
            query.AddObserver(this);
        }
    }

    private async Task ExecuteFetchAsync(FetchOptions? fetchOptions = null)
    {
        UpdateQuery();

        try
        {
            await _currentQuery.FetchAsync(_resolvedOptions, fetchOptions).ConfigureAwait(true);
        }
        catch (Exception)
        {
            // A failed fetch is a result, not an accident: it is already recorded in the
            // query's state and surfaces through Error on the observer's result.
        }
    }

    private void UpdateResult()
    {
        var prevResult = _currentResult;
        var nextResult = CreateResult(_currentQuery, _resolvedOptions);

        _currentResultState = _currentQuery.State;

        if (_currentResultState.HasData)
        {
            _lastQueryWithDefinedData = _currentQuery;
        }

        if (nextResult == prevResult)
        {
            return;
        }

        _currentResult = nextResult;

        foreach (var listener in _listeners.ToArray())
        {
            listener(nextResult);
        }

        _client.QueryCache.Notify(
            new QueryCacheNotifyEvent(QueryCacheNotifyEventType.ObserverResultsUpdated, _currentQuery, this));
    }

    private QueryObserverResult<TData> CreateResult(Query query, ResolvedQueryOptions options)
    {
        var prevQuery = _currentQuery;
        var prevResult = _currentResult;
        var prevResultState = _currentResultState;
        var queryChange = !ReferenceEquals(query, prevQuery);
        var queryInitialState = queryChange ? query.State : _currentQueryInitialState;

        var state = query.State;
        var status = state.Status;
        var error = state.Error;
        var errorUpdatedAt = state.ErrorUpdatedAt;
        var isPlaceholderData = false;

        TData? data;
        var hasData = state.HasData;

        if (_typedOptions.Select is not null && state.HasData)
        {
            // Re-running a projection over unchanged data would hand consumers a new object
            // every time the query state ticks, so the last projection is reused whenever both
            // the data and the projection itself are the same references as last time.
            if (prevResult is not null
                && prevResultState is not null
                && ReferenceEquals(state.Data, prevResultState.Data)
                && ReferenceEquals(_typedOptions.Select, _selectFn))
            {
                data = _selectResult;
            }
            else
            {
                try
                {
                    _selectFn = _typedOptions.Select;
                    _selectResult = _typedOptions.Select((TQueryFnData)state.Data!);
                    data = _selectResult;
                    _selectError = null;
                }
                catch (Exception selectException)
                {
                    _selectError = selectException;
                    data = _selectResult;
                }
            }
        }
        else
        {
            // Guarded, because unboxing a missing value into a value-typed TData would throw
            // rather than yield "nothing yet".
            data = state.HasData ? (TData?)state.Data : default;
        }

        if (_selectError is not null)
        {
            error = _selectError;
            data = _selectResult;
            errorUpdatedAt = _client.Scheduler.Now();
            status = QueryStatus.Error;
        }

        // Placeholder data only ever stands in for data that is not there yet; it never
        // overrides real data and never survives into the cache.
        if (_typedOptions.PlaceholderData.HasValue && !hasData && status == QueryStatus.Pending)
        {
            var sourceQuery = _lastQueryWithDefinedData;
            var sourceData = sourceQuery is { State.HasData: true } ? sourceQuery.State.Data : null;

            // Memoised against what it was derived from, so a factory doing real work is not
            // re-run on every state tick of the query that is still loading.
            if (!_hasPlaceholderResult
                || !ReferenceEquals(sourceData, _placeholderSourceData)
                || !ReferenceEquals(sourceQuery, _placeholderSourceQuery))
            {
                var raw = _typedOptions.PlaceholderData.Resolve((TQueryFnData?)sourceData, sourceQuery);

                _placeholderResult = raw is null
                    ? default
                    : _typedOptions.Select is not null
                        ? _typedOptions.Select(raw)
                        : (TData?)(object?)raw;

                _hasPlaceholderResult = raw is not null;
                _placeholderSourceData = sourceData;
                _placeholderSourceQuery = sourceQuery;
            }

            if (_hasPlaceholderResult)
            {
                data = _placeholderResult;
                hasData = true;
                status = QueryStatus.Success;
                isPlaceholderData = true;
            }
        }

        return new QueryObserverResult<TData>
        {
            Data = data,
            HasData = hasData,
            Error = error,
            Status = status,
            FetchStatus = state.FetchStatus,
            DataUpdatedAt = state.DataUpdatedAt,
            ErrorUpdatedAt = errorUpdatedAt,
            FailureCount = state.FetchFailureCount,
            FailureReason = state.FetchFailureReason,
            ErrorUpdateCount = state.ErrorUpdateCount,
            IsStale = IsStaleFor(query, options),
            IsPlaceholderData = isPlaceholderData,
            IsFetched = state.DataUpdateCount > 0 || state.ErrorUpdateCount > 0,
            IsFetchedAfterMount = state.DataUpdateCount > queryInitialState.DataUpdateCount
                || state.ErrorUpdateCount > queryInitialState.ErrorUpdateCount,
            IsEnabled = options.Enabled.Resolve(query),
        };
    }

    private void UpdateTimers()
    {
        UpdateStaleTimeout();
        UpdateRefetchInterval(ComputeRefetchInterval());
    }

    private void UpdateStaleTimeout()
    {
        ClearStaleTimeout();

        var staleTime = _resolvedOptions.StaleTime.Resolve(_currentQuery);

        // Already stale, or never going stale on its own: nothing to wake up for.
        if (CurrentResult.IsStale || !QueryScheduler.IsValidTimeout(staleTime))
        {
            return;
        }

        var time = _currentQuery.TimeUntilStale(CurrentResult.DataUpdatedAt, staleTime);

        // A hair past the boundary, so the timer never fires a moment early and finds the data
        // still fresh.
        _staleTimer = _client.Scheduler.Schedule(time + TimeSpan.FromMilliseconds(1), () =>
        {
            if (!CurrentResult.IsStale)
            {
                UpdateResult();
            }
        });
    }

    private TimeSpan? ComputeRefetchInterval() => _resolvedOptions.RefetchInterval.Resolve(_currentQuery);

    private void UpdateRefetchInterval(TimeSpan? nextInterval)
    {
        ClearRefetchInterval();
        _currentRefetchInterval = nextInterval;

        if (!_resolvedOptions.Enabled.Resolve(_currentQuery)
            || !QueryScheduler.IsValidTimeout(nextInterval)
            || nextInterval == TimeSpan.Zero)
        {
            return;
        }

        _refetchIntervalTimer = _client.Scheduler.ScheduleRepeating(nextInterval!.Value, () =>
        {
            // Polling a page nobody is looking at wastes requests; opt back in with
            // RefetchIntervalInBackground when the data must stay warm regardless.
            if (_resolvedOptions.RefetchIntervalInBackground || _client.FocusManager.IsFocused)
            {
                _ = ExecuteFetchAsync();
            }
        });
    }

    private void ClearStaleTimeout()
    {
        _staleTimer?.Dispose();
        _staleTimer = null;
    }

    private void ClearRefetchInterval()
    {
        _refetchIntervalTimer?.Dispose();
        _refetchIntervalTimer = null;
        _currentRefetchInterval = null;
    }

    private static bool IsStaleFor(Query query, ResolvedQueryOptions options) =>
        options.Enabled.Resolve(query) && query.IsStaleByTime(options.StaleTime.Resolve(query));

    private static bool ShouldFetchOn(Query query, ResolvedQueryOptions options, RefetchOnOption field)
    {
        if (!options.Enabled.Resolve(query))
        {
            return false;
        }

        var value = field.Resolve(query);
        return value == RefetchOnValue.Always
            || (value != RefetchOnValue.False && IsStaleFor(query, options));
    }

    private static bool ShouldLoadOnMount(Query query, ResolvedQueryOptions options) =>
        options.Enabled.Resolve(query)
        && !query.State.HasData
        && !(query.State.Status == QueryStatus.Error && !options.RetryOnMount);

    private static bool ShouldFetchOnMount(Query query, ResolvedQueryOptions options) =>
        ShouldLoadOnMount(query, options)
        || (query.State.HasData && ShouldFetchOn(query, options, options.RefetchOnMount));

    /// <summary>
    /// Whether reconfiguring should fetch: only when the observer moved to another query, or
    /// when it was disabled and has just been switched on — and then only if the data it lands
    /// on is stale.
    /// </summary>
    private static bool ShouldFetchOptionally(
        Query query,
        Query prevQuery,
        ResolvedQueryOptions options,
        ResolvedQueryOptions prevOptions) =>
        (!ReferenceEquals(query, prevQuery) || !prevOptions.Enabled.Resolve(query))
        && IsStaleFor(query, options);

    private sealed class Subscription(QueryObserver<TQueryFnData, TData> observer, Action<QueryObserverResult<TData>> listener)
        : IDisposable
    {
        public void Dispose()
        {
            observer._listeners.Remove(listener);

            if (!observer.HasListeners)
            {
                observer.Dispose();
            }
        }
    }
}
