namespace Natrix.Query;

/// <summary>
/// One snapshot of a mutation as its caller sees it — the counterpart of TanStack Query's
/// <c>MutationObserverResult</c>.
/// </summary>
public sealed record MutationObserverResult<TData, TVariables>
{
    /// <summary>What the last successful run returned.</summary>
    public TData? Data { get; init; }

    /// <summary>Whether <see cref="Data"/> holds a real value.</summary>
    public bool HasData { get; init; }

    /// <summary>The error the last run failed with.</summary>
    public Exception? Error { get; init; }

    /// <summary>The variables the last run was called with — useful for rendering what is in flight.</summary>
    public TVariables? Variables { get; init; }

    /// <summary>Whether <see cref="Variables"/> was set.</summary>
    public bool HasVariables { get; init; }

    /// <inheritdoc cref="MutationStatus" />
    public MutationStatus Status { get; init; } = MutationStatus.Idle;

    /// <summary>Whether the mutation is waiting for the connection to come back.</summary>
    public bool IsPaused { get; init; }

    /// <summary>How many attempts have failed.</summary>
    public int FailureCount { get; init; }

    /// <summary>The error behind the most recent failed attempt.</summary>
    public Exception? FailureReason { get; init; }

    /// <summary>When the current run started, in Unix milliseconds.</summary>
    public long SubmittedAt { get; init; }

    /// <summary>Never run, or reset.</summary>
    public bool IsIdle => Status == MutationStatus.Idle;

    /// <summary>Running right now — what disables a submit button.</summary>
    public bool IsPending => Status == MutationStatus.Pending;

    /// <summary>The last run succeeded.</summary>
    public bool IsSuccess => Status == MutationStatus.Success;

    /// <summary>The last run failed.</summary>
    public bool IsError => Status == MutationStatus.Error;
}

/// <summary>
/// Watches the mutation a caller most recently fired, and exposes it as a result. The
/// counterpart of TanStack Query's <c>MutationObserver</c>.
/// </summary>
public sealed class MutationObserver<TData, TVariables, TContext> : MutationObserverBase, IDisposable
{
    private readonly QueryClient _client;
    private readonly List<Action<MutationObserverResult<TData, TVariables>>> _listeners = [];

    private ResolvedMutationOptions _resolvedOptions;
    private Mutation? _currentMutation;
    private MutateOptions<TData, TVariables>? _mutateOptions;
    private MutationObserverResult<TData, TVariables> _currentResult = new();
    private MutationStatus _lastNotifiedStatus = MutationStatus.Idle;
    private bool _disposed;

    public MutationObserver(QueryClient client, UseMutationOptions<TData, TVariables, TContext> options)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(options);

        _client = client;
        _resolvedOptions = client.ResolveMutationOptions(options);
    }

    /// <summary>The most recently computed result.</summary>
    public MutationObserverResult<TData, TVariables> CurrentResult => _currentResult;

    /// <summary>The mutation currently being watched, if one was ever fired.</summary>
    public Mutation? CurrentMutation => _currentMutation;

    /// <summary>Whether anything is watching.</summary>
    public bool HasListeners => _listeners.Count > 0;

    /// <summary>Subscribes to result changes; dispose to unsubscribe.</summary>
    public IDisposable Subscribe(Action<MutationObserverResult<TData, TVariables>> listener)
    {
        ArgumentNullException.ThrowIfNull(listener);
        ObjectDisposedException.ThrowIf(_disposed, this);

        _listeners.Add(listener);
        return new Subscription(this, listener);
    }

    /// <summary>Reconfigures the observer. Takes effect from the next <c>Mutate</c> onwards.</summary>
    public void SetOptions(UseMutationOptions<TData, TVariables, TContext> options)
    {
        ArgumentNullException.ThrowIfNull(options);
        _resolvedOptions = _client.ResolveMutationOptions(options);
    }

    /// <summary>
    /// Fires the mutation and completes when it — and every callback it triggers — has
    /// finished. Failure surfaces as an exception, unlike <see cref="Mutate"/>.
    /// </summary>
    public async Task<TData> MutateAsync(TVariables variables, MutateOptions<TData, TVariables>? options = null)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);

        _mutateOptions = options;

        // Every call is its own mutation: the previous one keeps its own record, which is what
        // lets the cache count and resume mutations independently.
        _currentMutation?.RemoveObserver(this);

        var mutation = _client.MutationCache.Build(_client, _resolvedOptions);
        _currentMutation = mutation;
        mutation.AddObserver(this);

        var data = await mutation.ExecuteAsync(variables).ConfigureAwait(true);
        return (TData)data!;
    }

    /// <summary>
    /// Fires the mutation without waiting for it and without throwing — the form a click
    /// handler wants. The outcome shows up in the result, and in the per-call callbacks.
    /// </summary>
    public void Mutate(TVariables variables, MutateOptions<TData, TVariables>? options = null)
    {
        _ = MutateAsync(variables, options).ContinueWith(
            static task => _ = task.Exception,
            CancellationToken.None,
            TaskContinuationOptions.OnlyOnFaulted | TaskContinuationOptions.ExecuteSynchronously,
            TaskScheduler.Default);
    }

    /// <summary>Forgets the last run, returning the result to idle.</summary>
    public void Reset()
    {
        _currentMutation?.RemoveObserver(this);
        _currentMutation = null;
        _mutateOptions = null;
        UpdateResult();
    }

    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        _disposed = true;
        _listeners.Clear();
        _currentMutation?.RemoveObserver(this);
        _currentMutation = null;
    }

    internal override void OnMutationUpdate() => UpdateResult();

    private void UpdateResult()
    {
        var state = _currentMutation?.State;

        var next = state is null
            ? new MutationObserverResult<TData, TVariables>()
            : new MutationObserverResult<TData, TVariables>
            {
                Data = state.HasData ? (TData?)state.Data : default,
                HasData = state.HasData,
                Error = state.Error,
                Variables = state.HasVariables ? (TVariables?)state.Variables : default,
                HasVariables = state.HasVariables,
                Status = state.Status,
                IsPaused = state.IsPaused,
                FailureCount = state.FailureCount,
                FailureReason = state.FailureReason,
                SubmittedAt = state.SubmittedAt,
            };

        var previousStatus = _lastNotifiedStatus;

        if (next == _currentResult)
        {
            return;
        }

        _currentResult = next;
        _lastNotifiedStatus = next.Status;

        // The per-call callbacks fire on the transition, not on every tick, and only while
        // someone is still watching — a component that unmounted mid-flight does not get them.
        if (_mutateOptions is { } mutateOptions && HasListeners && next.HasVariables)
        {
            if (previousStatus != MutationStatus.Success && next.Status == MutationStatus.Success)
            {
                mutateOptions.OnSuccess?.Invoke(next.Data!, next.Variables!);
                mutateOptions.OnSettled?.Invoke(next.Data, null, next.Variables!);
            }
            else if (previousStatus != MutationStatus.Error && next.Status == MutationStatus.Error)
            {
                mutateOptions.OnError?.Invoke(next.Error!, next.Variables!);
                mutateOptions.OnSettled?.Invoke(default, next.Error, next.Variables!);
            }
        }

        foreach (var listener in _listeners.ToArray())
        {
            listener(next);
        }
    }

    private sealed class Subscription(
        MutationObserver<TData, TVariables, TContext> observer,
        Action<MutationObserverResult<TData, TVariables>> listener) : IDisposable
    {
        public void Dispose() => observer._listeners.Remove(listener);
    }
}
