namespace Natrix.Swr;

/// <summary>
/// The application's SWR configuration, published to the component tree so that
/// <see cref="SwrResource.Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
/// can find the cache from inside any component's <c>Setup</c> without it being threaded through
/// props.
/// </summary>
/// <remarks>
/// Registered by <see cref="NatrixHostBuilderSwrExtensions.UseSwr"/>, which builds it at mount —
/// after everything the application registered is in place — and publishes it to the tree. There
/// is no implicit fallback when it is missing: an app that forgot to register would otherwise get
/// a process-wide cache, which is exactly the wrong default on a server rendering one request
/// after another.
/// </remarks>
public sealed class SwrFeature
{
    /// <summary>
    /// Property the cache occupies in the page's hydration state.
    /// </summary>
    internal const string HydrationSection = "swr";

    public SwrFeature(SwrCache cache, SwrOptions? defaultOptions = null)
    {
        ArgumentNullException.ThrowIfNull(cache);
        defaultOptions?.Validate();

        Cache = cache;
        DefaultOptions = defaultOptions ?? SwrOptions.Default;
    }

    public SwrCache Cache { get; }

    /// <summary>
    /// Used by every <c>Use</c> call that does not pass its own options.
    /// </summary>
    public SwrOptions DefaultOptions { get; }

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
    internal void EnsureKeySegmentContract<TSegment>() =>
        Cache.KeyEncoder.GetSegmentTypeInfo(typeof(TSegment));
}
