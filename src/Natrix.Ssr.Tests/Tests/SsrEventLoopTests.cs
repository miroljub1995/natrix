namespace Natrix.Ssr.Tests.Tests;

public class SsrEventLoopTests
{
    [Test]
    public async Task Body_runs_on_the_loop_and_continuations_come_back_to_it()
    {
        SynchronizationContext? atStart = null;
        SynchronizationContext? afterAwait = null;

        await SsrEventLoop.RunAsync(async () =>
        {
            atStart = SynchronizationContext.Current;
            await Task.Delay(1);
            afterAwait = SynchronizationContext.Current;
        });

        await Assert.That(atStart is SerialSynchronizationContext).IsTrue();
        await Assert.That(afterAwait).IsSameReferenceAs(atStart);
    }

    [Test]
    public async Task Continuations_of_concurrent_tasks_never_overlap()
    {
        const int tasks = 32;
        const int hops = 20;

        var inside = 0;
        var maxInside = 0;

        await SsrEventLoop.RunAsync(async () =>
        {
            var running = new Task[tasks];
            for (var t = 0; t < tasks; t++)
            {
                running[t] = HopAsync();
            }

            await Task.WhenAll(running);
        });

        await Assert.That(maxInside).IsEqualTo(1);

        async Task HopAsync()
        {
            for (var i = 0; i < hops; i++)
            {
                // Real timers: each continuation arrives from a thread-pool thread of its own.
                await Task.Delay(1);

                // Deliberately unsynchronized, since exclusivity is what is being measured.
                var now = ++inside;
                maxInside = Math.Max(maxInside, now);
                Thread.SpinWait(2000);
                inside--;
            }
        }
    }

    [Test]
    public async Task Body_failure_faults_the_run()
    {
        var ex = await Assert.ThrowsAsync<InvalidOperationException>(
            () => SsrEventLoop.RunAsync(async () =>
            {
                await Task.Yield();
                throw new InvalidOperationException("body-failed");
            }));

        await Assert.That(ex!.Message).IsEqualTo("body-failed");
    }

    [Test]
    public async Task Async_void_failure_faults_the_run_without_waiting_for_the_body()
    {
        var release = new TaskCompletionSource();

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(
            () => SsrEventLoop.RunAsync(async () =>
            {
                FireAndForget();
                await release.Task;
            }));

        await Assert.That(ex!.Message).IsEqualTo("fire-and-forget-failed");

        release.SetResult();

        static async void FireAndForget()
        {
            await Task.Yield();
            throw new InvalidOperationException("fire-and-forget-failed");
        }
    }

    [Test]
    public async Task A_run_started_from_inside_a_loop_joins_it()
    {
        SynchronizationContext? outer = null;
        SynchronizationContext? inner = null;

        await SsrEventLoop.RunAsync(async () =>
        {
            outer = SynchronizationContext.Current;

            await SsrEventLoop.RunAsync(async () =>
            {
                await Task.Yield();
                inner = SynchronizationContext.Current;
            });
        });

        await Assert.That(inner).IsSameReferenceAs(outer);
    }

    [Test]
    public async Task Synchronous_dispatch_from_outside_the_loop_is_refused()
    {
        SynchronizationContext? context = null;

        await SsrEventLoop.RunAsync(() =>
        {
            context = SynchronizationContext.Current;
            return Task.CompletedTask;
        });

        await Assert.That(() => context!.Send(_ => { }, null)).Throws<NotSupportedException>();
    }
}
