using System.Reflection;
using ChromeForTesting;
using System.Runtime.Versioning;

namespace Natrix.Browser.TestHost.Bridge;

[UnsupportedOSPlatform("browser")]
internal static class HostPaths
{
    public const string BundleVariable = "NATRIX_BROWSER_TESTHOST_BUNDLE";
    public const string ChromeVariable = "NATRIX_BROWSER_TESTHOST_CHROME";

    /// <summary>The test assembly, which is also the entry assembly of the bridge process.</summary>
    public static string EntryAssemblyPath
    {
        get
        {
            var name = Assembly.GetEntryAssembly()?.GetName().Name
                       ?? throw new InvalidOperationException("The entry assembly is unknown.");
            return Path.Join(AppContext.BaseDirectory, name + ".dll");
        }
    }

    public static string BundleDirectory
    {
        get
        {
            var directory = Environment.GetEnvironmentVariable(BundleVariable) is { Length: > 0 } configured
                ? Path.GetFullPath(configured)
                : Path.Join(AppContext.BaseDirectory, "AppBundle");

            if (!File.Exists(Path.Join(directory, "_framework", "dotnet.js")))
            {
                throw new InvalidOperationException(
                    $"No wasm AppBundle at '{directory}'. Build the test project for browser-wasm first, " +
                    $"or point {BundleVariable} at the bundle.");
            }

            return directory;
        }
    }

    public static string ChromePath =>
        Environment.GetEnvironmentVariable(ChromeVariable) is { Length: > 0 } configured
            ? configured
            : ChromeForTestingInstance.ChromePath;
}
