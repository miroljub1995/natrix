namespace Natrix.Query;

/// <summary>
/// Raised when a fetch is cancelled — by <c>CancelQueries</c>, by a refetch that supersedes
/// it, or because the query's last observer went away. The counterpart of TanStack Query's
/// <c>CancelledError</c>.
/// </summary>
public sealed class QueryCancelledException : OperationCanceledException
{
    internal QueryCancelledException(bool revert, bool silent)
        : base("The query was cancelled.")
    {
        Revert = revert;
        Silent = silent;
    }

    /// <summary>Whether the query's state was rolled back to what it was before the fetch.</summary>
    public bool Revert { get; }

    /// <summary>Whether the cancellation was hidden from the query's state entirely.</summary>
    public bool Silent { get; }
}

/// <summary>
/// Raised when a query is asked to fetch but neither it nor any of its observers supplies a
/// query function.
/// </summary>
public sealed class MissingQueryFunctionException : InvalidOperationException
{
    internal MissingQueryFunctionException(string queryHash)
        : base($"Missing query function for query with key {queryHash}.")
    {
    }
}
