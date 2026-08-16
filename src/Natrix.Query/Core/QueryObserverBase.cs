namespace Natrix.Query;

/// <summary>
/// What a <see cref="Query"/> knows about the things watching it, independent of the data
/// type each of them projects. <see cref="QueryObserver{TQueryFnData, TData}"/> is the only
/// implementation.
/// </summary>
public abstract class QueryObserverBase
{
    /// <summary>The observer's defaulted options.</summary>
    internal abstract ResolvedQueryOptions Options { get; }

    /// <summary>Called by the query after every state transition.</summary>
    internal abstract void OnQueryUpdate();

    /// <summary>Whether regaining window focus should make this observer refetch.</summary>
    internal abstract bool ShouldFetchOnWindowFocus();

    /// <summary>Whether regaining connectivity should make this observer refetch.</summary>
    internal abstract bool ShouldFetchOnReconnect();

    /// <summary>Whether the result this observer currently exposes counts as stale.</summary>
    internal abstract bool CurrentResultIsStale { get; }

    /// <summary>Refetches through this observer, which is how a query re-runs with observer options.</summary>
    internal abstract Task RefetchCoreAsync(RefetchOptions? options);
}
