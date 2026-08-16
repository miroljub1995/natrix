namespace Natrix.Query;

/// <summary>One cache entry, extracted so it can be moved between clients.</summary>
/// <param name="QueryKey">The key the entry was stored under.</param>
/// <param name="QueryHash">The hash the entry was indexed by.</param>
/// <param name="State">The entry's state, with any in-flight fetch reset to idle.</param>
public sealed record DehydratedQuery(QueryKey QueryKey, string QueryHash, QueryState State);

/// <summary>One mutation, extracted so it can be resumed elsewhere.</summary>
/// <param name="MutationKey">The key its function is registered under, if it has one.</param>
/// <param name="State">The mutation's state, including the variables it was called with.</param>
public sealed record DehydratedMutation(QueryKey? MutationKey, MutationState State);

/// <summary>A snapshot of a cache, ready to be transferred and restored.</summary>
/// <param name="Queries">The entries worth transferring.</param>
/// <param name="Mutations">The mutations worth transferring — by default, the paused ones.</param>
public sealed record DehydratedState(
    IReadOnlyList<DehydratedQuery> Queries,
    IReadOnlyList<DehydratedMutation> Mutations);

/// <summary>Which entries <see cref="Hydration.Dehydrate"/> takes.</summary>
public sealed class DehydrateOptions
{
    /// <summary>
    /// Whether an entry should be transferred. By default only successful ones are: an error
    /// or a half-finished fetch is a property of the server that produced it, not data the
    /// client should adopt.
    /// </summary>
    public Func<Query, bool>? ShouldDehydrateQuery { get; init; }

    /// <summary>
    /// Whether a mutation should be transferred. By default only paused ones are — a write
    /// that never got out because the app was offline, which the next session should finish.
    /// </summary>
    public Func<Mutation, bool>? ShouldDehydrateMutation { get; init; }
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
                query.QueryHash,
                query.State with
                {
                    // Whatever was in flight belonged to the other client; the receiving one
                    // decides for itself whether to fetch again.
                    FetchStatus = FetchStatus.Idle,
                    FetchMeta = null,
                }))
            .ToArray();

        var shouldDehydrateMutation = options?.ShouldDehydrateMutation
            ?? (static mutation => mutation.State.IsPaused);

        var mutations = client.MutationCache.GetAll()
            .Where(shouldDehydrateMutation)
            .Select(mutation => new DehydratedMutation(mutation.Options.MutationKey, mutation.State))
            .ToArray();

        return new DehydratedState(queries, mutations);
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

            var existing = client.QueryCache.Get(dehydrated.QueryHash);

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

        foreach (var dehydrated in state.Mutations)
        {
            // A restored mutation carries no function of its own — the receiving client
            // supplies one through SetMutationDefaults, which is what makes a mutation that
            // was queued offline replayable in a later session.
            var defaults = dehydrated.MutationKey is { } key ? client.GetMutationDefaults(key) : null;

            client.MutationCache.Build(
                client,
                new ResolvedMutationOptions
                {
                    MutationKey = dehydrated.MutationKey,
                    MutationFn = defaults?.MutationFn
                        ?? (_ => Task.FromException<object?>(new MissingMutationFunctionException())),
                    Retry = defaults?.Retry ?? RetryOption.FromBool(false),
                    RetryDelay = defaults?.RetryDelay ?? QueryDefaults.ExponentialBackoff,
                    NetworkMode = defaults?.NetworkMode ?? NetworkMode.Online,
                    GcTime = defaults?.GcTime ?? QueryDefaults.GcTime,
                    Scope = defaults?.Scope,
                    Meta = defaults?.Meta,
                },
                dehydrated.State);
        }
    }
}
