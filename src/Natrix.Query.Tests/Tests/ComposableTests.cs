using Natrix.Core;
using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Query.Components;
using Natrix.Query.Tests.TestUtils;
using Natrix.Signals;
using Natrix.Ssr.Abstractions.Features;
using Natrix.Ssr.Features;
using Natrix.Ssr.RenderRoot;

using static Natrix.Query.NatrixQuery;

namespace Natrix.Query.Tests.Tests;

public class ComposableTests
{
    [Test]
    public async Task A_component_query_exposes_its_result_as_signals()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            UseQueryResult<string>? query = null;

            using var app = new NatrixHostBuilder()
                .UseRootRenderer(new SsrRenderRoot())
                .UseLifecycleHooks()
                .UseQueryClient(harness.Client)
                .UseRootComponent(() => new Probe
                {
                    Props = new ProbeProps
                    {
                        Setup = () => query = UseQuery(new UseQueryOptions<string>
                        {
                            QueryKey = ["todos"],
                            QueryFn = async _ =>
                            {
                                await Task.Yield();
                                return "data";
                            },
                        }),
                    },
                })
                .Build()
                .Mount();

            await Assert.That(query!.IsLoading.Value).IsTrue();
            await Assert.That(query.Data.Value).IsNull();

            await harness.SettleAsync();

            await Assert.That(query.Data.Value).IsEqualTo("data");
            await Assert.That(query.IsSuccess.Value).IsTrue();
            await Assert.That(query.IsFetching.Value).IsFalse();
        });
    }

    [Test]
    public async Task A_query_result_signal_only_wakes_effects_that_read_what_changed()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            UseQueryResult<string>? query = null;
            var dataRuns = 0;

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
                            query = UseQuery(new UseQueryOptions<string>
                            {
                                QueryKey = ["todos"],
                                Retry = 1,
                                RetryDelay = (_, _) => TimeSpan.FromMilliseconds(50),
                                QueryFn = async _ =>
                                {
                                    await Task.Yield();
                                    throw new InvalidOperationException("boom");
                                },
                            });

                            new Effect(onCleanup =>
                            {
                                _ = query.Data.Value;
                                dataRuns++;
                            });
                        },
                    },
                })
                .Build()
                .Mount();

            await harness.SettleAsync();
            var afterFirstFailure = dataRuns;

            // The retry bumps FailureCount but never touches Data.
            await harness.AdvanceAsync(TimeSpan.FromMilliseconds(50));

            await Assert.That(query!.FailureCount.Value).IsGreaterThan(0);
            await Assert.That(dataRuns).IsEqualTo(afterFirstFailure);
        });
    }

    [Test]
    public async Task Reactive_options_move_the_query_when_a_signal_changes()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var id = new Signal<int>(1);
            UseQueryResult<string>? query = null;

            using var app = new NatrixHostBuilder()
                .UseRootRenderer(new SsrRenderRoot())
                .UseLifecycleHooks()
                .UseQueryClient(harness.Client)
                .UseRootComponent(() => new Probe
                {
                    Props = new ProbeProps
                    {
                        Setup = () => query = UseQuery(() => new UseQueryOptions<string>
                        {
                            QueryKey = ["todos", id.Value],
                            QueryFn = async context =>
                            {
                                await Task.Yield();
                                return $"todo {context.QueryKey[1]}";
                            },
                        }),
                    },
                })
                .Build()
                .Mount();

            await harness.SettleAsync();
            await Assert.That(query!.Data.Value).IsEqualTo("todo 1");

            id.Value = 2;
            await harness.SettleAsync();

            await Assert.That(query.Data.Value).IsEqualTo("todo 2");
            await Assert.That(harness.Client.GetQueryData<string>(["todos", 1])).IsEqualTo("todo 1");
        });
    }

    [Test]
    public async Task A_dependent_query_waits_until_it_is_enabled()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var userId = new Signal<int?>(null);
            var calls = 0;
            UseQueryResult<string>? query = null;

            using var app = new NatrixHostBuilder()
                .UseRootRenderer(new SsrRenderRoot())
                .UseLifecycleHooks()
                .UseQueryClient(harness.Client)
                .UseRootComponent(() => new Probe
                {
                    Props = new ProbeProps
                    {
                        Setup = () => query = UseQuery(() => new UseQueryOptions<string>
                        {
                            QueryKey = ["projects", userId.Value],
                            Enabled = userId.Value is not null,
                            QueryFn = async _ =>
                            {
                                calls++;
                                await Task.Yield();
                                return $"projects of {userId.Value}";
                            },
                        }),
                    },
                })
                .Build()
                .Mount();

            await harness.SettleAsync();

            await Assert.That(calls).IsEqualTo(0);
            await Assert.That(query!.IsPending.Value).IsTrue();
            await Assert.That(query.IsLoading.Value).IsFalse();

            userId.Value = 7;
            await harness.SettleAsync();

            await Assert.That(calls).IsEqualTo(1);
            await Assert.That(query.Data.Value).IsEqualTo("projects of 7");
        });
    }

    [Test]
    public async Task Unmounting_the_component_releases_the_query()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var app = new NatrixHostBuilder()
                .UseRootRenderer(new SsrRenderRoot())
                .UseLifecycleHooks()
                .UseQueryClient(harness.Client)
                .UseRootComponent(() => new Probe
                {
                    Props = new ProbeProps
                    {
                        Setup = () => UseQuery(new UseQueryOptions<string>
                        {
                            QueryKey = ["todos"],
                            QueryFn = _ => Task.FromResult("data"),
                        }),
                    },
                })
                .Build()
                .Mount();

            await harness.SettleAsync();

            var query = harness.Client.QueryCache.Get(["todos"])!;
            await Assert.That(query.ObserversCount).IsEqualTo(1);

            app.Dispose();
            await harness.SettleAsync();

            await Assert.That(query.ObserversCount).IsEqualTo(0);
        });
    }

    [Test]
    public async Task UseIsFetching_tracks_how_many_queries_are_in_flight()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var gate = new TaskCompletionSource<string>(TaskCreationOptions.RunContinuationsAsynchronously);
            IReadOnlySignal<int>? fetching = null;

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
                            fetching = UseIsFetching();
                            UseQuery(new UseQueryOptions<string>
                            {
                                QueryKey = ["todos"],
                                QueryFn = _ => gate.Task,
                            });
                        },
                    },
                })
                .Build()
                .Mount();

            await harness.SettleAsync();
            await Assert.That(fetching!.Value).IsEqualTo(1);

            gate.TrySetResult("data");
            await harness.SettleAsync();

            await Assert.That(fetching.Value).IsEqualTo(0);
        });
    }

    [Test]
    public async Task UseQueries_follows_a_list_whose_length_changes()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var ids = new Signal<int[]>([1, 2]);
            var calls = new List<int>();
            IReadOnlySignal<IReadOnlyList<QueryObserverResult<string>>>? results = null;

            using var app = new NatrixHostBuilder()
                .UseRootRenderer(new SsrRenderRoot())
                .UseLifecycleHooks()
                .UseQueryClient(harness.Client)
                .UseRootComponent(() => new Probe
                {
                    Props = new ProbeProps
                    {
                        Setup = () => results = UseQueries(() => ids.Value
                            .Select(id => new UseQueryOptions<string>
                            {
                                QueryKey = ["todos", id],
                                QueryFn = async _ =>
                                {
                                    calls.Add(id);
                                    await Task.Yield();
                                    return $"todo {id}";
                                },
                            })
                            .ToArray()),
                    },
                })
                .Build()
                .Mount();

            await harness.SettleAsync();

            await Assert.That(results!.Value.Count).IsEqualTo(2);
            await Assert.That(results.Value.Select(r => r.Data ?? string.Empty).ToArray())
                .IsEquivalentTo(new[] { "todo 1", "todo 2" });
            await Assert.That(calls).IsEquivalentTo(new[] { 1, 2 });

            ids.Value = [2, 3];
            await harness.SettleAsync();

            await Assert.That(results.Value.Count).IsEqualTo(2);
            await Assert.That(results.Value.Select(r => r.Data ?? string.Empty).ToArray())
                .IsEquivalentTo(new[] { "todo 2", "todo 3" });

            // The query that stayed in the list was not fetched again.
            await Assert.That(calls).IsEquivalentTo(new[] { 1, 2, 3 });
        });
    }

    [Test]
    public async Task A_provider_scopes_its_own_client_to_the_subtree()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            using var scoped = new QueryClient();
            QueryClient? outer = null;
            QueryClient? inner = null;

            using var app = new NatrixHostBuilder()
                .UseRootRenderer(new SsrRenderRoot())
                .UseLifecycleHooks()
                .UseQueryClient(harness.Client)
                .UseRootComponent(() => new Probe
                {
                    Props = new ProbeProps
                    {
                        Setup = () => outer = UseQueryClient(),
                        Children =
                        [
                            new QueryClientProvider
                            {
                                Props = new QueryClientProviderProps
                                {
                                    Client = scoped,
                                    Children =
                                    [
                                        new Probe
                                        {
                                            Props = new ProbeProps { Setup = () => inner = UseQueryClient() },
                                        },
                                    ],
                                },
                            },
                        ],
                    },
                })
                .Build()
                .Mount();

            await harness.SettleAsync();

            await Assert.That(outer).IsSameReferenceAs(harness.Client);
            await Assert.That(inner).IsSameReferenceAs(scoped);
        });
    }

    [Test]
    public async Task Server_rendering_waits_for_the_query_before_producing_markup()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var prefetch = new ServerPrefetchFeature();
            var root = new SsrRenderRoot();
            var text = new Signal<string>("loading");

            using var app = new NatrixHostBuilder()
                .UseRootRenderer(root)
                .UseQueryClient(harness.Client)
                .SetFeature<IServerPrefetchFeature>(prefetch)
                .UseRootComponent(() => new Probe
                {
                    Props = new ProbeProps
                    {
                        Setup = () =>
                        {
                            var query = UseQuery(new UseQueryOptions<string>
                            {
                                QueryKey = ["todos"],
                                QueryFn = async _ =>
                                {
                                    await Task.Yield();
                                    return "server data";
                                },
                            });

                            new Effect(onCleanup => text.Value = query.Data.Value ?? "loading");
                        },
                        Children = [new Div { Children = [new DomText { Text = text }] }],
                    },
                })
                .Build()
                .Mount();

            // Rendering before the prefetch completes would produce the loading markup.
            await prefetch.WaitForCompletionAsync();
            await harness.SettleAsync();

            var markup = await SsrRender.RenderAsync(root);
            await Assert.That(markup).Contains("server data");
        });
    }

    [Test]
    public async Task A_component_query_can_project_its_data_with_Select()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            UseQueryResult<int>? count = null;

            using var app = new NatrixHostBuilder()
                .UseRootRenderer(new SsrRenderRoot())
                .UseLifecycleHooks()
                .UseQueryClient(harness.Client)
                .UseRootComponent(() => new Probe
                {
                    Props = new ProbeProps
                    {
                        Setup = () => count = UseQuery(new UseQueryOptions<string[], int>
                        {
                            QueryKey = ["todos"],
                            QueryFn = async _ =>
                            {
                                await Task.Yield();
                                return new[] { "a", "b", "c" };
                            },
                            Select = todos => todos.Length,
                        }),
                    },
                })
                .Build()
                .Mount();

            await harness.SettleAsync();

            await Assert.That(count!.Data.Value).IsEqualTo(3);

            // The cache holds the unprojected payload, so other consumers still see it whole.
            await Assert.That(harness.Client.GetQueryData<string[]>(["todos"])!.Length).IsEqualTo(3);
        });
    }
}
