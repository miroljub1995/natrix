namespace Natrix.Query;

/// <summary>Everything a <see cref="QueryClient"/> can be configured with.</summary>
public sealed class QueryClientConfig
{
    /// <summary>
    /// The cache to use. Supply one to share entries between clients — how a server-rendered
    /// request hands its data over, and how tests inspect state no component is watching.
    /// </summary>
    public QueryCache? QueryCache { get; init; }

    /// <summary>Defaults applied to every query that does not override them.</summary>
    public QueryClientDefaultOptions? DefaultOptions { get; init; }

    /// <summary>
    /// The clock behind staleness, polling, retry backoff and garbage collection. Substitute
    /// it to drive time by hand in tests.
    /// </summary>
    public TimeProvider? TimeProvider { get; init; }

    /// <summary>Where focus changes come from. Defaults to <see cref="Natrix.Query.FocusManager.Default"/>.</summary>
    public FocusManager? FocusManager { get; init; }

    /// <summary>Where connectivity changes come from. Defaults to <see cref="Natrix.Query.OnlineManager.Default"/>.</summary>
    public OnlineManager? OnlineManager { get; init; }
}

/// <summary>
/// The entry point: it owns the cache, the defaults, and every imperative operation over
/// cached data. The counterpart of TanStack Query's <c>QueryClient</c>.
/// </summary>
/// <remarks>
/// One client per application, published to components through
/// <c>NatrixHostBuilder.UseQueryClient</c> or <c>QueryClientProvider</c>, and
/// reachable from inside a component with <c>UseQueryClient()</c>.
/// </remarks>
public sealed class QueryClient : IDisposable
{
    private readonly List<(QueryKey Key, DefaultQueryOptions Options)> _queryDefaults = [];
    private readonly bool _ownsQueryCache;

    private IDisposable? _focusSubscription;
    private IDisposable? _onlineSubscription;
    private int _mountCount;

    public QueryClient(QueryClientConfig? config = null)
    {
        // A shared cache outlives the client that borrowed it, so it is only emptied on
        // disposal when this client created it.
        _ownsQueryCache = config?.QueryCache is null;
        QueryCache = config?.QueryCache ?? new QueryCache();
        DefaultOptions = config?.DefaultOptions;
        FocusManager = config?.FocusManager ?? FocusManager.Default;
        OnlineManager = config?.OnlineManager ?? OnlineManager.Default;
        Scheduler = new QueryScheduler(config?.TimeProvider ?? TimeProvider.System);
    }

    /// <summary>The cache this client reads and writes.</summary>
    public QueryCache QueryCache { get; }

    /// <summary>Defaults applied to every query that does not override them.</summary>
    public QueryClientDefaultOptions? DefaultOptions { get; set; }

    /// <summary>Where focus changes come from.</summary>
    public FocusManager FocusManager { get; }

    /// <summary>Where connectivity changes come from.</summary>
    public OnlineManager OnlineManager { get; }

    internal QueryScheduler Scheduler { get; }

    /// <summary>
    /// Starts listening for focus and connectivity so queries can refetch on focus and resume
    /// when the connection returns. Reference counted: only the first call subscribes.
    /// </summary>
    public void Mount()
    {
        _mountCount++;
        if (_mountCount != 1)
        {
            return;
        }

        _focusSubscription = FocusManager.Subscribe(isFocused =>
        {
            if (isFocused)
            {
                QueryCache.OnFocus();
            }
        });

        _onlineSubscription = OnlineManager.Subscribe(isOnline =>
        {
            if (isOnline)
            {
                QueryCache.OnOnline();
            }
        });
    }

    /// <summary>Stops listening once the last mount is released.</summary>
    public void Unmount()
    {
        if (_mountCount == 0)
        {
            return;
        }

        _mountCount--;
        if (_mountCount != 0)
        {
            return;
        }

        _focusSubscription?.Dispose();
        _focusSubscription = null;
        _onlineSubscription?.Dispose();
        _onlineSubscription = null;
    }

    /// <summary>How many queries matching <paramref name="filters"/> are currently fetching.</summary>
    public int IsFetching(QueryFilters? filters = null)
    {
        var effective = WithFetchStatus(filters, FetchStatus.Fetching);
        return QueryCache.FindAll(effective).Count;
    }

    /// <summary>
    /// The data cached under <paramref name="queryKey"/>, or <c>default</c> when the key has
    /// no data. A synchronous read: it never triggers a fetch.
    /// </summary>
    public TData? GetQueryData<TData>(QueryKey queryKey)
    {
        ArgumentNullException.ThrowIfNull(queryKey);

        var state = QueryCache.Get(queryKey.Hash)?.State;
        return state is { HasData: true } ? (TData?)state.Data : default;
    }

    /// <summary>The full state of the query under <paramref name="queryKey"/>, if it exists.</summary>
    public QueryState? GetQueryState(QueryKey queryKey)
    {
        ArgumentNullException.ThrowIfNull(queryKey);
        return QueryCache.Get(queryKey.Hash)?.State;
    }

    /// <summary>
    /// Writes data into the cache, creating the entry if needed. Every observer of the key
    /// sees it immediately — the mechanism behind optimistic updates and behind writing a
    /// server response straight into the cache.
    /// </summary>
    /// <remarks>
    /// A <c>null</c> value means "no data" and is ignored, mirroring how TanStack Query treats
    /// an updater that returns <c>undefined</c>.
    /// </remarks>
    public TData? SetQueryData<TData>(QueryKey queryKey, TData? data, SetDataOptions? options = null) =>
        SetQueryData<TData>(queryKey, _ => data, options);

    /// <summary>
    /// Writes data into the cache, deriving it from what is already there. The updater
    /// receives <c>default</c> when the key holds nothing yet, and returning <c>null</c>
    /// leaves the cache untouched.
    /// </summary>
    public TData? SetQueryData<TData>(QueryKey queryKey, Func<TData?, TData?> updater, SetDataOptions? options = null)
    {
        ArgumentNullException.ThrowIfNull(queryKey);
        ArgumentNullException.ThrowIfNull(updater);

        var existing = QueryCache.Get(queryKey.Hash);
        var previous = existing is { State.HasData: true } ? (TData?)existing.State.Data : default;
        var next = updater(previous);

        if (next is null)
        {
            return default;
        }

        var resolved = ResolveOptions(new UseQueryOptions<TData> { QueryKey = queryKey });
        var query = QueryCache.Build(this, resolved);

        return (TData?)query.SetData(next, new SetDataOptions
        {
            UpdatedAt = options?.UpdatedAt,
            Manual = true,
        });
    }

    /// <summary>The keys and data of every query matching <paramref name="filters"/>.</summary>
    public IReadOnlyList<(QueryKey QueryKey, TData? Data)> GetQueriesData<TData>(QueryFilters? filters = null) =>
        QueryCache.FindAll(filters)
            .Select(query => (
                query.QueryKey,
                query.State is { HasData: true } state ? (TData?)state.Data : default))
            .ToArray();

    /// <summary>Applies the same update to every query matching <paramref name="filters"/>.</summary>
    public IReadOnlyList<(QueryKey QueryKey, TData? Data)> SetQueriesData<TData>(
        QueryFilters filters,
        Func<TData?, TData?> updater,
        SetDataOptions? options = null)
    {
        ArgumentNullException.ThrowIfNull(filters);
        ArgumentNullException.ThrowIfNull(updater);

        return QueryCache.FindAll(filters)
            .Select(query => (query.QueryKey, SetQueryData(query.QueryKey, updater, options)))
            .ToArray();
    }

    /// <summary>
    /// Fetches and caches the data for a key, awaiting the result. Unlike a mounted query this
    /// does not retry by default, and it returns the cached data untouched when it is still
    /// fresh according to <c>StaleTime</c>.
    /// </summary>
    public async Task<TQueryFnData?> FetchQueryAsync<TQueryFnData>(UseQueryOptions<TQueryFnData> options)
    {
        ArgumentNullException.ThrowIfNull(options);

        // An imperative fetch is awaited by a caller who wants an answer or an exception now,
        // so it does not inherit the mounted-query default of retrying three times.
        return (TQueryFnData?)await FetchResolvedAsync(ResolveOptions(options, retryFallback: false))
            .ConfigureAwait(true);
    }

    /// <summary>
    /// Fetches an infinite query's pages ahead of time, awaiting the result. Without
    /// <paramref name="pages"/> it loads one page; with it, that many, stopping early when the
    /// list runs out.
    /// </summary>
    public async Task<InfiniteData<TPage, TPageParam>?> FetchInfiniteQueryAsync<TPage, TPageParam>(
        UseInfiniteQueryOptions<TPage, TPageParam> options,
        int? pages = null)
    {
        ArgumentNullException.ThrowIfNull(options);

        var resolved = ResolveOptions(options.ToQueryOptions(pages ?? 1), retryFallback: false);
        return (InfiniteData<TPage, TPageParam>?)await FetchResolvedAsync(resolved).ConfigureAwait(true);
    }

    /// <summary>Warms an infinite query's cache entry and swallows any failure.</summary>
    public async Task PrefetchInfiniteQueryAsync<TPage, TPageParam>(
        UseInfiniteQueryOptions<TPage, TPageParam> options,
        int? pages = null)
    {
        try
        {
            await FetchInfiniteQueryAsync(options, pages).ConfigureAwait(true);
        }
        catch (Exception)
        {
            // Prefetching is best effort: the mounted query will surface the error properly.
        }
    }

    /// <summary>Returns an infinite query's cached pages if there are any, and otherwise fetches them.</summary>
    public async Task<InfiniteData<TPage, TPageParam>?> EnsureInfiniteQueryDataAsync<TPage, TPageParam>(
        UseInfiniteQueryOptions<TPage, TPageParam> options,
        int? pages = null)
    {
        ArgumentNullException.ThrowIfNull(options);

        var query = QueryCache.Get(options.QueryKey.Hash);
        if (query is { State.HasData: true })
        {
            return (InfiniteData<TPage, TPageParam>?)query.State.Data;
        }

        return await FetchInfiniteQueryAsync(options, pages).ConfigureAwait(true);
    }

    private async Task<object?> FetchResolvedAsync(ResolvedQueryOptions resolved)
    {
        var query = QueryCache.Build(this, resolved);

        if (!query.IsStaleByTime(resolved.StaleTime.Resolve(query)))
        {
            return query.State.Data;
        }

        return await query.FetchAsync(resolved).ConfigureAwait(true);
    }

    /// <summary>
    /// Fetches data into the cache ahead of time and swallows any failure — the point is to
    /// warm the cache, not to hand anything back.
    /// </summary>
    public async Task PrefetchQueryAsync<TQueryFnData>(UseQueryOptions<TQueryFnData> options)
    {
        try
        {
            await FetchQueryAsync(options).ConfigureAwait(true);
        }
        catch (Exception)
        {
            // Prefetching is best effort: the mounted query will surface the error properly.
        }
    }

    /// <summary>
    /// Returns cached data if there is any, and otherwise fetches it. Use it when you need the
    /// data now but do not care whether it comes from the cache or the network.
    /// </summary>
    public async Task<TQueryFnData?> EnsureQueryDataAsync<TQueryFnData>(
        UseQueryOptions<TQueryFnData> options,
        bool revalidateIfStale = false)
    {
        ArgumentNullException.ThrowIfNull(options);

        var resolved = ResolveOptions(options, retryFallback: false);
        var query = QueryCache.Build(this, resolved);

        if (!query.State.HasData)
        {
            return await FetchQueryAsync(options).ConfigureAwait(true);
        }

        if (revalidateIfStale && query.IsStaleByTime(resolved.StaleTime.Resolve(query)))
        {
            _ = PrefetchQueryAsync(options);
        }

        return (TQueryFnData?)query.State.Data;
    }

    /// <summary>
    /// Marks matching queries stale and refetches the active ones. The everyday way to say
    /// "this data just changed" after a write.
    /// </summary>
    public Task InvalidateQueriesAsync(QueryFilters? filters = null, InvalidateQueryOptions? options = null)
    {
        foreach (var query in QueryCache.FindAll(filters))
        {
            query.Invalidate();
        }

        var refetchType = options?.RefetchType ?? RefetchType.Active;
        if (refetchType == RefetchType.None)
        {
            return Task.CompletedTask;
        }

        return RefetchQueriesAsync(
            WithType(filters, refetchType switch
            {
                RefetchType.Active => QueryTypeFilter.Active,
                RefetchType.Inactive => QueryTypeFilter.Inactive,
                _ => QueryTypeFilter.All,
            }),
            new RefetchQueryOptions { CancelRefetch = options?.CancelRefetch ?? true });
    }

    /// <summary>Refetches every matching query and completes once they have all settled.</summary>
    public async Task RefetchQueriesAsync(QueryFilters? filters = null, RefetchQueryOptions? options = null)
    {
        var fetchOptions = new FetchOptions { CancelRefetch = options?.CancelRefetch ?? true };

        var promises = QueryCache.FindAll(filters)
            .Where(query => !query.IsDisabled())
            .Select(query =>
            {
                var promise = query.FetchAsync(null, fetchOptions);

                // A query that paused because the app is offline will not settle until the
                // connection returns; waiting for it would hang the caller indefinitely.
                return query.State.FetchStatus == FetchStatus.Paused ? Task.CompletedTask : Swallow(promise);
            })
            .ToArray();

        await Task.WhenAll(promises).ConfigureAwait(true);
    }

    /// <summary>
    /// Cancels in-flight fetches for matching queries, reverting their state by default so a
    /// cancelled refetch leaves no trace.
    /// </summary>
    public async Task CancelQueriesAsync(QueryFilters? filters = null, CancelOptions? options = null)
    {
        var promises = QueryCache.FindAll(filters)
            .Select(query => query.CancelAsync(options ?? new CancelOptions()))
            .ToArray();

        await Task.WhenAll(promises).ConfigureAwait(true);
    }

    /// <summary>Removes matching queries from the cache entirely, data and all.</summary>
    public void RemoveQueries(QueryFilters? filters = null)
    {
        foreach (var query in QueryCache.FindAll(filters))
        {
            QueryCache.Remove(query);
        }
    }

    /// <summary>
    /// Returns matching queries to their initial state — unlike removal, observers stay
    /// attached, so active queries immediately fetch again.
    /// </summary>
    public Task ResetQueriesAsync(QueryFilters? filters = null, ResetQueryOptions? options = null)
    {
        foreach (var query in QueryCache.FindAll(filters))
        {
            query.Reset();
        }

        return RefetchQueriesAsync(
            WithType(filters, QueryTypeFilter.Active),
            new RefetchQueryOptions { CancelRefetch = options?.CancelRefetch ?? true });
    }

    /// <summary>Empties the cache.</summary>
    public void Clear() => QueryCache.Clear();

    /// <summary>
    /// Registers defaults for every query whose key starts with <paramref name="queryKey"/>.
    /// The usual home for a shared query function or a per-resource stale time.
    /// </summary>
    public void SetQueryDefaults(QueryKey queryKey, DefaultQueryOptions options)
    {
        ArgumentNullException.ThrowIfNull(queryKey);
        ArgumentNullException.ThrowIfNull(options);

        _queryDefaults.RemoveAll(entry => entry.Key.Hash == queryKey.Hash);
        _queryDefaults.Add((queryKey, options));
    }

    /// <summary>
    /// The defaults registered for <paramref name="queryKey"/>. When several registrations
    /// match, they are merged in registration order and the last one wins.
    /// </summary>
    public DefaultQueryOptions? GetQueryDefaults(QueryKey queryKey)
    {
        ArgumentNullException.ThrowIfNull(queryKey);

        DefaultQueryOptions? result = null;
        foreach (var (key, options) in _queryDefaults)
        {
            if (!queryKey.PartiallyMatches(key))
            {
                continue;
            }

            result = result is null ? options : Merge(result, options);
        }

        return result;
    }

    public void Dispose()
    {
        _mountCount = _mountCount > 0 ? 1 : 0;
        Unmount();

        if (_ownsQueryCache)
        {
            QueryCache.Clear();
        }
    }

    /// <summary>
    /// Merges client defaults, key defaults and the caller's options into the single defaulted
    /// options object a query runs on — TanStack Query's <c>defaultQueryOptions</c>.
    /// </summary>
    internal ResolvedQueryOptions ResolveOptions<TQueryFnData, TData>(
        UseQueryOptions<TQueryFnData, TData> options,
        RetryOption? retryFallback = null)
    {
        ArgumentNullException.ThrowIfNull(options);

        var keyDefaults = GetQueryDefaults(options.QueryKey);
        var clientDefaults = DefaultOptions?.Queries;

        var queryFn = WrapQueryFn(options.QueryFn)
            ?? keyDefaults?.QueryFn
            ?? clientDefaults?.QueryFn;

        var networkMode = options.NetworkMode
            ?? keyDefaults?.NetworkMode
            ?? clientDefaults?.NetworkMode
            ?? NetworkMode.Online;

        var enabled = options.Enabled
            ?? keyDefaults?.Enabled
            ?? clientDefaults?.Enabled
            ?? EnabledOption.FromBool(true);

        if (queryFn is null)
        {
            // Nothing can fetch this query, which is what TanStack Query's skipToken means:
            // the entry exists and can hold data, but it never runs on its own.
            enabled = EnabledOption.FromBool(false);
        }

        return new ResolvedQueryOptions
        {
            QueryKey = options.QueryKey,
            QueryHash = options.QueryKey.Hash,
            QueryFn = queryFn,
            Enabled = enabled,
            StaleTime = options.StaleTime
                ?? keyDefaults?.StaleTime
                ?? clientDefaults?.StaleTime
                ?? StaleTimeOption.FromTimeSpan(TimeSpan.Zero),
            GcTime = options.GcTime ?? keyDefaults?.GcTime ?? clientDefaults?.GcTime ?? QueryDefaults.GcTime,
            Retry = options.Retry ?? keyDefaults?.Retry ?? clientDefaults?.Retry ?? retryFallback ?? RetryOption.FromCount(3),
            RetryDelay = options.RetryDelay
                ?? keyDefaults?.RetryDelay
                ?? clientDefaults?.RetryDelay
                ?? QueryDefaults.ExponentialBackoff,
            NetworkMode = networkMode,
            RefetchInterval = options.RefetchInterval
                ?? keyDefaults?.RefetchInterval
                ?? clientDefaults?.RefetchInterval
                ?? default,
            RefetchIntervalInBackground = options.RefetchIntervalInBackground
                ?? keyDefaults?.RefetchIntervalInBackground
                ?? clientDefaults?.RefetchIntervalInBackground
                ?? false,
            RefetchOnMount = options.RefetchOnMount
                ?? keyDefaults?.RefetchOnMount
                ?? clientDefaults?.RefetchOnMount
                ?? RefetchOnOption.FromBool(true),
            RefetchOnWindowFocus = options.RefetchOnWindowFocus
                ?? keyDefaults?.RefetchOnWindowFocus
                ?? clientDefaults?.RefetchOnWindowFocus
                ?? RefetchOnOption.FromBool(true),

            // Reconnecting is meaningless to a query that ignores connectivity in the first
            // place, so NetworkMode.Always turns this default off.
            RefetchOnReconnect = options.RefetchOnReconnect
                ?? keyDefaults?.RefetchOnReconnect
                ?? clientDefaults?.RefetchOnReconnect
                ?? RefetchOnOption.FromBool(networkMode != NetworkMode.Always),
            RetryOnMount = options.RetryOnMount ?? keyDefaults?.RetryOnMount ?? clientDefaults?.RetryOnMount ?? true,
            InitialData = options.InitialData.HasValue
                ? () => options.InitialData.Resolve()
                : null,
            InitialDataUpdatedAt = options.InitialDataUpdatedAt,
            StructuralSharing = options.StructuralSharing
                ?? keyDefaults?.StructuralSharing
                ?? clientDefaults?.StructuralSharing
                ?? true,
            StructuralSharingFn = WrapStructuralSharing(options.StructuralSharingFn)
                ?? keyDefaults?.StructuralSharingFn
                ?? clientDefaults?.StructuralSharingFn,
            Meta = options.Meta ?? keyDefaults?.Meta ?? clientDefaults?.Meta,
            Behavior = options.Behavior,
        };
    }

    private static Func<QueryFunctionContext, Task<object?>>? WrapQueryFn<TQueryFnData>(
        Func<QueryFunctionContext, Task<TQueryFnData>>? queryFn)
    {
        if (queryFn is null)
        {
            return null;
        }

        return async context => await queryFn(context).ConfigureAwait(true);
    }

    private static Func<object?, object?, object?>? WrapStructuralSharing<TQueryFnData>(
        Func<TQueryFnData?, TQueryFnData, TQueryFnData>? structuralSharing)
    {
        if (structuralSharing is null)
        {
            return null;
        }

        return (previous, next) => next is TQueryFnData typed
            ? structuralSharing((TQueryFnData?)previous, typed)
            : next;
    }

    private static QueryFilters WithType(QueryFilters? filters, QueryTypeFilter type) => new()
    {
        QueryKey = filters?.QueryKey,
        Exact = filters?.Exact ?? false,
        Type = type,
        Stale = filters?.Stale,
        FetchStatus = filters?.FetchStatus,
        Predicate = filters?.Predicate,
    };

    private static QueryFilters WithFetchStatus(QueryFilters? filters, FetchStatus fetchStatus) => new()
    {
        QueryKey = filters?.QueryKey,
        Exact = filters?.Exact ?? false,
        Type = filters?.Type ?? QueryTypeFilter.All,
        Stale = filters?.Stale,
        FetchStatus = filters?.FetchStatus ?? fetchStatus,
        Predicate = filters?.Predicate,
    };

    private static DefaultQueryOptions Merge(DefaultQueryOptions baseOptions, DefaultQueryOptions overrides) => new()
    {
        QueryFn = overrides.QueryFn ?? baseOptions.QueryFn,
        Enabled = overrides.Enabled ?? baseOptions.Enabled,
        StaleTime = overrides.StaleTime ?? baseOptions.StaleTime,
        GcTime = overrides.GcTime ?? baseOptions.GcTime,
        Retry = overrides.Retry ?? baseOptions.Retry,
        RetryDelay = overrides.RetryDelay ?? baseOptions.RetryDelay,
        NetworkMode = overrides.NetworkMode ?? baseOptions.NetworkMode,
        RefetchInterval = overrides.RefetchInterval ?? baseOptions.RefetchInterval,
        RefetchIntervalInBackground = overrides.RefetchIntervalInBackground ?? baseOptions.RefetchIntervalInBackground,
        RefetchOnMount = overrides.RefetchOnMount ?? baseOptions.RefetchOnMount,
        RefetchOnWindowFocus = overrides.RefetchOnWindowFocus ?? baseOptions.RefetchOnWindowFocus,
        RefetchOnReconnect = overrides.RefetchOnReconnect ?? baseOptions.RefetchOnReconnect,
        RetryOnMount = overrides.RetryOnMount ?? baseOptions.RetryOnMount,
        StructuralSharing = overrides.StructuralSharing ?? baseOptions.StructuralSharing,
        StructuralSharingFn = overrides.StructuralSharingFn ?? baseOptions.StructuralSharingFn,
        Meta = overrides.Meta ?? baseOptions.Meta,
    };

    private static Task Swallow(Task task) => task.ContinueWith(
        static t => _ = t.Exception,
        CancellationToken.None,
        TaskContinuationOptions.ExecuteSynchronously,
        TaskScheduler.Default);
}
