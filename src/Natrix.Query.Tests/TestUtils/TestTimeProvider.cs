namespace Natrix.Query.Tests.TestUtils;

/// <summary>
/// A clock the test moves by hand. Timers fire synchronously inside
/// <see cref="Advance"/>, on the calling thread, so "five minutes later" is an ordinary
/// statement in a test rather than a real wait.
/// </summary>
internal sealed class TestTimeProvider : TimeProvider
{
    private readonly List<TestTimer> _timers = [];

    private DateTimeOffset _now = new(2026, 1, 1, 0, 0, 0, TimeSpan.Zero);

    public override DateTimeOffset GetUtcNow() => _now;

    public override ITimer CreateTimer(TimerCallback callback, object? state, TimeSpan dueTime, TimeSpan period)
    {
        var timer = new TestTimer(this, callback, state);
        _timers.Add(timer);
        timer.Change(dueTime, period);
        return timer;
    }

    /// <summary>
    /// Moves time forward, firing every timer that comes due on the way — in due order, with
    /// the clock set to each timer's own due time while it runs, so a callback that schedules
    /// another timer sees the time it actually fired at.
    /// </summary>
    public void Advance(TimeSpan delta)
    {
        var target = _now + delta;

        while (true)
        {
            var next = _timers
                .Where(timer => timer.DueAt is { } due && due <= target)
                .OrderBy(timer => timer.DueAt!.Value)
                .FirstOrDefault();

            if (next is null)
            {
                break;
            }

            _now = next.DueAt!.Value;
            next.Fire();
        }

        _now = target;
    }

    private void Remove(TestTimer timer) => _timers.Remove(timer);

    private sealed class TestTimer(TestTimeProvider provider, TimerCallback callback, object? state) : ITimer
    {
        private TimeSpan _period = Timeout.InfiniteTimeSpan;

        public DateTimeOffset? DueAt { get; private set; }

        public bool Change(TimeSpan dueTime, TimeSpan period)
        {
            _period = period;
            DueAt = dueTime == Timeout.InfiniteTimeSpan ? null : provider.GetUtcNow() + dueTime;
            return true;
        }

        public void Fire()
        {
            DueAt = _period == Timeout.InfiniteTimeSpan || _period <= TimeSpan.Zero
                ? null
                : provider.GetUtcNow() + _period;

            callback(state);
        }

        public void Dispose()
        {
            DueAt = null;
            provider.Remove(this);
        }

        public ValueTask DisposeAsync()
        {
            Dispose();
            return ValueTask.CompletedTask;
        }
    }
}
