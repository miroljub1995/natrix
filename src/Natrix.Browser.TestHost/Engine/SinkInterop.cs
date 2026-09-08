using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace Natrix.Browser.TestHost.Engine;

[SupportedOSPlatform("browser")]
internal static partial class SinkInterop
{
    // Installed by the bridge with Runtime.addBinding before the page loads.
    [JSImport("globalThis." + Protocol.Wire.SinkBinding)]
    public static partial void Post(string json);
}
