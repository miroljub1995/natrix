namespace Natrix.Query.Tests.TestUtils;

/// <summary>
/// Runs a test body on a single thread with a queue-driven
/// <see cref="SynchronizationContext"/> and a clock that only moves when the test says so.
/// </summary>
/// <remarks>
/// The query engine mutates signals from continuations and timer callbacks, which in a browser
/// all land on the one UI thread. This harness reproduces that: every continuation is queued
/// and drained in order on the harness thread, so a test never races the code under test and
/// never has to sleep. <see cref="SettleAsync"/> is the one primitive tests need — it returns
/// once everything queued so far has run.
/// </remarks>
internal sealed class QueryTestHarness
{
    private readonly PumpSynchronizationContext _context;

    private QueryTestHarness(
        PumpSynchronizationContext context,
        TestTimeProvider time,
        QueryClient client,
        FocusManager focus,
        OnlineManager online)
    {
        _context = context;
        Time = time;
        Client = client;
        Focus = focus;
        Online = online;
    }

    /// <summary>The clock behind staleness, polling, retry backoff and garbage collection.</summary>
    public TestTimeProvider Time { get; }

    /// <summary>The client under test.</summary>
    public QueryClient Client { get; }

    /// <summary>Window focus, as the test chooses to report it.</summary>
    public FocusManager Focus { get; }

    /// <summary>Connectivity, as the test chooses to report it.</summary>
    public OnlineManager Online { get; }

    /// <summary>Runs <paramref name="body"/> against a fresh client on the harness thread.</summary>
    public static Task RunAsync(
        Func<QueryTestHarness, Task> body,
        QueryClientDefaultOptions? defaultOptions = null,
        QueryCache? cache = null)
    {
        ArgumentNullException.ThrowIfNull(body);

        // A dedicated thread, so the pump can block on its own queue without occupying a
        // thread-pool thread the test framework may need.
        return Task.Factory.StartNew(
            () => Run(body, defaultOptions, cache),
            CancellationToken.None,
            TaskCreationOptions.LongRunning,
            TaskScheduler.Default).Unwrap();
    }

    /// <summary>
    /// Returns once every callback queued so far has run — including the ones those callbacks
    /// queue in turn. The deterministic replacement for waiting on wall-clock time.
    /// </summary>
    public async Task SettleAsync()
    {
        // Yielding puts the rest of this method at the back of the queue, so everything ahead
        // of it has already run by the time it resumes; repeat until nothing is left.
        for (var i = 0; i < 1000; i++)
        {
            await Task.Yield();

            if (!_context.HasWork)
            {
                return;
            }
        }

        throw new InvalidOperationException("Queued work did not settle: something is scheduling callbacks forever.");
    }

    /// <summary>Moves the clock forward and lets everything it triggered run.</summary>
    public async Task AdvanceAsync(TimeSpan delta)
    {
        Time.Advance(delta);
        await SettleAsync();
    }

    /// <summary>Reports the app as focused (or not) and lets the refetches it triggers run.</summary>
    public async Task SetFocusedAsync(bool focused)
    {
        Focus.SetFocused(focused);
        await SettleAsync();
    }

    /// <summary>Reports connectivity and lets the fetches it resumes run.</summary>
    public async Task SetOnlineAsync(bool online)
    {
        Online.SetOnline(online);
        await SettleAsync();
    }

    private static Task Run(
        Func<QueryTestHarness, Task> body,
        QueryClientDefaultOptions? defaultOptions,
        QueryCache? cache)
    {
        var previous = SynchronizationContext.Current;
        var context = new PumpSynchronizationContext();
        SynchronizationContext.SetSynchronizationContext(context);

        try
        {
            var time = new TestTimeProvider();
            var focus = new FocusManager();
            var online = new OnlineManager();

            var client = new QueryClient(new QueryClientConfig
            {
                TimeProvider = time,
                FocusManager = focus,
                OnlineManager = online,
                DefaultOptions = defaultOptions,
                QueryCache = cache,
            });

            var harness = new QueryTestHarness(context, time, client, focus, online);
            client.Mount();

            var task = body(harness);
            context.PumpUntilCompleted(task);

            client.Unmount();
            client.Dispose();

            return task;
        }
        finally
        {
            SynchronizationContext.SetSynchronizationContext(previous);
        }
    }

    /// <summary>
    /// A synchronization context that only ever queues, plus the loop that drains it. One
    /// callback at a time, in the order posted.
    /// </summary>
    private sealed class PumpSynchronizationContext : SynchronizationContext
    {
        private readonly Queue<(SendOrPostCallback Callback, object? State)> _queue = new();

        public bool HasWork => _queue.Count > 0;

        public override void Post(SendOrPostCallback d, object? state) => _queue.Enqueue((d, state));

        public override void Send(SendOrPostCallback d, object? state) => d(state);

        public override SynchronizationContext CreateCopy() => this;

        public void PumpUntilCompleted(Task task)
        {
            var idleSpins = 0;

            while (!task.IsCompleted)
            {
                if (_queue.Count > 0)
                {
                    idleSpins = 0;
                    var (callback, state) = _queue.Dequeue();
                    callback(state);
                    continue;
                }

                // Nothing queued and the body has not finished: it is waiting on something
                // outside the harness (real I/O, another thread). Give it a moment, but do not
                // hang the suite forever.
                if (++idleSpins > 5_000)
                {
                    throw new TimeoutException(
                        "The test body never completed. It is most likely awaiting work that the harness " +
                        "does not drive — use SettleAsync/AdvanceAsync, or complete the awaited source " +
                        "from inside the harness thread.");
                }

                Thread.Sleep(1);
            }

            // Anything the body queued on its way out still deserves to run.
            while (_queue.Count > 0)
            {
                var (callback, state) = _queue.Dequeue();
                callback(state);
            }
        }
    }
}
