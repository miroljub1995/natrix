using Microsoft.Testing.Platform.Extensions.Messages;
using Natrix.Browser.TestHost.Protocol;

namespace Natrix.Browser.TestHost.Engine;

internal static class TestEventMapper
{
    public static TestEvent FromMessage(TestNodeUpdateMessage message)
    {
        var node = message.TestNode;
        var state = node.Properties.SingleOrDefault<TestNodeStateProperty>();
        var method = node.Properties.SingleOrDefault<TestMethodIdentifierProperty>();
        var location = node.Properties.SingleOrDefault<TestFileLocationProperty>();
        var timing = node.Properties.SingleOrDefault<TimingProperty>()?.GlobalTiming;
        var metadata = node.Properties.OfType<TestMetadataProperty>();

        var (stateName, explanation, exception) = Describe(state);

        return new TestEvent
        {
            Uid = node.Uid.Value,
            ParentUid = message.ParentTestNodeUid?.Value,
            DisplayName = node.DisplayName,
            State = stateName,
            Explanation = explanation,

            ExceptionType = exception?.GetType().FullName,
            ExceptionMessage = exception?.Message,
            ExceptionStackTrace = exception?.StackTrace,

            AssemblyFullName = method?.AssemblyFullName,
            Namespace = method?.Namespace,
            TypeName = method?.TypeName,
            MethodName = method?.MethodName,
            MethodArity = method?.MethodArity,
            ParameterTypeFullNames = method?.ParameterTypeFullNames,
            ReturnTypeFullName = method?.ReturnTypeFullName,

            FilePath = location?.FilePath,
            StartLine = location?.LineSpan.Start.Line,
            StartColumn = location?.LineSpan.Start.Column,
            EndLine = location?.LineSpan.End.Line,
            EndColumn = location?.LineSpan.End.Column,

            StartTime = timing?.StartTime,
            EndTime = timing?.EndTime,
            DurationMilliseconds = timing?.Duration.TotalMilliseconds,

            StandardOutput = node.Properties.SingleOrDefault<StandardOutputProperty>()?.StandardOutput,
            StandardError = node.Properties.SingleOrDefault<StandardErrorProperty>()?.StandardError,

            Metadata = metadata.Length == 0
                ? null
                : metadata.Select(m => new MetadataEntry { Key = m.Key, Value = m.Value }).ToArray(),
        };
    }

    private static (string State, string? Explanation, Exception? Exception) Describe(TestNodeStateProperty? state) =>
        state switch
        {
            null => (TestStates.Discovered, null, null),
            DiscoveredTestNodeStateProperty => (TestStates.Discovered, null, null),
            InProgressTestNodeStateProperty => (TestStates.InProgress, null, null),
            PassedTestNodeStateProperty p => (TestStates.Passed, p.Explanation, null),
            SkippedTestNodeStateProperty s => (TestStates.Skipped, s.Explanation, null),
            FailedTestNodeStateProperty f => (TestStates.Failed, f.Explanation, f.Exception),
            ErrorTestNodeStateProperty e => (TestStates.Error, e.Explanation, e.Exception),
            TimeoutTestNodeStateProperty t => (TestStates.Timeout, t.Explanation, t.Exception),
            CancelledTestNodeStateProperty c => (TestStates.Cancelled, c.Explanation, c.Exception),
            _ => (TestStates.Discovered, null, null),
        };
}
