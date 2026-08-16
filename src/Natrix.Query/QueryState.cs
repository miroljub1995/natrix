namespace Natrix.Query;

/// <summary>
/// The full state a cache entry keeps for a query — the C# counterpart of TanStack Query's
/// <c>QueryState</c>. Immutable: every transition produces a new instance, so observers can
/// compare snapshots and a state read is never torn halfway through an update.
/// </summary>
/// <remarks>
/// <see cref="Data"/> is untyped here because one cache holds queries of every shape. Typed
/// access goes through <see cref="QueryClient.GetQueryData{TData}"/> or the result of
/// <c>UseQuery</c>.
/// </remarks>
public sealed record QueryState
{
    /// <summary>The last successfully fetched data, or <c>null</c> when there is none yet.</summary>
    public object? Data { get; init; }

    /// <summary>
    /// Whether <see cref="Data"/> holds a real value. It exists because C# has no
    /// <c>undefined</c>: a query function may legitimately produce <c>null</c>, so the
    /// reference alone cannot distinguish "resolved to null" from "never resolved", which is
    /// the distinction TanStack Query draws with <c>data !== undefined</c>.
    /// </summary>
    public bool HasData { get; init; }

    /// <summary>How many times data was written, counting <c>SetQueryData</c> and every successful fetch.</summary>
    public int DataUpdateCount { get; init; }

    /// <summary>When <see cref="Data"/> was last written, in Unix milliseconds; <c>0</c> when never.</summary>
    public long DataUpdatedAt { get; init; }

    /// <summary>The error of the last failed attempt, cleared by the next success.</summary>
    public Exception? Error { get; init; }

    /// <summary>How many times the query ended in an error.</summary>
    public int ErrorUpdateCount { get; init; }

    /// <summary>When <see cref="Error"/> was last written, in Unix milliseconds; <c>0</c> when never.</summary>
    public long ErrorUpdatedAt { get; init; }

    /// <summary>Failures within the current fetch, reset when a new fetch starts.</summary>
    public int FetchFailureCount { get; init; }

    /// <summary>The error of the most recent failed attempt within the current fetch.</summary>
    public Exception? FetchFailureReason { get; init; }

    /// <summary>Arbitrary metadata attached to the running fetch by whoever started it.</summary>
    public object? FetchMeta { get; init; }

    /// <summary>Whether the entry was invalidated and should refetch at the next opportunity.</summary>
    public bool IsInvalidated { get; init; }

    /// <inheritdoc cref="QueryStatus" />
    public QueryStatus Status { get; init; } = QueryStatus.Pending;

    /// <inheritdoc cref="FetchStatus" />
    public FetchStatus FetchStatus { get; init; } = FetchStatus.Idle;
}
