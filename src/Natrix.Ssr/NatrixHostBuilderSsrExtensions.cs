using Natrix.Core.Features;
using Natrix.Core;
using Natrix.Ssr.Features;

namespace Natrix.Ssr;

public static class NatrixHostBuilderSsrExtensions
{
    public static NatrixHostBuilder UseTeleport(this NatrixHostBuilder builder)
    {
        return builder.SetFeature<ITeleportFeatureFactory>(new SsrTeleportFeatureFactory());
    }
}
