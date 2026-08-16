namespace Natrix.Query;

/// <summary>
/// The clock and the timers the query engine runs on, so staleness, polling, retry backoff and
/// garbage collection are all driven by one substitutable source of time.
/// </summary>
/// <remarks>
/// Timer callbacks are posted back to the <see cref="SynchronizationContext"/> that was current
/// when the timer was scheduled. That is what keeps signal mutations on the UI thread in the
/// browser, and inside the SSR concurrency gate on the server, even though
/// <see cref="TimeProvider"/> fires its callbacks on a pool thread.
/// </remarks>
internal sealed class QueryScheduler(TimeProvider timeProvider)
{
    /// <summary>The longest delay a timer can express; anything above means "never".</summary>
    private static readonly TimeSpan MaxDelay = TimeSpan.FromMilliseconds(uint.MaxValue - 1);

    public TimeProvider TimeProvider { get; } = timeProvider;

    /// <summary>Now, in Unix milliseconds — the unit every timestamp in the cache uses.</summary>
    public long Now() => TimeProvider.GetUtcNow().ToUnixTimeMilliseconds();

    /// <summary>
    /// Whether a duration can be scheduled at all. Negative and "infinite" durations mean the
    /// timer must never fire, mirroring TanStack Query's <c>isValidTimeout</c>.
    /// </summary>
    public static bool IsValidTimeout(TimeSpan? duration) =>
        duration is { } value && value >= TimeSpan.Zero && value <= MaxDelay;

    /// <summary>
    /// Runs <paramref name="callback"/> once after <paramref name="delay"/>. Returns
    /// <c>null</c> when the delay is not schedulable, so callers can treat "no timer" and
    /// "never fires" identically.
    /// </summary>
    public IDisposable? Schedule(TimeSpan delay, Action callback)
    {
        if (!IsValidTimeout(delay))
        {
            return null;
        }

        return CreateTimer(delay, Timeout.InfiniteTimeSpan, callback);
    }

    /// <summary>Runs <paramref name="callback"/> every <paramref name="interval"/> until disposed.</summary>
    public IDisposable? ScheduleRepeating(TimeSpan interval, Action callback)
    {
        if (!IsValidTimeout(interval))
        {
            return null;
        }

        return CreateTimer(interval, interval, callback);
    }

    private IDisposable CreateTimer(TimeSpan dueTime, TimeSpan period, Action callback)
    {
        var context = SynchronizationContext.Current;

        return TimeProvider.CreateTimer(
            static state =>
            {
                var (context, callback) = ((SynchronizationContext?, Action))state!;
                if (context is null)
                {
                    callback();
                }
                else
                {
                    context.Post(static s => ((Action)s!)(), callback);
                }
            },
            (context, callback),
            dueTime,
            period);
    }
}
