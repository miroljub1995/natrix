using Natrix.Core;
using Natrix.Query.Features;

namespace Natrix.Query;

/// <summary>
/// Host wiring for Natrix Query — the counterpart of installing <c>VueQueryPlugin</c>.
/// </summary>
public static class NatrixHostBuilderQueryExtensions
{
    /// <summary>
    /// Makes <paramref name="client"/> available to every component in the app and starts it
    /// listening for focus and connectivity changes.
    /// </summary>
    /// <example>
    /// <code>
    /// new NatrixHostBuilder()
    ///     .UseRootElement(appElement)
    ///     .UseLifecycleHooks()
    ///     .UseQueryClient(new QueryClient())
    ///     .UseRootComponent(() => new App { Props = new AppProps() })
    ///     .Build()
    ///     .Mount();
    /// </code>
    /// </example>
    public static NatrixHostBuilder UseQueryClient(this NatrixHostBuilder builder, QueryClient client)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(client);

        client.Mount();
        return builder.SetFeature<IQueryClientFeature>(new QueryClientFeature(client));
    }

    /// <summary>Creates a client from <paramref name="config"/> and registers it.</summary>
    public static NatrixHostBuilder UseQueryClient(this NatrixHostBuilder builder, QueryClientConfig? config = null) =>
        builder.UseQueryClient(new QueryClient(config));
}
