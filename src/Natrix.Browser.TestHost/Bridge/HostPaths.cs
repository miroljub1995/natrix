using System.Reflection;
using ChromeForTesting;
using System.Runtime.Versioning;

namespace Natrix.Browser.TestHost.Bridge;

[UnsupportedOSPlatform("browser")]
internal static class HostPaths
{
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
            var directory = Path.Join(AppContext.BaseDirectory, "AppBundle");

            if (!File.Exists(Path.Join(directory, "_framework", "dotnet.js")))
            {
                throw new InvalidOperationException(
                    $"No wasm AppBundle at '{directory}'. Build the test project for browser-wasm first.");
            }

            return directory;
        }
    }

    public static string ChromePath => ChromeForTestingInstance.ChromePath;
}
