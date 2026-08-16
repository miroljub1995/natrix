using Natrix.Signals;

namespace Natrix.Query;

/// <summary>
/// What <c>UseQuery</c> hands back: the query's result as signals, plus the imperative
/// handles. The counterpart of the object Vue Query's <c>useQuery</c> returns, where every
/// field is a ref.
/// </summary>
/// <remarks>
/// <para>
/// Each property is a separate signal derived from <see cref="Result"/>, so reading one binds
/// only to it: a component that renders <see cref="Data"/> is not re-run when
/// <see cref="FailureCount"/> ticks during a retry. That granularity is what makes Vue Query's
/// <c>notifyOnChangeProps</c> unnecessary here.
/// </para>
/// <para>
/// Signals are created on first access, so an unread property costs nothing.
/// </para>
/// </remarks>
public sealed class UseQueryResult<TData>
{
    private readonly IReadOnlySignal<QueryObserverResult<TData>> _result;
    private readonly Func<RefetchOptions?, Task<QueryObserverResult<TData>>> _refetch;
    private readonly Func<Task<QueryObserverResult<TData>>> _suspense;

    private IReadOnlySignal<TData?>? _data;
    private IReadOnlySignal<Exception?>? _error;
    private IReadOnlySignal<QueryStatus>? _status;
    private IReadOnlySignal<FetchStatus>? _fetchStatus;
    private IReadOnlySignal<bool>? _isPending;
    private IReadOnlySignal<bool>? _isSuccess;
    private IReadOnlySignal<bool>? _isError;
    private IReadOnlySignal<bool>? _isLoading;
    private IReadOnlySignal<bool>? _isFetching;
    private IReadOnlySignal<bool>? _isRefetching;
    private IReadOnlySignal<bool>? _isPaused;
    private IReadOnlySignal<bool>? _isStale;
    private IReadOnlySignal<bool>? _isPlaceholderData;
    private IReadOnlySignal<bool>? _isFetched;
    private IReadOnlySignal<bool>? _isFetchedAfterMount;
    private IReadOnlySignal<bool>? _isLoadingError;
    private IReadOnlySignal<bool>? _isRefetchError;
    private IReadOnlySignal<bool>? _isEnabled;
    private IReadOnlySignal<long>? _dataUpdatedAt;
    private IReadOnlySignal<long>? _errorUpdatedAt;
    private IReadOnlySignal<int>? _failureCount;
    private IReadOnlySignal<Exception?>? _failureReason;
    private IReadOnlySignal<int>? _errorUpdateCount;

    internal UseQueryResult(
        IReadOnlySignal<QueryObserverResult<TData>> result,
        Func<RefetchOptions?, Task<QueryObserverResult<TData>>> refetch,
        Func<Task<QueryObserverResult<TData>>> suspense)
    {
        _result = result;
        _refetch = refetch;
        _suspense = suspense;
    }

    /// <summary>The whole result, for code that wants every field at once.</summary>
    public IReadOnlySignal<QueryObserverResult<TData>> Result => _result;

    /// <summary>The data, or <c>default</c> while there is none.</summary>
    public IReadOnlySignal<TData?> Data => _data ??= new Computed<TData?>(() => _result.Value.Data);

    /// <summary>The error of the last failed attempt.</summary>
    public IReadOnlySignal<Exception?> Error => _error ??= new Computed<Exception?>(() => _result.Value.Error);

    /// <inheritdoc cref="QueryObserverResult{TData}.Status" />
    public IReadOnlySignal<QueryStatus> Status => _status ??= new Computed<QueryStatus>(() => _result.Value.Status);

    /// <inheritdoc cref="QueryObserverResult{TData}.FetchStatus" />
    public IReadOnlySignal<FetchStatus> FetchStatus =>
        _fetchStatus ??= new Computed<FetchStatus>(() => _result.Value.FetchStatus);

    /// <inheritdoc cref="QueryObserverResult{TData}.IsPending" />
    public IReadOnlySignal<bool> IsPending => _isPending ??= new Computed<bool>(() => _result.Value.IsPending);

    /// <inheritdoc cref="QueryObserverResult{TData}.IsSuccess" />
    public IReadOnlySignal<bool> IsSuccess => _isSuccess ??= new Computed<bool>(() => _result.Value.IsSuccess);

    /// <inheritdoc cref="QueryObserverResult{TData}.IsError" />
    public IReadOnlySignal<bool> IsError => _isError ??= new Computed<bool>(() => _result.Value.IsError);

    /// <inheritdoc cref="QueryObserverResult{TData}.IsLoading" />
    public IReadOnlySignal<bool> IsLoading => _isLoading ??= new Computed<bool>(() => _result.Value.IsLoading);

    /// <inheritdoc cref="QueryObserverResult{TData}.IsFetching" />
    public IReadOnlySignal<bool> IsFetching => _isFetching ??= new Computed<bool>(() => _result.Value.IsFetching);

    /// <inheritdoc cref="QueryObserverResult{TData}.IsRefetching" />
    public IReadOnlySignal<bool> IsRefetching => _isRefetching ??= new Computed<bool>(() => _result.Value.IsRefetching);

    /// <inheritdoc cref="QueryObserverResult{TData}.IsPaused" />
    public IReadOnlySignal<bool> IsPaused => _isPaused ??= new Computed<bool>(() => _result.Value.IsPaused);

    /// <inheritdoc cref="QueryObserverResult{TData}.IsStale" />
    public IReadOnlySignal<bool> IsStale => _isStale ??= new Computed<bool>(() => _result.Value.IsStale);

    /// <inheritdoc cref="QueryObserverResult{TData}.IsPlaceholderData" />
    public IReadOnlySignal<bool> IsPlaceholderData =>
        _isPlaceholderData ??= new Computed<bool>(() => _result.Value.IsPlaceholderData);

    /// <inheritdoc cref="QueryObserverResult{TData}.IsFetched" />
    public IReadOnlySignal<bool> IsFetched => _isFetched ??= new Computed<bool>(() => _result.Value.IsFetched);

    /// <inheritdoc cref="QueryObserverResult{TData}.IsFetchedAfterMount" />
    public IReadOnlySignal<bool> IsFetchedAfterMount =>
        _isFetchedAfterMount ??= new Computed<bool>(() => _result.Value.IsFetchedAfterMount);

    /// <inheritdoc cref="QueryObserverResult{TData}.IsLoadingError" />
    public IReadOnlySignal<bool> IsLoadingError =>
        _isLoadingError ??= new Computed<bool>(() => _result.Value.IsLoadingError);

    /// <inheritdoc cref="QueryObserverResult{TData}.IsRefetchError" />
    public IReadOnlySignal<bool> IsRefetchError =>
        _isRefetchError ??= new Computed<bool>(() => _result.Value.IsRefetchError);

    /// <inheritdoc cref="QueryObserverResult{TData}.IsEnabled" />
    public IReadOnlySignal<bool> IsEnabled => _isEnabled ??= new Computed<bool>(() => _result.Value.IsEnabled);

    /// <inheritdoc cref="QueryObserverResult{TData}.DataUpdatedAt" />
    public IReadOnlySignal<long> DataUpdatedAt =>
        _dataUpdatedAt ??= new Computed<long>(() => _result.Value.DataUpdatedAt);

    /// <inheritdoc cref="QueryObserverResult{TData}.ErrorUpdatedAt" />
    public IReadOnlySignal<long> ErrorUpdatedAt =>
        _errorUpdatedAt ??= new Computed<long>(() => _result.Value.ErrorUpdatedAt);

    /// <inheritdoc cref="QueryObserverResult{TData}.FailureCount" />
    public IReadOnlySignal<int> FailureCount => _failureCount ??= new Computed<int>(() => _result.Value.FailureCount);

    /// <inheritdoc cref="QueryObserverResult{TData}.FailureReason" />
    public IReadOnlySignal<Exception?> FailureReason =>
        _failureReason ??= new Computed<Exception?>(() => _result.Value.FailureReason);

    /// <inheritdoc cref="QueryObserverResult{TData}.ErrorUpdateCount" />
    public IReadOnlySignal<int> ErrorUpdateCount =>
        _errorUpdateCount ??= new Computed<int>(() => _result.Value.ErrorUpdateCount);

    /// <summary>
    /// Refetches regardless of freshness and completes when the result is in. What a "reload"
    /// button calls; ordinary invalidation should go through
    /// <see cref="QueryClient.InvalidateQueriesAsync"/> instead.
    /// </summary>
    public Task<QueryObserverResult<TData>> RefetchAsync(RefetchOptions? options = null) => _refetch(options);

    /// <summary>
    /// Completes once the query has data, fetching it if the cache cannot answer — the hook
    /// server rendering uses to wait for a component's data.
    /// </summary>
    public Task<QueryObserverResult<TData>> SuspenseAsync() => _suspense();
}
