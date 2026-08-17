using Natrix.Core;
using Natrix.Core.Features;

namespace Natrix.Swr;

/// <summary>
/// Entry point of the library — the equivalent of React SWR's <c>useSWR</c> hook.
///
/// Call <see cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, SwrOptions?)"/>
/// from a component's <c>Setup</c> and render from the signals it returns:
/// <code>
/// var user = SwrResource.Use(
///     () => ["user", Props.UserId.Value],
///     async (key, ct) => await api.GetUserAsync(key[1], ct));
/// </code>
/// </summary>
public static class SwrResource
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
    /// <param name="options">
    /// Overrides the application-wide defaults from <see cref="NatrixHostBuilderSwrExtensions.UseSwr"/>.
    /// </param>
    /// <remarks>
    /// Only valid inside <c>Setup</c>: the resource is scoped to the component, and takes the
    /// cache from the ambient features while they are the component's own.
    /// </remarks>
    /// <exception cref="InvalidOperationException">
    /// Called outside <c>Setup</c>, or the application never called <c>UseSwr</c>.
    /// </exception>
    public static SwrResource<TData> Use<TData>(
        Func<SwrKey> key,
        Func<SwrKey, CancellationToken, Task<TData>> fetcher,
        SwrOptions? options = null)
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(fetcher);

        var features = AppFeatures.Current
            ?? throw new InvalidOperationException(
                $"{nameof(SwrResource)}.{nameof(Use)} can only be called while a component is being set up.");

        var feature = features.Get<SwrFeature>()
            ?? throw new InvalidOperationException(
                $"No SWR cache is registered. Call {nameof(NatrixHostBuilderSwrExtensions.UseSwr)}() on the "
                + $"{nameof(NatrixHostBuilder)} before mounting.");

        var effectiveOptions = options ?? feature.DefaultOptions;
        effectiveOptions.Validate();

        return new SwrResource<TData>(feature.Cache, key, fetcher, effectiveOptions);
    }

    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, SwrOptions?)" />
    public static SwrResource<TData> Use<TData>(
        Func<SwrKey> key,
        Func<SwrKey, Task<TData>> fetcher,
        SwrOptions? options = null)
    {
        ArgumentNullException.ThrowIfNull(fetcher);

        return Use(key, (k, _) => fetcher(k), options);
    }

    /// <summary>
    /// Overload for a key that never changes.
    /// </summary>
    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, SwrOptions?)" />
    public static SwrResource<TData> Use<TData>(
        SwrKey key,
        Func<SwrKey, CancellationToken, Task<TData>> fetcher,
        SwrOptions? options = null) =>
        Use(() => key, fetcher, options);

    /// <summary>
    /// Overload for a key that never changes.
    /// </summary>
    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, SwrOptions?)" />
    public static SwrResource<TData> Use<TData>(
        SwrKey key,
        Func<SwrKey, Task<TData>> fetcher,
        SwrOptions? options = null)
    {
        ArgumentNullException.ThrowIfNull(fetcher);

        return Use(() => key, (k, _) => fetcher(k), options);
    }
}
