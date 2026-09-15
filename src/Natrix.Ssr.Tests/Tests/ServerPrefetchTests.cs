using Natrix.Core;
using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Core.Features;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.Features;
using Natrix.Ssr.Features;
using Natrix.Ssr.RenderRoot;
using Natrix.Signals;

namespace Natrix.Ssr.Tests.Tests;

public class ServerPrefetchTests
{
    private sealed class HarnessProps
    {
        public required Action<IFeatureCollection> Setup { get; init; }
        public IComponent[] Children { get; init; } = [];
    }

    /// <summary>
    /// Generic component: invokes <see cref="HarnessProps.Setup"/> with the
    /// ambient features during Setup and renders any child components.
    /// </summary>
    private sealed class Harness : BaseComponent<HarnessProps, NoEvents, NoSlots, NoExpose>
    {
        protected override IComponent[] Setup(out NoExpose exposed)
        {
            Props.Setup(AppFeatures.Features);
            exposed = default;
            return Props.Children;
        }
    }

    /// <summary>
    /// Component that reads a string signal and renders it as text. Used to
    /// confirm prefetched values made it into the rendered output.
    /// </summary>
    private sealed class TextFromSignal : BaseComponent<ISignal<string>, BaseEmits, NoSlots, NoExpose>
    {
        protected override IComponent[] Setup(out NoExpose exposed)
        {
            exposed = default;
            return [new DomText { Text = Props }];
        }
    }

    private static NatrixHost BuildHost(
        ServerPrefetchFeature prefetch,
        Action<IFeatureCollection> setup,
        IComponent[]? children = null,
        SsrRenderRoot? root = null)
    {
        return new NatrixHostBuilder()
            .UseRootRenderer(root ?? new SsrRenderRoot())
            .SetFeature<IServerPrefetchFeature>(prefetch)
            .UseRootComponent(() => new Harness
            {
                Props = new HarnessProps { Setup = setup, Children = children ?? [] },
            })
            .Build();
    }

    [Test]
    public async Task Single_component_prefetch_is_awaited_before_render() => await SsrEventLoop.RunAsync(async () =>
    {
        var prefetch = new ServerPrefetchFeature();
        var root = new SsrRenderRoot();
        var text = new Signal<string>("loading");

        using var _ = BuildHost(
            prefetch,
            f => f.OnServerPrefetch(async () =>
            {
                await Task.Yield();
                text.Value = "hello";
            }),
            [new Div { Children = [new TextFromSignal { Props = text }] }],
            root).Mount();

        await prefetch.WaitForCompletionAsync();

        var output = await SsrHelpers.RenderAsync(root);
        await Assert.That(output).IsEqualTo("<!--[--><div><!--[-->hello<!--]--></div><!--]-->");
    });

    [Test]
    public async Task Callbacks_start_when_registered_and_run_concurrently() => await SsrEventLoop.RunAsync(async () =>
    {
        var prefetch = new ServerPrefetchFeature();
        var started = 0;
        var release = new TaskCompletionSource();

        using var _ = BuildHost(prefetch, f =>
        {
            for (var i = 0; i < 3; i++)
            {
                f.OnServerPrefetch(async () =>
                {
                    started++;
                    await release.Task;
                });
            }
        }).Mount();

        // All three are in flight before the drain is even asked for: registering is starting.
        // None can finish until released, so being past their first await together is what
        // shows they are not run one after another.
        await Assert.That(started).IsEqualTo(3);

        release.SetResult();
        await prefetch.WaitForCompletionAsync();
    });

    [Test]
    public async Task Multiple_components_register_and_all_complete() => await SsrEventLoop.RunAsync(async () =>
    {
        var prefetch = new ServerPrefetchFeature();
        var counts = new List<string>();

        // A plain list with no lock: continuations on the loop never overlap.
        using var _ = BuildHost(
            prefetch,
            f => f.OnServerPrefetch(async () =>
            {
                await Task.Yield();
                counts.Add("root");
            }),
            [
                new Harness
                {
                    Props = new HarnessProps
                    {
                        Setup = f => f.OnServerPrefetch(async () =>
                        {
                            await Task.Yield();
                            counts.Add("childA");
                        }),
                    },
                },
                new Harness
                {
                    Props = new HarnessProps
                    {
                        Setup = f => f.OnServerPrefetch(async () =>
                        {
                            await Task.Yield();
                            counts.Add("childB");
                        }),
                    },
                },
            ]).Mount();

        await prefetch.WaitForCompletionAsync();

        await Assert.That(counts).Contains("root");
        await Assert.That(counts).Contains("childA");
        await Assert.That(counts).Contains("childB");
        await Assert.That(counts.Count).IsEqualTo(3);
    });

    [Test]
    public async Task Cascading_registrations_during_drain_are_awaited() => await SsrEventLoop.RunAsync(async () =>
    {
        var prefetch = new ServerPrefetchFeature();
        var ran = new List<string>();

        using var _ = BuildHost(prefetch, f =>
        {
            f.OnServerPrefetch(async () =>
            {
                await Task.Yield();
                ran.Add("first");
                // Cascading registration during drain.
                f.OnServerPrefetch(async () =>
                {
                    await Task.Yield();
                    ran.Add("second");
                    f.OnServerPrefetch(async () =>
                    {
                        await Task.Yield();
                        ran.Add("third");
                    });
                });
            });
        }).Mount();

        await prefetch.WaitForCompletionAsync();

        await Assert.That(ran).IsEquivalentTo(new[] { "first", "second", "third" });
    });

    [Test]
    public async Task Prefetch_can_flip_If_branch_and_new_branch_prefetch_is_awaited() => await SsrEventLoop.RunAsync(async () =>
    {
        var prefetch = new ServerPrefetchFeature();
        var condition = new Signal<bool>(false);
        var ran = new List<string>();
        var root = new SsrRenderRoot();
        var text = new Signal<string>("loading");

        using var _ = BuildHost(
            prefetch,
            f =>
            {
                // Top-level prefetch: flips the If condition so the Then-branch
                // mounts mid-drain and registers its own prefetch.
                f.OnServerPrefetch(async () =>
                {
                    await Task.Yield();
                    ran.Add("outer");
                    condition.Value = true;
                });
            },
            [
                new If
                {
                    Condition = condition,
                    Then = () =>
                    [
                        new Harness
                        {
                            Props = new HarnessProps
                            {
                                Setup = f => f.OnServerPrefetch(async () =>
                                {
                                    await Task.Yield();
                                    ran.Add("inner");
                                    text.Value = "ready";
                                }),
                                Children = [new Div { Children = [new TextFromSignal { Props = text }] }],
                            },
                        },
                    ],
                },
            ],
            root).Mount();

        await prefetch.WaitForCompletionAsync();

        await Assert.That(ran).IsEquivalentTo(new[] { "outer", "inner" });
        var output = await SsrHelpers.RenderAsync(root);
        await Assert.That(output).IsEqualTo("<!--[--><!--[--><div><!--[-->ready<!--]--></div><!--]--><!--]-->");
    });

    [Test]
    public async Task Signal_writes_from_concurrent_callbacks_are_serialized() => await SsrEventLoop.RunAsync(async () =>
    {
        const int writers = 32;
        const int incrementsPerWriter = 50;

        var prefetch = new ServerPrefetchFeature();
        var counter = new Signal<int>(0);
        var observed = new List<int>();

        using var _ = BuildHost(prefetch, f =>
        {
            new Effect(_ => observed.Add(counter.Value));

            for (var w = 0; w < writers; w++)
            {
                // Real timers, so the continuations arrive from real thread-pool threads. An
                // unsynchronized read-modify-write on the signal would lose increments; the loop
                // is what makes it safe.
                f.OnServerPrefetch(async () =>
                {
                    for (var i = 0; i < incrementsPerWriter; i++)
                    {
                        await Task.Delay(1);
                        counter.Value = counter.Value + 1;
                    }
                });
            }
        }).Mount();

        await prefetch.WaitForCompletionAsync();

        await Assert.That(counter.Value).IsEqualTo(writers * incrementsPerWriter);
        // Initial run + one re-run per write, each ordered against every write.
        await Assert.That(observed.Count).IsEqualTo(writers * incrementsPerWriter + 1);
        for (var i = 1; i < observed.Count; i++)
        {
            await Assert.That(observed[i]).IsEqualTo(observed[i - 1] + 1);
        }
    });

    [Test]
    public async Task OnServerPrefetch_is_no_op_when_feature_absent()
    {
        var ran = false;

        using var _ = new NatrixHostBuilder()
            .UseRootRenderer(new SsrRenderRoot())
            .UseRootComponent(() => new Harness
            {
                Props = new HarnessProps
                {
                    Setup = f => f.OnServerPrefetch(async () =>
                    {
                        await Task.Yield();
                        ran = true;
                    }),
                },
            })
            .Build()
            .Mount();

        await Assert.That(ran).IsFalse();
    }

    [Test]
    public async Task Drain_continues_past_failures_and_aggregates_errors() => await SsrEventLoop.RunAsync(async () =>
    {
        var prefetch = new ServerPrefetchFeature();
        var ran = new List<string>();

        using var _ = BuildHost(prefetch, f =>
        {
            f.OnServerPrefetch(async () =>
            {
                await Task.Yield();
                ran.Add("a");
                throw new InvalidOperationException("a-failed");
            });
            f.OnServerPrefetch(async () =>
            {
                await Task.Yield();
                ran.Add("b");
            });
            f.OnServerPrefetch(async () =>
            {
                await Task.Yield();
                ran.Add("c");
                throw new InvalidOperationException("c-failed");
            });
        }).Mount();

        var ex = await Assert.ThrowsAsync<AggregateException>(
            async () => await prefetch.WaitForCompletionAsync());

        await Assert.That(ran).IsEquivalentTo(new[] { "a", "b", "c" });
        await Assert.That(ex!.InnerExceptions.Count).IsEqualTo(2);
        await Assert.That(ex.InnerExceptions[0].Message).IsEqualTo("a-failed");
        await Assert.That(ex.InnerExceptions[1].Message).IsEqualTo("c-failed");
    });

    [Test]
    public async Task A_callback_that_throws_before_its_first_await_fails_the_drain_not_the_mount() => await SsrEventLoop.RunAsync(async () =>
    {
        var prefetch = new ServerPrefetchFeature();

        // Mounts: the failure belongs to the prefetch, not to the Setup that registered it.
        using var _ = BuildHost(prefetch, f =>
            f.OnServerPrefetch(_ => throw new InvalidOperationException("sync-failed"))).Mount();

        var ex = await Assert.ThrowsAsync<AggregateException>(
            async () => await prefetch.WaitForCompletionAsync());

        await Assert.That(ex!.InnerExceptions).HasSingleItem();
        await Assert.That(ex.InnerExceptions[0].Message).IsEqualTo("sync-failed");
    });

    [Test]
    public async Task Empty_drain_completes_successfully()
    {
        var prefetch = new ServerPrefetchFeature();
        await prefetch.WaitForCompletionAsync();
    }

    [Test]
    public async Task Register_outside_the_event_loop_is_refused()
    {
        var prefetch = new ServerPrefetchFeature();

        // Thrown out of Mount, from the Setup that registers: a prefetch started here would
        // resume on the thread pool alongside the render.
        var ex = await Assert.That(() => BuildHost(prefetch, f => f.OnServerPrefetch(() => Task.CompletedTask)).Mount())
            .Throws<InvalidOperationException>();

        await Assert.That(ex!.Message).Contains(nameof(SsrEventLoop));
    }

    [Test]
    public async Task Register_after_the_drain_is_refused() => await SsrEventLoop.RunAsync(async () =>
    {
        var prefetch = new ServerPrefetchFeature();

        using var _ = BuildHost(prefetch, f => f.OnServerPrefetch(() => Task.CompletedTask)).Mount();
        await prefetch.WaitForCompletionAsync();

        // Nothing is left to wait for it; it would outlive the response.
        await Assert.That(() => prefetch.Register(_ => Task.CompletedTask))
            .Throws<InvalidOperationException>();
    });

    [Test]
    public async Task Cancelling_the_request_cancels_callbacks_and_stops_the_drain() => await SsrEventLoop.RunAsync(async () =>
    {
        using var request = new CancellationTokenSource();
        var prefetch = new ServerPrefetchFeature(request.Token);
        var observed = CancellationToken.None;

        using var _ = BuildHost(prefetch, f =>
        {
            // Honours its token.
            f.OnServerPrefetch(async token =>
            {
                observed = token;
                await Task.Delay(Timeout.Infinite, token);
            });

            // Ignores it: must not keep the drain waiting for a response nobody wants.
            f.OnServerPrefetch(async () => await new TaskCompletionSource().Task);
        }).Mount();

        var drain = prefetch.WaitForCompletionAsync();
        request.Cancel();

        await Assert.That(async () => await drain).Throws<OperationCanceledException>();
        await Assert.That(observed.IsCancellationRequested).IsTrue();
    });
}
