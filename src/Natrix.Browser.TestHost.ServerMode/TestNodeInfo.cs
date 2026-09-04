namespace Natrix.Browser.TestHost.ServerMode;

/// <summary>
/// One test node as reported over the server-mode protocol. Location keys are the
/// protocol's flattened form: the type is namespace-qualified and the method
/// carries its parameter list in parentheses when it has one.
/// </summary>
public sealed record TestNodeInfo(
    string Uid,
    string DisplayName,
    string? ParentUid,
    string? NodeType,
    string? ExecutionState,
    string? FilePath,
    int? LineStart,
    int? LineEnd,
    string? TypeFullName,
    string? MethodSignature,
    int? MethodArity,
    string? ErrorMessage,
    string? ErrorStackTrace,
    double? DurationMilliseconds,
    string? StandardOutput,
    string? StandardError);
