using Natrix.Core.Features;

namespace Natrix.Browser.Features;

internal sealed class BrowserTeleportFeatureFactory : ITeleportFeatureFactory
{
    public ITeleportFeature Create() => new TeleportFeature(true);
}
