using System.Text.Json;
using Microsoft.Testing.Platform.Extensions.Messages;
using Microsoft.Testing.Platform.Extensions.TestHost;
using Natrix.Browser.TestHost.Protocol;

namespace Natrix.Browser.TestHost.Engine;

/// <summary>
/// Forwards every test node update to the bridge over the JavaScript binding it
/// installed. On the host, where the engine only ever runs in server mode for
/// discovery, the platform itself reports to the bridge and this does nothing.
/// </summary>
internal sealed class TestEventSink : IDataConsumer
{
    public string Uid => "Natrix.Browser.TestHost.Engine.Sink";
    public string Version => "1.0.0";
    public string DisplayName => "Natrix browser test host";
    public string Description => "Relays test results to the browser test host.";

    public Type[] DataTypesConsumed => [typeof(TestNodeUpdateMessage)];

    public Task<bool> IsEnabledAsync() => Task.FromResult(true);

    public Task ConsumeAsync(IDataProducer dataProducer, IData value, CancellationToken cancellationToken)
    {
        if (OperatingSystem.IsBrowser() && value is TestNodeUpdateMessage message)
        {
            SinkInterop.Post(JsonSerializer.Serialize(TestEventMapper.FromMessage(message), ProtocolJsonContext.Default.TestEvent));
        }

        return Task.CompletedTask;
    }
}
