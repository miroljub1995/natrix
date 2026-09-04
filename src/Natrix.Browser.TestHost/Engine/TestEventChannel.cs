using System.Text.Json;
using Natrix.Browser.TestHost.Protocol;

namespace Natrix.Browser.TestHost.Engine;

/// <summary>
/// Where engine-side events go: the JavaScript binding in the browser, the raw
/// stdout stream on the host. TUnit swaps <see cref="Console.Out"/> for a per-test
/// interceptor, so the console writer cannot be used for the latter.
/// </summary>
internal static class TestEventChannel
{
    private static readonly Lazy<TextWriter> RawStandardOutput = new(() =>
        new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });

    public static void Post(TestEvent testEvent)
    {
        var json = JsonSerializer.Serialize(testEvent, ProtocolJsonContext.Default.TestEvent);

        if (OperatingSystem.IsBrowser())
        {
            SinkInterop.Post(json);
        }
        else
        {
            RawStandardOutput.Value.WriteLine(Wire.StdoutPrefix + json);
        }
    }
}
