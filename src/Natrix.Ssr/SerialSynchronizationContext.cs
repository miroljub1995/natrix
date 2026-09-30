namespace Natrix.Ssr;

/// <summary>
/// A <see cref="SynchronizationContext"/> that runs at most one posted callback at a time.
/// </summary>
/// <remarks>
/// <para>
/// This is what lets a server render use the same lock-free signals as the browser. The browser
/// has one thread, so nothing in the reactive layer needs to be safe against a second one. On the
/// server every <c>await</c> resumes on an arbitrary thread-pool thread, and two continuations
/// writing signals at once would run effects, and mutate the tree, on two threads. Under this
/// context an <c>await</c> captures it, and its continuation is posted back here and waits its
/// turn, so the request's continuations run one at a time however many threads carry them: a
/// single-threaded event loop without the thread.
/// </para>
/// <para>
/// The gate is held only while a callback runs synchronously. A callback that awaits a network
/// call releases it at the await, so any number of requests can be in flight at once; only their
/// continuations are serialized.
/// </para>
/// <para>
/// Not FIFO by contract — <see cref="SemaphoreSlim"/> does not promise an order between waiters —
/// so two continuations that become ready at the same instant land in an unspecified order.
/// Nothing rendered on the server may depend on that order, and nothing in the framework does.
/// </para>
/// <para>
/// Owned by <see cref="SsrEventLoop"/>, one per request. Not disposable on purpose: a
/// continuation can arrive after the request has ended — a fetch abandoned by an aborted request,
/// say — and must still have a gate to run through rather than an exception to trip over. A
/// <see cref="SemaphoreSlim"/> that never handed out its wait handle holds nothing to release.
/// </para>
/// </remarks>
internal sealed class SerialSynchronizationContext : SynchronizationContext
{
    private readonly SemaphoreSlim _gate = new(1, 1);

    /// <summary>
    /// Raised when a posted callback throws. The async machinery keeps the exceptions of
    /// <c>async Task</c> methods in their tasks, so what reaches this is what has no task to go
    /// to: an <c>async void</c> method's failure, which the machinery rethrows through the
    /// context it captured.
    /// </summary>
    public event Action<Exception>? UnhandledException;

    public override SynchronizationContext CreateCopy() => this;

    public override void Post(SendOrPostCallback d, object? state)
    {
        ArgumentNullException.ThrowIfNull(d);

        // The task only ever completes: every failure inside is routed to UnhandledException.
        _ = RunAsync(d, state);
    }

    /// <summary>
    /// Synchronous dispatch is only possible from inside the gate — the caller already holds it,
    /// so the callback can run on the spot. From anywhere else it would have to block on a gate
    /// held by someone whose continuation may be waiting on the caller, which is a deadlock, so
    /// it is refused rather than attempted.
    /// </summary>
    public override void Send(SendOrPostCallback d, object? state)
    {
        ArgumentNullException.ThrowIfNull(d);

        if (!ReferenceEquals(Current, this))
        {
            throw new NotSupportedException(
                $"{nameof(SerialSynchronizationContext)} cannot run a callback synchronously from outside its "
                + "own callbacks.");
        }

        d(state);
    }

    private async Task RunAsync(SendOrPostCallback callback, object? state)
    {
        // A free gate is taken on the caller's thread and the callback runs before Post returns;
        // this is how a request's first segment runs on the thread that started it. ConfigureAwait
        // is deliberate: when the gate is busy the continuation must not go through the very
        // context it is trying to enter.
        await _gate.WaitAsync().ConfigureAwait(false);

        var previous = Current;
        SetSynchronizationContext(this);
        try
        {
            callback(state);
        }
        catch (Exception exception)
        {
            UnhandledException?.Invoke(exception);
        }
        finally
        {
            SetSynchronizationContext(previous);
            _gate.Release();
        }
    }
}
