using Natrix.Core;

namespace Natrix.Swr;

public static class NatrixHostBuilderSwrExtensions
{
    /// <summary>
    /// Gives the application a cache, which is what
    /// <see cref="SwrResource.Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, SwrOptions?)"/>
    /// binds components to. Call it before mounting.
    /// </summary>
    /// <param name="defaultOptions">
    /// Applied to every resource that does not pass options of its own.
    /// </param>
    /// <param name="cache">
    /// An existing cache to mount against, when it has to outlive the host or be inspected from
    /// outside it. A fresh one per host otherwise, which is the right lifetime for a client app
    /// and the only safe one for a server rendering pass.
    /// </param>
    public static NatrixHostBuilder UseSwr(
        this NatrixHostBuilder builder,
        SwrOptions? defaultOptions = null,
        SwrCache? cache = null)
    {
        ArgumentNullException.ThrowIfNull(builder);

        return builder.SetFeature(new SwrFeature(cache, defaultOptions));
    }
}
