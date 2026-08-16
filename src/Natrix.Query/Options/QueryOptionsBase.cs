namespace Natrix.Query;

/// <summary>
/// The options every query understands, independent of the data it produces. Each is nullable
/// so that "not specified" stays distinguishable from "specified as the default value" — which
/// is what lets client-wide defaults, per-key defaults and a call site's own options merge the
/// way TanStack Query's spread-based defaulting does.
/// </summary>
public abstract class QueryOptionsBase
{
    /// <summary>
    /// Whether the query may run. A disabled query never fetches on its own, is excluded from
    /// <see cref="QueryTypeFilter.Active"/> filters, and stays pending — the idiom behind
    /// dependent queries (<c>Enabled = userId is not null</c>). Defaults to <c>true</c>.
    /// </summary>
    public EnabledOption? Enabled { get; init; }

    /// <summary>
    /// How long data stays fresh. While fresh, mounting another observer, regaining focus or
    /// reconnecting will not refetch. Defaults to <see cref="TimeSpan.Zero"/> — data is
    /// considered stale the moment it arrives.
    /// </summary>
    public StaleTimeOption? StaleTime { get; init; }

    /// <summary>
    /// How long an entry with no observers is kept before being collected. Defaults to five
    /// minutes. When several observers disagree, the longest wins.
    /// </summary>
    public TimeSpan? GcTime { get; init; }

    /// <summary>
    /// How often a failed query is retried. Defaults to 3 attempts for queries mounted through
    /// <c>UseQuery</c>, and to none for the imperative
    /// <see cref="QueryClient.FetchQueryAsync{TQueryFnData}"/>.
    /// </summary>
    public RetryOption? Retry { get; init; }

    /// <summary>
    /// The delay before retry number <c>n</c>. Defaults to
    /// <see cref="QueryDefaults.ExponentialBackoff"/>.
    /// </summary>
    public Func<int, Exception, TimeSpan>? RetryDelay { get; init; }

    /// <inheritdoc cref="Natrix.Query.NetworkMode" />
    public NetworkMode? NetworkMode { get; init; }

    /// <summary>
    /// Polls the query on an interval while it has observers. Defaults to no polling.
    /// </summary>
    public RefetchIntervalOption? RefetchInterval { get; init; }

    /// <summary>Whether polling continues while the app is in the background. Defaults to <c>false</c>.</summary>
    public bool? RefetchIntervalInBackground { get; init; }

    /// <summary>
    /// Whether mounting a new observer refetches stale data. <see cref="RefetchOnValue.Always"/>
    /// refetches even when the data is fresh. Defaults to <c>true</c>.
    /// </summary>
    public RefetchOnOption? RefetchOnMount { get; init; }

    /// <summary>Whether the window regaining focus refetches stale data. Defaults to <c>true</c>.</summary>
    public RefetchOnOption? RefetchOnWindowFocus { get; init; }

    /// <summary>
    /// Whether regaining connectivity refetches stale data. Defaults to <c>true</c>, except
    /// under <see cref="Natrix.Query.NetworkMode.Always"/> where connectivity is irrelevant.
    /// </summary>
    public RefetchOnOption? RefetchOnReconnect { get; init; }

    /// <summary>
    /// Whether a query that is already in an error state retries when a new observer mounts.
    /// Defaults to <c>true</c>.
    /// </summary>
    public bool? RetryOnMount { get; init; }

    /// <summary>
    /// Whether data equal to what is already cached keeps the cached reference, so consumers
    /// reading it are not woken by an identical payload. Defaults to <c>true</c>.
    /// </summary>
    public bool? StructuralSharing { get; init; }

    /// <summary>
    /// Arbitrary metadata. It reaches the query function through
    /// <see cref="QueryFunctionContext.Meta"/> and stays available on the <see cref="Query"/>,
    /// which makes it the usual place to park things a global error handler needs.
    /// </summary>
    public IReadOnlyDictionary<string, object?>? Meta { get; init; }
}
