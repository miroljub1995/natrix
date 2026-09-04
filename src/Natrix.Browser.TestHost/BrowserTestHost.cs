using Natrix.Browser.TestHost.Bridge;
using Natrix.Browser.TestHost.Engine;

namespace Natrix.Browser.TestHost;

/// <summary>
/// Entry point for browser-wasm test projects. Call it from <c>Main</c>.
/// </summary>
/// <remarks>
/// The same assembly runs in two places. Inside the browser (or when
/// <c>NATRIX_BROWSER_TESTHOST_MODE=engine</c> is set) it is a TUnit test
/// application. Anywhere else it is a Microsoft.Testing.Platform test framework
/// that drives the browser: it discovers tests by running the assembly again in
/// engine mode on the host, and executes them by serving the wasm bundle to
/// headless Chromium and relaying the results.
/// </remarks>
public static class BrowserTestHost
{
    public const string ModeVariable = "NATRIX_BROWSER_TESTHOST_MODE";
    public const string EngineMode = "engine";

    public static Task<int> RunAsync(string[] args)
    {
        if (OperatingSystem.IsBrowser() || Environment.GetEnvironmentVariable(ModeVariable) == EngineMode)
        {
            return EngineApplication.RunAsync(args);
        }

        return BridgeApplication.RunAsync(args);
    }
}
