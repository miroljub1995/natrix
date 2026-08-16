using Natrix.Signals;

namespace Natrix.Query;

/// <summary>
/// What <c>UseInfiniteQuery</c> hands back: an ordinary query result plus the page state and
/// the two "load more" operations, all as signals.
/// </summary>
public sealed class UseInfiniteQueryResult<TPage, TPageParam, TData> : UseQueryResult<TData>
{
    private readonly Func<Task<InfiniteQueryObserverResult<TPage, TPageParam, TData>>> _fetchNextPage;
    private readonly Func<Task<InfiniteQueryObserverResult<TPage, TPageParam, TData>>> _fetchPreviousPage;

    private IReadOnlySignal<InfiniteData<TPage, TPageParam>?>? _pages;
    private IReadOnlySignal<bool>? _hasNextPage;
    private IReadOnlySignal<bool>? _hasPreviousPage;
    private IReadOnlySignal<bool>? _isFetchingNextPage;
    private IReadOnlySignal<bool>? _isFetchingPreviousPage;

    internal UseInfiniteQueryResult(
        IReadOnlySignal<QueryObserverResult<TData>> result,
        Func<RefetchOptions?, Task<QueryObserverResult<TData>>> refetch,
        Func<Task<QueryObserverResult<TData>>> suspense,
        Func<Task<InfiniteQueryObserverResult<TPage, TPageParam, TData>>> fetchNextPage,
        Func<Task<InfiniteQueryObserverResult<TPage, TPageParam, TData>>> fetchPreviousPage)
        : base(result, refetch, suspense)
    {
        _fetchNextPage = fetchNextPage;
        _fetchPreviousPage = fetchPreviousPage;
    }

    /// <summary>The accumulated pages as cached, before any projection.</summary>
    public IReadOnlySignal<InfiniteData<TPage, TPageParam>?> Pages =>
        _pages ??= new Computed<InfiniteData<TPage, TPageParam>?>(() => Current.Pages);

    /// <inheritdoc cref="InfiniteQueryObserverResult{TPage, TPageParam, TData}.HasNextPage" />
    public IReadOnlySignal<bool> HasNextPage => _hasNextPage ??= new Computed<bool>(() => Current.HasNextPage);

    /// <inheritdoc cref="InfiniteQueryObserverResult{TPage, TPageParam, TData}.HasPreviousPage" />
    public IReadOnlySignal<bool> HasPreviousPage =>
        _hasPreviousPage ??= new Computed<bool>(() => Current.HasPreviousPage);

    /// <inheritdoc cref="InfiniteQueryObserverResult{TPage, TPageParam, TData}.IsFetchingNextPage" />
    public IReadOnlySignal<bool> IsFetchingNextPage =>
        _isFetchingNextPage ??= new Computed<bool>(() => Current.IsFetchingNextPage);

    /// <inheritdoc cref="InfiniteQueryObserverResult{TPage, TPageParam, TData}.IsFetchingPreviousPage" />
    public IReadOnlySignal<bool> IsFetchingPreviousPage =>
        _isFetchingPreviousPage ??= new Computed<bool>(() => Current.IsFetchingPreviousPage);

    /// <summary>Fetches the next page. Safe to call when there is none — it is then a no-op.</summary>
    public Task<InfiniteQueryObserverResult<TPage, TPageParam, TData>> FetchNextPageAsync() => _fetchNextPage();

    /// <summary>Fetches the previous page.</summary>
    public Task<InfiniteQueryObserverResult<TPage, TPageParam, TData>> FetchPreviousPageAsync() =>
        _fetchPreviousPage();

    private InfiniteQueryObserverResult<TPage, TPageParam, TData> Current =>
        (InfiniteQueryObserverResult<TPage, TPageParam, TData>)Result.Value;
}
