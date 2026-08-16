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
}
