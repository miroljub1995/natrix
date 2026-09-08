using Natrix.Core;
using Natrix.Core.Features;
using Natrix.Ssr.Abstractions.Features;

namespace Natrix.Swr;

/// <summary>
/// Entry point of the library — the equivalent of React SWR's <c>useSWR</c> hook.
///
/// Call <see cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
/// from a component's <c>Setup</c> and render from the signals it returns:
/// <code>
/// var user = SwrResource.Use(
///     () => ("user", Props.UserId.Value),
///     async (key, ct) => await api.GetUserAsync(key.Item2, ct));
/// </code>
///
/// A key factory that returns a tuple gets the typed overloads, where the key's element types
/// flow into the fetcher's parameter — so the fetcher reads <c>key.Item2</c> as the <c>int</c> it
/// was, instead of a segment it has to know the position and the shape of. Overloads taking a
/// <see cref="SwrKey"/> remain for keys whose arity or types are not known at the call.
/// </summary>
public static partial class SwrResource
{
    /// <summary>
    /// Binds a component to a key and keeps it there, refetching whenever the key changes.
    /// </summary>
    /// <param name="key">
    /// Produces the key. Signals read inside are tracked, so a resource follows its inputs; the
    /// factory is re-evaluated on every change, and a resource rebinds only when the key it
    /// produces actually differs. Return <see cref="SwrKey.None"/> to pause fetching.
    /// </param>
    /// <param name="fetcher">
    /// Loads the data for a key. Called with the key it is loading — read the parameters back out
    /// of it rather than closing over signals, so the request always matches the key it is
    /// cached under. The token is cancelled when the request is superseded or when the last
    /// component watching the key goes away.
    /// </param>
    /// <param name="configure">
    /// Adjusts the application-wide defaults from <see cref="NatrixHostBuilderSwrExtensions.UseSwr"/>
    /// for this resource. It receives those defaults and returns the options to use, so a resource
    /// that cares about one setting says only that much and inherits the rest:
    /// <code>
    /// configure: options =&gt; options with { ErrorRetryCount = 1 }
    /// </code>
    /// Taking a whole <see cref="SwrOptions"/> instead would mean every caller silently replacing
    /// settings it never meant to have an opinion about.
    /// </param>
    /// <remarks>
    /// <para>
    /// Only valid inside <c>Setup</c>: the resource is scoped to the component, and takes the
    /// cache from the ambient features while they are the component's own.
    /// </para>
    /// <para>
    /// During server rendering, binding a key enqueues a prefetch the render waits for, so the
    /// markup ships with the data and the client hydrates it without fetching again.
    /// </para>
    /// </remarks>
    /// <exception cref="InvalidOperationException">
    /// Called outside <c>Setup</c>, the application never called <c>UseSwr</c>, or nothing
    /// describes <typeparamref name="TData"/> to the configured serializer.
    /// </exception>
    public static SwrResource<TData> Use<TData>(
        Func<SwrKey> key,
        Func<SwrKey, CancellationToken, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(fetcher);

        var features = AppFeatures.Features;
        var feature = features.GetRequired<SwrFeature>();

        var effectiveOptions = configure is null
            ? feature.DefaultOptions
            : configure(feature.DefaultOptions)
              ?? throw new ArgumentException("Returned null options.", nameof(configure));

        effectiveOptions.Validate();

        return new SwrResource<TData>(
            feature,
            key,
            fetcher,
            effectiveOptions,
            features.Get<IServerPrefetchFeature>());
    }

    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)" />
    public static SwrResource<TData> Use<TData>(
        Func<SwrKey> key,
        Func<SwrKey, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(fetcher);

        return Use(key, (k, _) => fetcher(k), configure);
    }

    /// <summary>
    /// Overload for a key that never changes.
    /// </summary>
    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)" />
    public static SwrResource<TData> Use<TData>(
        SwrKey key,
        Func<SwrKey, CancellationToken, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null) =>
        Use(() => key, fetcher, configure);

    /// <summary>
    /// Overload for a key that never changes.
    /// </summary>
    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)" />
    public static SwrResource<TData> Use<TData>(
        SwrKey key,
        Func<SwrKey, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(fetcher);

        return Use(() => key, (k, _) => fetcher(k), configure);
    }
}
