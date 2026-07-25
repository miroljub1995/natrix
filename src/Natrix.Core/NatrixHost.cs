using Natrix.Core.Components;
using Natrix.Core.Features;
using Natrix.Core.RenderRoot;

namespace Natrix.Core;

public sealed class NatrixHost
{
    private readonly Func<IComponent> _rootComponentFactory;
    private readonly IRenderRoot _renderRoot;
    private readonly IFeatureCollection _rootFeatures;

    internal NatrixHost(Func<IComponent> rootComponentFactory, IRenderRoot renderRoot, IFeatureCollection rootFeatures)
    {
        _rootComponentFactory = rootComponentFactory;
        _renderRoot = renderRoot;
        _rootFeatures = rootFeatures;
    }

    public IDisposable Mount()
    {
        var scope = new Signals.EffectScope();
        scope.Run(() =>
        {
            var prevFeatures = AppFeatures.Current;
            AppFeatures.Current = _rootFeatures;
            IComponent rootComponent;
            try
            {
                rootComponent = _rootComponentFactory();
                rootComponent.Mount(_renderRoot.CreateFirstSlot());
            }
            finally
            {
                AppFeatures.Current = prevFeatures;
            }

            new Signals.Effect(onCleanup => onCleanup(() => rootComponent.Unmount()));
        });
        return scope;
    }
}
