using System.Globalization;
using Microsoft.Testing.Platform.ServerMode.Client;

namespace Natrix.Browser.TestHost.ServerMode;

/// <summary>
/// Drives a Microsoft.Testing.Platform test application in server mode: starts it
/// with the platform's <c>--server</c> arguments, lets it dial back over loopback
/// TCP, and speaks the same JSON-RPC an IDE would.
/// </summary>
public static class ServerModeTestApplication
{
    private const string LocationTypeKey = "location.type";
    private const string LocationMethodKey = "location.method";
    private const string LocationMethodArityKey = "location.method-arity";

    /// <summary>
    /// Runs a discovery request against the test application and returns every node
    /// it reported, in arrival order.
    /// </summary>
    /// <param name="assemblyPath">The test application's managed assembly.</param>
    /// <param name="environment">Environment variables for the child process.</param>
    /// <param name="log">Optional sink for the client's own diagnostics.</param>
    public static async Task<IReadOnlyList<TestNodeInfo>> DiscoverAsync(
        string assemblyPath,
        IReadOnlyDictionary<string, string?> environment,
        Action<string>? log,
        CancellationToken cancellationToken)
    {
        var options = new MtpServerClientOptions
        {
            ClientName = "Natrix.Browser.TestHost",
            ClientVersion = "1.0.0",
            Logger = log is null ? null : new DelegateLogger(log),
        };

        foreach (var (name, value) in environment)
        {
            options.EnvironmentVariables[name] = value;
        }

        var nodes = new List<TestNodeInfo>();
        var gate = new object();

        var client = await MtpServerClient.LaunchAsync(assemblyPath, options, cancellationToken);
        try
        {
            client.TestNodesUpdated += (_, update) =>
            {
                lock (gate)
                {
                    foreach (var change in update.Changes)
                    {
                        if (change.Uid is { Length: > 0 })
                        {
                            nodes.Add(Map(change));
                        }
                    }
                }
            };

            await client.InitializeAsync(cancellationToken);
            await client.DiscoverTestsAsync(cancellationToken);
            await client.ExitAsync(cancellationToken);
        }
        finally
        {
            await client.ShutdownAsync();
        }

        lock (gate)
        {
            return nodes.ToArray();
        }
    }

    /// <summary>
    /// Runs tests and reports every node update as it arrives. With no uids, runs
    /// everything.
    /// </summary>
    public static async Task RunAsync(
        string assemblyPath,
        IReadOnlyDictionary<string, string?> environment,
        IReadOnlyCollection<string>? testNodeUids,
        Action<TestNodeInfo> onUpdate,
        Action<string>? log,
        CancellationToken cancellationToken)
    {
        var options = new MtpServerClientOptions
        {
            ClientName = "Natrix.Browser.TestHost",
            ClientVersion = "1.0.0",
            Logger = log is null ? null : new DelegateLogger(log),
        };

        foreach (var (name, value) in environment)
        {
            options.EnvironmentVariables[name] = value;
        }

        var client = await MtpServerClient.LaunchAsync(assemblyPath, options, cancellationToken);
        try
        {
            client.TestNodesUpdated += (_, update) =>
            {
                foreach (var change in update.Changes)
                {
                    if (change.Uid is { Length: > 0 })
                    {
                        onUpdate(Map(change));
                    }
                }
            };

            await client.InitializeAsync(cancellationToken);
            if (testNodeUids is { Count: > 0 })
            {
                await client.RunTestsAsync(testNodeUids, cancellationToken);
            }
            else
            {
                await client.RunTestsAsync(cancellationToken);
            }

            await client.ExitAsync(cancellationToken);
        }
        finally
        {
            await client.ShutdownAsync();
        }
    }

    private static TestNodeInfo Map(MtpTestNodeUpdate change) => new(
        change.Uid!,
        change.DisplayName ?? change.Uid!,
        change.ParentUid,
        change.NodeType,
        change.ExecutionState,
        change.FilePath,
        change.LineStart,
        change.LineEnd,
        GetString(change, LocationTypeKey),
        GetString(change, LocationMethodKey),
        GetInt32(change, LocationMethodArityKey),
        change.ErrorMessage,
        change.ErrorStackTrace,
        change.DurationInMilliseconds,
        change.StandardOutput,
        change.StandardError);

    private static string? GetString(MtpTestNodeUpdate change, string key) =>
        change.Node.TryGetValue(key, out var value) ? value?.ToString() : null;

    private static int? GetInt32(MtpTestNodeUpdate change, string key) =>
        change.Node.TryGetValue(key, out var value) && value is not null
            ? value switch
            {
                int number => number,
                long number => checked((int)number),
                double number => (int)number,
                string text when int.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed) => parsed,
                _ => null,
            }
            : null;

    private sealed class DelegateLogger(Action<string> log) : IMtpClientLogger
    {
        public void Log(MtpClientLogLevel level, string message) => log($"[{level}] {message}");
    }
}
