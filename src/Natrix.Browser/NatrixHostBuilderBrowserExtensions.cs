using System.Runtime.Versioning;
using Natrix.Browser.Features;
using Natrix.Core;
using Natrix.Core.Features;
using Natrix.StdWeb;

namespace Natrix.Browser;

public static class NatrixHostBuilderBrowserExtensions
{
    [SupportedOSPlatform("browser")]
    public static NatrixHostBuilder UseRootElement(this NatrixHostBuilder builder, Element element)
    {
        return builder.UseRootRenderer(new Natrix.Core.RenderRoot.DomRenderRoot(element));
    }

    [SupportedOSPlatform("browser")]
    public static NatrixHostBuilder UseTeleport(this NatrixHostBuilder builder)
    {
        return builder.SetFeature<ITeleportFeatureFactory>(new BrowserTeleportFeatureFactory());
    }
}
