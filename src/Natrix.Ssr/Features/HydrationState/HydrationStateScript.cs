using Natrix.Core.Components;
using Natrix.Core.Features;
using Natrix.Dom.Features.HydrationState;
using Natrix.Ssr.Abstractions.Features.HydrationState;
using Natrix.Core.RenderRoot;
using Natrix.Signals;
using Natrix.Ssr.Abstractions.RenderRoot;

namespace Natrix.Ssr.Features.HydrationState;

public sealed class HydrationStateScript : IComponent
{
    public const string DefaultScriptElementId = HydrationStateDefaults.ScriptElementId;

    public IReadOnlySignal<string> ScriptElementId { get; init; } = new Signal<string>(DefaultScriptElementId);

    private IRenderSlot? _slot;

    public void Mount(IRenderSlot slot)
    {
        if (_slot is not null)
        {
            throw new InvalidOperationException("Component is already mounted.");
        }

        var serverFeature = AppFeatures.Features.Get<IServerHydrationStateFeature>()
            ?? throw new InvalidOperationException(
                $"{nameof(IServerHydrationStateFeature)} is not registered. " +
                $"Register {nameof(ServerHydrationStateFeature)} before mounting.");

        var jsonText = serverFeature.Dehydrate().ToJsonString();

        if (slot is not ISsrRenderSlot ssrRenderSlot)
        {
            throw new InvalidOperationException("HydrationStateScript requires an ISsrRenderSlot in SSR rendering.");
        }

        var scriptNode = new SsrElementNode { TagName = "script", IsVoid = false };
        scriptNode.SetAttribute("id", ScriptElementId);
        scriptNode.SetAttribute("type", new Signal<string>("application/json"));

        var childRoot = ssrRenderSlot.CreateChildRoot(scriptNode);
        if (childRoot.CreateFirstSlot() is ISsrRenderSlot textSlot)
        {
            textSlot.Populate(new SsrTextNode { TextContent = new Signal<string>(jsonText), Raw = true });
        }

        ssrRenderSlot.Populate(scriptNode);

        _slot = slot;
    }

    public void Unmount()
    {
        if (_slot is not ISsrRenderSlot ssrRenderSlot)
        {
            throw new InvalidOperationException("HydrationStateScript expected ISsrRenderSlot during unmount.");
        }

        ssrRenderSlot.Empty();
        _slot = null;
    }
}