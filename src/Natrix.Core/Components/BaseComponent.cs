using Natrix.Core.Features;
using Natrix.Core.Hooks;
using Natrix.Core.HotReload;
using Natrix.Core.RenderRoot;
using Natrix.Signals;

namespace Natrix.Core.Components;

/// <summary>
/// Base class for every Natrix component. A component declares its public contract through
/// four type parameters and builds its child tree once, inside <see cref="Setup"/>.
/// </summary>
/// <typeparam name="TProps">
/// Data flowing <b>into</b> the component. Must be an immutable POCO: every member is
/// <c>{ get; init; }</c>, and reactive values are passed as <see cref="IReadOnlySignal{T}"/>
/// so the child can read and react but never write. Use <see cref="NoProps"/> when the
/// component takes no input.
/// <para>
/// Props must <b>not</b> contain <see cref="Action"/>/<see cref="Func{TResult}"/> callbacks,
/// event handlers, or writable <see cref="ISignal{T}"/> instances — those are the job of
/// <typeparamref name="TEvents"/>. The only exception is <c>Func&lt;IComponent[]&gt;</c>-style
/// content factories, which belong in <typeparamref name="TSlots"/> rather than props.
/// </para>
/// </typeparam>
/// <typeparam name="TEvents">
/// Notifications flowing <b>out</b> of the component. Declare a partial class annotated with
/// <c>[GeneratedEvents]</c> containing <c>public partial void Xxx(...)</c> stubs; the source
/// generator derives it from <see cref="BaseEmits"/> and adds a matching <c>OnXxx</c> callback
/// property for the parent to assign. Event methods must return <c>void</c> — a component
/// notifies, it never asks the parent for a value. Use <see cref="NoEvents"/> when the
/// component emits nothing.
/// <para>
/// The framework calls <see cref="BaseEmits.Disable"/> on unmount, so emitting after teardown
/// is a no-op and parents never receive events from dead subtrees.
/// </para>
/// </typeparam>
/// <typeparam name="TSlots">
/// Content the parent injects into the component. A POCO whose members are
/// <c>Func&lt;IComponent[]&gt;</c> (or <c>Func&lt;T, IComponent[]&gt;</c> for scoped slots),
/// one per named slot. Use <see cref="NoSlots"/> when the component renders no parent content.
/// </typeparam>
/// <typeparam name="TExpose">
/// The imperative handle the component publishes through <see cref="Ref"/> — typically a
/// <c>record</c> of read-only signals and methods a parent may call. Use
/// <see cref="NoExpose"/> when nothing is exposed.
/// </typeparam>
/// <remarks>
/// <para><b>Data flow.</b> Props down, events up. A child never mutates a value it received
/// through props; it emits an event and lets the owner of the state perform the write.</para>
/// <para><b>Setup runs once.</b> <see cref="Setup"/> is invoked a single time per mount, not
/// on every change. Anything that must track state has to be reactive
/// (<see cref="Computed{T}"/>, <c>Effect</c>, or a signal passed straight into a child), because
/// values read imperatively inside <see cref="Setup"/> are snapshots.</para>
/// <para><b>Side effects.</b> DOM access, timers, subscriptions, and anything else touching the
/// outside world belong in <see cref="OnMounted"/>, registered with a matching cleanup, or in
/// <see cref="OnUnmounted"/>. Never perform them directly in <see cref="Setup"/>: during
/// server-side rendering and hydration the DOM is not available yet.</para>
/// <para><b>Instances are single-use.</b> A component object is mounted at most once; create a
/// new instance instead of re-mounting an existing one.</para>
/// </remarks>
/// <example>
/// <code>
/// public class CounterProps
/// {
///     public required IReadOnlySignal&lt;int&gt; Count { get; init; }
/// }
///
/// [GeneratedEvents]
/// public partial class CounterEvents
/// {
///     public partial void Increment(int by);
/// }
///
/// public class Counter : BaseComponent&lt;CounterProps, CounterEvents, NoSlots, NoExpose&gt;
/// {
///     protected override IComponent[] Setup(out NoExpose exposed)
///     {
///         exposed = default;
///         // Props.Count is read-only here; the parent owns the state.
///         return [/* children that call Events?.Increment(1) */];
///     }
/// }
/// </code>
/// </example>
public abstract class BaseComponent<TProps, TEvents, TSlots, TExpose> : IComponent
    where TProps : notnull
    where TEvents : BaseEmits
    where TSlots : notnull
    where TExpose : notnull
{
    // The component's reactive scope. With hot reload enabled this is the "hot
    // reload scope": it hosts the subscription (which must outlive mount teardowns)
    // plus a mount scope that is recreated on each delta and nested inside it.
    // With hot reload disabled it is simply the component's mount scope.
    private EffectScope? _effectScope;

    /// <summary>
    /// Immutable input supplied by the parent. Set once through the object initializer and
    /// never reassigned; reactivity comes from the signals it carries, not from replacing it.
    /// </summary>
    public required TProps Props { get; init; }

    /// <summary>
    /// Callbacks the parent hooks into. <c>null</c> when the parent ignores the component's
    /// events, so always emit through <c>Events?.Xxx(...)</c>.
    /// </summary>
    public TEvents? Events { get; init; }

    /// <summary>
    /// Content supplied by the parent. <c>null</c> when no slot content was provided, so
    /// always guard with <c>Slots?.Xxx?.Invoke() ?? []</c> or an explicit fallback.
    /// </summary>
    public TSlots? Slots { get; init; }

    /// <summary>
    /// Optional signal the framework fills with the <typeparamref name="TExpose"/> value
    /// returned from <see cref="Setup"/>, and resets to <c>default</c> on unmount. Reserved
    /// for imperative access the props/events flow cannot express.
    /// </summary>
    public ISignal<TExpose?>? Ref { get; init; }

    /// <inheritdoc cref="LifecycleHooks.OnMounted" />
    protected static void OnMounted(Action<Action<Action>> callback)
    {
        LifecycleHooks.OnMounted(callback);
    }

    /// <inheritdoc cref="LifecycleHooks.OnUnmounted" />
    protected static void OnUnmounted(Action callback)
    {
        LifecycleHooks.OnUnmounted(callback);
    }

    public void Mount(IRenderSlot slot)
    {
        var parentFeatures = AppFeatures.Current
            ?? throw new InvalidOperationException(
                "AppFeatures.Current must be set before mounting a component. " +
                "Components must be mounted via NatrixHost.Mount or as a child of another mounting component.");

        if (_effectScope is not null)
        {
            throw new InvalidOperationException("Component is already mounted.");
        }

        if (!HotReloadManager.IsSupported)
        {
            // No hot reload: the component scope IS the mount scope.
            _effectScope = RunMountScope(slot, parentFeatures);
        }
        else
        {
            // Hot reload: the scope hosts the subscription. The mount scope is created,
            // disposed, and recreated by the hot reload manager on each delta, nested
            // under this scope so a real unmount (disposing the scope) tears it down too.
            _effectScope = new();
            _effectScope.Run(() =>
                parentFeatures.SetupComponentHotReload(
                    this,
                    () => RunMountScope(slot, parentFeatures)));
        }
    }

    private EffectScope RunMountScope(IRenderSlot slot, IFeatureCollection parentFeatures)
    {
        var mountScope = new EffectScope();

        mountScope.Run(() =>
        {
            var hooks = new ComponentHooksFeature(parentFeatures.Get<ILifecycleHooksFeature>());

            // Components mounted by a later reactive update (an If branch flip, a ForEach
            // insertion) are not part of any pass, so the first one of them owns the flush.
            // During the initial mount NatrixHost already owns the pass.
            hooks.BeginPass();

            // Each component gets its own layer that falls back to the parent's features.
            // Writes inside Setup land only in this layer, so siblings are isolated.
            var ownFeatures = new FeatureCollection(parentFeatures);
            ownFeatures.Set(hooks);

            ComposedComponent composedComponent;

            var prevFeatures = AppFeatures.Current;
            AppFeatures.Current = ownFeatures;
            try
            {
                var setupResult = Setup(out TExpose exposed);

                var (openBound, closeBound) = slot.CreateComponentBounds();

                var extraCount = (openBound is not null ? 1 : 0) + (closeBound is not null ? 1 : 0);
                var children = new IComponent[setupResult.Length + extraCount];
                var idx = 0;
                if (openBound is not null)
                {
                    children[idx++] = openBound;
                }

                setupResult.CopyTo(children, idx);
                idx += setupResult.Length;

                if (closeBound is not null)
                {
                    children[idx] = closeBound;
                }

                composedComponent = new ComposedComponent(children);


                if (Ref is not null)
                {
                    Ref.Value = exposed;
                    new Effect(onCleanup => onCleanup(() => Ref.Value = default));
                }

                composedComponent.Mount(slot);
            }
            finally
            {
                AppFeatures.Current = prevFeatures;
            }

            // Created after the children mounted, so their hooks are already queued and
            // this component's land behind them: hooks run bottom-up.
            new Effect(onCleanup =>
            {
                hooks.QueueMountedHooks();

                onCleanup(() =>
                {
                    hooks.MarkUnmounted();

                    Events?.Disable();

                    composedComponent.Unmount();

                    hooks.RunUnmountedHooks();
                });
            });

            hooks.EndPassAndFlush();
        });

        return mountScope;
    }

    public void Unmount()
    {
        if (_effectScope is null)
        {
            throw new InvalidOperationException("Component is not mounted.");
        }

        _effectScope.Dispose();
        _effectScope = null;
    }

    /// <summary>
    /// Builds the component's child tree. Called exactly once per mount, before any child is
    /// rendered and before the DOM exists.
    /// </summary>
    /// <param name="exposed">
    /// The handle published through <see cref="Ref"/>. Assign <c>default</c> when
    /// <typeparamref name="TExpose"/> is <see cref="NoExpose"/>.
    /// </param>
    /// <returns>The child components to render, in order.</returns>
    /// <remarks>
    /// Create signals, <see cref="Computed{T}"/> values, and effects here, and register
    /// <see cref="OnMounted"/>/<see cref="OnUnmounted"/> hooks for anything that touches the
    /// DOM, timers, or external resources. Do not read signal values imperatively to decide
    /// what to return — wrap the dependent part in a reactive construct instead, otherwise the
    /// result is frozen at setup time.
    /// </remarks>
    protected abstract IComponent[] Setup(out TExpose exposed);
}