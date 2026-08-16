namespace Natrix.Query;

/// <summary>Which end of an infinite query a fetch is extending.</summary>
public enum FetchDirection
{
    /// <summary>Towards the next page — the usual "load more".</summary>
    Forward,

    /// <summary>Towards the previous page, for lists that grow upwards.</summary>
    Backward,
}

/// <summary>
/// The page cursor an infinite query hands to the next request, or the explicit absence of one.
/// </summary>
/// <remarks>
/// TanStack Query says "no more pages" by returning <c>undefined</c> or <c>null</c>. C# cannot:
/// a cursor is often an <see cref="int"/> or a <see cref="DateTime"/>, where <c>0</c> and
/// <c>default</c> are perfectly good page params. So the absence is its own value —
/// <see cref="None"/> — while a real cursor converts implicitly and reads exactly as it would
/// in the original.
/// </remarks>
public readonly struct NextPageParam<TPageParam>
{
    private NextPageParam(TPageParam value, bool hasValue)
    {
        Value = value;
        HasValue = hasValue;
    }

    /// <summary>There is no further page in this direction.</summary>
    public static NextPageParam<TPageParam> None => default;

    /// <summary>Whether a page param is present.</summary>
    public bool HasValue { get; }

    /// <summary>The cursor, meaningful only when <see cref="HasValue"/>.</summary>
    public TPageParam Value { get; }

    public static implicit operator NextPageParam<TPageParam>(TPageParam value) =>
        new(value, value is not null);

    /// <summary>Named alternative to the implicit conversion.</summary>
    public static NextPageParam<TPageParam> From(TPageParam value) => value;
}

/// <summary>
/// The pages an infinite query has accumulated, together with the cursor each was fetched with
/// — the counterpart of TanStack Query's <c>InfiniteData</c>.
/// </summary>
/// <param name="Pages">Every page fetched so far, in display order.</param>
/// <param name="PageParams">The cursor each page was fetched with, aligned with <paramref name="Pages"/>.</param>
public sealed record InfiniteData<TPage, TPageParam>(
    IReadOnlyList<TPage> Pages,
    IReadOnlyList<TPageParam> PageParams)
{
    /// <summary>Nothing fetched yet.</summary>
    public static InfiniteData<TPage, TPageParam> Empty { get; } = new([], []);

    /// <summary>Adds a page at the end, dropping the oldest one when <paramref name="maxPages"/> is reached.</summary>
    internal InfiniteData<TPage, TPageParam> Append(TPage page, TPageParam pageParam, int? maxPages) =>
        new(AddToEnd(Pages, page, maxPages), AddToEnd(PageParams, pageParam, maxPages));

    /// <summary>Adds a page at the start, dropping the newest one when <paramref name="maxPages"/> is reached.</summary>
    internal InfiniteData<TPage, TPageParam> Prepend(TPage page, TPageParam pageParam, int? maxPages) =>
        new(AddToStart(Pages, page, maxPages), AddToStart(PageParams, pageParam, maxPages));

    private static IReadOnlyList<T> AddToEnd<T>(IReadOnlyList<T> items, T item, int? max)
    {
        var next = new List<T>(items) { item };

        // Bounded pages are how an infinite list stays affordable: keeping the last N means the
        // far end is refetched rather than held in memory forever.
        return max is { } limit && limit > 0 && next.Count > limit
            ? next.GetRange(next.Count - limit, limit)
            : next;
    }

    private static IReadOnlyList<T> AddToStart<T>(IReadOnlyList<T> items, T item, int? max)
    {
        var next = new List<T>(items.Count + 1) { item };
        next.AddRange(items);

        return max is { } limit && limit > 0 && next.Count > limit
            ? next.GetRange(0, limit)
            : next;
    }
}

/// <summary>
/// What an infinite query's page function is handed: everything an ordinary query function
/// gets, plus the cursor for the page being fetched.
/// </summary>
public sealed class InfiniteQueryFunctionContext<TPageParam> : QueryFunctionContext
{
    internal InfiniteQueryFunctionContext(
        QueryFunctionContext parent,
        TPageParam pageParam,
        FetchDirection direction)
        : base(parent.Client, parent.QueryKey, parent.RawSignal, parent.Meta, parent.SignalConsumedCallback)
    {
        PageParam = pageParam;
        Direction = direction;
    }

    /// <summary>The cursor for this page — <c>InitialPageParam</c> for the first one.</summary>
    public TPageParam PageParam { get; }

    /// <summary>Which end of the list this page extends.</summary>
    public FetchDirection Direction { get; }
}

/// <summary>Marks a fetch as extending an existing infinite query rather than replacing it.</summary>
internal sealed record FetchMoreMeta(FetchDirection Direction);
