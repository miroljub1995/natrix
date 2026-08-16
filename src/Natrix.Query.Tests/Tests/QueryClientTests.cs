using Natrix.Query.Tests.TestUtils;

namespace Natrix.Query.Tests.Tests;

public class QueryClientTests
{
    [Test]
    public async Task Data_written_to_the_cache_can_be_read_back()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            harness.Client.SetQueryData<string>(["todos"], "written");

            await Assert.That(harness.Client.GetQueryData<string>(["todos"])).IsEqualTo("written");
            await Assert.That(harness.Client.GetQueryData<string>(["other"])).IsNull();
            await Assert.That(harness.Client.GetQueryState(["todos"])!.Status).IsEqualTo(QueryStatus.Success);
        });
    }

    [Test]
    public async Task An_updater_receives_the_cached_value()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            harness.Client.SetQueryData<int>(["count"], 1);
            harness.Client.SetQueryData<int>(["count"], previous => previous + 1);

            await Assert.That(harness.Client.GetQueryData<int>(["count"])).IsEqualTo(2);
        });
    }

    [Test]
    public async Task Writing_data_reaches_a_mounted_observer_immediately()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                QueryFn = _ => Task.FromResult("fetched"),
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            harness.Client.SetQueryData<string>(["todos"], "optimistic");

            await Assert.That(observer.CurrentResult.Data).IsEqualTo("optimistic");
        });
    }

    [Test]
    public async Task Queries_can_be_read_and_written_in_bulk_by_filter()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            harness.Client.SetQueryData<int>(["todos", 1], 1);
            harness.Client.SetQueryData<int>(["todos", 2], 2);
            harness.Client.SetQueryData<int>(["users", 1], 10);

            var todos = harness.Client.GetQueriesData<int>(new QueryFilters { QueryKey = ["todos"] });
            await Assert.That(todos.Count).IsEqualTo(2);

            harness.Client.SetQueriesData<int>(
                new QueryFilters { QueryKey = ["todos"] },
                previous => previous * 100);

            await Assert.That(harness.Client.GetQueryData<int>(["todos", 1])).IsEqualTo(100);
            await Assert.That(harness.Client.GetQueryData<int>(["todos", 2])).IsEqualTo(200);
            await Assert.That(harness.Client.GetQueryData<int>(["users", 1])).IsEqualTo(10);
        });
    }

    [Test]
    public async Task FetchQuery_caches_its_result_and_serves_fresh_data_from_the_cache()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var calls = 0;

            UseQueryOptions<string> Options() => new()
            {
                QueryKey = ["todos"],
                StaleTime = TimeSpan.FromMinutes(1),
                QueryFn = async _ =>
                {
                    calls++;
                    await Task.Yield();
                    return "data";
                },
            };

            var first = await harness.Client.FetchQueryAsync(Options());
            var second = await harness.Client.FetchQueryAsync(Options());

            await Assert.That(first).IsEqualTo("data");
            await Assert.That(second).IsEqualTo("data");
            await Assert.That(calls).IsEqualTo(1);

            await harness.AdvanceAsync(TimeSpan.FromMinutes(2));

            await harness.Client.FetchQueryAsync(Options());
            await Assert.That(calls).IsEqualTo(2);
        });
    }

    [Test]
    public async Task FetchQuery_throws_and_does_not_retry_by_default()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var calls = 0;

            var thrown = await Assert.ThrowsAsync<InvalidOperationException>(async () =>
                await harness.Client.FetchQueryAsync(new UseQueryOptions<string>
                {
                    QueryKey = ["todos"],
                    QueryFn = async _ =>
                    {
                        calls++;
                        await Task.Yield();
                        throw new InvalidOperationException("boom");
                    },
                }));

            await Assert.That(thrown!.Message).IsEqualTo("boom");
            await Assert.That(calls).IsEqualTo(1);
        });
    }

    [Test]
    public async Task PrefetchQuery_warms_the_cache_and_swallows_failures()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            await harness.Client.PrefetchQueryAsync(new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                QueryFn = _ => Task.FromResult("data"),
            });

            await Assert.That(harness.Client.GetQueryData<string>(["todos"])).IsEqualTo("data");

            // No exception escapes, even though the query fails.
            await harness.Client.PrefetchQueryAsync(new UseQueryOptions<string>
            {
                QueryKey = ["broken"],
                QueryFn = _ => throw new InvalidOperationException("boom"),
            });

            await Assert.That(harness.Client.GetQueryData<string>(["broken"])).IsNull();
        });
    }

    [Test]
    public async Task EnsureQueryData_returns_cached_data_without_fetching()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var calls = 0;

            UseQueryOptions<string> Options() => new()
            {
                QueryKey = ["todos"],
                QueryFn = async _ =>
                {
                    calls++;
                    await Task.Yield();
                    return "data";
                },
            };

            await Assert.That(await harness.Client.EnsureQueryDataAsync(Options())).IsEqualTo("data");
            await Assert.That(await harness.Client.EnsureQueryDataAsync(Options())).IsEqualTo("data");
            await Assert.That(calls).IsEqualTo(1);
        });
    }

    [Test]
    public async Task Invalidation_marks_data_stale_and_refetches_the_active_query()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var calls = 0;

            var observer = new QueryObserver<int, int>(harness.Client, new UseQueryOptions<int>
            {
                QueryKey = ["todos"],
                StaleTime = TimeSpan.FromMinutes(5),
                QueryFn = async _ =>
                {
                    calls++;
                    await Task.Yield();
                    return calls;
                },
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            await Assert.That(calls).IsEqualTo(1);
            await Assert.That(observer.CurrentResult.IsStale).IsFalse();

            await harness.Client.InvalidateQueriesAsync(new QueryFilters { QueryKey = ["todos"] });
            await harness.SettleAsync();

            await Assert.That(calls).IsEqualTo(2);
            await Assert.That(observer.CurrentResult.Data).IsEqualTo(2);
        });
    }

    [Test]
    public async Task Invalidation_of_an_inactive_query_only_marks_it_stale()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            harness.Client.SetQueryData<string>(["todos"], "cached");

            await harness.Client.InvalidateQueriesAsync(new QueryFilters { QueryKey = ["todos"] });
            await harness.SettleAsync();

            var query = harness.Client.QueryCache.Get(new QueryKey("todos").Hash)!;
            await Assert.That(query.State.IsInvalidated).IsTrue();
            await Assert.That(query.State.Data).IsEqualTo("cached");
        });
    }

    [Test]
    public async Task RefetchType_None_invalidates_without_refetching()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var calls = 0;

            var observer = new QueryObserver<int, int>(harness.Client, new UseQueryOptions<int>
            {
                QueryKey = ["todos"],
                StaleTime = TimeSpan.FromMinutes(5),
                QueryFn = async _ =>
                {
                    calls++;
                    await Task.Yield();
                    return calls;
                },
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            await harness.Client.InvalidateQueriesAsync(
                new QueryFilters { QueryKey = ["todos"] },
                new InvalidateQueryOptions { RefetchType = RefetchType.None });
            await harness.SettleAsync();

            await Assert.That(calls).IsEqualTo(1);
            await Assert.That(observer.CurrentResult.IsStale).IsTrue();
        });
    }

    [Test]
    public async Task Removing_a_query_drops_it_from_the_cache()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            harness.Client.SetQueryData<string>(["todos", 1], "a");
            harness.Client.SetQueryData<string>(["todos", 2], "b");
            harness.Client.SetQueryData<string>(["users", 1], "c");

            harness.Client.RemoveQueries(new QueryFilters { QueryKey = ["todos"] });

            await Assert.That(harness.Client.GetQueryData<string>(["todos", 1])).IsNull();
            await Assert.That(harness.Client.GetQueryData<string>(["todos", 2])).IsNull();
            await Assert.That(harness.Client.GetQueryData<string>(["users", 1])).IsEqualTo("c");
        });
    }

    [Test]
    public async Task Resetting_a_query_restores_its_initial_state_and_refetches_when_active()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var calls = 0;

            var observer = new QueryObserver<int, int>(harness.Client, new UseQueryOptions<int>
            {
                QueryKey = ["todos"],
                StaleTime = TimeSpan.FromMinutes(5),
                QueryFn = async _ =>
                {
                    calls++;
                    await Task.Yield();
                    return calls;
                },
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();
            await Assert.That(observer.CurrentResult.Data).IsEqualTo(1);

            await harness.Client.ResetQueriesAsync(new QueryFilters { QueryKey = ["todos"] });
            await harness.SettleAsync();

            await Assert.That(calls).IsEqualTo(2);
            await Assert.That(observer.CurrentResult.Data).IsEqualTo(2);
        });
    }

    [Test]
    public async Task Cancelling_a_query_reverts_it_to_the_state_before_the_fetch()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var gate = new TaskCompletionSource<string>(TaskCreationOptions.RunContinuationsAsynchronously);
            var observed = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);

            var observer = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                QueryFn = async context =>
                {
                    observed.TrySetResult(context.Signal.CanBeCanceled);
                    return await gate.Task;
                },
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.FetchStatus).IsEqualTo(FetchStatus.Fetching);

            await harness.Client.CancelQueriesAsync(new QueryFilters { QueryKey = ["todos"] });
            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.FetchStatus).IsEqualTo(FetchStatus.Idle);
            await Assert.That(observer.CurrentResult.Status).IsEqualTo(QueryStatus.Pending);
            await Assert.That(observer.CurrentResult.Error).IsNull();

            gate.TrySetResult("late");
            await harness.SettleAsync();
        });
    }

    [Test]
    public async Task A_cancelled_query_function_sees_its_token_signalled()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var cancelled = false;
            var started = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
            var gate = new TaskCompletionSource<string>(TaskCreationOptions.RunContinuationsAsynchronously);

            var observer = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                QueryFn = async context =>
                {
                    context.Signal.Register(() => cancelled = true);
                    started.TrySetResult();
                    return await gate.Task;
                },
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();
            await started.Task;

            await harness.Client.CancelQueriesAsync(new QueryFilters { QueryKey = ["todos"] });
            await harness.SettleAsync();

            await Assert.That(cancelled).IsTrue();

            gate.TrySetResult("late");
            await harness.SettleAsync();
        });
    }

    [Test]
    public async Task IsFetching_counts_the_queries_in_flight()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var gate = new TaskCompletionSource<string>(TaskCreationOptions.RunContinuationsAsynchronously);

            var first = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                QueryFn = _ => gate.Task,
            });

            var second = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["users"],
                QueryFn = _ => gate.Task,
            });

            using var firstSubscription = first.Subscribe(_ => { });
            using var secondSubscription = second.Subscribe(_ => { });
            await harness.SettleAsync();

            await Assert.That(harness.Client.IsFetching()).IsEqualTo(2);
            await Assert.That(harness.Client.IsFetching(new QueryFilters { QueryKey = ["todos"] })).IsEqualTo(1);

            gate.TrySetResult("data");
            await harness.SettleAsync();

            await Assert.That(harness.Client.IsFetching()).IsEqualTo(0);
        });
    }

    [Test]
    public async Task Client_defaults_apply_to_queries_that_do_not_override_them()
    {
        await QueryTestHarness.RunAsync(
            async harness =>
            {
                var calls = 0;

                UseQueryOptions<string> Options() => new()
                {
                    QueryKey = ["todos"],
                    QueryFn = async _ =>
                    {
                        calls++;
                        await Task.Yield();
                        return "data";
                    },
                };

                var first = new QueryObserver<string, string>(harness.Client, Options());
                using (var subscription = first.Subscribe(_ => { }))
                {
                    await harness.SettleAsync();
                }

                var second = new QueryObserver<string, string>(harness.Client, Options());
                using var secondSubscription = second.Subscribe(_ => { });
                await harness.SettleAsync();

                // The client-wide stale time of one minute keeps the second mount from fetching.
                await Assert.That(calls).IsEqualTo(1);
            },
            new QueryClientDefaultOptions
            {
                Queries = new DefaultQueryOptions { StaleTime = TimeSpan.FromMinutes(1) },
            });
    }

    [Test]
    public async Task Per_key_defaults_override_client_defaults()
    {
        await QueryTestHarness.RunAsync(
            async harness =>
            {
                harness.Client.SetQueryDefaults(["todos"], new DefaultQueryOptions
                {
                    StaleTime = TimeSpan.Zero,
                });

                var calls = 0;

                UseQueryOptions<string> Options() => new()
                {
                    QueryKey = ["todos"],
                    QueryFn = async _ =>
                    {
                        calls++;
                        await Task.Yield();
                        return "data";
                    },
                };

                var first = new QueryObserver<string, string>(harness.Client, Options());
                using (var subscription = first.Subscribe(_ => { }))
                {
                    await harness.SettleAsync();
                }

                var second = new QueryObserver<string, string>(harness.Client, Options());
                using var secondSubscription = second.Subscribe(_ => { });
                await harness.SettleAsync();

                await Assert.That(calls).IsEqualTo(2);
            },
            new QueryClientDefaultOptions
            {
                Queries = new DefaultQueryOptions { StaleTime = TimeSpan.FromMinutes(1) },
            });
    }

    [Test]
    public async Task A_default_query_function_serves_keys_that_bring_none()
    {
        await QueryTestHarness.RunAsync(
            async harness =>
            {
                var data = await harness.Client.FetchQueryAsync(new UseQueryOptions<string>
                {
                    QueryKey = ["todos", 7],
                });

                await Assert.That(data).IsEqualTo("todos/7");
            },
            new QueryClientDefaultOptions
            {
                Queries = new DefaultQueryOptions
                {
                    QueryFn = context => Task.FromResult<object?>(string.Join('/', context.QueryKey)),
                },
            });
    }

    [Test]
    public async Task Filters_select_by_key_shape_staleness_and_predicate()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            harness.Client.SetQueryData<string>(["todos", 1], "a");
            harness.Client.SetQueryData<string>(["todos", 2], "b");
            harness.Client.SetQueryData<string>(["users", 1], "c");

            var byPrefix = harness.Client.QueryCache.FindAll(new QueryFilters { QueryKey = ["todos"] });
            await Assert.That(byPrefix.Count).IsEqualTo(2);

            var exact = harness.Client.QueryCache.FindAll(new QueryFilters { QueryKey = ["todos"], Exact = true });
            await Assert.That(exact.Count).IsEqualTo(0);

            var inactive = harness.Client.QueryCache.FindAll(new QueryFilters { Type = QueryTypeFilter.Inactive });
            await Assert.That(inactive.Count).IsEqualTo(3);

            var byPredicate = harness.Client.QueryCache.FindAll(new QueryFilters
            {
                Predicate = query => Equals(query.State.Data, "c"),
            });
            await Assert.That(byPredicate.Count).IsEqualTo(1);
        });
    }
}
