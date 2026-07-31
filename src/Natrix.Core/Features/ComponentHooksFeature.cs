using Natrix.Core.Hooks;

namespace Natrix.Core.Features;

/// <summary>
/// Per-component store for lifecycle callbacks, published in the component's own feature
/// layer so that <c>Setup</c> — and anything it calls — can register hooks without a
/// reference to the component itself.
///
/// It only holds and runs the callbacks; <em>when</em> they run is decided by the
/// component, which hands the mounted hooks to the app-wide pass once its children are in
/// place and runs the unmounted ones during teardown.
/// </summary>
internal sealed class ComponentHooksFeature
{
    private readonly ILifecycleHooksFeature? _pass;
    private readonly List<Action<Action<Action>>> _mountedCallbacks = [];
    private readonly List<Action> _unmountedActions = [];
    private bool _ownsPass;
    private bool _isUnmounted;

    internal ComponentHooksFeature(ILifecycleHooksFeature? pass)
    {
        _pass = pass;
    }

    /// <summary>
    /// Runs once the whole mount pass has completed, so the callback observes a finished
    /// tree. The parameter registers a matching cleanup, which — unlike
    /// <see cref="OnUnmounted"/> — is only reachable from a hook that actually ran.
    ///
    /// The pass is the switch. It is registered by hosts that mount into a live tree;
    /// where it is absent (server rendering) there is nothing for a hook to act on, so the
    /// callback is dropped here rather than collected and never run.
    /// </summary>
    public void OnMounted(Action<Action<Action>> callback)
    {
        if (_pass is null)
        {
            return;
        }

        _mountedCallbacks.Add(callback);
    }

    /// <summary>
    /// Runs when the component is torn down, regardless of whether its mounted hooks ever
    /// got to run: a component unmounted mid-flush still has whatever <c>Setup</c> created
    /// to release. Dropped without a pass, for the same reason as
    /// <see cref="OnMounted"/>.
    /// </summary>
    public void OnUnmounted(Action callback)
    {
        if (_pass is null)
        {
            return;
        }

        _unmountedActions.Add(callback);
    }

    /// <summary>
    /// Takes ownership of a mount pass on this component's behalf, unless one is already
    /// open — during the initial mount <c>NatrixHost</c> owns it — or there is no pass at
    /// all. Pair with <see cref="EndPassAndFlush"/>, which is a no-op when this component
    /// is not the owner.
    /// </summary>
    internal void BeginPass()
    {
        _ownsPass = _pass?.TryBeginPass() ?? false;
    }

    /// <summary>
    /// Ends the pass this component opened and runs everything queued in it. Does nothing
    /// when the pass belongs to someone further up, who will flush it instead.
    /// </summary>
    internal void EndPassAndFlush()
    {
        if (_ownsPass)
        {
            _pass?.EndPassAndFlush();
        }
    }

    /// <summary>
    /// Hands the mounted hooks to the pass. Called after the component's children have
    /// mounted, which is what makes hooks run bottom-up: a child reaches this point first
    /// and so lands earlier in the pass queue.
    /// </summary>
    internal void QueueMountedHooks()
    {
        if (_pass is null)
        {
            return;
        }

        foreach (var callback in _mountedCallbacks)
        {
            var hook = callback;

            // One queue entry per callback, each with its own liveness check: an earlier
            // hook in the same batch may have torn this component down.
            _pass.QueueMountedHook(() =>
            {
                if (_isUnmounted)
                {
                    return;
                }

                DetachedContext.Run(() => hook(OnUnmounted));
            });
        }

        _mountedCallbacks.Clear();
    }

    /// <summary>
    /// Stops any hook still sitting in the pass queue from running.
    /// </summary>
    internal void MarkUnmounted()
    {
        _isUnmounted = true;
    }

    /// <summary>
    /// Runs the unmount callbacks. Empty without a pass, since nothing was registered.
    /// </summary>
    internal void RunUnmountedHooks()
    {
        DetachedContext.Run(() =>
        {
            foreach (var action in _unmountedActions)
            {
                action();
            }
        });

        _unmountedActions.Clear();
    }
}
