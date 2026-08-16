namespace Natrix.Query.Features;

/// <summary>
/// Publishes the <see cref="QueryClient"/> to a component tree. Components reach it through
/// <see cref="NatrixQuery.UseQueryClient"/>, which is the Natrix equivalent of Vue Query's
/// <c>provide</c>/<c>inject</c> of the client.
/// </summary>
public interface IQueryClientFeature
{
    /// <summary>The client every query in this part of the tree runs against.</summary>
    QueryClient Client { get; }
}

/// <inheritdoc />
public sealed class QueryClientFeature(QueryClient client) : IQueryClientFeature
{
    /// <inheritdoc />
    public QueryClient Client { get; } = client ?? throw new ArgumentNullException(nameof(client));
}
