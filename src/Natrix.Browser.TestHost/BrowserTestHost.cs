using Microsoft.Testing.Platform.Builder;
using Natrix.Browser.TestHost.Bridge;
using Natrix.Browser.TestHost.Engine;

namespace Natrix.Browser.TestHost;

/// <summary>
/// Entry point for browser-wasm test projects. Call it from <c>Main</c>.
/// </summary>
/// <remarks>
/// The same assembly runs in two places. Inside the browser (or when
/// <c>NATRIX_BROWSER_TESTHOST_MODE=engine</c> is set) it is a Microsoft.Testing.Platform
/// test application, with the framework the caller registers. Anywhere else it is
/// a platform test framework that drives the browser: it discovers tests by running
/// the assembly again in engine mode on the host, and executes them by serving the
/// wasm bundle to headless Chromium and relaying the results.
/// </remarks>
public static class BrowserTestHost
{
    public const string ModeVariable = "NATRIX_BROWSER_TESTHOST_MODE";
    public const string EngineMode = "engine";

    /// <param name="args">The process arguments.</param>
    /// <param name="registerExtensions">
    /// Registers the test framework and any other extensions with the platform builder.
    /// The platform generates <c>SelfRegisteredExtensions.AddSelfRegisteredExtensions</c>
    /// into every test project for exactly this; pass that method.
    /// </param>
    public static Task<int> RunAsync(string[] args, Action<ITestApplicationBuilder, string[]> registerExtensions)
    {
        if (OperatingSystem.IsBrowser())
        {
            return EngineApplication.RunAsync(args, registerExtensions);
        }

        if (Environment.GetEnvironmentVariable(ModeVariable) == EngineMode)
        {
            return EngineApplication.RunAsync(args, registerExtensions);
        }

        return BridgeApplication.RunAsync(args);
    }
}
