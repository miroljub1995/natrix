using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization.Metadata;
using Natrix.Browser.Abstractions.Features.HydrationState;
using Natrix.Core.Features;
using Natrix.Ssr.Abstractions.Features.HydrationState;

namespace Natrix.Swr;

/// <summary>
/// The application's SWR configuration, published as a feature so that
/// <see cref="SwrResource.Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
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

    private readonly JsonSerializerOptions? _explicitSerializerOptions;
    private bool _wired;

    public SwrFeature(
        SwrCache? cache = null,
        SwrOptions? defaultOptions = null,
        JsonSerializerOptions? serializerOptions = null)
    {
        defaultOptions?.Validate();

        Cache = cache ?? new SwrCache();
        DefaultOptions = defaultOptions ?? SwrOptions.Default;
        _explicitSerializerOptions = serializerOptions;
    }

    public SwrCache Cache { get; }

    /// <summary>
    /// Used by every <c>Use</c> call that does not pass its own options.
    /// </summary>
    public SwrOptions DefaultOptions { get; }

    /// <summary>
    /// How cached values cross from the server render to the client: the options passed to
    /// <c>UseSwr</c>, or failing that whichever <see cref="JsonSerializerOptions"/> the
    /// application registered as a feature. Resolved on first use, so it reads as null until a
    /// component has asked for a resource.
    ///
    /// Either way it wants the resolver chain of a source-generated <c>JsonSerializerContext</c>
    /// — that is what keeps the transfer trim-safe and AOT-safe, and it is why the contracts
    /// belong in a project both hosts reference.
    ///
    /// Null once resolved turns the transfer off: the server does not prefetch at all, and each
    /// client fetches for itself after hydration.
    /// </summary>
    public JsonSerializerOptions? SerializerOptions { get; private set; }

    /// <summary>
    /// Whether anything this host fetches can cross the hydration boundary, which is decided by
    /// <see cref="SerializerOptions"/> resolving to anything at all. It gates prefetching as well
    /// as transferring: data rendered into markup the browser has no way to read back is a
    /// hydration mismatch waiting to happen.
    /// </summary>
    /// <remarks>
    /// Only meaningful after <see cref="EnsureWired"/>, which every <c>Use</c> call runs first.
    /// </remarks>
    internal bool CanTransfer => SerializerOptions is not null;

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

        // An application that already configures serialization - which a server does for its own
        // endpoints anyway - should not have to hand the same options to UseSwr as well.
        SerializerOptions = _explicitSerializerOptions ?? features.Get<JsonSerializerOptions>();

        if (features.Get<IClientHydrationStateFeature>()?.Value[HydrationSection] is JsonObject payload)
        {
            if (SerializerOptions is null)
            {
                throw new InvalidOperationException(
                    "The page carries server-rendered SWR data but no serializer options are configured, "
                    + $"so it cannot be read. Register the same {nameof(JsonSerializerOptions)} as a feature "
                    + "on the client as on the server, or pass it to UseSwr().");
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
    /// <returns>
    /// The metadata for <typeparamref name="TData"/>, or <c>null</c> when this host transfers
    /// nothing at all and so has no boundary for it to cross — see <see cref="CanTransfer"/>. A
    /// type the configured options cannot describe throws instead: skipping it would leave the
    /// server rendering a value the client cannot read.
    /// </returns>
    /// <remarks>
    /// Only meaningful after <see cref="EnsureWired"/>, which every <c>Use</c> call runs first.
    /// </remarks>
    internal JsonTypeInfo<TData>? GetTypeInfo<TData>()
    {
        // Checked against the field rather than CanTransfer so the compiler carries the
        // non-nullness into the call below.
        if (SerializerOptions is not { } options)
        {
            return null;
        }

        try
        {
            return (JsonTypeInfo<TData>)options.GetTypeInfo(typeof(TData));
        }
        catch (Exception exception) when (exception is InvalidOperationException or NotSupportedException)
        {
            throw new InvalidOperationException(
                $"The serializer options in use have no metadata for {typeof(TData)}. Add "
                + $"[JsonSerializable(typeof({typeof(TData).Name}))] to the JsonSerializerContext shared by "
                + "the client and the server.",
                exception);
        }
    }
}
