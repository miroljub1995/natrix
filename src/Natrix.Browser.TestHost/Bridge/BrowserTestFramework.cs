using System.Reflection;
using Microsoft.Testing.Platform.CommandLine;
using Microsoft.Testing.Platform.Extensions.Messages;
using Microsoft.Testing.Platform.Extensions.OutputDevice;
using Microsoft.Testing.Platform.Extensions.TestFramework;
using Microsoft.Testing.Platform.OutputDevice;
using Microsoft.Testing.Platform.Requests;
using Microsoft.Testing.Platform.Services;
using Microsoft.Testing.Platform.TestHost;
using Natrix.Browser.TestHost.Protocol;
using System.Runtime.Versioning;

namespace Natrix.Browser.TestHost.Bridge;

/// <summary>
/// The Microsoft.Testing.Platform test framework the host sees. Discovery runs the
/// engine on the host; execution runs it in the browser. Either way the results
/// arrive as <see cref="TestEvent"/>s and are republished as test nodes here.
/// </summary>
[UnsupportedOSPlatform("browser")]
internal sealed class BrowserTestFramework(IServiceProvider serviceProvider)
    : ITestFramework, IDataProducer, IOutputDeviceDataProducer
{
    private readonly ICommandLineOptions _options = serviceProvider.GetCommandLineOptions();
    private readonly IOutputDevice _output = serviceProvider.GetOutputDevice();
    private readonly bool _headed = BridgeCommandLineOptions.IsSet(serviceProvider.GetCommandLineOptions(), BridgeCommandLineOptions.HeadedOption, BridgeCommandLineOptions.HeadedVariable);
    private readonly bool _forwardAllConsole = BridgeCommandLineOptions.IsSet(serviceProvider.GetCommandLineOptions(), BridgeCommandLineOptions.ConsoleOption, BridgeCommandLineOptions.ConsoleVariable);

    // Discovery results by uid. An IDE discovers before it runs a selection, and a
    // uid alone is not enough to build the browser-side filter.
    private Dictionary<string, TestEvent>? _discovered;

    public string Uid => "Natrix.Browser.TestHost";
    public string Version => "1.0.0";
    public string DisplayName => "Natrix browser test host";
    public string Description => "Runs browser-wasm tests in headless Chromium.";

    public Type[] DataTypesProduced => [typeof(TestNodeUpdateMessage)];

    public Task<bool> IsEnabledAsync() => Task.FromResult(true);

    public Task<CreateTestSessionResult> CreateTestSessionAsync(CreateTestSessionContext context) =>
        Task.FromResult(new CreateTestSessionResult { IsSuccess = true });

    public Task<CloseTestSessionResult> CloseTestSessionAsync(CloseTestSessionContext context) =>
        Task.FromResult(new CloseTestSessionResult { IsSuccess = true });

    public async Task ExecuteRequestAsync(ExecuteRequestContext context)
    {
        try
        {
            switch (context.Request)
            {
                case DiscoverTestExecutionRequest discover:
                    await DiscoverAsync(context, discover);
                    break;
                case RunTestExecutionRequest run:
                    await RunAsync(context, run);
                    break;
            }
        }
        finally
        {
            context.Complete();
        }
    }

    private async Task DiscoverAsync(ExecuteRequestContext context, DiscoverTestExecutionRequest request)
    {
        var matcher = TreeNodeFilterText(request.Filter) is { } filter ? new TreeNodeFilterMatcher(filter) : null;
        var assembly = Assembly.GetEntryAssembly()?.GetName().Name;

        foreach (var testEvent in await EnsureDiscoveredAsync(context.CancellationToken, refresh: true))
        {
            if (matcher is null || matcher.Matches(assembly, testEvent.Namespace, testEvent.TypeName, testEvent.MethodName))
            {
                await PublishAsync(context, request.Session.SessionUid, testEvent, forceDiscovered: true);
            }
        }
    }

    /// <summary>
    /// The platform hands a parsed filter over when it registered <c>--treenode-filter</c>
    /// itself; when the bridge's own option provider did, only the raw text exists.
    /// </summary>
    private string? TreeNodeFilterText(ITestExecutionFilter filter)
    {
        if (filter is TreeNodeFilter treeFilter)
        {
            return treeFilter.Filter;
        }

        return _options.TryGetOptionArgumentList(BridgeCommandLineOptions.TreeNodeFilterOption, out var arguments) && arguments.Length == 1
            ? arguments[0]
            : null;
    }

    private async Task<IReadOnlyCollection<TestEvent>> EnsureDiscoveredAsync(CancellationToken cancellationToken, bool refresh)
    {
        if (_discovered is null || refresh)
        {
            _discovered = (await EngineDiscovery.DiscoverAsync(LogAsync, cancellationToken)).ToDictionary(e => e.Uid);
        }

        return _discovered.Values;
    }

    private async Task RunAsync(ExecuteRequestContext context, RunTestExecutionRequest request)
    {
        var engineArguments = new List<string>();
        HashSet<string>? requestedUids = null;

        switch (request.Filter)
        {
            case TestNodeUidListFilter uidFilter:
                // The platform's uid filter only exists in server mode, which the browser
                // cannot join. Translate the selection into a tree-node filter over the
                // discovered names. That can over-select (several classes sharing method
                // names), so results are also filtered by uid on the way back.
                requestedUids = uidFilter.TestNodeUids.Select(uid => uid.Value).ToHashSet();
                await EnsureDiscoveredAsync(context.CancellationToken, refresh: false);
                var selected = requestedUids.Select(uid => _discovered!.GetValueOrDefault(uid)).OfType<TestEvent>().ToArray();
                if (selected.Length == 0)
                {
                    await _output.DisplayAsync(this, new TextOutputDeviceData(
                        $"None of the {requestedUids.Count} selected tests exist in the current build; rebuild and rediscover."));
                    return;
                }

                engineArguments.Add("--treenode-filter");
                engineArguments.Add(TreeNodeFilterBuilder.Build(selected));
                break;

            default:
                if (TreeNodeFilterText(request.Filter) is { } treeFilter)
                {
                    engineArguments.Add("--" + BridgeCommandLineOptions.TreeNodeFilterOption);
                    engineArguments.Add(treeFilter);
                }

                break;
        }

        var options = new BrowserRunOptions { Headed = _headed, ForwardAllConsole = _forwardAllConsole };

        var bundle = HostPaths.BundleDirectory;
        var sawFailure = false;

        var exitCode = await BrowserRun.ExecuteAsync(
            bundle,
            engineArguments,
            options,
            async testEvent =>
            {
                // The engine's exit code covers every test it ran, including ones the
                // tree-node filter over-selected, so failures are counted before the
                // uid filter decides what the caller gets to see.
                sawFailure |= testEvent.State is TestStates.Failed or TestStates.Error or TestStates.Timeout;

                if (requestedUids is null || requestedUids.Contains(testEvent.Uid))
                {
                    await PublishAsync(context, request.Session.SessionUid, testEvent, forceDiscovered: false);
                }
            },
            text => _output.DisplayAsync(this, new TextOutputDeviceData(text)),
            context.CancellationToken);

        // The engine's own exit code is authoritative for anything the results do not
        // already show, such as a failing assembly hook or a filter that matched nothing.
        if (exitCode != 0 && !sawFailure)
        {
            throw new InvalidOperationException(
                $"The test application in the browser exited with code {exitCode}. " +
                "Re-run with --browser-console to see its output.");
        }
    }

    private Task PublishAsync(ExecuteRequestContext context, SessionUid session, TestEvent testEvent, bool forceDiscovered)
    {
        var node = new TestNode
        {
            Uid = new TestNodeUid(testEvent.Uid),
            DisplayName = testEvent.DisplayName,
        };

        node.Properties.Add(forceDiscovered ? DiscoveredTestNodeStateProperty.CachedInstance : StateProperty(testEvent));

        if (testEvent.MethodName is not null)
        {
            node.Properties.Add(new TestMethodIdentifierProperty(
                testEvent.AssemblyFullName ?? string.Empty,
                testEvent.Namespace ?? string.Empty,
                testEvent.TypeName ?? string.Empty,
                testEvent.MethodName,
                testEvent.MethodArity ?? 0,
                testEvent.ParameterTypeFullNames ?? [],
                testEvent.ReturnTypeFullName ?? string.Empty));
        }

        if (testEvent.FilePath is not null)
        {
            node.Properties.Add(new TestFileLocationProperty(
                testEvent.FilePath,
                new LinePositionSpan(
                    new LinePosition(testEvent.StartLine ?? 0, testEvent.StartColumn ?? 0),
                    new LinePosition(testEvent.EndLine ?? testEvent.StartLine ?? 0, testEvent.EndColumn ?? 0))));
        }

        if (testEvent is { StartTime: { } start, EndTime: { } end })
        {
            node.Properties.Add(new TimingProperty(new TimingInfo(start, end, end - start)));
        }

        if (testEvent.StandardOutput is { Length: > 0 } standardOutput)
        {
            node.Properties.Add(new StandardOutputProperty(standardOutput));
        }

        if (testEvent.StandardError is { Length: > 0 } standardError)
        {
            node.Properties.Add(new StandardErrorProperty(standardError));
        }

        foreach (var entry in testEvent.Metadata ?? [])
        {
            node.Properties.Add(new TestMetadataProperty(entry.Key, entry.Value));
        }

        var parent = testEvent.ParentUid is { } parentUid ? new TestNodeUid(parentUid) : null;
        return context.MessageBus.PublishAsync(this, new TestNodeUpdateMessage(session, node, parent));
    }

    private void LogAsync(string message)
    {
        if (_forwardAllConsole)
        {
            _ = _output.DisplayAsync(this, new TextOutputDeviceData("[discovery] " + message));
        }
    }

    private static TestNodeStateProperty StateProperty(TestEvent testEvent)
    {
        var exception = testEvent.ExceptionMessage is null
            ? null
            : new BrowserTestException(testEvent.ExceptionType ?? "Exception", testEvent.ExceptionMessage, testEvent.ExceptionStackTrace);

        return testEvent.State switch
        {
            TestStates.InProgress => InProgressTestNodeStateProperty.CachedInstance,
            TestStates.Passed => PassedTestNodeStateProperty.CachedInstance,
            TestStates.Skipped => new SkippedTestNodeStateProperty(testEvent.Explanation),
            TestStates.Failed => new FailedTestNodeStateProperty(exception ?? new BrowserTestException("Exception", testEvent.Explanation ?? "Failed", null), testEvent.Explanation),
            TestStates.Error => new ErrorTestNodeStateProperty(exception ?? new BrowserTestException("Exception", testEvent.Explanation ?? "Error", null), testEvent.Explanation),
            TestStates.Timeout => new TimeoutTestNodeStateProperty(exception ?? new BrowserTestException("Exception", testEvent.Explanation ?? "Timeout", null), testEvent.Explanation),
            TestStates.Cancelled => new CancelledTestNodeStateProperty(exception ?? new BrowserTestException("Exception", testEvent.Explanation ?? "Cancelled", null), testEvent.Explanation),
            _ => DiscoveredTestNodeStateProperty.CachedInstance,
        };
    }
}
