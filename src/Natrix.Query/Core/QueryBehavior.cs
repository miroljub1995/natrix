namespace Natrix.Query;

/// <summary>
/// A hook that replaces what a fetch actually does, without changing the query around it.
/// The counterpart of TanStack Query's <c>behavior.onFetch</c>, and how infinite queries turn
/// one fetch into a sequence of pages while keeping the same caching, retrying and
/// deduplication.
/// </summary>
public interface IQueryBehavior
{
    /// <summary>
    /// Called once per fetch, before the first attempt. Replace
    /// <see cref="QueryBehaviorContext.FetchFn"/> to take over the request.
    /// </summary>
    void OnFetch(QueryBehaviorContext context);
}

/// <summary>What a <see cref="IQueryBehavior"/> is given, and the one thing it may replace.</summary>
public sealed class QueryBehaviorContext
{
    /// <summary>The query being fetched.</summary>
    public required Query Query { get; init; }

    /// <summary>The options this fetch runs with.</summary>
    public required ResolvedQueryOptions Options { get; init; }

    /// <summary>The query's state as it was when the fetch started.</summary>
    public required QueryState State { get; init; }

    /// <summary>Per-fetch overrides, including the metadata that says which page to fetch.</summary>
    public FetchOptions? FetchOptions { get; init; }

    /// <summary>The context the query function would be called with.</summary>
    public required QueryFunctionContext FunctionContext { get; init; }

    /// <summary>
    /// What the fetch runs. Assign to it to replace the default call to the query function;
    /// whatever it resolves to becomes the query's data.
    /// </summary>
    public required Func<Task<object?>> FetchFn { get; set; }
}
