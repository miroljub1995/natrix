namespace Natrix.Query;

/// <summary>
/// Defaults applied to queries that do not specify an option themselves — either client-wide
/// through <see cref="QueryClientConfig.DefaultOptions"/>, or for a family of keys through
/// <see cref="QueryClient.SetQueryDefaults"/>.
/// </summary>
/// <example>
/// <code>
/// var client = new QueryClient(new QueryClientConfig
/// {
///     DefaultOptions = new QueryClientDefaultOptions
///     {
///         Queries = new DefaultQueryOptions
///         {
///             StaleTime = TimeSpan.FromMinutes(1),
///             Retry = 2,
///         },
///     },
/// });
///
/// client.SetQueryDefaults(["todos"], new DefaultQueryOptions { StaleTime = TimeSpan.FromSeconds(30) });
/// </code>
/// </example>
public sealed class DefaultQueryOptions : QueryOptionsBase
{
    /// <summary>
    /// A query function used by every query that does not bring its own. Untyped, because the
    /// default applies across keys of different shapes.
    /// </summary>
    public Func<QueryFunctionContext, Task<object?>>? QueryFn { get; init; }

    /// <summary>
    /// Full control over how new data replaces old, taking precedence over
    /// <see cref="QueryOptionsBase.StructuralSharing"/>.
    /// </summary>
    public Func<object?, object?, object?>? StructuralSharingFn { get; init; }
}

/// <summary>The defaults a <see cref="QueryClient"/> is configured with.</summary>
public sealed class QueryClientDefaultOptions
{
    /// <summary>Defaults for every query.</summary>
    public DefaultQueryOptions? Queries { get; init; }

    /// <summary>Defaults for every mutation.</summary>
    public DefaultMutationOptions? Mutations { get; init; }
}
