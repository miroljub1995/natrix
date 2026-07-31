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
            // Own the mount pass so that queued mounted hooks run only once the whole
            // tree is in place. This has to sit outside the root component's Mount:
            // hydration only ends when HydrationRoot.Mount returns, and a hook running
            // before that would re-render against markup still being claimed.
            var lifecycleHooks = _rootFeatures.Get<ILifecycleHooksFeature>();
            var ownedPass = lifecycleHooks?.TryBeginPass() == true ? lifecycleHooks : null;

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

            ownedPass?.EndPassAndFlush();

            new Signals.Effect(onCleanup => onCleanup(() => rootComponent.Unmount()));
        });
        return scope;
    }
}
