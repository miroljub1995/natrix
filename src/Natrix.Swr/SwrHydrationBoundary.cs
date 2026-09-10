using Natrix.Core.Components;
using Natrix.Core.Features;
using Natrix.Core.RenderRoot;

namespace Natrix.Swr;

/// <summary>
/// Draws the line the cache's hydration pass ends at: the return of the synchronous mount of
/// everything beneath it — the same boundary the browser's hydration root draws for the DOM. Keys
/// bound before that line were rendered by the server and hydrate from the payload; keys bound
/// after it are new requests, whatever the payload carried.
/// </summary>
/// <remarks>
/// Renders into the slot it is given and adds nothing to it, so it is invisible to the markup and
/// to hydration. On a host with no payload the pass was never open, and closing it does nothing.
/// </remarks>
internal sealed class SwrHydrationBoundary : IComponent
{
    public required Func<IComponent> Child { get; init; }

    private IComponent? _child;

    public void Mount(IRenderSlot slot)
    {
        var cache = AppFeatures.Features.GetRequired<SwrFeature>().Cache;

        // Closed even when the mount fails: a caller-supplied cache can outlive this host, and
        // left open the pass would keep handing out the payload to whatever mounts next.
        try
        {
            _child = Child();
            _child.Mount(slot);
        }
        finally
        {
            cache.EndHydration();
        }
    }

    public void Unmount()
    {
        _child?.Unmount();
        _child = null;
    }
}
