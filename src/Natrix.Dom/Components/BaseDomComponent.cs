using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
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

    /// <summary>
    /// The children to mount.
    /// </summary>
    /// <param name="isSsr">Whether they are being rendered on the server. Elements whose content
    /// comes from a prop on the client, such as a <c>textarea</c>'s value, render that prop as their
    /// content there instead.</param>
    protected abstract IComponent[]? GetChildren(bool isSsr);

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

        if (slot is IDomRenderSlot domRenderSlot)
        {
            var children = GetChildren(isSsr: false);

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

            ApplyProps(element, afterChildren: false);

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

            ApplyProps(element, afterChildren: true);

            if (existingNode is null)
            {
                domRenderSlot.Populate(element);
            }

            PublishRef(pass, element);
        }
        else if (slot is ISsrRenderSlot ssrRenderSlot)
        {
            var children = GetChildren(isSsr: true);
            var node = new SsrElementNode { TagName = tagName, IsVoid = IsVoid };

            var props = Props;
            props?.RegisterServerEffects(node, afterChildren: false);

            if (!IsVoid && children?.Length > 0)
            {
                var childrenRoot = ssrRenderSlot.CreateChildRoot(node);
                _childrenComposed = new ComposedComponent(children);
                _childrenComposed.Mount(childrenRoot.CreateFirstSlot());
            }

            props?.RegisterServerEffects(node, afterChildren: true);

            ssrRenderSlot.Populate(node);
        }

        _slot = slot;

        ownedPass?.EndPassAndFlush();
    }

    [SupportedOSPlatform("browser")]
    private void ApplyProps(TElement element, bool afterChildren)
    {
        Action<TElement>? combinedEffect = null;
        Props?.RegisterClientEffects(action => combinedEffect += action, afterChildren);
        if (combinedEffect is not null)
        {
            new Effect(_ => combinedEffect(element));
        }
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