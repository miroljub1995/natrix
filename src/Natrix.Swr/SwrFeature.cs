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
    public SwrFeature(SwrCache? cache = null, SwrOptions? defaultOptions = null)
    {
        defaultOptions?.Validate();

        Cache = cache ?? new SwrCache();
        DefaultOptions = defaultOptions ?? SwrOptions.Default;
    }

    public SwrCache Cache { get; }

    /// <summary>
    /// Used by every <c>Use</c> call that does not pass its own options.
    /// </summary>
    public SwrOptions DefaultOptions { get; }
}
