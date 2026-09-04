using System.Diagnostics;
using System.Text.Json;
using Natrix.Browser.TestHost.Protocol;
using System.Runtime.Versioning;

namespace Natrix.Browser.TestHost.Bridge;

/// <summary>
/// Discovers tests without a browser by running this same assembly on the host in
/// engine mode with <c>--list-tests</c>. TUnit's source-generated discovery never
/// touches the DOM, so it works anywhere the assembly loads.
/// </summary>
[UnsupportedOSPlatform("browser")]
internal static class EngineDiscovery
{
    public static async Task<List<TestEvent>> DiscoverAsync(CancellationToken cancellationToken)
    {
        var startInfo = new ProcessStartInfo(HostPaths.DotnetPath)
        {
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            WorkingDirectory = AppContext.BaseDirectory,
        };
        startInfo.ArgumentList.Add("exec");
        startInfo.ArgumentList.Add(HostPaths.EntryAssemblyPath);
        startInfo.ArgumentList.Add("--list-tests");
        startInfo.Environment[BrowserTestHost.ModeVariable] = BrowserTestHost.EngineMode;

        using var process = Process.Start(startInfo)
                            ?? throw new InvalidOperationException("Could not start the discovery process.");

        var events = new List<TestEvent>();
        var stderr = process.StandardError.ReadToEndAsync(cancellationToken);

        while (await process.StandardOutput.ReadLineAsync(cancellationToken) is { } line)
        {
            if (line.StartsWith(Wire.StdoutPrefix, StringComparison.Ordinal) &&
                JsonSerializer.Deserialize(line.AsSpan(Wire.StdoutPrefix.Length), ProtocolJsonContext.Default.TestEvent) is { } testEvent)
            {
                events.Add(testEvent);
            }
        }

        await process.WaitForExitAsync(cancellationToken);

        // Exit code 8 is "zero tests"; an empty project is not a discovery failure.
        if (process.ExitCode is not (0 or 8))
        {
            throw new InvalidOperationException(
                $"Test discovery failed with exit code {process.ExitCode}.{Environment.NewLine}{await stderr}");
        }

        return events;
    }
}
