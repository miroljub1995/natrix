using Natrix.Core.Features;

namespace Natrix.Ssr.Features;

public sealed class SsrTeleportFeatureFactory : ITeleportFeatureFactory
{
    public ITeleportFeature Create() => new TeleportFeature(false);
}
