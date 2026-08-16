namespace Natrix.Query;

/// <summary>
/// Everything a query needs, for a query function returning <typeparamref name="TQueryFnData"/>
/// whose data is projected to <typeparamref name="TData"/> by <see cref="Select"/>. The
/// counterpart of TanStack Query's <c>UseQueryOptions</c>.
/// </summary>
/// <typeparam name="TQueryFnData">What the query function returns, and what the cache stores.</typeparam>
/// <typeparam name="TData">What the component observes, after <see cref="Select"/>.</typeparam>
/// <remarks>
/// Options are read reactively when passed as a factory, so every option — the key included —
/// may be derived from signals and the query reconfigures itself when they change:
/// <code>
/// var todo = UseQuery(() => new UseQueryOptions&lt;Todo&gt;
/// {
///     QueryKey = ["todos", selectedId.Value],
///     QueryFn = ctx => api.GetTodoAsync(selectedId.Value, ctx.Signal),
///     Enabled = selectedId.Value is not null,
/// });
/// </code>
/// </remarks>
public class UseQueryOptions<TQueryFnData, TData> : QueryOptionsBase
{
    /// <summary>
    /// The query's identity. Everything the query function reads from the outside must appear
    /// here, so that changing it fetches the right data and caching stays correct.
    /// </summary>
    public required QueryKey QueryKey { get; init; }

    /// <summary>
    /// Produces the data. It must throw on failure — a returned error is a value, and a query
    /// that never throws never enters the error state.
    /// </summary>
    public Func<QueryFunctionContext, Task<TQueryFnData>>? QueryFn { get; init; }

    /// <summary>
    /// Projects the cached data into what the component actually needs, re-running only when
    /// the underlying data changes. Deriving here rather than in the component keeps the
    /// cached payload shared between consumers that each want a different slice of it.
    /// </summary>
    public Func<TQueryFnData, TData>? Select { get; init; }

    /// <summary>
    /// Data written into the cache up front, treated exactly like fetched data: it is
    /// persisted, shared with every other observer of the key, and made stale by
    /// <see cref="QueryOptionsBase.StaleTime"/> like anything else. Pair it with
    /// <see cref="InitialDataUpdatedAt"/> when the data is older than "now".
    /// </summary>
    public InitialDataOption<TQueryFnData> InitialData { get; init; }

    /// <summary>How old <see cref="InitialData"/> is, in Unix milliseconds.</summary>
    public long? InitialDataUpdatedAt { get; init; }

    /// <summary>
    /// Data to show while the real data loads. Unlike <see cref="InitialData"/> it is never
    /// written to the cache and the result is flagged with <c>IsPlaceholderData</c>. Use
    /// <see cref="PlaceholderDataOption{TQueryFnData}.KeepPreviousData"/> to keep the previous
    /// key's data on screen while a new key loads.
    /// </summary>
    public PlaceholderDataOption<TQueryFnData> PlaceholderData { get; init; }

    /// <summary>
    /// Full control over how new data replaces old, taking precedence over
    /// <see cref="QueryOptionsBase.StructuralSharing"/>. Receives the previous data (default
    /// when there is none) and the incoming data, and returns what to store.
    /// </summary>
    public Func<TQueryFnData?, TQueryFnData, TQueryFnData>? StructuralSharingFn { get; init; }
}

/// <summary>
/// Options for a query whose data is observed exactly as the query function returned it — the
/// common case, and the reason <see cref="UseQueryOptions{TQueryFnData, TData}.Select"/> is
/// optional.
/// </summary>
/// <typeparam name="TQueryFnData">What the query function returns.</typeparam>
public sealed class UseQueryOptions<TQueryFnData> : UseQueryOptions<TQueryFnData, TQueryFnData>;
