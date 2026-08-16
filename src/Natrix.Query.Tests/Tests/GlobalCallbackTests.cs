using Natrix.Query.Tests.TestUtils;

namespace Natrix.Query.Tests.Tests;

public class GlobalCallbackTests
{
    [Test]
    public async Task Every_query_failure_reaches_the_cache_wide_handler()
    {
        var seen = new List<string>();

        var cache = new QueryCache(new QueryCacheConfig
        {
            OnError = (error, query) => seen.Add($"error:{query.Meta?["label"]}:{error.Message}"),
            OnSuccess = (data, query) => seen.Add($"success:{query.Meta?["label"]}:{data}"),
            OnSettled = (_, error, query) => seen.Add($"settled:{query.Meta?["label"]}:{error is not null}"),
        });

        await QueryTestHarness.RunAsync(
            async harness =>
            {
                await harness.Client.PrefetchQueryAsync(new UseQueryOptions<string>
                {
                    QueryKey = ["todos"],
                    Meta = new Dictionary<string, object?> { ["label"] = "todos" },
                    QueryFn = _ => Task.FromResult("data"),
                });

                await harness.Client.PrefetchQueryAsync(new UseQueryOptions<string>
                {
                    QueryKey = ["broken"],
                    Meta = new Dictionary<string, object?> { ["label"] = "broken" },
                    QueryFn = _ => throw new InvalidOperationException("boom"),
                });

                await Assert.That(seen).IsEquivalentTo(new[]
                {
                    "success:todos:data",
                    "settled:todos:False",
                    "error:broken:boom",
                    "settled:broken:True",
                });
            },
            cache: cache);
    }

    [Test]
    public async Task A_cancelled_query_does_not_reach_the_global_error_handler()
    {
        var errors = 0;
        var cache = new QueryCache(new QueryCacheConfig { OnError = (_, _) => errors++ });

        await QueryTestHarness.RunAsync(
            async harness =>
            {
                var gate = new TaskCompletionSource<string>(TaskCreationOptions.RunContinuationsAsynchronously);

                var observer = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
                {
                    QueryKey = ["todos"],
                    QueryFn = _ => gate.Task,
                });

                using var subscription = observer.Subscribe(_ => { });
                await harness.SettleAsync();

                await harness.Client.CancelQueriesAsync(new QueryFilters { QueryKey = ["todos"] });
                await harness.SettleAsync();

                // A cancellation is not a failure of the query — nothing went wrong that a
                // global handler should report.
                await Assert.That(errors).IsEqualTo(0);

                gate.TrySetResult("late");
                await harness.SettleAsync();
            },
            cache: cache);
    }

    [Test]
    public async Task Cache_wide_mutation_handlers_run_before_the_mutation_own_ones()
    {
        var order = new List<string>();

        var mutationCache = new MutationCache(new MutationCacheConfig
        {
            OnMutate = (_, _) =>
            {
                order.Add("cache:onMutate");
                return Task.CompletedTask;
            },
            OnSuccess = (_, _, _, _) =>
            {
                order.Add("cache:onSuccess");
                return Task.CompletedTask;
            },
            OnSettled = (_, _, _, _, _) =>
            {
                order.Add("cache:onSettled");
                return Task.CompletedTask;
            },
            OnError = (error, _, _, _) =>
            {
                order.Add($"cache:onError:{error.Message}");
                return Task.CompletedTask;
            },
        });

        await QueryTestHarness.RunAsync(
            async harness =>
            {
                var observer = new MutationObserver<string, int, object>(
                    harness.Client,
                    new UseMutationOptions<string, int>
                    {
                        MutationFn = _ => Task.FromResult("saved"),
                        OnMutate = _ =>
                        {
                            order.Add("mutation:onMutate");
                            return Task.FromResult<object?>(null);
                        },
                        OnSuccess = (_, _, _) =>
                        {
                            order.Add("mutation:onSuccess");
                            return Task.CompletedTask;
                        },
                        OnSettled = (_, _, _, _) =>
                        {
                            order.Add("mutation:onSettled");
                            return Task.CompletedTask;
                        },
                    });

                using var subscription = observer.Subscribe(_ => { });
                await observer.MutateAsync(1);

                await Assert.That(order).IsEquivalentTo(new[]
                {
                    "cache:onMutate",
                    "mutation:onMutate",
                    "cache:onSuccess",
                    "mutation:onSuccess",
                    "cache:onSettled",
                    "mutation:onSettled",
                });

                order.Clear();

                var failing = new MutationObserver<string, int, object>(
                    harness.Client,
                    new UseMutationOptions<string, int>
                    {
                        MutationFn = _ => throw new InvalidOperationException("boom"),
                    });

                using var failingSubscription = failing.Subscribe(_ => { });
                failing.Mutate(1);
                await harness.SettleAsync();

                await Assert.That(order).Contains("cache:onError:boom");
            },
            mutationCache: mutationCache);
    }
}
