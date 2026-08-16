namespace Natrix.Query;

/// <summary>
/// One entry in the cache: the data for a single key, its state machine, the fetch currently
/// running against it, and the observers watching it. The counterpart of TanStack Query's
/// <c>Query</c> class.
/// </summary>
/// <remarks>
/// Queries are created and disposed of by the <see cref="QueryCache"/>, never directly. Most
/// applications interact with them only through filters and predicates —
/// <c>Predicate = q =&gt; q.State.Status == QueryStatus.Error</c> — or through the
/// <see cref="QueryClient"/> methods that operate on them.
/// </remarks>
public sealed class Query
{
    private readonly QueryCache _cache;
    private readonly QueryScheduler _scheduler;
    private readonly List<QueryObserverBase> _observers = [];

    private QueryState? _revertState;
    private Retryer? _retryer;
    private IDisposable? _gcTimer;
    private TimeSpan _gcTime;
    private bool _abortSignalConsumed;

    internal Query(
        QueryCache cache,
        QueryClient client,
        QueryScheduler scheduler,
        ResolvedQueryOptions options,
        QueryState? state)
    {
        _cache = cache;
        _scheduler = scheduler;
        Client = client;
        QueryKey = options.QueryKey;
        QueryHash = options.QueryHash;
        Options = options;
        _gcTime = TimeSpan.Zero;
        UpdateGcTime(options.GcTime);

        InitialState = state ?? GetDefaultState(options, scheduler);
        State = InitialState;

        ScheduleGc();
    }

    /// <summary>The client this query belongs to.</summary>
    public QueryClient Client { get; }

    /// <summary>The key this query was registered under.</summary>
    public QueryKey QueryKey { get; }

    /// <summary>The hash the cache indexes this query under.</summary>
    public string QueryHash { get; }

    /// <summary>The query's current options, last written by whichever observer set them.</summary>
    public ResolvedQueryOptions Options { get; private set; }

    /// <summary>The current state. Replaced wholesale on every transition, never mutated.</summary>
    public QueryState State { get; private set; }

    /// <summary>The state the query started from, restored by <see cref="Reset"/>.</summary>
    public QueryState InitialState { get; }

    /// <summary>Arbitrary metadata from the <c>Meta</c> option.</summary>
    public IReadOnlyDictionary<string, object?>? Meta => Options.Meta;

    /// <summary>How many observers are watching this query.</summary>
    public int ObserversCount => _observers.Count;

    /// <summary>The observers watching this query.</summary>
    public IReadOnlyList<QueryObserverBase> Observers => _observers;

    /// <summary>
    /// Whether at least one observer wants this query — i.e. is enabled. Queries with no
    /// observers, and queries whose observers are all disabled, are inactive.
    /// </summary>
    public bool IsActive() => _observers.Any(observer => observer.Options.Enabled.Resolve(this));

    /// <summary>
    /// Whether the query is prevented from fetching: every observer disabled, or — with no
    /// observers at all — no query function and nothing ever fetched.
    /// </summary>
    public bool IsDisabled()
    {
        if (ObserversCount > 0)
        {
            return !IsActive();
        }

        return Options.QueryFn is null
            || State.DataUpdateCount + State.ErrorUpdateCount == 0;
    }

    /// <summary>
    /// Whether the data should be considered out of date. With observers attached this is
    /// their verdict (each applies its own <c>StaleTime</c>); without them, data that exists
    /// and was not invalidated is fresh.
    /// </summary>
    public bool IsStale()
    {
        if (ObserversCount > 0)
        {
            return _observers.Any(observer => observer.CurrentResultIsStale);
        }

        return !State.HasData || State.IsInvalidated;
    }

    /// <summary>
    /// Whether the data is older than <paramref name="staleTime"/> — or invalidated, or absent,
    /// both of which make a query stale regardless of the clock.
    /// </summary>
    public bool IsStaleByTime(TimeSpan staleTime)
    {
        if (State.IsInvalidated || !State.HasData)
        {
            return true;
        }

        return TimeUntilStale(State.DataUpdatedAt, staleTime) <= TimeSpan.Zero;
    }

    /// <summary>How long until data fetched at <paramref name="updatedAt"/> goes stale.</summary>
    internal TimeSpan TimeUntilStale(long updatedAt, TimeSpan staleTime)
    {
        if (staleTime == QueryTime.Infinity)
        {
            return QueryTime.Infinity;
        }

        // Milliseconds rather than TimeSpan arithmetic: subtracting from a stale time close to
        // TimeSpan.MaxValue would overflow, and "practically never" is a stale time people do
        // configure.
        var remaining = staleTime.TotalMilliseconds - (_scheduler.Now() - updatedAt);
        return remaining > 0 ? TimeSpan.FromMilliseconds(remaining) : TimeSpan.Zero;
    }

    /// <summary>
    /// Writes data straight into the cache, as <see cref="QueryClient.SetQueryData{TData}"/>
    /// does. Returns what was actually stored, which structural sharing may keep as the
    /// previous reference.
    /// </summary>
    public object? SetData(object? data, SetDataOptions? options = null)
    {
        var replaced = DataReplacer.Replace(State.Data, data, Options);

        var manual = options?.Manual ?? false;

        Dispatch(state =>
        {
            var next = state with
            {
                Data = replaced,
                HasData = true,
                DataUpdateCount = state.DataUpdateCount + 1,
                DataUpdatedAt = options?.UpdatedAt ?? _scheduler.Now(),
                Error = null,
                IsInvalidated = false,
                Status = QueryStatus.Success,
            };

            return manual
                ? next
                : next with
                {
                    FetchStatus = FetchStatus.Idle,
                    FetchFailureCount = 0,
                    FetchFailureReason = null,
                };
        });

        return replaced;
    }

    /// <summary>Replaces the whole state, as restoring a dehydrated entry does.</summary>
    public void SetState(QueryState state)
    {
        ArgumentNullException.ThrowIfNull(state);
        Dispatch(_ => state);
    }

    /// <summary>
    /// Cancels the fetch in flight, if any, and waits for it to unwind. Reverting — the
    /// default — restores the state the query had before the fetch started.
    /// </summary>
    public Task CancelAsync(CancelOptions? options = null)
    {
        var promise = _retryer?.Promise;
        _retryer?.Cancel(options?.Revert ?? true, options?.Silent ?? false);

        if (promise is null)
        {
            return Task.CompletedTask;
        }

        // The caller wants to know when the query has settled, not why it failed.
        return promise.ContinueWith(
            static _ => { },
            CancellationToken.None,
            TaskContinuationOptions.ExecuteSynchronously,
            TaskScheduler.Default);
    }

    /// <summary>Throws the entry away: stops the timers and abandons any fetch in flight.</summary>
    internal void Destroy()
    {
        ClearGcTimeout();
        _retryer?.Cancel(revert: true, silent: true);
    }

    /// <summary>Returns the query to the state it was created with, discarding data and errors.</summary>
    public void Reset()
    {
        Destroy();
        SetState(InitialState);
    }

    /// <summary>
    /// Marks the data out of date without discarding it, so the next opportunity — an active
    /// observer, a remount, a window focus — refetches while the stale data stays on screen.
    /// </summary>
    public void Invalidate()
    {
        if (!State.IsInvalidated)
        {
            Dispatch(state => state with { IsInvalidated = true });
        }
    }

    internal void AddObserver(QueryObserverBase observer)
    {
        if (_observers.Contains(observer))
        {
            return;
        }

        _observers.Add(observer);

        // An observed query is never garbage: stop the collection timer that started when the
        // entry was created or when its last observer left.
        ClearGcTimeout();

        _cache.Notify(new QueryCacheNotifyEvent(QueryCacheNotifyEventType.ObserverAdded, this, observer));
    }

    internal void RemoveObserver(QueryObserverBase observer)
    {
        if (!_observers.Remove(observer))
        {
            return;
        }

        if (_observers.Count == 0 && _retryer is not null)
        {
            // A query function that took the cancellation token can be stopped outright;
            // one that ignored it would keep running anyway, so only its retries are stopped
            // and its result is still allowed to land in the cache.
            if (_abortSignalConsumed)
            {
                _retryer.Cancel(revert: true, silent: false);
            }
            else
            {
                _retryer.CancelRetry();
            }
        }

        if (_observers.Count == 0)
        {
            ScheduleGc();
        }

        _cache.Notify(new QueryCacheNotifyEvent(QueryCacheNotifyEventType.ObserverRemoved, this, observer));
    }

    internal void SetOptions(ResolvedQueryOptions options)
    {
        Options = options;
        UpdateGcTime(options.GcTime);
    }

    /// <summary>Refetches because the window regained focus, and resumes anything paused.</summary>
    internal void OnFocus()
    {
        var observer = _observers.FirstOrDefault(o => o.ShouldFetchOnWindowFocus());
        _ = observer?.RefetchCoreAsync(new RefetchOptions { CancelRefetch = false });

        _retryer?.Continue();
    }

    /// <summary>Refetches because connectivity returned, and resumes anything paused.</summary>
    internal void OnOnline()
    {
        var observer = _observers.FirstOrDefault(o => o.ShouldFetchOnReconnect());
        _ = observer?.RefetchCoreAsync(new RefetchOptions { CancelRefetch = false });

        _retryer?.Continue();
    }

    /// <summary>
    /// Runs the query function, deduplicating against a fetch that is already in flight.
    /// </summary>
    internal Task<object?> FetchAsync(ResolvedQueryOptions? options = null, FetchOptions? fetchOptions = null)
    {
        if (State.FetchStatus != FetchStatus.Idle)
        {
            if (State.HasData && fetchOptions?.CancelRefetch == true)
            {
                // Silently, because the caller is replacing this fetch rather than abandoning
                // the query: the state should show the new fetch, not a cancellation.
                _retryer?.Cancel(revert: true, silent: true);
            }
            else if (_retryer is not null)
            {
                // Deduplication: everyone asking for the same data while a fetch is running
                // waits on that one fetch.
                _retryer.ContinueRetry();
                return _retryer.Promise;
            }
        }

        if (options is not null)
        {
            SetOptions(options);
        }

        if (Options.QueryFn is null)
        {
            // A query created by SetQueryData or by prefetching has no function of its own;
            // borrow one from an observer so a later refetch can actually run.
            var withFn = _observers.FirstOrDefault(observer => observer.Options.QueryFn is not null);
            if (withFn is not null)
            {
                SetOptions(withFn.Options);
            }
        }

        _abortSignalConsumed = false;
        _revertState = State;

        var options2 = Options;
        Retryer? retryer = null;
        QueryFunctionContext? context = null;

        Task<object?> Fetch()
        {
            if (options2.QueryFn is null)
            {
                return Task.FromException<object?>(new MissingQueryFunctionException(QueryHash));
            }

            context ??= new QueryFunctionContext(
                Client,
                QueryKey,
                retryer!.Signal,
                options2.Meta,
                () => _abortSignalConsumed = true);

            return options2.QueryFn(context);
        }

        if (State.FetchStatus == FetchStatus.Idle || !Equals(State.FetchMeta, fetchOptions?.Meta))
        {
            var canFetch = options2.NetworkMode != NetworkMode.Online || Client.OnlineManager.IsOnline;
            Dispatch(state => state with
            {
                FetchFailureCount = 0,
                FetchFailureReason = null,
                FetchStatus = canFetch ? FetchStatus.Fetching : FetchStatus.Paused,
                FetchMeta = fetchOptions?.Meta,
                Error = state.HasData ? state.Error : null,
                Status = state.HasData ? state.Status : QueryStatus.Pending,
            });
        }

        retryer = new Retryer(new RetryerConfig
        {
            Fetch = Fetch,
            Scheduler = _scheduler,
            OnlineManager = Client.OnlineManager,
            NetworkMode = options2.NetworkMode,
            Retry = options2.Retry,
            RetryDelay = options2.RetryDelay,
            CanRun = static () => true,
            OnSuccess = data =>
            {
                SetData(data);
                ScheduleGc();
            },
            OnError = error =>
            {
                if (error is QueryCancelledException { Silent: true })
                {
                    ScheduleGc();
                    return;
                }

                Dispatch(state =>
                {
                    if (error is QueryCancelledException { Revert: true } && _revertState is { } reverted)
                    {
                        return reverted with { FetchStatus = FetchStatus.Idle };
                    }

                    return state with
                    {
                        Error = error,
                        ErrorUpdateCount = state.ErrorUpdateCount + 1,
                        ErrorUpdatedAt = _scheduler.Now(),
                        FetchFailureCount = state.FetchFailureCount + 1,
                        FetchFailureReason = error,
                        FetchStatus = FetchStatus.Idle,
                        Status = QueryStatus.Error,
                    };
                });

                ScheduleGc();
            },
            OnFail = (failureCount, error) => Dispatch(state => state with
            {
                FetchFailureCount = failureCount,
                FetchFailureReason = error,
            }),
            OnPause = () => Dispatch(state => state with { FetchStatus = FetchStatus.Paused }),
            OnContinue = () => Dispatch(state => state with { FetchStatus = FetchStatus.Fetching }),
        });

        _retryer = retryer;

        return retryer.Start();
    }

    private void Dispatch(Func<QueryState, QueryState> reduce)
    {
        State = reduce(State);

        foreach (var observer in _observers.ToArray())
        {
            observer.OnQueryUpdate();
        }

        _cache.Notify(new QueryCacheNotifyEvent(QueryCacheNotifyEventType.Updated, this, null));
    }

    /// <summary>
    /// Widens the collection window to the longest any interested party asked for, so one
    /// short-lived observer cannot shorten the lifetime another one is relying on.
    /// </summary>
    private void UpdateGcTime(TimeSpan gcTime)
    {
        _gcTime = _gcTime > gcTime ? _gcTime : gcTime;
    }

    private void ScheduleGc()
    {
        ClearGcTimeout();

        if (_observers.Count > 0)
        {
            return;
        }

        _gcTimer = _scheduler.Schedule(_gcTime, OptionalRemove);
    }

    private void ClearGcTimeout()
    {
        _gcTimer?.Dispose();
        _gcTimer = null;
    }

    private void OptionalRemove()
    {
        if (_observers.Count > 0)
        {
            return;
        }

        if (State.FetchStatus == FetchStatus.Idle)
        {
            _cache.Remove(this);
        }
        else
        {
            ScheduleGc();
        }
    }

    private static QueryState GetDefaultState(ResolvedQueryOptions options, QueryScheduler scheduler)
    {
        var hasInitialData = options.InitialData is not null;
        var data = hasInitialData ? options.InitialData!() : null;

        return new QueryState
        {
            Data = data,
            HasData = hasInitialData,
            DataUpdatedAt = hasInitialData ? options.InitialDataUpdatedAt ?? scheduler.Now() : 0,
            Status = hasInitialData ? QueryStatus.Success : QueryStatus.Pending,
            FetchStatus = FetchStatus.Idle,
        };
    }
}
