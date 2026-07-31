using Natrix.Core.Components;
using Natrix.Core.Features;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.Features.RawText;
using Natrix.Ssr.Abstractions.RenderRoot;

namespace Natrix.Dom.Components;

/// <summary>
/// Wraps the children of an HTML raw text element (<c>script</c>, <c>style</c>) so that
/// <see cref="DomText"/> nested anywhere below sees an <see cref="ISsrRawTextFeature"/>
/// and writes its content verbatim during server rendering.
///
/// The feature layer is only established for SSR slots; on the client the children are
/// mounted directly, since text nodes are created through the DOM API and never escaped.
/// </summary>
internal sealed class SsrRawTextScope : IComponent
{
    public required IComponent[] Children { get; init; }

    private ComposedComponent? _composed;

    public void Mount(IRenderSlot slot)
    {
        _composed = new ComposedComponent(Children);

        if (slot is not ISsrRenderSlot)
        {
            _composed.Mount(slot);
            return;
        }

        var parentFeatures = AppFeatures.Current;
        var childFeatures = parentFeatures is null
            ? new FeatureCollection()
            : new FeatureCollection(parentFeatures);
        childFeatures.Set<ISsrRawTextFeature>(SsrRawTextFeature.Raw);

        AppFeatures.Current = childFeatures;
        try
        {
            _composed.Mount(slot);
        }
        finally
        {
            AppFeatures.Current = parentFeatures;
        }
    }

    public void Unmount()
    {
        _composed?.Unmount();
        _composed = null;
    }
}
