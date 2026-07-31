namespace Natrix.Core.Features;

/// <summary>
/// Collects work that must not run while a tree is still being built, and runs it once the
/// mount pass has completed. Two things are deferred through it: component mounted hooks,
/// and the refs the framework publishes for mounted components and elements.
///
/// Both routinely feed signal mutations — a hook writes state outright, a ref wakes whoever
/// watches it — and a mutation during the pass re-renders a tree that is still being built:
/// during hydration the re-render competes with the server-rendered markup still being
/// claimed (surfacing as a hydration mismatch), and even on a pure client render it would
/// observe a half-built DOM whose later siblings are not attached yet.
///
/// Only registered by hosts that mount into a live tree. Where the feature is absent
/// (server rendering) hooks are dropped instead of run, so its presence — not the
/// platform — is what decides whether components have lifecycle hooks at all.
/// </summary>
public interface ILifecycleHooksFeature
{
    /// <summary>
    /// Takes ownership of a mount pass. Returns <c>false</c> when a pass is already in
    /// progress, in which case that owner is responsible for the flush.
    /// The caller must invoke <see cref="EndPassAndFlush"/> when it returns <c>true</c>.
    /// </summary>
    bool TryBeginPass();

    /// <summary>
    /// Ends the pass opened by <see cref="TryBeginPass"/> and runs everything queued in it.
    /// </summary>
    void EndPassAndFlush();

    /// <summary>
    /// Queues a single unit of post-mount work to run when the open pass ends, in the order
    /// queued. Only ever called while a pass is in progress, since mounting opens one.
    /// </summary>
    /// <remarks>
    /// Callers are responsible for running their own callback through
    /// <see cref="Hooks.DetachedContext"/>, so the guarantee does not depend on the
    /// implementation of this interface.
    /// </remarks>
    void QueueMountedHook(Action hook);
}
