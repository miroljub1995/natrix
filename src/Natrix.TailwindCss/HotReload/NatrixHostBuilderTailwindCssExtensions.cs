using System.Reflection.Metadata;
using System.Runtime.Versioning;
using Natrix.Core;
using Natrix.Core.HotReload;

namespace Natrix.TailwindCss;

public static class NatrixHostBuilderTailwindCssExtensions
{
    /// <summary>
    /// Keeps the generated stylesheet up to date in the browser across hot reload deltas.
    /// </summary>
    /// <remarks>
    /// Chain this <em>after</em> <see cref="NatrixHostBuilderHotReloadExtensions.UseDefaultHotReloadManager"/>:
    /// it reads the hot reload manager that call registers, and does nothing when hot reload is
    /// unavailable and the feature is therefore absent.
    /// </remarks>
    /// <param name="getCss">The generated method, e.g. <c>Styles.GetCss</c>.</param>
    /// <param name="elementId">
    /// Id of the <c>&lt;style&gt;</c> element to update. Must match the id the server rendered it
    /// with; created if it does not exist.
    /// </param>
    [SupportedOSPlatform("browser")]
    public static NatrixHostBuilder UseTailwindCssHotReload(
        this NatrixHostBuilder builder,
        Func<string> getCss,
        string elementId = TailwindCssHotReload.StyleElementId)
    {
        // Redundant with the feature lookup below — the manager is only registered when hot
        // reload is supported — but this is the substituted feature switch, so a published app
        // trims everything behind it instead of carrying the updater and its DOM calls.
        if (!MetadataUpdater.IsSupported)
        {
            return builder;
        }

        if (builder.Features.Get<IHotReloadManager>() is { } manager)
        {
            // The subscription lives as long as the app does, so the handle is dropped.
            TailwindCssHotReload.Attach(manager, getCss, elementId);
        }

        return builder;
    }
}
