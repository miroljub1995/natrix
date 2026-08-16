namespace Natrix.Query;

/// <summary>
/// A mutation's options after client defaults, per-key defaults and the caller's own options
/// have been merged. Untyped, because one cache holds mutations of every shape.
/// </summary>
public sealed class ResolvedMutationOptions
{
    /// <summary>An optional identity, used by filters and by <c>SetMutationDefaults</c>.</summary>
    public QueryKey? MutationKey { get; init; }

    /// <summary>Performs the mutation.</summary>
    public required Func<object?, Task<object?>> MutationFn { get; init; }

    /// <summary>Runs before the mutation and produces the context handed to the other callbacks.</summary>
    public Func<object?, Task<object?>>? OnMutate { get; init; }

    /// <summary>Runs after success, before the mutation is reported as settled.</summary>
    public Func<object?, object?, object?, Task>? OnSuccess { get; init; }

    /// <summary>Runs after failure, before the mutation is reported as settled.</summary>
    public Func<Exception, object?, object?, Task>? OnError { get; init; }

    /// <summary>Runs after either outcome.</summary>
    public Func<object?, Exception?, object?, object?, Task>? OnSettled { get; init; }

    /// <inheritdoc cref="RetryOption" />
    public RetryOption Retry { get; init; }

    /// <summary>Backoff before attempt <c>n</c>.</summary>
    public Func<int, Exception, TimeSpan> RetryDelay { get; init; } = QueryDefaults.ExponentialBackoff;

    /// <inheritdoc cref="Natrix.Query.NetworkMode" />
    public NetworkMode NetworkMode { get; init; } = NetworkMode.Online;

    /// <summary>How long a finished mutation is kept before being collected.</summary>
    public TimeSpan GcTime { get; init; } = QueryDefaults.GcTime;

    /// <inheritdoc cref="MutationScope" />
    public MutationScope? Scope { get; init; }

    /// <summary>Arbitrary metadata, available on the mutation.</summary>
    public IReadOnlyDictionary<string, object?>? Meta { get; init; }
}

/// <summary>
/// The options every mutation understands, independent of its data and variable types. Each is
/// nullable so "not specified" stays distinguishable from "specified as the default".
/// </summary>
public abstract class MutationOptionsBase
{
    /// <summary>
    /// How often a failed mutation is retried. Defaults to none — unlike a query, a mutation
    /// has side effects, and repeating it is a decision rather than a default.
    /// </summary>
    public RetryOption? Retry { get; init; }

    /// <summary>Backoff before attempt <c>n</c>. Defaults to <see cref="QueryDefaults.ExponentialBackoff"/>.</summary>
    public Func<int, Exception, TimeSpan>? RetryDelay { get; init; }

    /// <inheritdoc cref="Natrix.Query.NetworkMode" />
    public NetworkMode? NetworkMode { get; init; }

    /// <summary>How long a finished mutation is kept before being collected. Defaults to five minutes.</summary>
    public TimeSpan? GcTime { get; init; }

    /// <inheritdoc cref="MutationScope" />
    public MutationScope? Scope { get; init; }

    /// <summary>Arbitrary metadata, available on the mutation.</summary>
    public IReadOnlyDictionary<string, object?>? Meta { get; init; }
}

/// <summary>
/// Defaults applied to mutations that do not specify an option themselves — client-wide, or
/// per mutation key through <see cref="QueryClient.SetMutationDefaults"/>.
/// </summary>
public sealed class DefaultMutationOptions : MutationOptionsBase
{
    /// <summary>A mutation function used by every mutation that does not bring its own.</summary>
    public Func<object?, Task<object?>>? MutationFn { get; init; }
}

/// <summary>
/// Everything a mutation needs — the counterpart of TanStack Query's <c>UseMutationOptions</c>.
/// </summary>
/// <typeparam name="TData">What the mutation function returns.</typeparam>
/// <typeparam name="TVariables">What it is called with.</typeparam>
/// <typeparam name="TContext">
/// What <see cref="OnMutate"/> produces and the other callbacks receive — the snapshot an
/// optimistic update needs in order to roll itself back.
/// </typeparam>
/// <example>
/// <code>
/// var addTodo = UseMutation(new UseMutationOptions&lt;Todo, string&gt;
/// {
///     MutationFn = title => api.CreateTodoAsync(title),
///     OnSuccess = (todo, title, context) =>
///         client.InvalidateQueriesAsync(new QueryFilters { QueryKey = ["todos"] }),
/// });
///
/// addTodo.Mutate("buy milk");
/// </code>
/// </example>
public class UseMutationOptions<TData, TVariables, TContext> : MutationOptionsBase
{
    /// <summary>
    /// Performs the mutation. It must throw on failure. Optional only because it can instead
    /// be registered for the mutation key with
    /// <see cref="QueryClient.SetMutationDefaults"/> — firing a mutation that has neither
    /// throws.
    /// </summary>
    public Func<TVariables, Task<TData>>? MutationFn { get; init; }

    /// <summary>
    /// An optional identity. It does not cache anything — mutations are never cached by key —
    /// but it lets filters and <c>SetMutationDefaults</c> address a family of mutations.
    /// </summary>
    public QueryKey? MutationKey { get; init; }

    /// <summary>
    /// Runs before the mutation function. Whatever it returns becomes the context the other
    /// callbacks receive, which is how an optimistic update carries the previous value to roll
    /// back to.
    /// </summary>
    public Func<TVariables, Task<TContext?>>? OnMutate { get; init; }

    /// <summary>Runs after success. The mutation is not reported as settled until it completes.</summary>
    public Func<TData, TVariables, TContext?, Task>? OnSuccess { get; init; }

    /// <summary>Runs after failure — where an optimistic update undoes itself.</summary>
    public Func<Exception, TVariables, TContext?, Task>? OnError { get; init; }

    /// <summary>Runs after either outcome, which is the usual place to invalidate.</summary>
    public Func<TData?, Exception?, TVariables, TContext?, Task>? OnSettled { get; init; }
}

/// <summary>Options for a mutation that has no use for a context object.</summary>
public sealed class UseMutationOptions<TData, TVariables> : UseMutationOptions<TData, TVariables, object>;

/// <summary>
/// Callbacks for a single <c>Mutate</c> call, on top of the ones configured for every call.
/// They run only if the observer is still alive when the mutation settles.
/// </summary>
public sealed class MutateOptions<TData, TVariables>
{
    /// <summary>Runs after this call succeeds.</summary>
    public Action<TData, TVariables>? OnSuccess { get; init; }

    /// <summary>Runs after this call fails.</summary>
    public Action<Exception, TVariables>? OnError { get; init; }

    /// <summary>Runs after this call settles, either way.</summary>
    public Action<TData?, Exception?, TVariables>? OnSettled { get; init; }
}

/// <summary>Selects mutations — the counterpart of TanStack Query's <c>MutationFilters</c>.</summary>
public sealed class MutationFilters
{
    /// <summary>The mutation key to match, as a prefix unless <see cref="Exact"/> is set.</summary>
    public QueryKey? MutationKey { get; init; }

    /// <summary>Whether <see cref="MutationKey"/> must match exactly.</summary>
    public bool Exact { get; init; }

    /// <summary>Restricts to mutations in a particular state.</summary>
    public MutationStatus? Status { get; init; }

    /// <summary>An arbitrary extra condition.</summary>
    public Func<Mutation, bool>? Predicate { get; init; }

    /// <summary>Whether <paramref name="mutation"/> satisfies every criterion.</summary>
    public bool Matches(Mutation mutation)
    {
        ArgumentNullException.ThrowIfNull(mutation);

        if (MutationKey is not null)
        {
            if (mutation.Options.MutationKey is not { } key)
            {
                return false;
            }

            if (Exact)
            {
                if (key.Hash != MutationKey.Hash)
                {
                    return false;
                }
            }
            else if (!key.PartiallyMatches(MutationKey))
            {
                return false;
            }
        }

        if (Status is { } status && mutation.State.Status != status)
        {
            return false;
        }

        return Predicate is null || Predicate(mutation);
    }
}
