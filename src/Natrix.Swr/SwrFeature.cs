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
    private JsonSerializerOptions? _serializerOptions;
    private SwrKeyEncoder? _keyEncoder;
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
    /// application registered as a feature.
    ///
    /// Either way it wants the resolver chain of a source-generated <c>JsonSerializerContext</c>
    /// — that is what keeps the transfer trim-safe and AOT-safe, and it is why the contracts
    /// belong in a project both hosts reference.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// Read before <see cref="EnsureWired"/> resolved it, which cannot happen through
    /// <c>Use</c> — it wires the feature first.
    /// </exception>
    private JsonSerializerOptions SerializerOptions =>
        _serializerOptions
        ?? throw new InvalidOperationException($"{nameof(SwrFeature)} has not been wired yet.");

    /// <summary>
    /// How keys become cache keys. Built from the application's resolver but none of its
    /// formatting — see <see cref="SwrKeyEncoder"/> for why the two are separated.
    /// </summary>
    /// <inheritdoc cref="SerializerOptions" path="/exception"/>
    internal SwrKeyEncoder KeyEncoder =>
        _keyEncoder
        ?? throw new InvalidOperationException($"{nameof(SwrFeature)} has not been wired yet.");

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
        _serializerOptions = _explicitSerializerOptions ?? features.Get<JsonSerializerOptions>()
            ?? throw new InvalidOperationException(
                $"SWR needs {nameof(JsonSerializerOptions)} to carry values from the server's render "
                + "into the page the browser hydrates from. Pass them to UseSwr() or register them as "
                + "a feature, using the resolver chain of the JsonSerializerContext both hosts share.");

        // The contracts come from the application, the formatting does not; the cache is handed
        // the same encoder so that dropping a key by hand files it under the string a resource
        // binding that key would have produced.
        _keyEncoder = new SwrKeyEncoder(_serializerOptions.TypeInfoResolver);
        Cache.AttachKeyEncoder(_keyEncoder);

        if (features.Get<IClientHydrationStateFeature>()?.Value[HydrationSection] is JsonObject payload)
        {
            Cache.SeedFromHydration(payload);
        }

        if (features.Get<IServerHydrationStateFeature>() is { } server)
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
    /// <exception cref="InvalidOperationException">
    /// The configured options cannot describe <typeparamref name="TData"/>. Carrying on without
    /// it would only defer the failure to the hydration mismatch it causes.
    /// </exception>
    /// <remarks>
    /// Only meaningful after <see cref="EnsureWired"/>, which every <c>Use</c> call runs first.
    /// </remarks>
    /// <summary>
    /// Resolves the contract a key segment of <typeparamref name="TSegment"/> encodes under and
    /// discards it, for the typed <c>Use</c> overloads to call before they build anything.
    /// </summary>
    /// <remarks>
    /// Redundant for a key that binds straight away, which reaches the encoder inside <c>Use</c>
    /// regardless. It earns its place on the key that starts paused: that one has no segments to
    /// encode yet, so without this it carries the problem until something unpauses it and then
    /// reports it against whatever wrote that signal, rather than against the component holding
    /// the key.
    /// </remarks>
    /// <inheritdoc cref="SwrKeyEncoder.GetSegmentTypeInfo" path="/exception"/>
    internal void EnsureKeySegmentContract<TSegment>() => KeyEncoder.GetSegmentTypeInfo(typeof(TSegment));

    internal JsonTypeInfo<TData> GetTypeInfo<TData>()
    {
        // Read before the try so an unwired feature is not mistaken for a missing contract.
        var options = SerializerOptions;

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
