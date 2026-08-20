using Natrix.Core.Components;
using Natrix.Signals;

namespace Natrix.Swr.Tests;

public class SwrResourceTests
{
    private static readonly SwrOptions NoRetries = new() { ShouldRetryOnError = false };

    /// <summary>
    /// Retries with no waiting between them, so a whole retry sequence completes inside the mount
    /// call and the assertions need no polling.
    /// </summary>
    private static SwrOptions ImmediateRetries(int count) =>
        new() { ErrorRetryCount = count, ErrorRetryInterval = TimeSpan.Zero };

    [Test]
    public async Task Fetches_on_mount_and_publishes_data()
    {
        var fetcher = new RecordingFetcher<string>((_, _) => Task.FromResult("Ada"));
        SwrResource<string>? resource = null;

        using var app = new TestApp(NoRetries);
        app.MountProbe(() => resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
        await Assert.That(fetcher.Keys[0]).IsEqualTo(new SwrKey("user", "1"));
        await Assert.That(resource!.Data.Value).IsEqualTo("Ada");
        await Assert.That(resource.Error.Value).IsNull();
        await Assert.That(resource.IsLoading.Value).IsFalse();
        await Assert.That(resource.IsValidating.Value).IsFalse();
    }

    [Test]
    public async Task Does_not_fetch_during_setup()
    {
        var fetcher = new RecordingFetcher<string>((_, _) => Task.FromResult("Ada"));
        var callsSeenInSetup = -1;

        using var app = new TestApp(NoRetries);
        app.MountProbe(() =>
        {
            var resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync);

            // Still inside Setup: the tree is not mounted, so nothing may have been requested.
            callsSeenInSetup = fetcher.CallCount;
            _ = resource;
        });

        await Assert.That(callsSeenInSetup).IsEqualTo(0);
        await Assert.That(fetcher.CallCount).IsEqualTo(1);
    }

    [Test]
    public async Task Does_not_fetch_without_lifecycle_hooks()
    {
        // Server-side rendering registers no lifecycle hooks feature, so mounted hooks — and
        // with them the first request — are dropped. The tree renders its loading state instead.
        var fetcher = new RecordingFetcher<string>((_, _) => Task.FromResult("Ada"));
        SwrResource<string>? resource = null;

        using var app = new TestApp(NoRetries, lifecycleHooks: false);
        app.MountProbe(() => resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        await Assert.That(fetcher.CallCount).IsEqualTo(0);
        await Assert.That(resource!.IsLoading.Value).IsTrue();
        await Assert.That(resource.IsValidating.Value).IsFalse();
    }

    [Test]
    public async Task Reports_loading_until_the_first_value_arrives()
    {
        var completion = new TaskCompletionSource<string>();
        var fetcher = new RecordingFetcher<string>((_, _) => completion.Task);
        SwrResource<string>? resource = null;

        using var app = new TestApp(NoRetries);
        app.MountProbe(() => resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        await Assert.That(resource!.IsLoading.Value).IsTrue();
        await Assert.That(resource.IsValidating.Value).IsTrue();

        completion.SetResult("Ada");

        await Assert.That(resource.IsLoading.Value).IsFalse();
        await Assert.That(resource.IsValidating.Value).IsFalse();
        await Assert.That(resource.Data.Value).IsEqualTo("Ada");
    }

    [Test]
    public async Task Revalidation_keeps_data_visible_and_only_sets_is_validating()
    {
        var completions = new List<TaskCompletionSource<string>>();
        var fetcher = new RecordingFetcher<string>((_, _) =>
        {
            var completion = new TaskCompletionSource<string>();
            completions.Add(completion);
            return completion.Task;
        });
        SwrResource<string>? resource = null;

        using var app = new TestApp(NoRetries);
        app.MountProbe(() => resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        completions[0].SetResult("Ada");

        var revalidation = resource!.RevalidateAsync();

        await Assert.That(resource.IsValidating.Value).IsTrue();
        await Assert.That(resource.IsLoading.Value).IsFalse();
        await Assert.That(resource.Data.Value).IsEqualTo("Ada");

        completions[1].SetResult("Ada Lovelace");
        await revalidation;

        await Assert.That(resource.Data.Value).IsEqualTo("Ada Lovelace");
    }

    [Test]
    public async Task Components_sharing_a_key_issue_one_request()
    {
        var completion = new TaskCompletionSource<string>();
        var fetcher = new RecordingFetcher<string>((_, _) => completion.Task);
        SwrResource<string>? first = null;
        SwrResource<string>? second = null;

        using var app = new TestApp(NoRetries);
        app.Mount(() => new Probe
        {
            Props = new ProbeProps
            {
                Body = () => first = SwrResource.Use(["user", "1"], fetcher.FetchAsync),
                Children =
                [
                    new Probe
                    {
                        Props = new ProbeProps
                        {
                            Body = () => second = SwrResource.Use(["user", "1"], fetcher.FetchAsync),
                        },
                    },
                ],
            },
        });

        await Assert.That(fetcher.CallCount).IsEqualTo(1);

        completion.SetResult("Ada");

        await Assert.That(first!.Data.Value).IsEqualTo("Ada");
        await Assert.That(second!.Data.Value).IsEqualTo("Ada");
    }

    [Test]
    public async Task Remounting_renders_the_cached_value_before_revalidating()
    {
        var fetcher = new RecordingFetcher<string>((index, _) => Task.FromResult($"Ada {index}"));
        var visible = new Signal<bool>(true);
        SwrResource<string>? latest = null;
        var dataAtSetup = new List<string?>();

        using var app = new TestApp(NoRetries);
        app.Mount(() => new If
        {
            Condition = visible,
            Then = () =>
            [
                new Probe
                {
                    Props = new ProbeProps
                    {
                        Body = () =>
                        {
                            latest = SwrResource.Use(["user", "1"], fetcher.FetchAsync);
                            dataAtSetup.Add(latest.Data.Value);
                        },
                    },
                },
            ],
        });

        await Assert.That(dataAtSetup[0]).IsNull();
        await Assert.That(latest!.Data.Value).IsEqualTo("Ada 0");

        visible.Value = false;
        visible.Value = true;

        // The remounted component sees the cached value before its own request completes.
        await Assert.That(dataAtSetup[1]).IsEqualTo("Ada 0");
        await Assert.That(fetcher.CallCount).IsEqualTo(2);
        await Assert.That(latest.Data.Value).IsEqualTo("Ada 1");
    }

    [Test]
    public async Task Key_change_refetches_and_switches_data()
    {
        var fetcher = new RecordingFetcher<string>((_, key) => Task.FromResult($"user-{key[1]}"));
        var userId = new Signal<string>("1");
        SwrResource<string>? resource = null;

        using var app = new TestApp(NoRetries);
        app.MountProbe(() =>
            resource = SwrResource.Use(() => ["user", userId.Value], fetcher.FetchAsync));

        await Assert.That(resource!.Data.Value).IsEqualTo("user-1");

        userId.Value = "2";

        await Assert.That(fetcher.CallCount).IsEqualTo(2);
        await Assert.That(resource.Key.Value).IsEqualTo(new SwrKey("user", "2"));
        await Assert.That(resource.Data.Value).IsEqualTo("user-2");

        // Back to a key already in the cache: its value is there immediately, and it revalidates.
        userId.Value = "1";

        await Assert.That(resource.Data.Value).IsEqualTo("user-1");
        await Assert.That(fetcher.CallCount).IsEqualTo(3);
    }

    [Test]
    public async Task Key_factory_re_running_with_an_unchanged_key_does_not_refetch()
    {
        var fetcher = new RecordingFetcher<string>((_, _) => Task.FromResult("Ada"));
        var unrelated = new Signal<int>(0);
        SwrResource<string>? resource = null;

        using var app = new TestApp(NoRetries);
        app.MountProbe(() => resource = SwrResource.Use(
            () =>
            {
                // Read so the factory re-runs, but the key it produces never changes.
                _ = unrelated.Value;
                return ["user", "1"];
            },
            fetcher.FetchAsync));

        unrelated.Value = 1;
        unrelated.Value = 2;

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
        await Assert.That(resource!.Data.Value).IsEqualTo("Ada");
    }

    [Test]
    public async Task Key_factory_re_running_with_an_unchanged_key_stays_bound_to_the_entry()
    {
        // A claim on an entry lasts as long as the key does, not as long as one run of the key
        // factory. Releasing it per run would leave the resource showing a value it can no
        // longer refresh — which looks identical to the test above until something asks it to.
        var fetcher = new RecordingFetcher<string>((index, _) => Task.FromResult($"Ada {index}"));
        var unrelated = new Signal<int>(0);
        SwrResource<string>? resource = null;

        using var app = new TestApp(NoRetries);
        app.MountProbe(() => resource = SwrResource.Use(
            () =>
            {
                _ = unrelated.Value;
                return ["user", "1"];
            },
            fetcher.FetchAsync));

        unrelated.Value = 1;

        await resource!.RevalidateAsync();

        await Assert.That(fetcher.CallCount).IsEqualTo(2);
        await Assert.That(resource.Data.Value).IsEqualTo("Ada 1");
    }

    [Test]
    public async Task Pausing_one_resource_leaves_another_holding_the_key()
    {
        // Pausing takes no claim on anything, so the release that follows it must not hand one
        // back. An extra release would take the count to zero under the component still watching
        // and cancel the request out from under it.
        var completion = new TaskCompletionSource<string>();
        var fetcher = new RecordingFetcher<string>((_, _) => completion.Task);
        var paused = new Signal<bool>(false);

        using var app = new TestApp(NoRetries);
        app.Mount(() => new Probe
        {
            Props = new ProbeProps
            {
                Body = () => SwrResource.Use(
                    () => paused.Value ? SwrKey.None : new SwrKey("user", "1"),
                    fetcher.FetchAsync),
                Children =
                [
                    new Probe
                    {
                        Props = new ProbeProps
                        {
                            Body = () => SwrResource.Use(["user", "1"], fetcher.FetchAsync),
                        },
                    },
                ],
            },
        });

        paused.Value = true;

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
        await Assert.That(fetcher.Tokens[0].IsCancellationRequested).IsFalse();
    }

    [Test]
    public async Task Absent_key_pauses_until_it_becomes_available()
    {
        var fetcher = new RecordingFetcher<string>((_, key) => Task.FromResult($"user-{key[1]}"));
        var userId = new Signal<string?>(null);
        SwrResource<string>? resource = null;

        using var app = new TestApp(NoRetries);
        app.MountProbe(() => resource = SwrResource.Use(
            () => userId.Value is { } id ? new SwrKey("user", id) : SwrKey.None,
            fetcher.FetchAsync));

        await Assert.That(fetcher.CallCount).IsEqualTo(0);
        await Assert.That(resource!.IsLoading.Value).IsFalse();
        await Assert.That(resource.Key.Value).IsEqualTo(SwrKey.None);

        userId.Value = "7";

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
        await Assert.That(resource.Data.Value).IsEqualTo("user-7");

        // Going back to no key stops reporting the previous key's data.
        userId.Value = null;

        await Assert.That(resource.Data.Value).IsNull();
        await Assert.That(resource.IsLoading.Value).IsFalse();
        await Assert.That(fetcher.CallCount).IsEqualTo(1);
    }

    [Test]
    public async Task Retries_up_to_the_configured_count_then_reports_the_error()
    {
        var fetcher = new RecordingFetcher<string>((index, _) =>
            Task.FromException<string>(new InvalidOperationException($"boom {index}")));
        SwrResource<string>? resource = null;

        using var app = new TestApp(ImmediateRetries(3));
        app.MountProbe(() => resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        // The first attempt plus three retries.
        await Assert.That(fetcher.CallCount).IsEqualTo(4);
        await Assert.That(resource!.Error.Value?.Message).IsEqualTo("boom 3");
        await Assert.That(resource.IsValidating.Value).IsFalse();
        await Assert.That(resource.IsLoading.Value).IsFalse();
    }

    [Test]
    public async Task Does_not_retry_when_retrying_is_disabled()
    {
        var fetcher = new RecordingFetcher<string>((_, _) =>
            Task.FromException<string>(new InvalidOperationException("boom")));
        SwrResource<string>? resource = null;

        using var app = new TestApp(NoRetries);
        app.MountProbe(() => resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
        await Assert.That(resource!.Error.Value?.Message).IsEqualTo("boom");
    }

    [Test]
    public async Task Zero_retry_count_is_a_single_attempt()
    {
        var fetcher = new RecordingFetcher<string>((_, _) =>
            Task.FromException<string>(new InvalidOperationException("boom")));

        using var app = new TestApp(ImmediateRetries(0));
        app.MountProbe(() => SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
    }

    [Test]
    public async Task A_retry_that_succeeds_clears_the_error()
    {
        var fetcher = new RecordingFetcher<string>((index, _) => index == 0
            ? Task.FromException<string>(new InvalidOperationException("boom"))
            : Task.FromResult("Ada"));
        SwrResource<string>? resource = null;

        using var app = new TestApp(ImmediateRetries(3));
        app.MountProbe(() => resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        await Assert.That(fetcher.CallCount).IsEqualTo(2);
        await Assert.That(resource!.Error.Value).IsNull();
        await Assert.That(resource.Data.Value).IsEqualTo("Ada");
    }

    [Test]
    public async Task A_failure_keeps_the_previous_value_on_screen()
    {
        var fetcher = new RecordingFetcher<string>((index, _) => index == 0
            ? Task.FromResult("Ada")
            : Task.FromException<string>(new InvalidOperationException("boom")));
        SwrResource<string>? resource = null;

        using var app = new TestApp(NoRetries);
        app.MountProbe(() => resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        await resource!.RevalidateAsync();

        await Assert.That(resource.Data.Value).IsEqualTo("Ada");
        await Assert.That(resource.Error.Value?.Message).IsEqualTo("boom");
        await Assert.That(resource.IsLoading.Value).IsFalse();
    }

    [Test]
    public async Task Unmounting_abandons_a_pending_retry()
    {
        var fetcher = new RecordingFetcher<string>((_, _) =>
            Task.FromException<string>(new InvalidOperationException("boom")));
        var visible = new Signal<bool>(true);

        // Long enough that the retry can only happen if nothing cancels it.
        var options = new SwrOptions { ErrorRetryCount = 5, ErrorRetryInterval = TimeSpan.FromMinutes(10) };

        using var app = new TestApp(options);
        app.Mount(() => new If
        {
            Condition = visible,
            Then = () => [new Probe { Props = new ProbeProps { Body = () => SwrResource.Use(["user", "1"], fetcher.FetchAsync) } }],
        });

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
        await Assert.That(fetcher.Tokens[0].IsCancellationRequested).IsFalse();

        visible.Value = false;

        await Assert.That(fetcher.Tokens[0].IsCancellationRequested).IsTrue();
        await Assert.That(fetcher.CallCount).IsEqualTo(1);
    }

    [Test]
    public async Task Unmounting_one_of_two_subscribers_leaves_the_request_running()
    {
        var completion = new TaskCompletionSource<string>();
        var fetcher = new RecordingFetcher<string>((_, _) => completion.Task);
        var secondVisible = new Signal<bool>(true);
        SwrResource<string>? first = null;

        using var app = new TestApp(NoRetries);
        app.Mount(() => new Probe
        {
            Props = new ProbeProps
            {
                Body = () => first = SwrResource.Use(["user", "1"], fetcher.FetchAsync),
                Children =
                [
                    new If
                    {
                        Condition = secondVisible,
                        Then = () =>
                        [
                            new Probe
                            {
                                Props = new ProbeProps
                                {
                                    Body = () => SwrResource.Use(["user", "1"], fetcher.FetchAsync),
                                },
                            },
                        ],
                    },
                ],
            },
        });

        secondVisible.Value = false;

        await Assert.That(fetcher.Tokens[0].IsCancellationRequested).IsFalse();

        completion.SetResult("Ada");

        await Assert.That(first!.Data.Value).IsEqualTo("Ada");
    }

    [Test]
    public async Task Revalidate_joins_a_request_already_in_flight()
    {
        var completion = new TaskCompletionSource<string>();
        var fetcher = new RecordingFetcher<string>((_, _) => completion.Task);
        SwrResource<string>? resource = null;

        using var app = new TestApp(NoRetries);
        app.MountProbe(() => resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        var joined = resource!.RevalidateAsync();

        await Assert.That(fetcher.CallCount).IsEqualTo(1);

        completion.SetResult("Ada");
        await joined;

        await Assert.That(resource.Data.Value).IsEqualTo("Ada");
    }

    [Test]
    public async Task Mutate_without_revalidation_only_writes_locally()
    {
        var fetcher = new RecordingFetcher<string>((_, _) => Task.FromResult("Ada"));
        SwrResource<string>? resource = null;

        using var app = new TestApp(NoRetries);
        app.MountProbe(() => resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        await resource!.MutateAsync("Grace", revalidate: false);

        await Assert.That(resource.Data.Value).IsEqualTo("Grace");
        await Assert.That(fetcher.CallCount).IsEqualTo(1);
    }

    [Test]
    public async Task Mutate_revalidates_by_default()
    {
        var fetcher = new RecordingFetcher<string>((index, _) => Task.FromResult($"server-{index}"));
        SwrResource<string>? resource = null;

        using var app = new TestApp(NoRetries);
        app.MountProbe(() => resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        await resource!.MutateAsync("local");

        await Assert.That(fetcher.CallCount).IsEqualTo(2);
        await Assert.That(resource.Data.Value).IsEqualTo("server-1");
    }

    [Test]
    public async Task Mutate_updates_from_the_current_value()
    {
        var fetcher = new RecordingFetcher<int>((_, _) => Task.FromResult(41));
        SwrResource<int>? resource = null;

        using var app = new TestApp(NoRetries);
        app.MountProbe(() => resource = SwrResource.Use(["counter"], fetcher.FetchAsync));

        await resource!.MutateAsync(current => current + 1, revalidate: false);

        await Assert.That(resource.Data.Value).IsEqualTo(42);
    }

    [Test]
    public async Task Mutate_discards_a_response_that_was_already_in_flight()
    {
        var completions = new List<TaskCompletionSource<string>>();
        var fetcher = new RecordingFetcher<string>((_, _) =>
        {
            var completion = new TaskCompletionSource<string>();
            completions.Add(completion);
            return completion.Task;
        });
        SwrResource<string>? resource = null;

        using var app = new TestApp(NoRetries);
        app.MountProbe(() => resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        var mutation = resource!.MutateAsync("local");

        await Assert.That(resource.Data.Value).IsEqualTo("local");

        // The response to the request the mutation superseded describes the state before it.
        completions[0].SetResult("stale");

        await Assert.That(resource.Data.Value).IsEqualTo("local");

        completions[1].SetResult("server");
        await mutation;

        await Assert.That(resource.Data.Value).IsEqualTo("server");
    }

    [Test]
    public async Task Mutating_a_shared_key_updates_every_subscriber()
    {
        var fetcher = new RecordingFetcher<string>((_, _) => Task.FromResult("Ada"));
        SwrResource<string>? first = null;
        SwrResource<string>? second = null;

        using var app = new TestApp(NoRetries);
        app.Mount(() => new Probe
        {
            Props = new ProbeProps
            {
                Body = () => first = SwrResource.Use(["user", "1"], fetcher.FetchAsync),
                Children =
                [
                    new Probe
                    {
                        Props = new ProbeProps
                        {
                            Body = () => second = SwrResource.Use(["user", "1"], fetcher.FetchAsync),
                        },
                    },
                ],
            },
        });

        await first!.MutateAsync("Grace", revalidate: false);

        await Assert.That(second!.Data.Value).IsEqualTo("Grace");
    }

    [Test]
    public async Task Operations_on_an_absent_key_are_no_ops()
    {
        var fetcher = new RecordingFetcher<string>((_, _) => Task.FromResult("Ada"));
        SwrResource<string>? resource = null;

        using var app = new TestApp(NoRetries);
        app.MountProbe(() => resource = SwrResource.Use(() => SwrKey.None, fetcher.FetchAsync));

        await resource!.RevalidateAsync();
        await resource.MutateAsync("Grace");
        await resource.MutateAsync(_ => "Grace");

        await Assert.That(fetcher.CallCount).IsEqualTo(0);
        await Assert.That(resource.Data.Value).IsNull();
    }

    [Test]
    public async Task Effects_observe_data_arriving()
    {
        var completion = new TaskCompletionSource<string>();
        var fetcher = new RecordingFetcher<string>((_, _) => completion.Task);
        var rendered = new List<string>();

        using var app = new TestApp(NoRetries);
        app.MountProbe(() =>
        {
            var resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync);

            new Effect(_ => rendered.Add(resource.IsLoading.Value ? "loading" : resource.Data.Value ?? "empty"));
        });

        completion.SetResult("Ada");

        await Assert.That(rendered).IsEquivalentTo(new[] { "loading", "Ada" });
    }
}
