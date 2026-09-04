using System.Text.Json.Serialization;

namespace Natrix.Browser.TestHost.Protocol;

/// <summary>
/// A flattened <c>TestNodeUpdateMessage</c>. Produced by the engine side (TUnit in
/// the browser, or on the host during discovery) and consumed by the bridge, which
/// turns it back into a test node for the host's Microsoft.Testing.Platform session.
/// </summary>
public sealed class TestEvent
{
    public required string Uid { get; init; }
    public string? ParentUid { get; init; }
    public required string DisplayName { get; init; }
    public required string State { get; init; }
    public string? Explanation { get; init; }

    public string? ExceptionType { get; init; }
    public string? ExceptionMessage { get; init; }
    public string? ExceptionStackTrace { get; init; }

    public string? AssemblyFullName { get; init; }
    public string? Namespace { get; init; }
    public string? TypeName { get; init; }
    public string? MethodName { get; init; }
    public int? MethodArity { get; init; }
    public string[]? ParameterTypeFullNames { get; init; }
    public string? ReturnTypeFullName { get; init; }

    public string? FilePath { get; init; }
    public int? StartLine { get; init; }
    public int? StartColumn { get; init; }
    public int? EndLine { get; init; }
    public int? EndColumn { get; init; }

    public DateTimeOffset? StartTime { get; init; }
    public DateTimeOffset? EndTime { get; init; }
    public double? DurationMilliseconds { get; init; }

    public string? StandardOutput { get; init; }
    public string? StandardError { get; init; }

    public MetadataEntry[]? Metadata { get; init; }
}

public sealed class MetadataEntry
{
    public required string Key { get; init; }
    public required string Value { get; init; }
}

public static class TestStates
{
    public const string Discovered = "discovered";
    public const string InProgress = "in-progress";
    public const string Passed = "passed";
    public const string Failed = "failed";
    public const string Error = "error";
    public const string Skipped = "skipped";
    public const string Timeout = "timeout";
    public const string Cancelled = "cancelled";
}

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(TestEvent))]
[JsonSerializable(typeof(string[]))]
internal sealed partial class ProtocolJsonContext : JsonSerializerContext;
