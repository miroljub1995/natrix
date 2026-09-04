using Microsoft.Testing.Platform.Extensions.Messages;
using Microsoft.Testing.Platform.Extensions.TestHost;

namespace Natrix.Browser.TestHost.Engine;

/// <summary>
/// Forwards every test node update to the bridge.
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
        if (value is TestNodeUpdateMessage message)
        {
            TestEventChannel.Post(TestEventMapper.FromMessage(message));
        }

        return Task.CompletedTask;
    }
}
