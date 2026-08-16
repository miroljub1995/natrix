using Natrix.Signals;

namespace Natrix.Query;

/// <summary>
/// What <c>UseMutation</c> hands back: the mutation's state as signals, plus the two ways to
/// fire it. The counterpart of the object Vue Query's <c>useMutation</c> returns.
/// </summary>
public sealed class UseMutationResult<TData, TVariables>
{
    private readonly IReadOnlySignal<MutationObserverResult<TData, TVariables>> _result;
    private readonly Action<TVariables, MutateOptions<TData, TVariables>?> _mutate;
    private readonly Func<TVariables, MutateOptions<TData, TVariables>?, Task<TData>> _mutateAsync;
    private readonly Action _reset;

    private IReadOnlySignal<TData?>? _data;
    private IReadOnlySignal<Exception?>? _error;
    private IReadOnlySignal<TVariables?>? _variables;
    private IReadOnlySignal<MutationStatus>? _status;
    private IReadOnlySignal<bool>? _isIdle;
    private IReadOnlySignal<bool>? _isPending;
    private IReadOnlySignal<bool>? _isSuccess;
    private IReadOnlySignal<bool>? _isError;
    private IReadOnlySignal<bool>? _isPaused;
    private IReadOnlySignal<int>? _failureCount;
    private IReadOnlySignal<Exception?>? _failureReason;
    private IReadOnlySignal<long>? _submittedAt;

    internal UseMutationResult(
        IReadOnlySignal<MutationObserverResult<TData, TVariables>> result,
        Action<TVariables, MutateOptions<TData, TVariables>?> mutate,
        Func<TVariables, MutateOptions<TData, TVariables>?, Task<TData>> mutateAsync,
        Action reset)
    {
        _result = result;
        _mutate = mutate;
        _mutateAsync = mutateAsync;
        _reset = reset;
    }

    /// <summary>The whole result, for code that wants every field at once.</summary>
    public IReadOnlySignal<MutationObserverResult<TData, TVariables>> Result => _result;

    /// <inheritdoc cref="MutationObserverResult{TData, TVariables}.Data" />
    public IReadOnlySignal<TData?> Data => _data ??= new Computed<TData?>(() => _result.Value.Data);

    /// <inheritdoc cref="MutationObserverResult{TData, TVariables}.Error" />
    public IReadOnlySignal<Exception?> Error => _error ??= new Computed<Exception?>(() => _result.Value.Error);

    /// <inheritdoc cref="MutationObserverResult{TData, TVariables}.Variables" />
    public IReadOnlySignal<TVariables?> Variables =>
        _variables ??= new Computed<TVariables?>(() => _result.Value.Variables);

    /// <inheritdoc cref="MutationObserverResult{TData, TVariables}.Status" />
    public IReadOnlySignal<MutationStatus> Status =>
        _status ??= new Computed<MutationStatus>(() => _result.Value.Status);

    /// <inheritdoc cref="MutationObserverResult{TData, TVariables}.IsIdle" />
    public IReadOnlySignal<bool> IsIdle => _isIdle ??= new Computed<bool>(() => _result.Value.IsIdle);

    /// <inheritdoc cref="MutationObserverResult{TData, TVariables}.IsPending" />
    public IReadOnlySignal<bool> IsPending => _isPending ??= new Computed<bool>(() => _result.Value.IsPending);

    /// <inheritdoc cref="MutationObserverResult{TData, TVariables}.IsSuccess" />
    public IReadOnlySignal<bool> IsSuccess => _isSuccess ??= new Computed<bool>(() => _result.Value.IsSuccess);

    /// <inheritdoc cref="MutationObserverResult{TData, TVariables}.IsError" />
    public IReadOnlySignal<bool> IsError => _isError ??= new Computed<bool>(() => _result.Value.IsError);

    /// <inheritdoc cref="MutationObserverResult{TData, TVariables}.IsPaused" />
    public IReadOnlySignal<bool> IsPaused => _isPaused ??= new Computed<bool>(() => _result.Value.IsPaused);

    /// <inheritdoc cref="MutationObserverResult{TData, TVariables}.FailureCount" />
    public IReadOnlySignal<int> FailureCount => _failureCount ??= new Computed<int>(() => _result.Value.FailureCount);

    /// <inheritdoc cref="MutationObserverResult{TData, TVariables}.FailureReason" />
    public IReadOnlySignal<Exception?> FailureReason =>
        _failureReason ??= new Computed<Exception?>(() => _result.Value.FailureReason);

    /// <inheritdoc cref="MutationObserverResult{TData, TVariables}.SubmittedAt" />
    public IReadOnlySignal<long> SubmittedAt => _submittedAt ??= new Computed<long>(() => _result.Value.SubmittedAt);

    /// <summary>
    /// Fires the mutation without waiting and without throwing — the form an event handler
    /// wants. The outcome arrives through the signals and through <paramref name="options"/>.
    /// </summary>
    public void Mutate(TVariables variables, MutateOptions<TData, TVariables>? options = null) =>
        _mutate(variables, options);

    /// <summary>
    /// Fires the mutation and completes when it — and every callback it triggers — has
    /// finished. Failure surfaces as an exception.
    /// </summary>
    public Task<TData> MutateAsync(TVariables variables, MutateOptions<TData, TVariables>? options = null) =>
        _mutateAsync(variables, options);

    /// <summary>Forgets the last run, returning the result to idle.</summary>
    public void Reset() => _reset();
}
