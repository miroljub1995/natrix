using System.Runtime.InteropServices.JavaScript;
using Natrix.Core;
using Natrix.Core.Components;
using Natrix.Core.Features;
using Natrix.Core.Hooks;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.JSCore;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public abstract class BaseDomComponent<TElement, TProps, TEvents>(string tagName) : IComponent
    where TElement : Element
    where TProps : BaseDomComponentProps<TElement>
    where TEvents : BaseDomComponentEvents<TElement>
{
    private IRenderSlot? _slot;
    private ComposedComponent? _childrenComposed;
    private readonly List<Action> _eventCleanups = [];
    private bool _isUnmounted;

    protected abstract IComponent[]? GetChildren();

    protected abstract bool IsVoid { get; }

    public TProps? Props { get; init; }
    public TEvents? Events { get; init; }

    /// <summary>
    /// Optional signal the framework fills with the underlying element, and resets to
    /// <c>null</c> on unmount.
    /// </summary>
    /// <remarks>
    /// Populated only once the whole mount pass has completed, so it is <c>null</c>
    /// throughout <c>Setup</c> and readable from <c>OnMounted</c>. Writing it while the tree
    /// is still being built would let a watcher of the ref mutate state mid-mount: during
    /// hydration that re-render competes with the server-rendered markup still being
    /// claimed, surfacing as a <see cref="HydrationMismatchException"/>.
    /// </remarks>
    public ISignal<TElement?>? Ref { get; init; }

    public void Mount(IRenderSlot slot)
    {
        // Taken before the children mount so they queue into this pass rather than each
        // opening one of their own. During the initial mount the host already owns it, and
        // on the server there is no pass at all.
        var pass = AppFeatures.Current?.Get<ILifecycleHooksFeature>();
        var ownedPass = pass?.TryBeginPass() == true ? pass : null;

        var children = GetChildren();

        if (slot is IDomRenderSlot domRenderSlot)
        {
            if (!OperatingSystem.IsBrowser())
            {
                throw new PlatformNotSupportedException();
            }

            TElement element;
            var existingNode = domRenderSlot.TryHydrateSlot();
            if (existingNode is not null)
            {
                if (!string.Equals(existingNode.NodeName, tagName, StringComparison.OrdinalIgnoreCase))
                {
                    throw new HydrationMismatchException(
                        $"Hydration mismatch: expected <{tagName}> but found <{existingNode.NodeName.ToLowerInvariant()}>.");
                }

                element = JSObjectProxyFactory.GetProxy<TElement>(existingNode.JSObject);
            }
            else
            {
                element = (TElement)JSObjectProxyFactory.GetProxy<Window>(JSHost.GlobalThis).Document
                    .CreateElement(tagName);
            }

            var props = Props;
            Action<TElement> combinedEffect = static _ => { };
            props?.RegisterClientEffects(action => combinedEffect += action);
            new Effect(_ => combinedEffect(element));

            var events = Events;
            events?.RegisterClientEffects(effect => _eventCleanups.Add(effect(element)));

            if (!IsVoid && children?.Length > 0)
            {
                var childrenRoot = domRenderSlot.CreateChildRoot(element);
                if (domRenderSlot.IsHydrating)
                {
                    childrenRoot.BeginHydration();
                }

                _childrenComposed = new ComposedComponent(children);
                _childrenComposed.Mount(childrenRoot.CreateFirstSlot());

                childrenRoot.EndHydration();
            }

            if (existingNode is null)
            {
                domRenderSlot.Populate(element);
            }

            PublishRef(pass, element);
        }
        else if (slot is ISsrRenderSlot ssrRenderSlot)
        {
            var node = new SsrElementNode { TagName = tagName, IsVoid = IsVoid };

            var props = Props;
            props?.RegisterServerEffects(node);

            if (!IsVoid && children?.Length > 0)
            {
                var childrenRoot = ssrRenderSlot.CreateChildRoot(node);
                _childrenComposed = new ComposedComponent(children);
                _childrenComposed.Mount(childrenRoot.CreateFirstSlot());
            }

            ssrRenderSlot.Populate(node);
        }

        _slot = slot;

        ownedPass?.EndPassAndFlush();
    }

    /// <summary>
    /// Hands the ref assignment to the mount pass so it lands at the same moment mounted
    /// hooks do — once the tree is in place — instead of mid-mount.
    /// </summary>
    /// <remarks>
    /// The pass queue is FIFO and this element is a child of the component that owns the
    /// ref, so the assignment is always queued before that component's own hooks: a hook
    /// reading the ref sees the element.
    /// </remarks>
    private void PublishRef(ILifecycleHooksFeature? pass, TElement element)
    {
        var refSignal = Ref;
        if (refSignal is null)
        {
            return;
        }

        if (pass is null)
        {
            // No pass to defer to. Unlike a lifecycle hook a ref cannot simply be dropped,
            // so hosts that opt out of the pass keep the immediate assignment.
            refSignal.Value = element;
            return;
        }

        pass.QueueMountedHook(() =>
        {
            // An earlier hook in the same batch may have torn this element down; publishing
            // it now would leave the ref pointing at a detached element for good.
            if (_isUnmounted)
            {
                return;
            }

            DetachedContext.Run(() => refSignal.Value = element);
        });
    }

    public void Unmount()
    {
        _isUnmounted = true;

        if (_slot is IDomRenderSlot domRenderSlot)
        {
            if (!OperatingSystem.IsBrowser())
            {
                throw new PlatformNotSupportedException();
            }

            domRenderSlot.Empty();

            foreach (var cleanup in _eventCleanups)
            {
                cleanup();
            }
            _eventCleanups.Clear();
        }
        else if (_slot is ISsrRenderSlot ssrRenderSlot)
        {
            ssrRenderSlot.Empty();
        }

        _childrenComposed?.Unmount();
        _childrenComposed = null;
        _slot = null;

        if (Ref is not null)
        {
            Ref.Value = null;
        }
    }
}