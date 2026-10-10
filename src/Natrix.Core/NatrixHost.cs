using System.Collections.Concurrent;
using Natrix.Core.Components;
using Natrix.Core.Features;
using Natrix.Core.RenderRoot;

namespace Natrix.Core;

public sealed class NatrixHost
{
    /// <summary>
    /// Every host that is mounted and not yet disposed. Signals hold their consumers weakly, so a
    /// mounted tree is otherwise reachable only through whatever event handler happens to capture
    /// part of it, and a collection can take the rest - effects included - out from under a
    /// running app. The caller is not relied on to hold the returned handle: a Program that ends
    /// in <c>await Task.Delay(Timeout.Infinite)</c> roots nothing.
    /// </summary>
    private static readonly ConcurrentDictionary<MountedHost, byte> Mounted = new();
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

        var mounted = new MountedHost(scope);
        Mounted.TryAdd(mounted, 0);
        return mounted;
    }

    private sealed class MountedHost(Signals.EffectScope scope) : IDisposable
    {
        public void Dispose()
        {
            Mounted.TryRemove(this, out _);
            scope.Dispose();
        }
    }
}
