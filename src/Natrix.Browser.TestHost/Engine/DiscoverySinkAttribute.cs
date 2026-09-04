using Natrix.Browser.TestHost.Protocol;
using TUnit.Core;
using TUnit.Core.Interfaces;

namespace Natrix.Browser.TestHost.Engine;

/// <summary>
/// Reports discovered tests on the host. <c>--list-tests</c> does not route test
/// node messages to data consumers, so <see cref="TestEventSink"/> sees nothing in
/// that mode; TUnit's own discovery event does fire. Applied to the test assembly
/// by the Natrix.Browser.TestHost targets.
/// </summary>
[AttributeUsage(AttributeTargets.Assembly)]
public sealed class DiscoverySinkAttribute : Attribute, ITestDiscoveryEventReceiver
{
    public int Order => int.MaxValue;

    public ValueTask OnTestDiscovered(DiscoveredTestContext context)
    {
        if (!OperatingSystem.IsBrowser())
        {
            TestEventChannel.Post(TestEventMapper.FromDiscovery(context));
        }

        return ValueTask.CompletedTask;
    }
}
