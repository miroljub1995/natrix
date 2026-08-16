namespace Natrix.Query;

/// <summary>
/// One snapshot of everything an observer exposes about a query — the object
/// <c>UseQuery</c> hands back, and the counterpart of TanStack Query's
/// <c>QueryObserverResult</c>.
/// </summary>
/// <remarks>
/// The two axes are worth keeping straight: <see cref="Status"/> answers "do I have data?"
/// and <see cref="FetchStatus"/> answers "is a request happening?". A background refetch is
/// <see cref="QueryStatus.Success"/> and <see cref="Natrix.Query.FetchStatus.Fetching"/> at the
/// same time; an offline query is <see cref="QueryStatus.Pending"/> and
/// <see cref="Natrix.Query.FetchStatus.Paused"/>.
/// </remarks>
public record QueryObserverResult<TData>
{
    /// <summary>The data, or <c>default</c> when there is none yet.</summary>
    public TData? Data { get; init; }

    /// <summary>Whether <see cref="Data"/> holds a real value rather than standing in for "nothing yet".</summary>
    public bool HasData { get; init; }

    /// <summary>The error the last attempt threw, if it failed.</summary>
    public Exception? Error { get; init; }

    /// <inheritdoc cref="QueryStatus" />
    public QueryStatus Status { get; init; }

    /// <inheritdoc cref="Natrix.Query.FetchStatus" />
    public FetchStatus FetchStatus { get; init; }

    /// <summary>When the data was last updated, in Unix milliseconds.</summary>
    public long DataUpdatedAt { get; init; }

    /// <summary>When the error was last updated, in Unix milliseconds.</summary>
    public long ErrorUpdatedAt { get; init; }

    /// <summary>Failed attempts within the current fetch — useful for "retrying…" indicators.</summary>
    public int FailureCount { get; init; }

    /// <summary>The error behind the most recent failed attempt, even while retries continue.</summary>
    public Exception? FailureReason { get; init; }

    /// <summary>How many times this query has ended in an error.</summary>
    public int ErrorUpdateCount { get; init; }

    /// <summary>Whether the data is considered out of date under this observer's stale time.</summary>
    public bool IsStale { get; init; }

    /// <summary>Whether <see cref="Data"/> is placeholder data rather than anything cached.</summary>
    public bool IsPlaceholderData { get; init; }

    /// <summary>Whether the query has ever completed, successfully or not.</summary>
    public bool IsFetched { get; init; }

    /// <summary>Whether the query has completed since this observer mounted.</summary>
    public bool IsFetchedAfterMount { get; init; }

    /// <summary>Whether the query is allowed to run at all.</summary>
    public bool IsEnabled { get; init; }

    /// <summary>No data and no error yet.</summary>
    public bool IsPending => Status == QueryStatus.Pending;

    /// <summary>Data is available.</summary>
    public bool IsSuccess => Status == QueryStatus.Success;

    /// <summary>The query failed.</summary>
    public bool IsError => Status == QueryStatus.Error;

    /// <summary>A request is in flight, first load or background refetch alike.</summary>
    public bool IsFetching => FetchStatus == FetchStatus.Fetching;

    /// <summary>The query wants to fetch but is waiting for the connection to come back.</summary>
    public bool IsPaused => FetchStatus == FetchStatus.Paused;

    /// <summary>
    /// The first load: pending <em>and</em> fetching. This — not <see cref="IsPending"/> — is
    /// what a spinner should key off, since a disabled or paused query is pending without
    /// anything being on its way.
    /// </summary>
    public bool IsLoading => IsPending && IsFetching;

    /// <summary>A refetch on top of data that is already displayed.</summary>
    public bool IsRefetching => IsFetching && !IsPending;

    /// <summary>The query failed and there is no data to fall back on.</summary>
    public bool IsLoadingError => Status == QueryStatus.Error && DataUpdatedAt == 0;

    /// <summary>The query failed while refetching, so the previous data is still there.</summary>
    public bool IsRefetchError => Status == QueryStatus.Error && DataUpdatedAt != 0;
}
