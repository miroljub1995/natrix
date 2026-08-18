using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization.Metadata;
using Natrix.Browser.Abstractions.Features.HydrationState;
using Natrix.Core.Features;
using Natrix.Ssr.Abstractions.Features.HydrationState;

namespace Natrix.Swr;

/// <summary>
/// The application's SWR configuration, published as a feature so that
/// <see cref="SwrResource.Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, SwrOptions?)"/>
/// can find the cache from inside any component's <c>Setup</c> without it being threaded through
/// props.
/// </summary>
/// <remarks>
/// Register it with <see cref="NatrixHostBuilderSwrExtensions.UseSwr"/>. There is no implicit
/// fallback when it is missing: an app that forgot to register would otherwise get a
/// process-wide cache, which is exactly the wrong default on a server rendering one request
/// after another.
/// </remarks>
public sealed class SwrFeature
{
    /// <summary>
    /// Property the cache occupies in the page's hydration state.
    /// </summary>
    internal const string HydrationSection = "swr";

    private bool _wired;

    public SwrFeature(
        SwrCache? cache = null,
        SwrOptions? defaultOptions = null,
        JsonSerializerOptions? serializerOptions = null)
    {
        defaultOptions?.Validate();

        Cache = cache ?? new SwrCache();
        DefaultOptions = defaultOptions ?? SwrOptions.Default;
        SerializerOptions = serializerOptions;
    }

    public SwrCache Cache { get; }

    /// <summary>
    /// Used by every <c>Use</c> call that does not pass its own options.
    /// </summary>
    public SwrOptions DefaultOptions { get; }

    /// <summary>
    /// How cached values cross from the server render to the client. Supply the options of a
    /// source-generated <c>JsonSerializerContext</c> — that is what keeps the transfer
    /// trim-safe and AOT-safe, and it is why the contracts belong in a project both sides
    /// reference.
    ///
    /// Leaving it null turns the transfer off: the server does not prefetch at all, and each
    /// client fetches for itself after hydration.
    /// </summary>
    public JsonSerializerOptions? SerializerOptions { get; }

    /// <summary>
    /// Attaches the cache to whichever side of the hydration boundary this host is on. Driven
    /// from the first <c>Use</c> call rather than from host construction, so it does not depend
    /// on the order features were registered in.
    /// </summary>
    internal void EnsureWired(IFeatureCollection features)
    {
        if (_wired)
        {
            return;
        }

        if (features.Get<IClientHydrationStateFeature>()?.Value[HydrationSection] is JsonObject payload)
        {
            if (SerializerOptions is null)
            {
                throw new InvalidOperationException(
                    "The page carries server-rendered SWR data but no serializer options are configured, "
                    + $"so it cannot be read. Pass the same {nameof(JsonSerializerOptions)} to UseSwr() on "
                    + "the client as on the server.");
            }

            Cache.SeedFromHydration(payload);
        }

        if (SerializerOptions is not null && features.Get<IServerHydrationStateFeature>() is { } server)
        {
            server.RegisterDehydrateCallback(state => state[HydrationSection] = Cache.Dehydrate());
        }

        // Set last: a misconfiguration reported above should keep being reported, and the
        // callback above must never be registered twice.
        _wired = true;
    }

    /// <summary>
    /// Resolves how <typeparamref name="TData"/> crosses the hydration boundary, at the
    /// <c>Use</c> call that introduced it rather than at render time, so a type missing from the
    /// serializer context is reported against the code that asked for it.
    /// </summary>
    internal JsonTypeInfo<TData>? GetTypeInfo<TData>()
    {
        if (SerializerOptions is null)
        {
            return null;
        }

        try
        {
            return (JsonTypeInfo<TData>)SerializerOptions.GetTypeInfo(typeof(TData));
        }
        catch (Exception exception) when (exception is InvalidOperationException or NotSupportedException)
        {
            throw new InvalidOperationException(
                $"The serializer options registered with UseSwr() have no metadata for {typeof(TData)}. "
                + $"Add [JsonSerializable(typeof({typeof(TData).Name}))] to the JsonSerializerContext shared "
                + "by the client and the server.",
                exception);
        }
    }
}
