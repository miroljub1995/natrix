using System.Runtime.Versioning;

namespace Natrix.Browser.TestHost.Bridge;

/// <summary>
/// Re-materializes an exception that was thrown in the browser so the host's
/// test node carries the original message and stack trace.
/// </summary>
[UnsupportedOSPlatform("browser")]
internal sealed class BrowserTestException(string typeName, string message, string? stackTrace) : Exception(message)
{
    public string TypeName { get; } = typeName;

    public override string? StackTrace { get; } = stackTrace;

    public override string ToString() =>
        StackTrace is null ? $"{TypeName}: {Message}" : $"{TypeName}: {Message}{Environment.NewLine}{StackTrace}";
}
