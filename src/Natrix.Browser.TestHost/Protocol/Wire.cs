namespace Natrix.Browser.TestHost.Protocol;

/// <summary>
/// The two channels a <see cref="TestEvent"/> travels over: a JavaScript binding
/// when the engine runs in the browser, and a prefixed stdout line when it runs
/// on the host for discovery.
/// </summary>
internal static class Wire
{
    /// <summary>Name of the function the bridge installs on <c>globalThis</c> via <c>Runtime.addBinding</c>.</summary>
    public const string SinkBinding = "__natrixTestSink";

    /// <summary>Marker at the start of every stdout line carrying a serialized event.</summary>
    public const string StdoutPrefix = "##natrix-test-event## ";
}
