using System.Text.Json;
using System.Text.Json.Nodes;
using Natrix.Core.Components;
using Natrix.Signals;
using Natrix.Ssr.Features;
using Natrix.Ssr.Features.HydrationState;

namespace Natrix.Swr.Tests;

/// <summary>
/// The server-rendering path: fetch while rendering, ship the values with the page, and pick them
/// up on the client instead of asking for them all over again.
/// </summary>
public class SwrSsrTests
{
    private static readonly SwrOptions NoRetries = new() { ShouldRetryOnError = false };

    /// <summary>
    /// Renders a tree the way the SSR host does — a prefetch feature to drain, which is what tells
    /// a resource it is on the server — and returns the payload the page would carry.
    /// </summary>
    private static async Task<JsonObject> RenderOnServerAsync(Func<IComponent> root)
    {
        var prefetch = new ServerPrefetchFeature();
        var hydration = new ServerHydrationStateFeature();

        using var app = new TestApp(
            NoRetries,
            serializerOptions: TestJsonContext.Default.Options,
            serverPrefetch: prefetch,
            hydrationState: hydration);

        app.Mount(root);

        await app.DrainAsync(prefetch);

        // Through a string, exactly as it travels: the client parses it back out of the page.
        var dehydrated = hydration.Dehydrate().ToJsonString();
        return JsonNode.Parse(dehydrated)!.AsObject();
    }

    [Test]
    public async Task Server_prefetches_while_it_renders()
    {
        var fetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromResult(new TestUser("Ada", 1843)));
        var prefetch = new ServerPrefetchFeature();
        SwrResource<TestUser>? resource = null;

        using var app = new TestApp(
            NoRetries,
            serializerOptions: TestJsonContext.Default.Options,
            serverPrefetch: prefetch,
            hydrationState: new ServerHydrationStateFeature());

        app.MountProbe(() => resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        // Nothing has run yet: mounting only registers, the drain is what fetches. The render
        // still reports the key as being fetched, since the prefetch is on its way.
        await Assert.That(fetcher.CallCount).IsEqualTo(0);
        await Assert.That(resource!.IsLoading.Value).IsTrue();
        await Assert.That(resource.IsValidating.Value).IsTrue();

        await app.DrainAsync(prefetch);

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
        await Assert.That(resource.Data.Value).IsEqualTo(new TestUser("Ada", 1843));
        await Assert.That(resource.IsLoading.Value).IsFalse();
        await Assert.That(resource.IsValidating.Value).IsFalse();
    }

    [Test]
    public async Task Two_components_on_one_key_cost_one_prefetch()
    {
        var fetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromResult(new TestUser("Ada", 1843)));
        var prefetch = new ServerPrefetchFeature();

        using var app = new TestApp(
            NoRetries,
            serializerOptions: TestJsonContext.Default.Options,
            serverPrefetch: prefetch,
            hydrationState: new ServerHydrationStateFeature());

        app.Mount(() => new Probe
        {
            Props = new ProbeProps
            {
                Body = () => SwrResource.Use(["user", "1"], fetcher.FetchAsync),
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

        await app.DrainAsync(prefetch);

        // The drain runs callbacks one at a time, so deduplicating in-flight requests is not
        // enough here: the second callback has to see the value the first one produced.
        await Assert.That(fetcher.CallCount).IsEqualTo(1);
    }

    [Test]
    public async Task Client_hydrates_the_payload_without_fetching()
    {
        // Both fetchers complete synchronously, which is the demanding case: the server's value
        // still has to travel through the payload rather than be re-fetched, and the client's
        // instant fetcher must not get a chance to run at all.
        var serverFetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromResult(new TestUser("Ada", 1843)));

        var payload = await RenderOnServerAsync(() => new Probe
        {
            Props = new ProbeProps
            {
                Body = () => SwrResource.Use(["user", "1"], serverFetcher.FetchAsync),
            },
        });

        var clientFetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromResult(new TestUser("stale", 0)));
        TestUser? dataAtSetup = null;
        SwrResource<TestUser>? resource = null;

        using var client = new TestApp(
            NoRetries,
            serializerOptions: TestJsonContext.Default.Options,
            clientHydrationState: payload);

        client.MountProbe(() =>
        {
            resource = SwrResource.Use(["user", "1"], clientFetcher.FetchAsync);

            // The value has to be there during Setup, before any hook runs: this is the render
            // that has to match the server's markup.
            dataAtSetup = resource.Data.Value;
        });

        await Assert.That(dataAtSetup).IsEqualTo(new TestUser("Ada", 1843));
        await Assert.That(resource!.IsLoading.Value).IsFalse();
        await Assert.That(clientFetcher.CallCount).IsEqualTo(0);
    }

    [Test]
    public async Task Hydrated_value_is_refetched_once_the_page_that_carried_it_is_gone()
    {
        var payload = await RenderOnServerAsync(() => new Probe
        {
            Props = new ProbeProps
            {
                Body = () => SwrResource.Use(
                    ["user", "1"],
                    (_, _) => Task.FromResult(new TestUser("Ada", 1843))),
            },
        });

        var fetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromResult(new TestUser("Ada", 1844)));
        var visible = new Signal<bool>(true);

        using var client = new TestApp(
            NoRetries,
            serializerOptions: TestJsonContext.Default.Options,
            clientHydrationState: payload);

        client.Mount(() => new If
        {
            Condition = visible,
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
        });

        await Assert.That(fetcher.CallCount).IsEqualTo(0);

        // Hydration covers the pass that reproduced the markup, not the session after it.
        visible.Value = false;
        visible.Value = true;
        client.Pump();

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
    }

    [Test]
    public async Task A_component_mounted_after_hydration_revalidates_a_key_another_still_holds()
    {
        var payload = await RenderOnServerAsync(() => new Probe
        {
            Props = new ProbeProps
            {
                Body = () => SwrResource.Use(
                    ["user", "1"],
                    (_, _) => Task.FromResult(new TestUser("Ada", 1843))),
            },
        });

        var fetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromResult(new TestUser("Ada", 1844)));
        var secondVisible = new Signal<bool>(false);
        SwrResource<TestUser>? first = null;
        SwrResource<TestUser>? second = null;
        TestUser? secondDataAtSetup = null;

        using var client = new TestApp(
            NoRetries,
            serializerOptions: TestJsonContext.Default.Options,
            clientHydrationState: payload);

        client.Mount(() => new Probe
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
                                    Body = () =>
                                    {
                                        second = SwrResource.Use(["user", "1"], fetcher.FetchAsync);
                                        secondDataAtSetup = second.Data.Value;
                                    },
                                },
                            },
                        ],
                    },
                ],
            },
        });

        // The hydrated component is content with what the page shipped.
        await Assert.That(fetcher.CallCount).IsEqualTo(0);

        // A component arriving later was not part of the render the server produced, so its bind
        // is an ordinary one: it shows the cached value straight away and revalidates it, which
        // the still-mounted first component sees through the shared entry.
        secondVisible.Value = true;

        await Assert.That(secondDataAtSetup).IsEqualTo(new TestUser("Ada", 1843));

        client.Pump();

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
        await Assert.That(second!.Data.Value).IsEqualTo(new TestUser("Ada", 1844));
        await Assert.That(first!.Data.Value).IsEqualTo(new TestUser("Ada", 1844));
    }

    [Test]
    public async Task Payload_for_a_key_nothing_bound_during_hydration_is_dropped()
    {
        // The payload describes the render the server produced. A key the client did not bind
        // while reproducing it was not on that page, and a component that asks for it later
        // starts from nothing rather than from a value that was never on screen.
        var payload = await RenderOnServerAsync(() => new Probe
        {
            Props = new ProbeProps
            {
                Body = () => SwrResource.Use(
                    ["user", "1"],
                    (_, _) => Task.FromResult(new TestUser("Ada", 1843))),
            },
        });

        await Assert.That(payload[SwrFeature.HydrationSection]!.AsObject().Count).IsEqualTo(1);

        var fetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromResult(new TestUser("Ada", 1844)));
        var visible = new Signal<bool>(false);
        SwrResource<TestUser>? resource = null;
        var loadingAtSetup = false;

        using var client = new TestApp(
            NoRetries,
            serializerOptions: TestJsonContext.Default.Options,
            clientHydrationState: payload);

        client.Mount(() => new If
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
                            resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync);
                            loadingAtSetup = resource.IsLoading.Value;
                        },
                    },
                },
            ],
        });

        visible.Value = true;

        await Assert.That(loadingAtSetup).IsTrue();

        client.Pump();

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
        await Assert.That(resource!.Data.Value).IsEqualTo(new TestUser("Ada", 1844));
    }

    [Test]
    public async Task Explicit_revalidation_of_a_hydrated_value_still_fetches()
    {
        var payload = await RenderOnServerAsync(() => new Probe
        {
            Props = new ProbeProps
            {
                Body = () => SwrResource.Use(
                    ["user", "1"],
                    (_, _) => Task.FromResult(new TestUser("Ada", 1843))),
            },
        });

        var fetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromResult(new TestUser("Ada", 1844)));
        SwrResource<TestUser>? resource = null;

        using var client = new TestApp(
            NoRetries,
            serializerOptions: TestJsonContext.Default.Options,
            clientHydrationState: payload);

        client.MountProbe(() => resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        await client.Pumped(resource!.RevalidateAsync());

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
        await Assert.That(resource.Data.Value).IsEqualTo(new TestUser("Ada", 1844));
    }

    [Test]
    public async Task A_key_that_fails_on_the_server_fails_the_render()
    {
        // A page rendered without data it asked for is a broken page. The failure leaves the
        // drain, and the host turns it into an error response; a key the page can do without is
        // what FetchOnServer = false is for.
        var failure = new InvalidOperationException("upstream is down");
        var fetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromException<TestUser>(failure));
        var prefetch = new ServerPrefetchFeature();
        var hydration = new ServerHydrationStateFeature();
        SwrResource<TestUser>? resource = null;

        using var server = new TestApp(
            NoRetries,
            serializerOptions: TestJsonContext.Default.Options,
            serverPrefetch: prefetch,
            hydrationState: hydration);

        server.MountProbe(() => resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        var thrown = await Assert.That(() => server.DrainAsync(prefetch)).Throws<AggregateException>();

        await Assert.That(thrown!.InnerExceptions).HasSingleItem();
        await Assert.That(thrown.InnerExceptions[0]).IsSameReferenceAs(failure);

        // Recorded as well as thrown, and never transferred.
        await Assert.That(resource!.Error.Value).IsSameReferenceAs(failure);
        var payload = JsonNode.Parse(hydration.Dehydrate().ToJsonString())!.AsObject();
        await Assert.That(payload[SwrFeature.HydrationSection]!.AsObject().Count).IsEqualTo(0);
    }

    [Test]
    public async Task A_run_started_during_setup_does_not_soften_the_server_failure()
    {
        // An explicit revalidation from Setup carries the caller's retries and swallows its
        // failure. The prefetch must not join it, or a failing key would hold the response open
        // for the backoff and then be served as an error the client cannot reproduce.
        var fetcher = new RecordingFetcher<TestUser>((_, _) =>
            Task.FromException<TestUser>(new InvalidOperationException("upstream is down")));
        var prefetch = new ServerPrefetchFeature();
        var options = new SwrOptions { ErrorRetryCount = 5, ErrorRetryInterval = TimeSpan.FromMinutes(10) };

        using var server = new TestApp(
            options,
            serializerOptions: TestJsonContext.Default.Options,
            serverPrefetch: prefetch,
            hydrationState: new ServerHydrationStateFeature());

        server.MountProbe(() => _ = SwrResource.Use(["user", "1"], fetcher.FetchAsync).RevalidateAsync());

        await Assert.That(() => server.DrainAsync(prefetch)).Throws<AggregateException>();

        // The Setup run had not published its failure — it was waiting on a retry — so the
        // prefetch cancels it and asks the upstream itself, once, and raises that answer.
        await Assert.That(fetcher.CallCount).IsEqualTo(2);
        await Assert.That(fetcher.Tokens[0].IsCancellationRequested).IsTrue();
    }

    [Test]
    public async Task Two_components_on_one_failing_key_cost_one_prefetch()
    {
        var failure = new InvalidOperationException("upstream is down");
        var fetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromException<TestUser>(failure));
        var prefetch = new ServerPrefetchFeature();

        using var server = new TestApp(
            NoRetries,
            serializerOptions: TestJsonContext.Default.Options,
            serverPrefetch: prefetch,
            hydrationState: new ServerHydrationStateFeature());

        server.Mount(() => new Probe
        {
            Props = new ProbeProps
            {
                Body = () => SwrResource.Use(["user", "1"], fetcher.FetchAsync),
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

        var thrown = await Assert.That(() => server.DrainAsync(prefetch)).Throws<AggregateException>();

        // The second callback raises the recorded failure rather than asking the upstream again.
        await Assert.That(fetcher.CallCount).IsEqualTo(1);
        await Assert.That(thrown!.InnerExceptions.Count).IsEqualTo(2);
        await Assert.That(thrown.InnerExceptions[1]).IsSameReferenceAs(failure);
    }

    [Test]
    public async Task A_server_host_without_a_prefetch_feature_is_reported()
    {
        // The prefetch feature is what tells a resource it is on the server. A host that renders
        // for hydration without it would have every resource fetch after the render, off the
        // request's thread — so it is refused at mount rather than left to misbehave.
        using var server = new TestApp(
            NoRetries,
            serializerOptions: TestJsonContext.Default.Options,
            hydrationState: new ServerHydrationStateFeature());

        await Assert.That(() => server.MountProbe(() => SwrResource.Use(
                ["user", "1"],
                (_, _) => Task.FromResult(new TestUser("Ada", 1843)))))
            .Throws<InvalidOperationException>();
    }

    [Test]
    public async Task Server_prefetch_does_not_sit_through_a_retry_backoff()
    {
        var fetcher = new RecordingFetcher<TestUser>((_, _) =>
            Task.FromException<TestUser>(new InvalidOperationException("upstream is down")));
        var prefetch = new ServerPrefetchFeature();

        // Retries that would take minutes on the client must not hold the response open.
        var options = new SwrOptions { ErrorRetryCount = 5, ErrorRetryInterval = TimeSpan.FromMinutes(10) };

        using var server = new TestApp(
            options,
            serializerOptions: TestJsonContext.Default.Options,
            serverPrefetch: prefetch,
            hydrationState: new ServerHydrationStateFeature());

        server.MountProbe(() => SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        await Assert.That(() => server.DrainAsync(prefetch)).Throws<AggregateException>();

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
    }

    [Test]
    public async Task A_client_only_resource_is_not_prefetched_on_the_server()
    {
        var fetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromResult(new TestUser("Ada", 1843)));
        var prefetch = new ServerPrefetchFeature();
        var hydration = new ServerHydrationStateFeature();
        SwrResource<TestUser>? resource = null;

        using var server = new TestApp(
            NoRetries,
            serializerOptions: TestJsonContext.Default.Options,
            serverPrefetch: prefetch,
            hydrationState: hydration);

        server.MountProbe(() => resource = SwrResource.Use(
            ["user", "1"],
            fetcher.FetchAsync,
            options => options with { FetchOnServer = false }));

        await server.DrainAsync(prefetch);

        // The fetcher never runs on the server, and the markup shows the loading state — the same
        // state the client will render before it fetches. The key is being fetched, just not
        // here, so it is validating as it will be on the client.
        await Assert.That(fetcher.CallCount).IsEqualTo(0);
        await Assert.That(resource!.IsLoading.Value).IsTrue();
        await Assert.That(resource.IsValidating.Value).IsTrue();

        var payload = JsonNode.Parse(hydration.Dehydrate().ToJsonString())!.AsObject();
        await Assert.That(payload[SwrFeature.HydrationSection]!.AsObject().Count).IsEqualTo(0);
    }

    [Test]
    public async Task Client_only_and_server_fetched_resources_hydrate_side_by_side()
    {
        var serverFetcher = new RecordingFetcher<TestUser>((_, key) =>
            Task.FromResult(new TestUser(key.Segment<string>(1), 1843)));

        var payload = await RenderOnServerAsync(() => new Probe
        {
            Props = new ProbeProps
            {
                Body = () => SwrResource.Use(["user", "both"], serverFetcher.FetchAsync),
                Children =
                [
                    new Probe
                    {
                        Props = new ProbeProps
                        {
                            Body = () => SwrResource.Use(
                                ["user", "client"],
                                serverFetcher.FetchAsync,
                                options => options with { FetchOnServer = false }),
                        },
                    },
                ],
            },
        });

        // Only the key that fetched on the server travels with the page.
        await Assert.That(serverFetcher.CallCount).IsEqualTo(1);
        await Assert.That(serverFetcher.Keys[0]).IsEqualTo(new SwrKey("user", "both"));
        await Assert.That(payload[SwrFeature.HydrationSection]!.AsObject().Count).IsEqualTo(1);

        var clientFetcher = new RecordingFetcher<TestUser>((_, key) =>
            Task.FromResult(new TestUser(key.Segment<string>(1), 2026)));
        SwrResource<TestUser>? both = null;
        SwrResource<TestUser>? clientOnly = null;
        TestUser? bothAtSetup = null;
        var clientOnlyLoadingAtSetup = false;

        using var client = new TestApp(
            NoRetries,
            serializerOptions: TestJsonContext.Default.Options,
            clientHydrationState: payload);

        client.MountProbe(() =>
        {
            both = SwrResource.Use(["user", "both"], clientFetcher.FetchAsync);
            clientOnly = SwrResource.Use(
                ["user", "client"],
                clientFetcher.FetchAsync,
                options => options with { FetchOnServer = false });

            // The first render is the one that has to match the server's markup: the transferred
            // value is there, and the client-only key is still loading, exactly as it was rendered.
            bothAtSetup = both.Data.Value;
            clientOnlyLoadingAtSetup = clientOnly.IsLoading.Value;
        });

        await Assert.That(bothAtSetup).IsEqualTo(new TestUser("both", 1843));
        await Assert.That(clientOnlyLoadingAtSetup).IsTrue();

        // A cycle later the client-only key fetches like any key the page did not carry, and the
        // hydrated one is left alone.
        await Assert.That(clientFetcher.CallCount).IsEqualTo(1);
        await Assert.That(clientFetcher.Keys[0]).IsEqualTo(new SwrKey("user", "client"));
        await Assert.That(clientOnly!.Data.Value).IsEqualTo(new TestUser("client", 2026));
        await Assert.That(clientOnly.IsLoading.Value).IsFalse();
        await Assert.That(both!.Data.Value).IsEqualTo(new TestUser("both", 1843));
    }

    [Test]
    public async Task A_client_only_resource_shares_a_value_another_resource_prefetched()
    {
        // The setting belongs to the caller, not to the entry: when another component fetches the
        // same key on the server, a client-only one is just one more subscriber to that value.
        var fetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromResult(new TestUser("Ada", 1843)));
        var prefetch = new ServerPrefetchFeature();
        SwrResource<TestUser>? clientOnly = null;

        using var server = new TestApp(
            NoRetries,
            serializerOptions: TestJsonContext.Default.Options,
            serverPrefetch: prefetch,
            hydrationState: new ServerHydrationStateFeature());

        server.Mount(() => new Probe
        {
            Props = new ProbeProps
            {
                Body = () => clientOnly = SwrResource.Use(
                    ["user", "1"],
                    fetcher.FetchAsync,
                    options => options with { FetchOnServer = false }),
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

        // Before the drain the key has no value, and the client-only resource reports the request
        // that is coming for it, whichever side runs it.
        await Assert.That(clientOnly!.IsLoading.Value).IsTrue();
        await Assert.That(clientOnly.IsValidating.Value).IsTrue();

        await server.DrainAsync(prefetch);

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
        await Assert.That(clientOnly.Data.Value).IsEqualTo(new TestUser("Ada", 1843));

        // The value travels with the page and the client hydrates it without a request, so the
        // markup must not say one is in flight.
        await Assert.That(clientOnly.IsLoading.Value).IsFalse();
        await Assert.That(clientOnly.IsValidating.Value).IsFalse();
    }

    [Test]
    public async Task A_client_only_key_with_an_instant_fetcher_still_renders_loading_first()
    {
        // The server rendered this key as loading and sent nothing for it. A client fetcher that
        // completes synchronously must not turn the first client render into something else —
        // the request is deferred to the cycle after the render, whatever the fetcher's speed.
        var payload = await RenderOnServerAsync(() => new Probe
        {
            Props = new ProbeProps
            {
                Body = () => SwrResource.Use(
                    ["user", "1"],
                    (_, _) => Task.FromResult(new TestUser("never", 0)),
                    options => options with { FetchOnServer = false }),
            },
        });

        await Assert.That(payload[SwrFeature.HydrationSection]!.AsObject().Count).IsEqualTo(0);

        var fetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromResult(new TestUser("Ada", 1843)));
        SwrResource<TestUser>? resource = null;

        using var client = new TestApp(
            NoRetries,
            serializerOptions: TestJsonContext.Default.Options,
            clientHydrationState: payload);

        client.MountProbe(
            () => resource = SwrResource.Use(
                ["user", "1"],
                fetcher.FetchAsync,
                options => options with { FetchOnServer = false }),
            pump: false);

        // The first render, the one that has to match the markup: nothing has been fetched, but
        // the key is being fetched, as the server rendered it.
        await Assert.That(fetcher.CallCount).IsEqualTo(0);
        await Assert.That(resource!.IsLoading.Value).IsTrue();
        await Assert.That(resource.IsValidating.Value).IsTrue();
        await Assert.That(resource.Data.Value).IsNull();

        client.Pump();

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
        await Assert.That(resource.Data.Value).IsEqualTo(new TestUser("Ada", 1843));
    }

    [Test]
    public async Task Client_only_fetches_normally_in_the_browser()
    {
        // Nothing about the option changes the client: a host with no server prefetch feature
        // fetches after setup whichever way the option is set.
        var fetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromResult(new TestUser("Ada", 1843)));
        SwrResource<TestUser>? resource = null;

        using var client = new TestApp(NoRetries, serializerOptions: TestJsonContext.Default.Options);

        client.MountProbe(() => resource = SwrResource.Use(
            ["user", "1"],
            fetcher.FetchAsync,
            options => options with { FetchOnServer = false }));

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
        await Assert.That(resource!.Data.Value).IsEqualTo(new TestUser("Ada", 1843));
    }

    [Test]
    public async Task A_host_with_no_serializer_options_is_reported()
    {
        // Not a mode to degrade into: a host that cannot serialize what it fetched would render
        // values into markup the browser has no way to read back.
        using var app = new TestApp(NoRetries, serialization: false);

        await Assert.That(() => app.MountProbe(() => SwrResource.Use(
                ["user", "1"],
                (_, _) => Task.FromResult(new TestUser("Ada", 1843)))))
            .Throws<InvalidOperationException>();
    }

    [Test]
    public async Task Serializer_options_can_come_from_a_registered_feature()
    {
        // An app that already configures serialization should not have to hand UseSwr the same
        // options a second time.
        var fetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromResult(new TestUser("Ada", 1843)));
        var prefetch = new ServerPrefetchFeature();
        var hydration = new ServerHydrationStateFeature();

        using var server = new TestApp(
            NoRetries,
            serializerOptionsFeature: TestJsonContext.Default.Options,
            serverPrefetch: prefetch,
            hydrationState: hydration);

        server.MountProbe(() => SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        await server.DrainAsync(prefetch);

        var payload = JsonNode.Parse(hydration.Dehydrate().ToJsonString())!.AsObject();
        await Assert.That(payload[SwrFeature.HydrationSection]!.AsObject().Count).IsEqualTo(1);

        var clientFetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromResult(new TestUser("stale", 0)));
        TestUser? dataAtSetup = null;

        using var client = new TestApp(
            NoRetries,
            serializerOptionsFeature: TestJsonContext.Default.Options,
            clientHydrationState: payload);

        client.MountProbe(() =>
            dataAtSetup = SwrResource.Use(["user", "1"], clientFetcher.FetchAsync).Data.Value);

        await Assert.That(dataAtSetup).IsEqualTo(new TestUser("Ada", 1843));
        await Assert.That(clientFetcher.CallCount).IsEqualTo(0);
    }

    [Test]
    public async Task Options_passed_to_UseSwr_win_over_the_registered_feature()
    {
        // The explicit argument is the more specific statement of intent.
        var fetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromResult(new TestUser("Ada", 1843)));
        var prefetch = new ServerPrefetchFeature();

        using var server = new TestApp(
            NoRetries,
            serializerOptions: TestJsonContext.Default.Options,
            serializerOptionsFeature: new JsonSerializerOptions(),
            serverPrefetch: prefetch,
            hydrationState: new ServerHydrationStateFeature());

        server.MountProbe(() => SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        await server.DrainAsync(prefetch);

        // The empty options in the feature have no metadata for TestUser, so reaching for them
        // would have thrown rather than prefetched.
        await Assert.That(fetcher.CallCount).IsEqualTo(1);
    }

    [Test]
    public async Task A_type_missing_from_the_serializer_context_is_reported()
    {
        using var app = new TestApp(NoRetries, serializerOptions: TestJsonContext.Default.Options);

        await Assert.That(() => app.MountProbe(() => SwrResource.Use(
                ["thing"],
                (_, _) => Task.FromResult(new UncontractedType(1)))))
            .Throws<InvalidOperationException>();
    }

    private sealed record UncontractedType(int Value);
}
