namespace Natrix.Query;

/// <summary>
/// Derives the cursor for the next (or previous) page from what has been fetched so far.
/// Returning <see cref="NextPageParam{TPageParam}.None"/> means there is no further page,
/// which is what <c>HasNextPage</c> reports.
/// </summary>
/// <param name="lastPage">The page at the end being extended.</param>
/// <param name="allPages">Every page fetched so far.</param>
/// <param name="lastPageParam">The cursor <paramref name="lastPage"/> was fetched with.</param>
/// <param name="allPageParams">Every cursor used so far.</param>
public delegate NextPageParam<TPageParam> PageParamResolver<TPage, TPageParam>(
    TPage lastPage,
    IReadOnlyList<TPage> allPages,
    TPageParam lastPageParam,
    IReadOnlyList<TPageParam> allPageParams);

/// <summary>
/// Options for a query that accumulates pages — the counterpart of TanStack Query's
/// <c>UseInfiniteQueryOptions</c>.
/// </summary>
/// <typeparam name="TPage">What one call of the page function returns.</typeparam>
/// <typeparam name="TPageParam">The cursor type.</typeparam>
/// <typeparam name="TData">What the component observes, after <see cref="Select"/>.</typeparam>
/// <example>
/// <code>
/// var projects = UseInfiniteQuery(new UseInfiniteQueryOptions&lt;ProjectPage, int&gt;
/// {
///     QueryKey = ["projects"],
///     InitialPageParam = 0,
///     QueryFn = ctx => api.GetProjectsAsync(ctx.PageParam, ctx.Signal),
///     GetNextPageParam = (lastPage, _, _, _) => lastPage.NextCursor is { } next
///         ? next
///         : NextPageParam&lt;int&gt;.None,
/// });
/// </code>
/// </example>
public class UseInfiniteQueryOptions<TPage, TPageParam, TData> : QueryOptionsBase
{
    /// <summary>The query's identity, shared by every page.</summary>
    public required QueryKey QueryKey { get; init; }

    /// <summary>Fetches one page, given its cursor.</summary>
    public required Func<InfiniteQueryFunctionContext<TPageParam>, Task<TPage>> QueryFn { get; init; }

    /// <summary>The cursor the first page is fetched with.</summary>
    public required TPageParam InitialPageParam { get; init; }

    /// <summary>Where the next page starts, or <see cref="NextPageParam{TPageParam}.None"/> at the end.</summary>
    public required PageParamResolver<TPage, TPageParam> GetNextPageParam { get; init; }

    /// <summary>
    /// Where the previous page starts, for lists that also grow upwards. Without it,
    /// <c>HasPreviousPage</c> is always false.
    /// </summary>
    public PageParamResolver<TPage, TPageParam>? GetPreviousPageParam { get; init; }

    /// <summary>
    /// How many pages to keep. Beyond this the far end is dropped, so a long list stays
    /// affordable at the cost of refetching what scrolled away.
    /// </summary>
    public int? MaxPages { get; init; }

    /// <summary>Projects the accumulated pages into what the component needs — flattening them, usually.</summary>
    public Func<InfiniteData<TPage, TPageParam>, TData>? Select { get; init; }

    /// <inheritdoc cref="UseQueryOptions{TQueryFnData, TData}.InitialData" />
    public InitialDataOption<InfiniteData<TPage, TPageParam>> InitialData { get; init; }

    /// <inheritdoc cref="UseQueryOptions{TQueryFnData, TData}.InitialDataUpdatedAt" />
    public long? InitialDataUpdatedAt { get; init; }

    /// <inheritdoc cref="UseQueryOptions{TQueryFnData, TData}.PlaceholderData" />
    public PlaceholderDataOption<InfiniteData<TPage, TPageParam>> PlaceholderData { get; init; }

    /// <summary>
    /// Builds the ordinary query options this infinite query runs as.
    /// <paramref name="pages"/> fixes how many pages a single fetch loads, for the imperative
    /// prefetching path; left null, a fetch reloads as many pages as the query already had.
    /// </summary>
    internal UseQueryOptions<InfiniteData<TPage, TPageParam>, TData> ToQueryOptions(int? pages = null) => new()
    {
        QueryKey = QueryKey,

        // Never called: the infinite behaviour replaces the whole fetch. It is present so the
        // query counts as fetchable — the same role skipToken's absence plays elsewhere.
        QueryFn = _ => Task.FromResult(InfiniteData<TPage, TPageParam>.Empty),
        Behavior = new InfiniteQueryBehavior<TPage, TPageParam>(
            QueryFn,
            InitialPageParam,
            GetNextPageParam,
            GetPreviousPageParam,
            MaxPages,
            pages),
        Select = Select,
        InitialData = InitialData,
        InitialDataUpdatedAt = InitialDataUpdatedAt,
        PlaceholderData = PlaceholderData,
        Enabled = Enabled,
        StaleTime = StaleTime,
        GcTime = GcTime,
        Retry = Retry,
        RetryDelay = RetryDelay,
        NetworkMode = NetworkMode,
        RefetchInterval = RefetchInterval,
        RefetchIntervalInBackground = RefetchIntervalInBackground,
        RefetchOnMount = RefetchOnMount,
        RefetchOnWindowFocus = RefetchOnWindowFocus,
        RefetchOnReconnect = RefetchOnReconnect,
        RetryOnMount = RetryOnMount,
        StructuralSharing = StructuralSharing,
        Meta = Meta,
    };
}

/// <summary>
/// Options for an infinite query whose pages are observed as they are accumulated, with no
/// projection.
/// </summary>
public sealed class UseInfiniteQueryOptions<TPage, TPageParam>
    : UseInfiniteQueryOptions<TPage, TPageParam, InfiniteData<TPage, TPageParam>>;
