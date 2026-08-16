namespace Natrix.Query;

/// <summary>
/// Whether a query has data yet, mirroring TanStack Query's <c>status</c>. It answers
/// "do I have data?" and nothing about whether a request is in flight — that is
/// <see cref="FetchStatus"/>.
/// </summary>
public enum QueryStatus
{
    /// <summary>No data and no error yet.</summary>
    Pending,

    /// <summary>The query attempt failed and produced an error.</summary>
    Error,

    /// <summary>The query succeeded and data is available.</summary>
    Success,
}

/// <summary>
/// Whether a request is currently happening, mirroring TanStack Query's <c>fetchStatus</c>.
/// Orthogonal to <see cref="QueryStatus"/>: a query can be <see cref="QueryStatus.Success"/>
/// and <see cref="Fetching"/> at the same time (a background refetch).
/// </summary>
public enum FetchStatus
{
    /// <summary>Nothing is happening.</summary>
    Idle,

    /// <summary>The query function is running.</summary>
    Fetching,

    /// <summary>
    /// The query wanted to fetch but cannot — there is no network connection and the
    /// query's <see cref="NetworkMode"/> requires one. It resumes automatically.
    /// </summary>
    Paused,
}

/// <summary>
/// How a query behaves with respect to connectivity.
/// </summary>
public enum NetworkMode
{
    /// <summary>
    /// Default. Fetches only while online; going offline pauses fetches and retries instead
    /// of failing them.
    /// </summary>
    Online,

    /// <summary>Always fetches, ignoring connectivity entirely.</summary>
    Always,

    /// <summary>
    /// Issues the first request regardless of connectivity, then pauses retries while
    /// offline. Useful in front of an offline-capable cache.
    /// </summary>
    OfflineFirst,
}

/// <summary>Which queries a filter selects, mirroring TanStack Query's <c>type</c> filter.</summary>
public enum QueryTypeFilter
{
    /// <summary>Every query, active or not.</summary>
    All,

    /// <summary>Queries with at least one enabled observer.</summary>
    Active,

    /// <summary>Queries with no observers, or only disabled ones.</summary>
    Inactive,
}

/// <summary>Which queries an invalidation refetches, mirroring TanStack Query's <c>refetchType</c>.</summary>
public enum RefetchType
{
    /// <summary>Default for invalidation: refetch matching queries that are active.</summary>
    Active,

    /// <summary>Refetch matching queries that are inactive.</summary>
    Inactive,

    /// <summary>Refetch every matching query.</summary>
    All,

    /// <summary>Mark as invalidated but do not refetch anything.</summary>
    None,
}
