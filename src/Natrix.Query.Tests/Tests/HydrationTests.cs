using Natrix.Query.Tests.TestUtils;

namespace Natrix.Query.Tests.Tests;

public class HydrationTests
{
    [Test]
    public async Task Successful_queries_are_dehydrated_and_restored()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            await harness.Client.PrefetchQueryAsync(new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                QueryFn = _ => Task.FromResult("server data"),
            });

            var dehydrated = Hydration.Dehydrate(harness.Client);
            await Assert.That(dehydrated.Queries.Count).IsEqualTo(1);
            await Assert.That(dehydrated.Queries[0].State.FetchStatus).IsEqualTo(FetchStatus.Idle);

            using var client = new QueryClient();
            Hydration.Hydrate(client, dehydrated);

            await Assert.That(client.GetQueryData<string>(["todos"])).IsEqualTo("server data");
            await Assert.That(client.GetQueryState(["todos"])!.Status).IsEqualTo(QueryStatus.Success);
        });
    }

    [Test]
    public async Task Failed_queries_are_not_transferred_by_default()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            await harness.Client.PrefetchQueryAsync(new UseQueryOptions<string>
            {
                QueryKey = ["broken"],
                QueryFn = _ => throw new InvalidOperationException("boom"),
            });

            var dehydrated = Hydration.Dehydrate(harness.Client);

            await Assert.That(dehydrated.Queries.Count).IsEqualTo(0);
        });
    }

    [Test]
    public async Task A_custom_predicate_decides_what_is_transferred()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            harness.Client.SetQueryData<string>(["todos"], "a");
            harness.Client.SetQueryData<string>(["users"], "b");

            var dehydrated = Hydration.Dehydrate(harness.Client, new DehydrateOptions
            {
                ShouldDehydrateQuery = query => query.QueryKey.PartiallyMatches(["todos"]),
            });

            await Assert.That(dehydrated.Queries.Count).IsEqualTo(1);
            await Assert.That(dehydrated.Queries[0].QueryKey == new QueryKey("todos")).IsTrue();
        });
    }

    [Test]
    public async Task Hydration_does_not_overwrite_newer_data_already_in_the_cache()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            harness.Client.SetQueryData<string>(["todos"], "old", new SetDataOptions { UpdatedAt = 1_000 });
            var dehydrated = Hydration.Dehydrate(harness.Client);

            using var client = new QueryClient();
            client.SetQueryData<string>(["todos"], "newer", new SetDataOptions { UpdatedAt = 2_000 });

            Hydration.Hydrate(client, dehydrated);

            await Assert.That(client.GetQueryData<string>(["todos"])).IsEqualTo("newer");
        });
    }

    [Test]
    public async Task A_hydrated_query_is_observable_without_refetching_while_fresh()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var source = new QueryClient();
            source.SetQueryData<string>(["todos"], "hydrated", new SetDataOptions
            {
                UpdatedAt = harness.Time.GetUtcNow().ToUnixTimeMilliseconds(),
            });

            Hydration.Hydrate(harness.Client, Hydration.Dehydrate(source));
            source.Dispose();

            var calls = 0;
            var observer = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                StaleTime = TimeSpan.FromMinutes(1),
                QueryFn = async _ =>
                {
                    calls++;
                    await Task.Yield();
                    return "refetched";
                },
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.Data).IsEqualTo("hydrated");
            await Assert.That(calls).IsEqualTo(0);
        });
    }
}
