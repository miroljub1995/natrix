namespace Natrix.Query;

/// <summary>What happened to a cache entry, for subscribers of <see cref="QueryCache.Subscribe"/>.</summary>
public enum QueryCacheNotifyEventType
{
    /// <summary>A query was added to the cache.</summary>
    Added,

    /// <summary>A query was removed from the cache.</summary>
    Removed,

    /// <summary>A query's state changed.</summary>
    Updated,

    /// <summary>An observer started watching a query.</summary>
    ObserverAdded,

    /// <summary>An observer stopped watching a query.</summary>
    ObserverRemoved,

    /// <summary>An observer produced a new result.</summary>
    ObserverResultsUpdated,

    /// <summary>An observer's options changed.</summary>
    ObserverOptionsUpdated,
}

/// <summary>A single cache notification.</summary>
/// <param name="Type">What happened.</param>
/// <param name="Query">The query it happened to.</param>
/// <param name="Observer">The observer involved, for the observer-related events.</param>
public sealed record QueryCacheNotifyEvent(
    QueryCacheNotifyEventType Type,
    Query Query,
    QueryObserverBase? Observer);
