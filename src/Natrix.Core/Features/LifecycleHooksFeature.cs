namespace Natrix.Core.Features;

/// <inheritdoc />
public sealed class LifecycleHooksFeature : ILifecycleHooksFeature
{
    /// <summary>
    /// Upper bound on hooks executed by a single flush. A hook may legitimately mount
    /// components whose own hooks join the same batch, but a pair of hooks that keep
    /// re-triggering each other would otherwise spin forever.
    /// </summary>
    private const int MaxDrainIterations = 10_000;

    private readonly Queue<Action> _queue = new();
    private bool _isCollecting;

    public bool TryBeginPass()
    {
        if (_isCollecting)
        {
            return false;
        }

        _isCollecting = true;
        return true;
    }

    public void QueueMountedHook(Action hook)
    {
        _queue.Enqueue(hook);
    }

    public void EndPassAndFlush()
    {
        var iterations = 0;

        // Dequeue one at a time while still collecting: hooks that mount new components
        // append to the end of this batch instead of running nested inside the current
        // hook, which keeps the order deterministic and the stack flat.
        while (_queue.Count > 0)
        {
            if (++iterations > MaxDrainIterations)
            {
                throw new InvalidOperationException(
                    $"Mounted hooks did not settle after {MaxDrainIterations} iterations. " +
                    "A hook most likely mounts components whose hooks re-trigger it.");
            }

            _queue.Dequeue()();
        }

        _isCollecting = false;
    }
}
