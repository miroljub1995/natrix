using Natrix.Core.Components;
using Natrix.Core.Features;

namespace Natrix.Core.Hooks;

/// <summary>
/// Registers lifecycle callbacks against the component currently being set up.
///
/// The component is found through <see cref="AppFeatures.Current"/> rather than passed in,
/// so <c>Setup</c> can delegate to helpers and composable functions that register hooks
/// without either side knowing about the other. <see cref="BaseComponent{TProps, TEvents,
/// TSlots, TExpose}"/> re-exposes both methods so a component body can call them unqualified.
/// </summary>
public static class LifecycleHooks
{
    /// <summary>
    /// Runs the callback once the whole mount pass has completed, so it observes a
    /// finished tree. The parameter registers a matching cleanup, which — unlike
    /// <see cref="OnUnmounted"/> — is only reachable from a hook that actually ran.
    ///
    /// Callbacks are dropped where there is no live tree to act on (server rendering).
    /// </summary>
    public static void OnMounted(Action<Action<Action>> callback)
    {
        Current.OnMounted(callback);
    }

    /// <summary>
    /// Runs the callback when the component is torn down, regardless of whether its
    /// mounted hooks ever got to run: a component unmounted mid-flush still has whatever
    /// <c>Setup</c> created to release. Dropped without a live tree, for the same reason
    /// as <see cref="OnMounted"/>.
    /// </summary>
    public static void OnUnmounted(Action callback)
    {
        Current.OnUnmounted(callback);
    }

    /// <summary>
    /// Only resolvable while <see cref="AppFeatures.Current"/> points at a component's own
    /// layer, which the framework guarantees for the duration of its <c>Setup</c>. Calling
    /// from anywhere else — a click handler, a continuation after an <c>await</c>, a
    /// lifecycle callback — is a mistake rather than a no-op, so it throws.
    /// </summary>
    private static ComponentHooksFeature Current =>
        AppFeatures.Current?.Get<ComponentHooksFeature>()
        ?? throw new InvalidOperationException(
            "Lifecycle hooks can only be registered while a component is being set up.");
}
