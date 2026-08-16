namespace Natrix.Query;

/// <summary>
/// One run of a mutation: its state machine, its callbacks, and the retryer performing it.
/// The counterpart of TanStack Query's <c>Mutation</c>.
/// </summary>
/// <remarks>
/// Unlike a query, a mutation is not addressed by key and is not shared: each
/// <c>Mutate</c> call builds a new one. What the cache holds is the record of what happened,
/// which is what makes an offline mutation resumable and what <c>IsMutating</c> counts.
/// </remarks>
public sealed class Mutation
{
    private readonly MutationCache _cache;
    private readonly QueryScheduler _scheduler;
    private readonly List<MutationObserverBase> _observers = [];

    private Retryer? _retryer;
    private IDisposable? _gcTimer;

    internal Mutation(
        MutationCache cache,
        QueryClient client,
        QueryScheduler scheduler,
        ResolvedMutationOptions options,
        MutationState? state)
    {
        _cache = cache;
        _scheduler = scheduler;
        Client = client;
        Options = options;
        State = state ?? new MutationState();
        MutationId = cache.NextMutationId();

        ScheduleGc();
    }

    /// <summary>The client this mutation belongs to.</summary>
    public QueryClient Client { get; }

    /// <summary>A number unique within the cache, used to scope mutations that have no scope.</summary>
    public int MutationId { get; }

    /// <summary>The mutation's options.</summary>
    public ResolvedMutationOptions Options { get; }

    /// <summary>The current state.</summary>
    public MutationState State { get; private set; }

    /// <summary>Arbitrary metadata from the <c>Meta</c> option.</summary>
    public IReadOnlyDictionary<string, object?>? Meta => Options.Meta;

    /// <summary>How many observers are watching this mutation.</summary>
    public int ObserversCount => _observers.Count;

    /// <summary>The scope this mutation serialises against; its own id when it has no scope.</summary>
    internal string ScopeId => Options.Scope?.Id ?? $"#{MutationId}";

    internal void AddObserver(MutationObserverBase observer)
    {
        if (_observers.Contains(observer))
        {
            return;
        }

        _observers.Add(observer);
        ClearGcTimeout();

        _cache.Notify(new MutationCacheNotifyEvent(MutationCacheNotifyEventType.ObserverAdded, this));
    }

    internal void RemoveObserver(MutationObserverBase observer)
    {
        if (!_observers.Remove(observer))
        {
            return;
        }

        ScheduleGc();
        _cache.Notify(new MutationCacheNotifyEvent(MutationCacheNotifyEventType.ObserverRemoved, this));
    }

    /// <summary>
    /// Runs the mutation: <c>OnMutate</c>, the mutation function with its retries, then the
    /// success or error callbacks and <c>OnSettled</c>. The returned task completes only once
    /// every callback has, so an invalidation awaited in <c>OnSettled</c> is finished before
    /// the caller continues.
    /// </summary>
    public async Task<object?> ExecuteAsync(object? variables)
    {
        // A restored mutation (one resumed after being paused) is already pending and has
        // already run OnMutate; re-running it would duplicate its optimistic update.
        var restored = State.Status == MutationStatus.Pending;

        var abort = new CancellationTokenSource();
        var retryer = new Retryer(new RetryerConfig
        {
            Fetch = () => Options.MutationFn(variables),
            Abort = abort,
            Scheduler = _scheduler,
            OnlineManager = Client.OnlineManager,
            NetworkMode = Options.NetworkMode,
            Retry = Options.Retry,
            RetryDelay = Options.RetryDelay,
            CanRun = () => _cache.CanRun(this),
            OnSuccess = static _ => { },
            OnError = static _ => { },
            OnFail = (failureCount, error) => Dispatch(state => state with
            {
                FailureCount = failureCount,
                FailureReason = error,
                IsPaused = false,
            }),
            OnPause = () => Dispatch(state => state with { IsPaused = true }),
            OnContinue = () => Dispatch(state => state with { IsPaused = false }),
        });

        _retryer = retryer;

        try
        {
            if (!restored)
            {
                Dispatch(state => state with
                {
                    Status = MutationStatus.Pending,
                    Variables = variables,
                    HasVariables = true,
                    IsPaused = !retryer.CanStart(),
                    SubmittedAt = _scheduler.Now(),
                    FailureCount = 0,
                    FailureReason = null,
                    Error = null,
                });

                if (Options.OnMutate is not null)
                {
                    var context = await Options.OnMutate(variables).ConfigureAwait(true);

                    if (!Equals(context, State.Context))
                    {
                        Dispatch(state => state with { Context = context });
                    }
                }
            }

            var data = await retryer.Start().ConfigureAwait(true);

            if (Options.OnSuccess is not null)
            {
                await Options.OnSuccess(data, variables, State.Context).ConfigureAwait(true);
            }

            if (Options.OnSettled is not null)
            {
                await Options.OnSettled(data, null, variables, State.Context).ConfigureAwait(true);
            }

            Dispatch(state => state with
            {
                Status = MutationStatus.Success,
                Data = data,
                HasData = true,
                Error = null,
                IsPaused = false,
            });

            return data;
        }
        catch (Exception error)
        {
            try
            {
                if (Options.OnError is not null)
                {
                    await Options.OnError(error, variables, State.Context).ConfigureAwait(true);
                }

                if (Options.OnSettled is not null)
                {
                    await Options.OnSettled(null, error, variables, State.Context).ConfigureAwait(true);
                }

                throw;
            }
            finally
            {
                Dispatch(state => state with
                {
                    Status = MutationStatus.Error,
                    Data = null,
                    HasData = false,
                    Error = error,
                    FailureCount = state.FailureCount + 1,
                    FailureReason = error,
                    IsPaused = false,
                });
            }
        }
        finally
        {
            // Whatever else was waiting on this scope may now go.
            _cache.RunNext(this);
            ScheduleGc();
        }
    }

    /// <summary>
    /// Resumes a paused mutation — or starts one that was restored from a previous session and
    /// never got to run.
    /// </summary>
    public Task ContinueAsync()
    {
        if (_retryer is { IsResolved: false })
        {
            _retryer.Continue();
            return Task.CompletedTask;
        }

        return ExecuteAsync(State.Variables);
    }

    /// <summary>Returns the mutation to its initial state.</summary>
    public void Reset() => Dispatch(_ => new MutationState());

    /// <summary>Replaces the whole state, as restoring a persisted mutation does.</summary>
    public void SetState(MutationState state)
    {
        ArgumentNullException.ThrowIfNull(state);
        Dispatch(_ => state);
    }

    internal void Destroy() => ClearGcTimeout();

    private void Dispatch(Func<MutationState, MutationState> reduce)
    {
        State = reduce(State);

        foreach (var observer in _observers.ToArray())
        {
            observer.OnMutationUpdate();
        }

        _cache.Notify(new MutationCacheNotifyEvent(MutationCacheNotifyEventType.Updated, this));
    }

    private void ScheduleGc()
    {
        ClearGcTimeout();

        if (_observers.Count > 0)
        {
            return;
        }

        _gcTimer = _scheduler.Schedule(Options.GcTime, () =>
        {
            if (_observers.Count == 0 && State.Status != MutationStatus.Pending)
            {
                _cache.Remove(this);
            }
        });
    }

    private void ClearGcTimeout()
    {
        _gcTimer?.Dispose();
        _gcTimer = null;
    }
}

/// <summary>What a <see cref="Mutation"/> knows about the things watching it.</summary>
public abstract class MutationObserverBase
{
    /// <summary>Called after every state transition.</summary>
    internal abstract void OnMutationUpdate();
}
