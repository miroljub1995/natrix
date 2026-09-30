using Natrix.Core.Features;

namespace Natrix.Ssr.Abstractions.Features;

public static class ServerPrefetchFeatureExtensions
{
    /// <summary>
    /// Registers an asynchronous prefetch callback on the <see cref="IServerPrefetchFeature"/>
    /// stored in <paramref name="features"/>. The token is cancelled when the request is. No-op
    /// when the feature is absent (e.g. client-side rendering), so the same component code is
    /// safe to use in both SSR and CSR.
    /// </summary>
    public static void OnServerPrefetch(this IFeatureCollection features, Func<CancellationToken, Task> callback)
    {
        ArgumentNullException.ThrowIfNull(features);
        ArgumentNullException.ThrowIfNull(callback);

        features.Get<IServerPrefetchFeature>()?.Register(callback);
    }

    /// <summary>
    /// <inheritdoc cref="OnServerPrefetch(IFeatureCollection, Func{CancellationToken, Task})"/>
    /// For callbacks with nothing to cancel.
    /// </summary>
    public static void OnServerPrefetch(this IFeatureCollection features, Func<Task> callback)
    {
        ArgumentNullException.ThrowIfNull(features);
        ArgumentNullException.ThrowIfNull(callback);

        features.Get<IServerPrefetchFeature>()?.Register(_ => callback());
    }
}
