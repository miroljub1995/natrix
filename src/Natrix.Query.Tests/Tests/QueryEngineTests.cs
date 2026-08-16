using Natrix.Query.Tests.TestUtils;

namespace Natrix.Query.Tests.Tests;

public class QueryEngineTests
{
    [Test]
    public async Task OfflineFirst_issues_the_first_request_but_pauses_its_retries()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            await harness.SetOnlineAsync(false);

            var calls = 0;

            var observer = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                NetworkMode = NetworkMode.OfflineFirst,
                Retry = 1,
                RetryDelay = (_, _) => TimeSpan.FromMilliseconds(10),
                QueryFn = async _ =>
                {
                    calls++;
                    await Task.Yield();
                    throw new InvalidOperationException("offline");
                },
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            // The first attempt ran even though the app is offline.
            await Assert.That(calls).IsEqualTo(1);

            await harness.AdvanceAsync(TimeSpan.FromMilliseconds(10));

            // The retry is waiting for the connection instead of burning attempts.
            await Assert.That(calls).IsEqualTo(1);
            await Assert.That(observer.CurrentResult.FetchStatus).IsEqualTo(FetchStatus.Paused);

            await harness.SetOnlineAsync(true);

            await Assert.That(calls).IsEqualTo(2);
        });
    }

    [Test]
    public async Task RetryOnMount_false_keeps_a_failed_query_from_retrying_on_a_new_mount()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var calls = 0;

            UseQueryOptions<string> Options() => new()
            {
                QueryKey = ["todos"],
                Retry = false,
                RetryOnMount = false,
                QueryFn = async _ =>
                {
                    calls++;
                    await Task.Yield();
                    throw new InvalidOperationException("boom");
                },
            };

            var first = new QueryObserver<string, string>(harness.Client, Options());
            using (var subscription = first.Subscribe(_ => { }))
            {
                await harness.SettleAsync();
            }

            await Assert.That(calls).IsEqualTo(1);

            var second = new QueryObserver<string, string>(harness.Client, Options());
            using var secondSubscription = second.Subscribe(_ => { });
            await harness.SettleAsync();

            await Assert.That(calls).IsEqualTo(1);
            await Assert.That(second.CurrentResult.Status).IsEqualTo(QueryStatus.Error);
        });
    }

    [Test]
    public async Task RefetchOnMount_Always_refetches_even_fresh_data()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var calls = 0;

            UseQueryOptions<string> Options() => new()
            {
                QueryKey = ["todos"],
                StaleTime = TimeSpan.FromMinutes(5),
                RefetchOnMount = RefetchOnValue.Always,
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
        });
    }

    [Test]
    public async Task A_custom_structural_sharing_function_decides_what_is_stored()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                StructuralSharingFn = (previous, next) => previous ?? next,
                QueryFn = async _ =>
                {
                    await Task.Yield();
                    return Guid.NewGuid().ToString();
                },
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            var first = observer.CurrentResult.Data;

            await observer.RefetchAsync();
            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.Data).IsEqualTo(first!);
        });
    }

    [Test]
    public async Task Meta_reaches_the_query_function_and_the_query()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            IReadOnlyDictionary<string, object?>? seen = null;

            await harness.Client.FetchQueryAsync(new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                Meta = new Dictionary<string, object?> { ["errorMessage"] = "could not load todos" },
                QueryFn = context =>
                {
                    seen = context.Meta;
                    return Task.FromResult("data");
                },
            });

            await Assert.That(seen is not null).IsTrue();
            await Assert.That(seen!["errorMessage"]).IsEqualTo("could not load todos");

            var query = harness.Client.QueryCache.Get(new QueryKey("todos").Hash)!;
            await Assert.That(query.Meta!["errorMessage"]).IsEqualTo("could not load todos");
        });
    }

    [Test]
    public async Task The_longest_requested_collection_time_wins()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var shortLived = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                GcTime = TimeSpan.FromSeconds(10),
                QueryFn = _ => Task.FromResult("data"),
            });

            var longLived = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                GcTime = TimeSpan.FromMinutes(10),
                QueryFn = _ => Task.FromResult("data"),
            });

            var shortSubscription = shortLived.Subscribe(_ => { });
            var longSubscription = longLived.Subscribe(_ => { });
            await harness.SettleAsync();

            var hash = new QueryKey("todos").Hash;

            shortSubscription.Dispose();
            longSubscription.Dispose();

            await harness.AdvanceAsync(TimeSpan.FromMinutes(5));
            await Assert.That(harness.Client.QueryCache.Get(hash)).IsNotNull();

            await harness.AdvanceAsync(TimeSpan.FromMinutes(6));
            await Assert.That(harness.Client.QueryCache.Get(hash)).IsNull();
        });
    }

    [Test]
    public async Task The_cache_reports_what_happens_to_its_entries()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var events = new List<QueryCacheNotifyEventType>();
            using var subscription = harness.Client.QueryCache.Subscribe(e => events.Add(e.Type));

            harness.Client.SetQueryData<string>(["todos"], "a");
            harness.Client.RemoveQueries(new QueryFilters { QueryKey = ["todos"] });

            await Assert.That(events).Contains(QueryCacheNotifyEventType.Added);
            await Assert.That(events).Contains(QueryCacheNotifyEventType.Updated);
            await Assert.That(events).Contains(QueryCacheNotifyEventType.Removed);
        });
    }

    [Test]
    public async Task A_query_with_no_function_stays_pending_and_holds_written_data()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.Status).IsEqualTo(QueryStatus.Pending);
            await Assert.That(observer.CurrentResult.IsEnabled).IsFalse();

            harness.Client.SetQueryData<string>(["todos"], "pushed");

            await Assert.That(observer.CurrentResult.Data).IsEqualTo("pushed");
        });
    }

    [Test]
    public async Task A_second_fetch_joins_the_one_already_running()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var calls = 0;
            var gate = new TaskCompletionSource<string>(TaskCreationOptions.RunContinuationsAsynchronously);

            UseQueryOptions<string> Options() => new()
            {
                QueryKey = ["todos"],
                QueryFn = _ =>
                {
                    calls++;
                    return gate.Task;
                },
            };

            var first = harness.Client.FetchQueryAsync(Options());
            var second = harness.Client.FetchQueryAsync(Options());
            await harness.SettleAsync();

            await Assert.That(calls).IsEqualTo(1);

            gate.TrySetResult("data");
            await harness.SettleAsync();

            await Assert.That(await first).IsEqualTo("data");
            await Assert.That(await second).IsEqualTo("data");
        });
    }

    [Test]
    public async Task A_query_projected_to_another_type_without_Select_is_rejected()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            await Assert.That(() => new QueryObserver<int[], int>(harness.Client, new UseQueryOptions<int[], int>
            {
                QueryKey = ["numbers"],
                QueryFn = _ => Task.FromResult(new[] { 1 }),
            })).Throws<InvalidOperationException>();

            await Task.CompletedTask;
        });
    }

    [Test]
    public async Task An_infinite_stale_time_never_goes_stale_on_its_own()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                StaleTime = QueryTime.Infinity,
                QueryFn = _ => Task.FromResult("data"),
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            await harness.AdvanceAsync(TimeSpan.FromDays(365));

            await Assert.That(observer.CurrentResult.IsStale).IsFalse();

            // Invalidation still works: it is the one thing that outranks the clock.
            await harness.Client.InvalidateQueriesAsync(new QueryFilters { QueryKey = ["todos"] });
            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.IsFetched).IsTrue();
        });
    }
}
