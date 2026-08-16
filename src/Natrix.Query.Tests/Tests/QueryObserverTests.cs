using Natrix.Query.Tests.TestUtils;

namespace Natrix.Query.Tests.Tests;

public class QueryObserverTests
{
    [Test]
    public async Task A_mounted_query_goes_from_pending_to_success()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                QueryFn = async _ =>
                {
                    await Task.Yield();
                    return "data";
                },
            });

            var seen = new List<(QueryStatus Status, FetchStatus FetchStatus)>();
            using var subscription = observer.Subscribe(result => seen.Add((result.Status, result.FetchStatus)));

            await Assert.That(observer.CurrentResult.Status).IsEqualTo(QueryStatus.Pending);
            await Assert.That(observer.CurrentResult.IsLoading).IsTrue();

            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.Status).IsEqualTo(QueryStatus.Success);
            await Assert.That(observer.CurrentResult.Data).IsEqualTo("data");
            await Assert.That(observer.CurrentResult.FetchStatus).IsEqualTo(FetchStatus.Idle);
            await Assert.That(observer.CurrentResult.IsFetched).IsTrue();
            await Assert.That(observer.CurrentResult.IsFetchedAfterMount).IsTrue();
            await Assert.That(seen).Contains((QueryStatus.Success, FetchStatus.Idle));
        });
    }

    [Test]
    public async Task A_failing_query_ends_in_the_error_state_with_the_thrown_exception()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                Retry = false,
                QueryFn = async _ =>
                {
                    await Task.Yield();
                    throw new InvalidOperationException("boom");
                },
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            var result = observer.CurrentResult;
            await Assert.That(result.Status).IsEqualTo(QueryStatus.Error);
            await Assert.That(result.Error is InvalidOperationException).IsTrue();
            await Assert.That(result.Error!.Message).IsEqualTo("boom");
            await Assert.That(result.IsLoadingError).IsTrue();
            await Assert.That(result.ErrorUpdateCount).IsEqualTo(1);
        });
    }

    [Test]
    public async Task Retries_use_the_backoff_delay_and_report_progress()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var attempts = 0;

            var observer = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                Retry = 2,
                RetryDelay = (_, _) => TimeSpan.FromMilliseconds(100),
                QueryFn = async _ =>
                {
                    attempts++;
                    await Task.Yield();
                    throw new InvalidOperationException($"attempt {attempts}");
                },
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            // First attempt failed; the query is still fetching while it waits to retry.
            await Assert.That(attempts).IsEqualTo(1);
            await Assert.That(observer.CurrentResult.FailureCount).IsEqualTo(1);
            await Assert.That(observer.CurrentResult.FailureReason!.Message).IsEqualTo("attempt 1");
            await Assert.That(observer.CurrentResult.Status).IsEqualTo(QueryStatus.Pending);

            await harness.AdvanceAsync(TimeSpan.FromMilliseconds(100));
            await Assert.That(attempts).IsEqualTo(2);

            await harness.AdvanceAsync(TimeSpan.FromMilliseconds(100));
            await Assert.That(attempts).IsEqualTo(3);

            await Assert.That(observer.CurrentResult.Status).IsEqualTo(QueryStatus.Error);
            await Assert.That(observer.CurrentResult.Error!.Message).IsEqualTo("attempt 3");
        });
    }

    [Test]
    public async Task Two_observers_of_one_key_share_a_single_fetch()
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

            var first = new QueryObserver<string, string>(harness.Client, Options());
            var second = new QueryObserver<string, string>(harness.Client, Options());

            using var firstSubscription = first.Subscribe(_ => { });
            using var secondSubscription = second.Subscribe(_ => { });

            await harness.SettleAsync();

            await Assert.That(calls).IsEqualTo(1);
            await Assert.That(first.CurrentResult.Data).IsEqualTo("data");
            await Assert.That(second.CurrentResult.Data).IsEqualTo("data");
        });
    }

    [Test]
    public async Task Fresh_data_is_not_refetched_by_a_newly_mounted_observer()
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
            await Assert.That(second.CurrentResult.IsStale).IsFalse();

            // Past the stale time the same mount does refetch.
            await harness.AdvanceAsync(TimeSpan.FromMinutes(2));

            var third = new QueryObserver<string, string>(harness.Client, Options());
            using var thirdSubscription = third.Subscribe(_ => { });
            await harness.SettleAsync();

            await Assert.That(calls).IsEqualTo(2);
        });
    }

    [Test]
    public async Task Data_becomes_stale_on_its_own_once_the_stale_time_passes()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                StaleTime = TimeSpan.FromSeconds(30),
                QueryFn = _ => Task.FromResult("data"),
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.IsStale).IsFalse();

            await harness.AdvanceAsync(TimeSpan.FromSeconds(31));

            await Assert.That(observer.CurrentResult.IsStale).IsTrue();
        });
    }

    [Test]
    public async Task A_disabled_query_never_fetches_and_starts_when_enabled()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var calls = 0;
            var enabled = false;

            UseQueryOptions<string> Options() => new()
            {
                QueryKey = ["todos"],
                Enabled = enabled,
                QueryFn = async _ =>
                {
                    calls++;
                    await Task.Yield();
                    return "data";
                },
            };

            var observer = new QueryObserver<string, string>(harness.Client, Options());
            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            await Assert.That(calls).IsEqualTo(0);
            await Assert.That(observer.CurrentResult.Status).IsEqualTo(QueryStatus.Pending);
            await Assert.That(observer.CurrentResult.IsLoading).IsFalse();
            await Assert.That(observer.CurrentResult.IsEnabled).IsFalse();

            enabled = true;
            observer.SetOptions(Options());
            await harness.SettleAsync();

            await Assert.That(calls).IsEqualTo(1);
            await Assert.That(observer.CurrentResult.Data).IsEqualTo("data");
        });
    }

    [Test]
    public async Task Changing_the_key_moves_the_observer_to_another_cache_entry()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var id = 1;

            UseQueryOptions<string> Options() => new()
            {
                QueryKey = ["todos", id],
                QueryFn = async _ =>
                {
                    var captured = id;
                    await Task.Yield();
                    return $"todo {captured}";
                },
            };

            var observer = new QueryObserver<string, string>(harness.Client, Options());
            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.Data).IsEqualTo("todo 1");

            id = 2;
            observer.SetOptions(Options());

            // The new key has nothing cached, so the observer is pending again.
            await Assert.That(observer.CurrentResult.Status).IsEqualTo(QueryStatus.Pending);

            await harness.SettleAsync();
            await Assert.That(observer.CurrentResult.Data).IsEqualTo("todo 2");

            // The first entry is still cached and nobody is watching it.
            var first = harness.Client.QueryCache.Get(new QueryKey("todos", 1).Hash);
            await Assert.That(first).IsNotNull();
            await Assert.That(first!.ObserversCount).IsEqualTo(0);
        });
    }

    [Test]
    public async Task Select_projects_the_data_and_a_throwing_projection_surfaces_as_an_error()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new QueryObserver<int[], int>(harness.Client, new UseQueryOptions<int[], int>
            {
                QueryKey = ["numbers"],
                QueryFn = _ => Task.FromResult(new[] { 1, 2, 3 }),
                Select = numbers => numbers.Sum(),
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.Data).IsEqualTo(6);

            var failing = new QueryObserver<int[], int>(harness.Client, new UseQueryOptions<int[], int>
            {
                QueryKey = ["numbers"],
                QueryFn = _ => Task.FromResult(new[] { 1, 2, 3 }),
                Select = _ => throw new InvalidOperationException("bad projection"),
            });

            using var failingSubscription = failing.Subscribe(_ => { });
            await harness.SettleAsync();

            await Assert.That(failing.CurrentResult.Status).IsEqualTo(QueryStatus.Error);
            await Assert.That(failing.CurrentResult.Error!.Message).IsEqualTo("bad projection");
        });
    }

    [Test]
    public async Task Initial_data_is_treated_as_fetched_data()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                InitialData = "seed",
                StaleTime = TimeSpan.FromMinutes(1),
                QueryFn = _ => Task.FromResult("fetched"),
            });

            using var subscription = observer.Subscribe(_ => { });

            await Assert.That(observer.CurrentResult.Status).IsEqualTo(QueryStatus.Success);
            await Assert.That(observer.CurrentResult.Data).IsEqualTo("seed");
            await Assert.That(observer.CurrentResult.IsPlaceholderData).IsFalse();

            await harness.SettleAsync();

            // Fresh initial data means no fetch, and the cache really holds it.
            await Assert.That(observer.CurrentResult.Data).IsEqualTo("seed");
            await Assert.That(harness.Client.GetQueryData<string>(["todos"])).IsEqualTo("seed");
        });
    }

    [Test]
    public async Task Placeholder_data_is_shown_while_loading_and_never_cached()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                PlaceholderData = "placeholder",
                QueryFn = async _ =>
                {
                    await Task.Yield();
                    return "data";
                },
            });

            using var subscription = observer.Subscribe(_ => { });

            await Assert.That(observer.CurrentResult.Data).IsEqualTo("placeholder");
            await Assert.That(observer.CurrentResult.IsPlaceholderData).IsTrue();
            await Assert.That(observer.CurrentResult.Status).IsEqualTo(QueryStatus.Success);
            await Assert.That(harness.Client.GetQueryData<string>(["todos"])).IsNull();

            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.Data).IsEqualTo("data");
            await Assert.That(observer.CurrentResult.IsPlaceholderData).IsFalse();
        });
    }

    [Test]
    public async Task KeepPreviousData_shows_the_previous_key_while_the_new_one_loads()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var page = 1;

            UseQueryOptions<string> Options() => new()
            {
                QueryKey = ["page", page],
                PlaceholderData = PlaceholderDataOption<string>.KeepPreviousData,
                QueryFn = async _ =>
                {
                    var captured = page;
                    await Task.Yield();
                    return $"page {captured}";
                },
            };

            var observer = new QueryObserver<string, string>(harness.Client, Options());
            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.Data).IsEqualTo("page 1");

            page = 2;
            observer.SetOptions(Options());

            await Assert.That(observer.CurrentResult.Data).IsEqualTo("page 1");
            await Assert.That(observer.CurrentResult.IsPlaceholderData).IsTrue();

            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.Data).IsEqualTo("page 2");
            await Assert.That(observer.CurrentResult.IsPlaceholderData).IsFalse();
        });
    }

    [Test]
    public async Task Refetching_reports_a_background_fetch_over_existing_data()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var value = 1;

            var observer = new QueryObserver<int, int>(harness.Client, new UseQueryOptions<int>
            {
                QueryKey = ["counter"],
                QueryFn = async _ =>
                {
                    await Task.Yield();
                    return value;
                },
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.Data).IsEqualTo(1);

            value = 2;
            var refetch = observer.RefetchAsync();

            await Assert.That(observer.CurrentResult.IsRefetching).IsTrue();
            await Assert.That(observer.CurrentResult.Data).IsEqualTo(1);
            await Assert.That(observer.CurrentResult.Status).IsEqualTo(QueryStatus.Success);

            await harness.SettleAsync();
            var result = await refetch;

            await Assert.That(result.Data).IsEqualTo(2);
            await Assert.That(observer.CurrentResult.IsRefetching).IsFalse();
        });
    }

    [Test]
    public async Task Polling_refetches_on_the_configured_interval()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var calls = 0;

            var observer = new QueryObserver<int, int>(harness.Client, new UseQueryOptions<int>
            {
                QueryKey = ["counter"],
                RefetchInterval = TimeSpan.FromSeconds(10),
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

            await harness.AdvanceAsync(TimeSpan.FromSeconds(10));
            await Assert.That(calls).IsEqualTo(2);

            await harness.AdvanceAsync(TimeSpan.FromSeconds(10));
            await Assert.That(calls).IsEqualTo(3);
            await Assert.That(observer.CurrentResult.Data).IsEqualTo(3);
        });
    }

    [Test]
    public async Task Polling_stops_while_the_app_is_in_the_background_unless_asked_otherwise()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var calls = 0;

            var observer = new QueryObserver<int, int>(harness.Client, new UseQueryOptions<int>
            {
                QueryKey = ["counter"],
                RefetchInterval = TimeSpan.FromSeconds(10),
                RefetchOnWindowFocus = false,
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

            await harness.SetFocusedAsync(false);
            await harness.AdvanceAsync(TimeSpan.FromSeconds(10));

            await Assert.That(calls).IsEqualTo(1);

            await harness.SetFocusedAsync(true);
            await harness.AdvanceAsync(TimeSpan.FromSeconds(10));

            await Assert.That(calls).IsEqualTo(2);
        });
    }

    [Test]
    public async Task Regaining_focus_refetches_stale_data_only()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var calls = 0;

            var observer = new QueryObserver<int, int>(harness.Client, new UseQueryOptions<int>
            {
                QueryKey = ["counter"],
                StaleTime = TimeSpan.FromSeconds(30),
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

            // Fresh data: a focus change is not a reason to fetch again.
            await harness.SetFocusedAsync(false);
            await harness.SetFocusedAsync(true);
            await Assert.That(calls).IsEqualTo(1);

            await harness.AdvanceAsync(TimeSpan.FromSeconds(31));
            await harness.SetFocusedAsync(false);
            await harness.SetFocusedAsync(true);

            await Assert.That(calls).IsEqualTo(2);
        });
    }

    [Test]
    public async Task An_offline_query_pauses_and_resumes_when_the_connection_returns()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            await harness.SetOnlineAsync(false);

            var calls = 0;

            var observer = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                QueryFn = async _ =>
                {
                    calls++;
                    await Task.Yield();
                    return "data";
                },
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            await Assert.That(calls).IsEqualTo(0);
            await Assert.That(observer.CurrentResult.FetchStatus).IsEqualTo(FetchStatus.Paused);
            await Assert.That(observer.CurrentResult.IsPaused).IsTrue();
            await Assert.That(observer.CurrentResult.Status).IsEqualTo(QueryStatus.Pending);

            await harness.SetOnlineAsync(true);

            await Assert.That(calls).IsEqualTo(1);
            await Assert.That(observer.CurrentResult.Data).IsEqualTo("data");
            await Assert.That(observer.CurrentResult.FetchStatus).IsEqualTo(FetchStatus.Idle);
        });
    }

    [Test]
    public async Task NetworkMode_Always_fetches_while_offline()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            await harness.SetOnlineAsync(false);

            var observer = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                NetworkMode = NetworkMode.Always,
                QueryFn = async _ =>
                {
                    await Task.Yield();
                    return "data";
                },
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.Data).IsEqualTo("data");
        });
    }

    [Test]
    public async Task Disposing_the_last_observer_leaves_the_query_unobserved_and_collectable()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new QueryObserver<string, string>(harness.Client, new UseQueryOptions<string>
            {
                QueryKey = ["todos"],
                GcTime = TimeSpan.FromMinutes(5),
                QueryFn = _ => Task.FromResult("data"),
            });

            var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            var query = harness.Client.QueryCache.Get(new QueryKey("todos").Hash);
            await Assert.That(query!.ObserversCount).IsEqualTo(1);

            subscription.Dispose();
            await Assert.That(query.ObserversCount).IsEqualTo(0);

            // Still cached: another observer mounting within the collection window reuses it.
            await harness.AdvanceAsync(TimeSpan.FromMinutes(4));
            await Assert.That(harness.Client.QueryCache.Get(query.QueryHash)).IsNotNull();

            await harness.AdvanceAsync(TimeSpan.FromMinutes(2));
            await Assert.That(harness.Client.QueryCache.Get(query.QueryHash)).IsNull();
        });
    }

    [Test]
    public async Task Structural_sharing_keeps_the_previous_reference_for_equal_data()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new QueryObserver<int[], int[]>(harness.Client, new UseQueryOptions<int[]>
            {
                QueryKey = ["numbers"],
                QueryFn = _ => Task.FromResult(new[] { 1, 2, 3 }),
            });

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            var first = observer.CurrentResult.Data;

            await observer.RefetchAsync();
            await harness.SettleAsync();

            await Assert.That(ReferenceEquals(observer.CurrentResult.Data, first)).IsTrue();
        });
    }
}
