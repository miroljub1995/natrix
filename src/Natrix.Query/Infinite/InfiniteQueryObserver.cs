namespace Natrix.Query;

/// <summary>
/// The result of an infinite query: everything an ordinary result carries, plus what the list
/// can still be extended with.
/// </summary>
public sealed record InfiniteQueryObserverResult<TPage, TPageParam, TData> : QueryObserverResult<TData>
{
    internal InfiniteQueryObserverResult(QueryObserverResult<TData> result)
        : base(result)
    {
    }

    /// <summary>
    /// The accumulated pages as they are cached, before any projection — so a query that
    /// flattens its pages through <c>Select</c> can still reach them.
    /// </summary>
    public InfiniteData<TPage, TPageParam>? Pages { get; init; }

    /// <summary>Whether another page can be fetched forwards.</summary>
    public bool HasNextPage { get; init; }

    /// <summary>Whether another page can be fetched backwards.</summary>
    public bool HasPreviousPage { get; init; }

    /// <summary>Whether a "load more" is in flight, as opposed to a refetch of the whole list.</summary>
    public bool IsFetchingNextPage { get; init; }

    /// <summary>Whether a backwards "load more" is in flight.</summary>
    public bool IsFetchingPreviousPage { get; init; }
}

/// <summary>
/// Watches a query that accumulates pages, adding the page state and the two "load more"
/// operations. The counterpart of TanStack Query's <c>InfiniteQueryObserver</c>.
/// </summary>
public sealed class InfiniteQueryObserver<TPage, TPageParam, TData>
    : QueryObserver<InfiniteData<TPage, TPageParam>, TData>
{
    public InfiniteQueryObserver(
        QueryClient client,
        UseInfiniteQueryOptions<TPage, TPageParam, TData> options)
        : base(client, (options ?? throw new ArgumentNullException(nameof(options))).ToQueryOptions())
    {
    }

    /// <summary>The current result, with its page state.</summary>
    public new InfiniteQueryObserverResult<TPage, TPageParam, TData> CurrentResult =>
        (InfiniteQueryObserverResult<TPage, TPageParam, TData>)base.CurrentResult;

    /// <summary>Reconfigures the observer, as <c>SetOptions</c> does for an ordinary query.</summary>
    public void SetOptions(UseInfiniteQueryOptions<TPage, TPageParam, TData> options)
    {
        ArgumentNullException.ThrowIfNull(options);
        SetOptions(options.ToQueryOptions());
    }

    /// <summary>Fetches the next page and appends it to what is already there.</summary>
    public Task<InfiniteQueryObserverResult<TPage, TPageParam, TData>> FetchNextPageAsync() =>
        FetchMoreAsync(FetchDirection.Forward);

    /// <summary>Fetches the previous page and puts it in front of what is already there.</summary>
    public Task<InfiniteQueryObserverResult<TPage, TPageParam, TData>> FetchPreviousPageAsync() =>
        FetchMoreAsync(FetchDirection.Backward);

    protected override QueryObserverResult<TData> AugmentResult(QueryObserverResult<TData> result, Query query)
    {
        // Read through the behaviour rather than through fields of this class: the base
        // constructor builds a result before this type's own state exists, and the behaviour
        // travels with the options, which are set by then.
        var inspector = ResolvedOptions.Behavior as IInfinitePageInspector;
        var pages = query.State.Data as InfiniteData<TPage, TPageParam>;
        var direction = (query.State.FetchMeta as FetchMoreMeta)?.Direction;

        return new InfiniteQueryObserverResult<TPage, TPageParam, TData>(result)
        {
            Pages = pages,
            HasNextPage = inspector?.HasNextPage(pages) ?? false,
            HasPreviousPage = inspector?.HasPreviousPage(pages) ?? false,
            IsFetchingNextPage = result.IsFetching && direction == FetchDirection.Forward,
            IsFetchingPreviousPage = result.IsFetching && direction == FetchDirection.Backward,
        };
    }

    private async Task<InfiniteQueryObserverResult<TPage, TPageParam, TData>> FetchMoreAsync(
        FetchDirection direction)
    {
        await ExecuteFetchAsync(new FetchOptions
        {
            CancelRefetch = true,
            Meta = new FetchMoreMeta(direction),
        }).ConfigureAwait(true);

        UpdateResult();
        return CurrentResult;
    }
}
