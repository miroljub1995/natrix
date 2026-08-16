using Natrix.Core;
using Natrix.Query.Tests.TestUtils;
using Natrix.Signals;
using Natrix.Ssr.RenderRoot;

using static Natrix.Query.NatrixQuery;

namespace Natrix.Query.Tests.Tests;

public class MutationTests
{
    [Test]
    public async Task A_mutation_goes_from_idle_through_pending_to_success()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new MutationObserver<string, int, object>(
                harness.Client,
                new UseMutationOptions<string, int>
                {
                    MutationFn = async value =>
                    {
                        await Task.Yield();
                        return $"saved {value}";
                    },
                });

            using var subscription = observer.Subscribe(_ => { });

            await Assert.That(observer.CurrentResult.IsIdle).IsTrue();

            var pending = observer.MutateAsync(7);

            await Assert.That(observer.CurrentResult.IsPending).IsTrue();
            await Assert.That(observer.CurrentResult.Variables).IsEqualTo(7);

            await harness.SettleAsync();
            var data = await pending;

            await Assert.That(data).IsEqualTo("saved 7");
            await Assert.That(observer.CurrentResult.IsSuccess).IsTrue();
            await Assert.That(observer.CurrentResult.Data).IsEqualTo("saved 7");
        });
    }

    [Test]
    public async Task A_failing_mutation_throws_from_MutateAsync_and_records_the_error()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new MutationObserver<string, int, object>(
                harness.Client,
                new UseMutationOptions<string, int>
                {
                    MutationFn = async _ =>
                    {
                        await Task.Yield();
                        throw new InvalidOperationException("boom");
                    },
                });

            using var subscription = observer.Subscribe(_ => { });

            var thrown = await Assert.ThrowsAsync<InvalidOperationException>(async () =>
                await observer.MutateAsync(1));

            await Assert.That(thrown!.Message).IsEqualTo("boom");
            await Assert.That(observer.CurrentResult.IsError).IsTrue();
            await Assert.That(observer.CurrentResult.Error!.Message).IsEqualTo("boom");
            await Assert.That(observer.CurrentResult.FailureCount).IsEqualTo(1);
        });
    }

    [Test]
    public async Task Mutate_does_not_throw_and_reports_failure_through_the_result()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new MutationObserver<string, int, object>(
                harness.Client,
                new UseMutationOptions<string, int>
                {
                    MutationFn = async _ =>
                    {
                        await Task.Yield();
                        throw new InvalidOperationException("boom");
                    },
                });

            using var subscription = observer.Subscribe(_ => { });

            observer.Mutate(1);
            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.IsError).IsTrue();
        });
    }

    [Test]
    public async Task The_callbacks_run_in_order_and_the_context_reaches_them()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var calls = new List<string>();

            var observer = new MutationObserver<string, int, string>(
                harness.Client,
                new UseMutationOptions<string, int, string>
                {
                    MutationFn = async value =>
                    {
                        calls.Add("mutationFn");
                        await Task.Yield();
                        return $"saved {value}";
                    },
                    OnMutate = _ =>
                    {
                        calls.Add("onMutate");
                        return Task.FromResult<string?>("snapshot");
                    },
                    OnSuccess = (_, _, context) =>
                    {
                        calls.Add($"onSuccess:{context}");
                        return Task.CompletedTask;
                    },
                    OnSettled = (_, _, _, context) =>
                    {
                        calls.Add($"onSettled:{context}");
                        return Task.CompletedTask;
                    },
                });

            using var subscription = observer.Subscribe(_ => { });

            await observer.MutateAsync(1);

            await Assert.That(calls).IsEquivalentTo(new[]
            {
                "onMutate",
                "mutationFn",
                "onSuccess:snapshot",
                "onSettled:snapshot",
            });
        });
    }

    [Test]
    public async Task A_failed_mutation_can_roll_back_what_OnMutate_wrote()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            harness.Client.SetQueryData<string[]>(["todos"], ["existing"]);

            var observer = new MutationObserver<string, string, string[]>(
                harness.Client,
                new UseMutationOptions<string, string, string[]>
                {
                    MutationFn = async _ =>
                    {
                        await Task.Yield();
                        throw new InvalidOperationException("rejected");
                    },
                    OnMutate = async title =>
                    {
                        await harness.Client.CancelQueriesAsync(new QueryFilters { QueryKey = ["todos"] });
                        var previous = harness.Client.GetQueryData<string[]>(["todos"]);
                        harness.Client.SetQueryData<string[]>(["todos"], todos => [.. todos ?? [], title]);
                        return previous;
                    },
                    OnError = (_, _, previous) =>
                    {
                        harness.Client.SetQueryData<string[]>(["todos"], previous);
                        return Task.CompletedTask;
                    },
                });

            using var subscription = observer.Subscribe(_ => { });

            observer.Mutate("optimistic");

            // The optimistic write is visible before the mutation resolves.
            await Assert.That(harness.Client.GetQueryData<string[]>(["todos"])!.Length).IsEqualTo(2);

            await harness.SettleAsync();

            await Assert.That(harness.Client.GetQueryData<string[]>(["todos"])!)
                .IsEquivalentTo(new[] { "existing" });
        });
    }

    [Test]
    public async Task Per_call_callbacks_run_for_the_call_that_registered_them()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var seen = new List<string>();

            var observer = new MutationObserver<string, int, object>(
                harness.Client,
                new UseMutationOptions<string, int>
                {
                    MutationFn = async value =>
                    {
                        await Task.Yield();
                        return $"saved {value}";
                    },
                });

            using var subscription = observer.Subscribe(_ => { });

            observer.Mutate(1, new MutateOptions<string, int>
            {
                OnSuccess = (data, variables) => seen.Add($"{variables}:{data}"),
                OnSettled = (_, _, variables) => seen.Add($"settled:{variables}"),
            });

            await harness.SettleAsync();

            await Assert.That(seen).IsEquivalentTo(new[] { "1:saved 1", "settled:1" });
        });
    }

    [Test]
    public async Task Mutations_do_not_retry_unless_asked_to()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var attempts = 0;

            var observer = new MutationObserver<string, int, object>(
                harness.Client,
                new UseMutationOptions<string, int>
                {
                    MutationFn = async _ =>
                    {
                        attempts++;
                        await Task.Yield();
                        throw new InvalidOperationException("boom");
                    },
                });

            using var subscription = observer.Subscribe(_ => { });

            observer.Mutate(1);
            await harness.SettleAsync();

            await Assert.That(attempts).IsEqualTo(1);

            var retrying = new MutationObserver<string, int, object>(
                harness.Client,
                new UseMutationOptions<string, int>
                {
                    Retry = 1,
                    RetryDelay = (_, _) => TimeSpan.FromMilliseconds(20),
                    MutationFn = async _ =>
                    {
                        attempts++;
                        await Task.Yield();
                        throw new InvalidOperationException("boom");
                    },
                });

            using var retryingSubscription = retrying.Subscribe(_ => { });

            retrying.Mutate(1);
            await harness.SettleAsync();
            await Assert.That(attempts).IsEqualTo(2);

            await harness.AdvanceAsync(TimeSpan.FromMilliseconds(20));
            await Assert.That(attempts).IsEqualTo(3);
        });
    }

    [Test]
    public async Task An_offline_mutation_pauses_and_resumes_when_the_connection_returns()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            await harness.SetOnlineAsync(false);

            var calls = 0;

            var observer = new MutationObserver<string, int, object>(
                harness.Client,
                new UseMutationOptions<string, int>
                {
                    MutationFn = async value =>
                    {
                        calls++;
                        await Task.Yield();
                        return $"saved {value}";
                    },
                });

            using var subscription = observer.Subscribe(_ => { });

            observer.Mutate(1);
            await harness.SettleAsync();

            await Assert.That(calls).IsEqualTo(0);
            await Assert.That(observer.CurrentResult.IsPending).IsTrue();
            await Assert.That(observer.CurrentResult.IsPaused).IsTrue();

            await harness.SetOnlineAsync(true);

            await Assert.That(calls).IsEqualTo(1);
            await Assert.That(observer.CurrentResult.IsSuccess).IsTrue();
            await Assert.That(observer.CurrentResult.IsPaused).IsFalse();
        });
    }

    [Test]
    public async Task Mutations_sharing_a_scope_run_one_after_another()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var order = new List<string>();
            var first = new TaskCompletionSource<string>(TaskCreationOptions.RunContinuationsAsynchronously);
            var second = new TaskCompletionSource<string>(TaskCreationOptions.RunContinuationsAsynchronously);

            MutationObserver<string, string, object> Observe(TaskCompletionSource<string> gate) =>
                new(harness.Client, new UseMutationOptions<string, string>
                {
                    Scope = new MutationScope("todos"),
                    MutationFn = variables =>
                    {
                        order.Add($"start {variables}");
                        return gate.Task;
                    },
                });

            var a = Observe(first);
            var b = Observe(second);

            using var aSubscription = a.Subscribe(_ => { });
            using var bSubscription = b.Subscribe(_ => { });

            a.Mutate("a");
            b.Mutate("b");
            await harness.SettleAsync();

            // The second is pending but held back until the first finishes.
            await Assert.That(order).IsEquivalentTo(new[] { "start a" });
            await Assert.That(b.CurrentResult.IsPaused).IsTrue();

            first.TrySetResult("done a");
            await harness.SettleAsync();

            await Assert.That(order).IsEquivalentTo(new[] { "start a", "start b" });

            second.TrySetResult("done b");
            await harness.SettleAsync();

            await Assert.That(a.CurrentResult.IsSuccess).IsTrue();
            await Assert.That(b.CurrentResult.IsSuccess).IsTrue();
        });
    }

    [Test]
    public async Task Resetting_returns_the_result_to_idle()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new MutationObserver<string, int, object>(
                harness.Client,
                new UseMutationOptions<string, int>
                {
                    MutationFn = value => Task.FromResult($"saved {value}"),
                });

            using var subscription = observer.Subscribe(_ => { });

            await observer.MutateAsync(1);
            await Assert.That(observer.CurrentResult.IsSuccess).IsTrue();

            observer.Reset();

            await Assert.That(observer.CurrentResult.IsIdle).IsTrue();
            await Assert.That(observer.CurrentResult.Data).IsNull();
        });
    }

    [Test]
    public async Task A_mutation_function_can_come_from_the_defaults_for_its_key()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            harness.Client.SetMutationDefaults(["todos"], new DefaultMutationOptions
            {
                MutationFn = variables => Task.FromResult<object?>($"default {variables}"),
            });

            var observer = new MutationObserver<string, string, object>(
                harness.Client,
                new UseMutationOptions<string, string> { MutationKey = ["todos", "add"] });

            using var subscription = observer.Subscribe(_ => { });

            var data = await observer.MutateAsync("x");

            await Assert.That(data).IsEqualTo("default x");
        });
    }

    [Test]
    public async Task Firing_a_mutation_with_no_function_at_all_fails_loudly()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new MutationObserver<string, string, object>(
                harness.Client,
                new UseMutationOptions<string, string>());

            using var subscription = observer.Subscribe(_ => { });

            await Assert.ThrowsAsync<MissingMutationFunctionException>(async () =>
                await observer.MutateAsync("x"));
        });
    }

    [Test]
    public async Task A_component_mutation_exposes_its_state_as_signals()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            UseMutationResult<string, int>? addTodo = null;
            IReadOnlySignal<int>? mutating = null;
            var gate = new TaskCompletionSource<string>(TaskCreationOptions.RunContinuationsAsynchronously);

            using var app = new NatrixHostBuilder()
                .UseRootRenderer(new SsrRenderRoot())
                .UseLifecycleHooks()
                .UseQueryClient(harness.Client)
                .UseRootComponent(() => new Probe
                {
                    Props = new ProbeProps
                    {
                        Setup = () =>
                        {
                            mutating = UseIsMutating();
                            addTodo = UseMutation(new UseMutationOptions<string, int>
                            {
                                MutationFn = _ => gate.Task,
                            });
                        },
                    },
                })
                .Build()
                .Mount();

            await Assert.That(addTodo!.IsIdle.Value).IsTrue();
            await Assert.That(mutating!.Value).IsEqualTo(0);

            addTodo.Mutate(1);
            await harness.SettleAsync();

            await Assert.That(addTodo.IsPending.Value).IsTrue();
            await Assert.That(mutating.Value).IsEqualTo(1);

            gate.TrySetResult("saved");
            await harness.SettleAsync();

            await Assert.That(addTodo.Data.Value).IsEqualTo("saved");
            await Assert.That(addTodo.IsSuccess.Value).IsTrue();
            await Assert.That(mutating.Value).IsEqualTo(0);
        });
    }

    [Test]
    public async Task Unmounting_the_component_releases_the_mutation_observer()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            UseMutationResult<string, int>? addTodo = null;

            var app = new NatrixHostBuilder()
                .UseRootRenderer(new SsrRenderRoot())
                .UseLifecycleHooks()
                .UseQueryClient(harness.Client)
                .UseRootComponent(() => new Probe
                {
                    Props = new ProbeProps
                    {
                        Setup = () => addTodo = UseMutation(new UseMutationOptions<string, int>
                        {
                            MutationFn = value => Task.FromResult($"saved {value}"),
                        }),
                    },
                })
                .Build()
                .Mount();

            await addTodo!.MutateAsync(1);
            await harness.SettleAsync();

            var mutation = harness.Client.MutationCache.GetAll().Single();
            await Assert.That(mutation.ObserversCount).IsEqualTo(1);

            app.Dispose();
            await harness.SettleAsync();

            await Assert.That(mutation.ObserversCount).IsEqualTo(0);
        });
    }

    [Test]
    public async Task A_finished_mutation_is_collected_once_nobody_is_watching()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new MutationObserver<string, int, object>(
                harness.Client,
                new UseMutationOptions<string, int>
                {
                    GcTime = TimeSpan.FromMinutes(1),
                    MutationFn = value => Task.FromResult($"saved {value}"),
                });

            var subscription = observer.Subscribe(_ => { });
            await observer.MutateAsync(1);
            await harness.SettleAsync();

            await Assert.That(harness.Client.MutationCache.GetAll().Count).IsEqualTo(1);

            subscription.Dispose();
            observer.Dispose();

            await harness.AdvanceAsync(TimeSpan.FromMinutes(2));

            await Assert.That(harness.Client.MutationCache.GetAll().Count).IsEqualTo(0);
        });
    }
}
