namespace Natrix.Query;

/// <summary>One cache entry, extracted so it can be moved between clients.</summary>
/// <param name="QueryKey">The key the entry was stored under.</param>
/// <param name="State">The entry's state, with any in-flight fetch reset to idle.</param>
public sealed record DehydratedQuery(QueryKey QueryKey, QueryState State);

/// <summary>A snapshot of a cache, ready to be transferred and restored.</summary>
/// <param name="Queries">The entries worth transferring.</param>
public sealed record DehydratedState(IReadOnlyList<DehydratedQuery> Queries);

/// <summary>Which entries <see cref="Hydration.Dehydrate"/> takes.</summary>
public sealed class DehydrateOptions
{
    /// <summary>
    /// Whether an entry should be transferred. By default only successful ones are: an error
    /// or a half-finished fetch is a property of the server that produced it, not data the
    /// client should adopt.
    /// </summary>
    public Func<Query, bool>? ShouldDehydrateQuery { get; init; }
}

/// <summary>
/// Moves cached data from one client to another — the counterpart of TanStack Query's
/// <c>dehydrate</c> and <c>hydrate</c>.
/// </summary>
/// <remarks>
/// The pair works at the object level and deliberately does not serialize anything: what the
/// wire format should be depends on the app, and a reflection-based serializer is not an
/// option in a trimmed assembly. Serialize <see cref="DehydratedState"/> with your own
/// (source-generated) serializer to send it from a server-rendered page to the browser, or
/// pass the object straight through when both clients live in the same process.
/// </remarks>
public static class Hydration
{
    /// <summary>Takes a snapshot of the client's cache.</summary>
    public static DehydratedState Dehydrate(QueryClient client, DehydrateOptions? options = null)
    {
        ArgumentNullException.ThrowIfNull(client);

        var shouldDehydrate = options?.ShouldDehydrateQuery
            ?? (static query => query.State.Status == QueryStatus.Success);

        var queries = client.QueryCache.GetAll()
            .Where(shouldDehydrate)
            .Select(query => new DehydratedQuery(
                query.QueryKey,
                query.State with
                {
                    // Whatever was in flight belonged to the other client; the receiving one
                    // decides for itself whether to fetch again.
                    FetchStatus = FetchStatus.Idle,
                    FetchMeta = null,
                }))
            .ToArray();

        return new DehydratedState(queries);
    }

    /// <summary>
    /// Restores a snapshot into a client. Entries the client already has are only overwritten
    /// when the incoming data is newer, so hydration never rolls back data the client fetched
    /// for itself in the meantime.
    /// </summary>
    public static void Hydrate(QueryClient client, DehydratedState state)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(state);

        foreach (var dehydrated in state.Queries)
        {
            var restored = dehydrated.State with
            {
                FetchStatus = FetchStatus.Idle,
                FetchMeta = null,
            };

            var existing = client.QueryCache.Get(dehydrated.QueryKey);

            if (existing is not null)
            {
                if (existing.State.DataUpdatedAt < restored.DataUpdatedAt)
                {
                    existing.SetState(restored);
                }

                continue;
            }

            var options = client.ResolveOptions(new UseQueryOptions<object> { QueryKey = dehydrated.QueryKey });
            client.QueryCache.Build(client, options, restored);
        }
    }
}
