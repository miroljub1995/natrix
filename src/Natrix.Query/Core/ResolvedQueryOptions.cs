namespace Natrix.Query;

/// <summary>
/// A query's options after client defaults, per-key defaults and the caller's own options have
/// been merged — TanStack Query's "defaulted options". Untyped, because the cache stores
/// queries of every shape; the typed options a caller writes are
/// <see cref="UseQueryOptions{TQueryFnData, TData}"/>.
/// </summary>
public sealed class ResolvedQueryOptions
{
    /// <summary>The query's key.</summary>
    public required QueryKey QueryKey { get; init; }

    /// <summary>The hash the cache indexes this query under.</summary>
    public required string QueryHash { get; init; }

    /// <summary>
    /// The function that produces the data. <c>null</c> means the query cannot fetch on its
    /// own — the "skipToken" case — and stays pending until data is written to it.
    /// </summary>
    public Func<QueryFunctionContext, Task<object?>>? QueryFn { get; init; }

    /// <inheritdoc cref="EnabledOption" />
    public EnabledOption Enabled { get; init; } = true;

    /// <inheritdoc cref="StaleTimeOption" />
    public StaleTimeOption StaleTime { get; init; } = TimeSpan.Zero;

    /// <summary>How long an entry survives in the cache with no observers.</summary>
    public TimeSpan GcTime { get; init; } = TimeSpan.FromMinutes(5);

    /// <inheritdoc cref="RetryOption" />
    public RetryOption Retry { get; init; } = 3;

    /// <summary>Backoff before attempt <c>n</c>, given the failure count and the error.</summary>
    public Func<int, Exception, TimeSpan> RetryDelay { get; init; } = QueryDefaults.ExponentialBackoff;

    /// <inheritdoc cref="NetworkMode" />
    public NetworkMode NetworkMode { get; init; } = NetworkMode.Online;

    /// <inheritdoc cref="RefetchIntervalOption" />
    public RefetchIntervalOption RefetchInterval { get; init; }

    /// <summary>Whether polling continues while the window is in the background.</summary>
    public bool RefetchIntervalInBackground { get; init; }

    /// <summary>Whether a newly mounted observer refetches.</summary>
    public RefetchOnOption RefetchOnMount { get; init; } = true;

    /// <summary>Whether regaining window focus refetches.</summary>
    public RefetchOnOption RefetchOnWindowFocus { get; init; } = true;

    /// <summary>Whether regaining connectivity refetches.</summary>
    public RefetchOnOption RefetchOnReconnect { get; init; } = true;

    /// <summary>Whether a query that is already in an error state retries when a new observer mounts.</summary>
    public bool RetryOnMount { get; init; } = true;

    /// <summary>Produces data to seed the cache with before the first fetch.</summary>
    public Func<object?>? InitialData { get; init; }

    /// <summary>How old <see cref="InitialData"/> is, in Unix milliseconds. Defaults to "just now".</summary>
    public long? InitialDataUpdatedAt { get; init; }

    /// <summary>
    /// Whether to keep the previous data reference when new data is equal to it, so consumers
    /// that only read <c>Data</c> are not woken by an identical payload.
    /// </summary>
    public bool StructuralSharing { get; init; } = true;

    /// <summary>
    /// Full control over how new data replaces old, taking precedence over
    /// <see cref="StructuralSharing"/>. Receives the previous data (possibly <c>null</c>) and
    /// the incoming data, and returns what to store.
    /// </summary>
    public Func<object?, object?, object?>? StructuralSharingFn { get; init; }

    /// <summary>Arbitrary metadata, handed to the query function and available on the query.</summary>
    public IReadOnlyDictionary<string, object?>? Meta { get; init; }

    /// <summary>
    /// Replaces what a fetch does while leaving caching, retrying and deduplication in place.
    /// Set by <c>UseInfiniteQuery</c>; ordinary queries have none.
    /// </summary>
    public IQueryBehavior? Behavior { get; init; }
}

/// <summary>The framework's own defaults, matching TanStack Query's.</summary>
public static class QueryDefaults
{
    /// <summary>Time an entry with no observers is kept before being garbage collected.</summary>
    public static TimeSpan GcTime { get; } = TimeSpan.FromMinutes(5);

    /// <summary>
    /// <c>min(1000 * 2 ^ attemptIndex, 30000)</c> — the default retry backoff, doubling per
    /// attempt and capped at 30 seconds.
    /// </summary>
    public static TimeSpan ExponentialBackoff(int failureCount, Exception error)
    {
        var exponent = Math.Min(failureCount - 1, 31);
        var milliseconds = Math.Min(1000d * Math.Pow(2, Math.Max(exponent, 0)), 30_000d);
        return TimeSpan.FromMilliseconds(milliseconds);
    }
}
