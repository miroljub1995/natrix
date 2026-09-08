using Microsoft.Testing.Platform.Builder;
using Microsoft.Testing.Platform.Capabilities.TestFramework;
using System.Runtime.Versioning;

namespace Natrix.Browser.TestHost.Bridge;

/// <summary>
/// The host side: a Microsoft.Testing.Platform application whose test framework
/// is the browser.
/// </summary>
[UnsupportedOSPlatform("browser")]
internal static class BridgeApplication
{
    public static async Task<int> RunAsync(string[] args)
    {
        var builder = await TestApplication.CreateBuilderAsync(args);

        builder.CommandLine.AddProvider(() => new BridgeCommandLineOptions());
        builder.RegisterTestFramework(
            _ => new TestFrameworkCapabilities(),
            (_, serviceProvider) => new BrowserTestFramework(serviceProvider));

        using var app = await builder.BuildAsync();
        return await app.RunAsync();
    }
}
