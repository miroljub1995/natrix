using Natrix.Core.Features;
using Natrix.Signals;

namespace Natrix.Core.Hooks;

/// <summary>
/// Runs a callback with no ambient context at all: no signal consumer, no effect scope and
/// no features.
///
/// Everything the mount pass defers — lifecycle hooks and component refs alike — runs at a
/// moment its author does not control: mid-flush, on whatever stack happened to end the
/// pass. Inheriting the ambient state of that moment is never right:
/// <list type="bullet">
/// <item>no consumer, so a signal read cannot register a dependency on the unrelated effect
/// that happened to trigger the callback;</item>
/// <item>no effect scope, so <c>new Effect(...)</c> throws instead of silently attaching to
/// a scope the component does not own — including the host scope that owns the initial
/// mount pass, which outlives every component in the tree;</item>
/// <item>no features, the same rule click handlers and post-await continuations already
/// follow — <c>If</c>, <c>ForEach</c> and <c>Teleport</c> re-establish the features they
/// captured at setup time whenever they mount later.</item>
/// </list>
/// </summary>
/// <remarks>
/// Detaching is the responsibility of whoever enqueues the work rather than of
/// <see cref="ILifecycleHooksFeature"/>, so the guarantee holds for any implementation of
/// that interface.
/// </remarks>
public static class DetachedContext
{
    /// <summary>
    /// Invokes <paramref name="callback"/> detached, restoring the previous ambient context
    /// afterwards even when it throws.
    /// </summary>
    public static void Run(Action callback)
    {
        var prevConsumer = ConsumerContext.Active;
        var prevScope = EffectScopeContext.Active;
        var prevFeatures = AppFeatures.Current;

        ConsumerContext.Active = null;
        EffectScopeContext.Active = null;
        AppFeatures.Current = null;
        try
        {
            callback();
        }
        finally
        {
            AppFeatures.Current = prevFeatures;
            EffectScopeContext.Active = prevScope;
            ConsumerContext.Active = prevConsumer;
        }
    }
}
