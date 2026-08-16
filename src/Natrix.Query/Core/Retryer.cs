namespace Natrix.Query;

/// <summary>
/// Runs one fetch attempt and everything around it: retry with backoff, pausing while
/// offline, and cancellation. The counterpart of TanStack Query's <c>createRetryer</c>.
/// </summary>
/// <remarks>
/// The promise a retryer hands out is deliberately not the same task as the query function's.
/// Cancelling settles the promise immediately, whether or not the underlying request notices
/// the abort — callers waiting on a cancelled fetch are released at once, exactly as they are
/// in TanStack Query.
/// </remarks>
internal sealed class Retryer
{
    private readonly RetryerConfig _config;
    private readonly TaskCompletionSource<object?> _completion =
        new(TaskCreationOptions.RunContinuationsAsynchronously);

    private readonly CancellationTokenSource _abort = new();
    private TaskCompletionSource? _pause;
    private int _failureCount;
    private bool _isRetryCancelled;
    private bool _isResolved;

    public Retryer(RetryerConfig config)
    {
        _config = config;

        // Nobody is required to await a background refetch, and a cancelled or failed one
        // would otherwise surface as an unobserved task exception at finalization.
        _ = _completion.Task.ContinueWith(
            static t => _ = t.Exception,
            CancellationToken.None,
            TaskContinuationOptions.OnlyOnFaulted | TaskContinuationOptions.ExecuteSynchronously,
            TaskScheduler.Default);
    }

    /// <summary>The token handed to the query function, aborted when the fetch is cancelled.</summary>
    public CancellationToken Signal => _abort.Token;

    /// <summary>Settles when the fetch succeeds, gives up, or is cancelled.</summary>
    public Task<object?> Promise => _completion.Task;

    /// <summary>Whether this retryer has already settled.</summary>
    public bool IsResolved => _isResolved;

    /// <summary>Starts the attempt loop and returns the promise for its outcome.</summary>
    public Task<object?> Start()
    {
        _ = RunLoopAsync();
        return _completion.Task;
    }

    /// <summary>
    /// Settles the promise as cancelled and aborts the in-flight request. A silent
    /// cancellation leaves the query's state untouched; a reverting one rolls it back.
    /// </summary>
    public void Cancel(bool revert, bool silent)
    {
        if (_isResolved)
        {
            return;
        }

        Reject(new QueryCancelledException(revert, silent));
        _abort.Cancel();
    }

    /// <summary>Stops retrying after the current attempt, without cancelling it.</summary>
    public void CancelRetry() => _isRetryCancelled = true;

    /// <summary>Allows retrying again after <see cref="CancelRetry"/>.</summary>
    public void ContinueRetry() => _isRetryCancelled = false;

    /// <summary>Resumes a fetch that paused because the app was offline.</summary>
    public void Continue() => _pause?.TrySetResult();

    private void Resolve(object? value)
    {
        if (_isResolved)
        {
            return;
        }

        _isResolved = true;

        // The query records the data before anyone awaiting the fetch is released, so an
        // awaited refetch never observes a state that is one step behind its own result.
        _config.OnSuccess(value);
        _pause?.TrySetResult();
        _completion.TrySetResult(value);
    }

    private void Reject(Exception error)
    {
        if (_isResolved)
        {
            return;
        }

        _isResolved = true;

        _config.OnError(error);
        _pause?.TrySetResult();
        _completion.TrySetException(error);
    }

    private async Task RunLoopAsync()
    {
        try
        {
            if (!CanStart())
            {
                await PauseAsync().ConfigureAwait(true);
            }

            while (!_isResolved)
            {
                try
                {
                    var data = await _config.Fetch().ConfigureAwait(true);
                    Resolve(data);
                    return;
                }
                catch (Exception error)
                {
                    if (_isResolved)
                    {
                        // Already cancelled: whatever the abandoned request did is irrelevant.
                        return;
                    }

                    // The retry predicate sees how many attempts have already failed, not
                    // counting this one, so `Retry = 3` means three retries after the first
                    // attempt — four requests in total.
                    var shouldRetry = !_isRetryCancelled
                        && error is not QueryCancelledException
                        && !_abort.IsCancellationRequested
                        && _config.Retry.ShouldRetry(_failureCount, error);

                    if (!shouldRetry)
                    {
                        // The final failure is counted by whoever records the error, so that
                        // a query's failure count still includes the attempt that gave up.
                        Reject(error);
                        return;
                    }

                    _failureCount++;
                    _config.OnFail(_failureCount, error);

                    var delay = _config.RetryDelay(_failureCount, error);
                    if (QueryScheduler.IsValidTimeout(delay) && delay > TimeSpan.Zero)
                    {
                        await Task.Delay(delay, _config.Scheduler.TimeProvider).ConfigureAwait(true);
                    }

                    if (!_isResolved && !CanContinue())
                    {
                        await PauseAsync().ConfigureAwait(true);
                    }
                }
            }
        }
        catch (Exception error)
        {
            // The loop itself faulted (a broken retry predicate or delay callback); surface it
            // rather than leaving the promise hanging forever.
            Reject(error);
        }
    }

    private async Task PauseAsync()
    {
        _pause = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
        _config.OnPause();

        await _pause.Task.ConfigureAwait(true);

        _pause = null;

        if (!_isResolved)
        {
            _config.OnContinue();
        }
    }

    /// <summary>
    /// Whether the first attempt may run. Only <see cref="NetworkMode.Online"/> holds the
    /// very first request back; <see cref="NetworkMode.OfflineFirst"/> exists precisely to
    /// let it through.
    /// </summary>
    private bool CanStart() =>
        _config.CanRun() && (_config.NetworkMode != NetworkMode.Online || _config.OnlineManager.IsOnline);

    /// <summary>
    /// Whether a retry may run. Here <see cref="NetworkMode.OfflineFirst"/> does wait for the
    /// connection: its point is one attempt against an offline-capable layer, not an endless
    /// retry loop against a network that is not there.
    /// </summary>
    private bool CanContinue() =>
        _config.CanRun() && (_config.NetworkMode == NetworkMode.Always || _config.OnlineManager.IsOnline);
}

/// <summary>Everything a <see cref="Retryer"/> needs to run and report an attempt.</summary>
internal sealed class RetryerConfig
{
    public required Func<Task<object?>> Fetch { get; init; }

    public required QueryScheduler Scheduler { get; init; }

    public required OnlineManager OnlineManager { get; init; }

    public required NetworkMode NetworkMode { get; init; }

    public required RetryOption Retry { get; init; }

    public required Func<int, Exception, TimeSpan> RetryDelay { get; init; }

    /// <summary>Whether the query still wants this fetch at all (it may have lost every observer).</summary>
    public required Func<bool> CanRun { get; init; }

    public required Action<object?> OnSuccess { get; init; }

    public required Action<Exception> OnError { get; init; }

    public required Action<int, Exception> OnFail { get; init; }

    public required Action OnPause { get; init; }

    public required Action OnContinue { get; init; }
}
