namespace Natrix.Query;

/// <summary>Per-fetch overrides, the counterpart of TanStack Query's <c>FetchOptions</c>.</summary>
public sealed class FetchOptions
{
    /// <summary>
    /// Whether an already running fetch is cancelled and replaced. <c>true</c> — the default
    /// for an explicit refetch — guarantees the caller's request is the one that wins.
    /// </summary>
    public bool CancelRefetch { get; init; }

    /// <summary>Metadata recorded on the query while this fetch runs.</summary>
    public object? Meta { get; init; }
}

/// <summary>Options for cancelling a query, the counterpart of TanStack Query's <c>CancelOptions</c>.</summary>
public sealed class CancelOptions
{
    /// <summary>
    /// Whether to roll the query's state back to what it was before the cancelled fetch
    /// started. Defaults to <c>true</c>, as in TanStack Query.
    /// </summary>
    public bool Revert { get; init; } = true;

    /// <summary>Whether the cancellation should leave no trace in the query's state.</summary>
    public bool Silent { get; init; }
}

/// <summary>Options for writing data into the cache directly.</summary>
public sealed class SetDataOptions
{
    /// <summary>The timestamp to record as <c>DataUpdatedAt</c>, in Unix milliseconds.</summary>
    public long? UpdatedAt { get; init; }

    /// <summary>
    /// Whether the write came from application code rather than from a completed fetch. A
    /// manual write leaves <c>FetchStatus</c> alone, so seeding data optimistically in the
    /// middle of a refetch does not make that refetch look finished.
    /// </summary>
    internal bool Manual { get; init; }
}

/// <summary>Options for <see cref="QueryClient.InvalidateQueriesAsync"/>.</summary>
public sealed class InvalidateQueryOptions
{
    /// <summary>Which of the invalidated queries are refetched right away. Defaults to <see cref="RefetchType.Active"/>.</summary>
    public RefetchType RefetchType { get; init; } = RefetchType.Active;

    /// <summary>Whether refetching cancels fetches that are already running.</summary>
    public bool CancelRefetch { get; init; } = true;
}

/// <summary>Options for <see cref="QueryClient.RefetchQueriesAsync"/>.</summary>
public sealed class RefetchQueryOptions
{
    /// <summary>Whether refetching cancels fetches that are already running.</summary>
    public bool CancelRefetch { get; init; } = true;
}

/// <summary>Options for refetching a single observer.</summary>
public sealed class RefetchOptions
{
    /// <summary>Whether the refetch cancels a fetch that is already running. Defaults to <c>true</c>.</summary>
    public bool CancelRefetch { get; init; } = true;
}

/// <summary>Options for <see cref="QueryClient.ResetQueriesAsync"/>.</summary>
public sealed class ResetQueryOptions
{
    /// <summary>Whether refetching cancels fetches that are already running.</summary>
    public bool CancelRefetch { get; init; } = true;
}
