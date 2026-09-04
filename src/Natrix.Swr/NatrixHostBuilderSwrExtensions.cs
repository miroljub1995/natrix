using System.Text.Json;
using System.Text.Json.Nodes;
using Natrix.Browser.Abstractions.Features.HydrationState;
using Natrix.Core;
using Natrix.Core.Features;
using Natrix.Ssr.Abstractions.Features.HydrationState;

namespace Natrix.Swr;

public static class NatrixHostBuilderSwrExtensions
{
    /// <summary>
    /// Gives the application a cache, which is what
    /// <see cref="SwrResource.Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    /// binds components to, and attaches it to whichever side of the hydration boundary this host
    /// is on. Call it before mounting.
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
    /// How values travel from the server's render into the page the browser hydrates from: the
    /// server prefetches while it renders and writes the result into the page's hydration state,
    /// and the client picks it up instead of fetching the same data again. Pass the
    /// <c>Options</c> of a source-generated <c>JsonSerializerContext</c> covering every fetched
    /// type — the same one on both hosts — which is what keeps it trim-safe and AOT-safe.
    /// <para>
    /// Omit it only when the application registers its <see cref="JsonSerializerOptions"/> as a
    /// feature, which is what a server configuring its own endpoints does anyway; those are used
    /// instead. Ignored when <paramref name="cache"/> is given, since a cache already carries the
    /// options it was built with.
    /// </para>
    /// </param>
    /// <remarks>
    /// Registered as middleware rather than as a feature, because what it registers is built out
    /// of other features and there is no order in which registration alone could see them. This
    /// runs at mount instead, with everything in place, which is why nothing here is assigned
    /// after the fact.
    /// </remarks>
    /// <exception cref="InvalidOperationException">
    /// Thrown at mount: no cache was given and nothing describes the application's serialization.
    /// </exception>
    public static NatrixHostBuilder UseSwr(
        this NatrixHostBuilder builder,
        SwrOptions? defaultOptions = null,
        SwrCache? cache = null,
        JsonSerializerOptions? serializerOptions = null)
    {
        ArgumentNullException.ThrowIfNull(builder);

        return builder.Use(features =>
        {
            var resolved = cache ?? new SwrCache(
                // An application that already configures serialization - which a server does for
                // its own endpoints anyway - should not have to hand the same options over twice.
                serializerOptions ?? features.Get<JsonSerializerOptions>()
                ?? throw new InvalidOperationException(
                    $"SWR needs {nameof(JsonSerializerOptions)} to carry values from the server's render "
                    + "into the page the browser hydrates from. Pass them to UseSwr() or register them as "
                    + "a feature, using the resolver chain of the JsonSerializerContext both hosts share."));

            if (features.Get<IClientHydrationStateFeature>()?.Value[SwrFeature.HydrationSection] is JsonObject payload)
            {
                resolved.SeedFromHydration(payload);
            }

            if (features.Get<IServerHydrationStateFeature>() is { } server)
            {
                server.RegisterDehydrateCallback(
                    state => state[SwrFeature.HydrationSection] = resolved.Dehydrate());
            }

            features.Set(new SwrFeature(resolved, defaultOptions));
        });
    }
}
