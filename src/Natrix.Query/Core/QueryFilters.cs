namespace Natrix.Query;

/// <summary>
/// Selects a set of cache entries — the counterpart of TanStack Query's <c>QueryFilters</c>.
/// Every client method that acts on "the matching queries" takes one.
/// </summary>
/// <remarks>
/// An empty filter matches every query, which is what makes
/// <c>client.InvalidateQueriesAsync()</c> invalidate the whole cache.
/// </remarks>
/// <example>
/// <code>
/// // Everything under ['todos'], however deep.
/// new QueryFilters { QueryKey = ["todos"] }
///
/// // Only the exact entry, not ['todos', 1].
/// new QueryFilters { QueryKey = ["todos"], Exact = true }
///
/// // Every stale query nobody is watching.
/// new QueryFilters { Type = QueryTypeFilter.Inactive, Stale = true }
/// </code>
/// </example>
public sealed class QueryFilters
{
    /// <summary>
    /// The key to match. By default this is a prefix match, so <c>["todos"]</c> also selects
    /// <c>["todos", 1]</c>; set <see cref="Exact"/> to require the whole key.
    /// </summary>
    public QueryKey? QueryKey { get; init; }

    /// <summary>Whether <see cref="QueryKey"/> must match the query's key exactly.</summary>
    public bool Exact { get; init; }

    /// <inheritdoc cref="QueryTypeFilter" />
    public QueryTypeFilter Type { get; init; } = QueryTypeFilter.All;

    /// <summary>Restricts to queries whose staleness matches.</summary>
    public bool? Stale { get; init; }

    /// <summary>Restricts to queries in a particular fetch state.</summary>
    public FetchStatus? FetchStatus { get; init; }

    /// <summary>An arbitrary extra condition, applied after all the others.</summary>
    public Func<Query, bool>? Predicate { get; init; }

    /// <summary>Whether <paramref name="query"/> satisfies every criterion of this filter.</summary>
    public bool Matches(Query query)
    {
        ArgumentNullException.ThrowIfNull(query);

        if (QueryKey is not null)
        {
            if (Exact)
            {
                if (query.QueryKey != QueryKey)
                {
                    return false;
                }
            }
            else if (!query.QueryKey.PartiallyMatches(QueryKey))
            {
                return false;
            }
        }

        if (Type != QueryTypeFilter.All)
        {
            var isActive = query.IsActive();
            if (Type == QueryTypeFilter.Active && !isActive)
            {
                return false;
            }

            if (Type == QueryTypeFilter.Inactive && isActive)
            {
                return false;
            }
        }

        if (Stale is { } stale && query.IsStale() != stale)
        {
            return false;
        }

        if (FetchStatus is { } fetchStatus && query.State.FetchStatus != fetchStatus)
        {
            return false;
        }

        return Predicate is null || Predicate(query);
    }
}
