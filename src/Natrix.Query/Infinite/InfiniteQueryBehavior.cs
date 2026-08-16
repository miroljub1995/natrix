namespace Natrix.Query;

/// <summary>
/// Lets a result be asked about pages without knowing the page types — how the observer reports
/// <c>HasNextPage</c> for a query whose page shape it was never told about.
/// </summary>
internal interface IInfinitePageInspector
{
    bool HasNextPage(object? data);

    bool HasPreviousPage(object? data);
}

/// <summary>
/// Turns one fetch into a sequence of page requests — the counterpart of TanStack Query's
/// <c>infiniteQueryBehavior</c>.
/// </summary>
/// <remarks>
/// Everything around the fetch is untouched: the pages land in one cache entry under one key,
/// share its deduplication and retrying, and a refetch replays every page it already had so
/// the list stays consistent rather than resetting to one page.
/// </remarks>
internal sealed class InfiniteQueryBehavior<TPage, TPageParam>(
    Func<InfiniteQueryFunctionContext<TPageParam>, Task<TPage>> queryFn,
    TPageParam initialPageParam,
    PageParamResolver<TPage, TPageParam> getNextPageParam,
    PageParamResolver<TPage, TPageParam>? getPreviousPageParam,
    int? maxPages) : IQueryBehavior, IInfinitePageInspector
{
    public void OnFetch(QueryBehaviorContext context)
    {
        context.FetchFn = () => FetchPagesAsync(context);
    }

    public bool HasNextPage(object? data) =>
        data is InfiniteData<TPage, TPageParam> pages && ResolveNextParam(pages).HasValue;

    public bool HasPreviousPage(object? data) =>
        getPreviousPageParam is not null
        && data is InfiniteData<TPage, TPageParam> pages
        && ResolvePreviousParam(pages).HasValue;

    private async Task<object?> FetchPagesAsync(QueryBehaviorContext context)
    {
        var existing = context.State.Data as InfiniteData<TPage, TPageParam> ?? InfiniteData<TPage, TPageParam>.Empty;
        var direction = (context.FetchOptions?.Meta as FetchMoreMeta)?.Direction;

        async Task<InfiniteData<TPage, TPageParam>> FetchPageAsync(
            InfiniteData<TPage, TPageParam> data,
            NextPageParam<TPageParam> pageParam,
            bool previous)
        {
            // No cursor and pages already in hand means the list has reached its end; the
            // accumulated data is the answer.
            if (!pageParam.HasValue && data.Pages.Count > 0)
            {
                return data;
            }

            var pageContext = new InfiniteQueryFunctionContext<TPageParam>(
                context.FunctionContext,
                pageParam.Value,
                previous ? FetchDirection.Backward : FetchDirection.Forward);

            var page = await queryFn(pageContext).ConfigureAwait(true);

            return previous
                ? data.Prepend(page, pageParam.Value, maxPages)
                : data.Append(page, pageParam.Value, maxPages);
        }

        if (direction is { } fetchMore && existing.Pages.Count > 0)
        {
            var previous = fetchMore == FetchDirection.Backward;
            var pageParam = previous ? ResolvePreviousParam(existing) : ResolveNextParam(existing);

            return await FetchPageAsync(existing, pageParam, previous).ConfigureAwait(true);
        }

        // Not a "load more": refetch every page the query already had, in order, so the whole
        // list is refreshed rather than collapsing back to its first page.
        var result = InfiniteData<TPage, TPageParam>.Empty;
        var remainingPages = existing.Pages.Count;
        var currentPage = 0;

        do
        {
            var pageParam = currentPage == 0
                ? existing.PageParams.Count > 0
                    ? NextPageParam<TPageParam>.From(existing.PageParams[0])
                    : NextPageParam<TPageParam>.From(initialPageParam)
                : ResolveNextParam(result);

            if (currentPage > 0 && !pageParam.HasValue)
            {
                break;
            }

            result = await FetchPageAsync(result, pageParam, false).ConfigureAwait(true);
            currentPage++;
        }
        while (currentPage < remainingPages);

        return result;
    }

    private NextPageParam<TPageParam> ResolveNextParam(InfiniteData<TPage, TPageParam> data)
    {
        if (data.Pages.Count == 0)
        {
            return NextPageParam<TPageParam>.None;
        }

        var lastIndex = data.Pages.Count - 1;
        return getNextPageParam(
            data.Pages[lastIndex],
            data.Pages,
            data.PageParams[lastIndex],
            data.PageParams);
    }

    private NextPageParam<TPageParam> ResolvePreviousParam(InfiniteData<TPage, TPageParam> data)
    {
        if (getPreviousPageParam is null || data.Pages.Count == 0)
        {
            return NextPageParam<TPageParam>.None;
        }

        return getPreviousPageParam(data.Pages[0], data.Pages, data.PageParams[0], data.PageParams);
    }
}
