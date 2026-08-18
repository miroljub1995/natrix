using System.Text.Json;
using Natrix.Core;

namespace Natrix.Swr;

public static class NatrixHostBuilderSwrExtensions
{
    /// <summary>
    /// Gives the application a cache, which is what
    /// <see cref="SwrResource.Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
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
    /// <param name="serializerOptions">
    /// Turns on the server-to-client transfer: the server prefetches while it renders and writes
    /// the result into the page's hydration state, and the client picks it up instead of
    /// fetching the same data again. Pass the <c>Options</c> of a source-generated
    /// <c>JsonSerializerContext</c> covering every fetched type — the same one on both hosts —
    /// which is what keeps it trim-safe and AOT-safe.
    /// <para>
    /// Omit it and nothing is transferred: server rendering emits the loading state and each
    /// client fetches for itself.
    /// </para>
    /// </param>
    public static NatrixHostBuilder UseSwr(
        this NatrixHostBuilder builder,
        SwrOptions? defaultOptions = null,
        SwrCache? cache = null,
        JsonSerializerOptions? serializerOptions = null)
    {
        ArgumentNullException.ThrowIfNull(builder);

        return builder.SetFeature(new SwrFeature(cache, defaultOptions, serializerOptions));
    }
}
