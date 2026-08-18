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
    /// Renders a tree the way the SSR host does — no lifecycle hooks, a prefetch feature to drain
    /// — and returns the payload the page would carry.
    /// </summary>
    private static async Task<JsonObject> RenderOnServerAsync(Func<IComponent> root)
    {
        var prefetch = new ServerPrefetchFeature();
        var hydration = new ServerHydrationStateFeature();

        using var app = new TestApp(
            NoRetries,
            lifecycleHooks: false,
            serializerOptions: TestJsonContext.Default.Options,
            serverPrefetch: prefetch,
            hydrationState: hydration);

        app.Mount(root);

        await prefetch.WaitForCompletionAsync();

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
            lifecycleHooks: false,
            serializerOptions: TestJsonContext.Default.Options,
            serverPrefetch: prefetch,
            hydrationState: new ServerHydrationStateFeature());

        app.MountProbe(() => resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        // Nothing has run yet: mounting only registers, the drain is what fetches.
        await Assert.That(fetcher.CallCount).IsEqualTo(0);
        await Assert.That(resource!.IsLoading.Value).IsTrue();

        await prefetch.WaitForCompletionAsync();

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
        await Assert.That(resource.Data.Value).IsEqualTo(new TestUser("Ada", 1843));
        await Assert.That(resource.IsLoading.Value).IsFalse();
    }

    [Test]
    public async Task Two_components_on_one_key_cost_one_prefetch()
    {
        var fetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromResult(new TestUser("Ada", 1843)));
        var prefetch = new ServerPrefetchFeature();

        using var app = new TestApp(
            NoRetries,
            lifecycleHooks: false,
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

        await prefetch.WaitForCompletionAsync();

        // The drain runs callbacks one at a time, so deduplicating in-flight requests is not
        // enough here: the second callback has to see the value the first one produced.
        await Assert.That(fetcher.CallCount).IsEqualTo(1);
    }

    [Test]
    public async Task Client_hydrates_the_payload_without_fetching()
    {
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

        // Hydration freshness covers the first render, not the whole session.
        visible.Value = false;
        visible.Value = true;

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
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

        await resource!.RevalidateAsync();

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
        await Assert.That(resource.Data.Value).IsEqualTo(new TestUser("Ada", 1844));
    }

    [Test]
    public async Task A_key_that_fails_on_the_server_is_left_to_the_client()
    {
        var serverFetcher = new RecordingFetcher<TestUser>((_, _) =>
            Task.FromException<TestUser>(new InvalidOperationException("upstream is down")));
        var prefetch = new ServerPrefetchFeature();
        var hydration = new ServerHydrationStateFeature();
        SwrResource<TestUser>? serverResource = null;

        using (var server = new TestApp(
            NoRetries,
            lifecycleHooks: false,
            serializerOptions: TestJsonContext.Default.Options,
            serverPrefetch: prefetch,
            hydrationState: hydration))
        {
            server.MountProbe(() => serverResource = SwrResource.Use(["user", "1"], serverFetcher.FetchAsync));

            // A failed prefetch must not fault the render - the page still has to be served.
            await prefetch.WaitForCompletionAsync();
        }

        // The server renders the loading state rather than an error it cannot transfer, so the
        // client's first render agrees with the markup.
        await Assert.That(serverResource!.IsLoading.Value).IsTrue();
        await Assert.That(serverResource.Error.Value).IsNull();

        var payload = JsonNode.Parse(hydration.Dehydrate().ToJsonString())!.AsObject();
        await Assert.That(payload[SwrFeature.HydrationSection]!.AsObject().Count).IsEqualTo(0);

        var clientFetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromResult(new TestUser("Ada", 1843)));
        SwrResource<TestUser>? clientResource = null;

        using var client = new TestApp(
            NoRetries,
            serializerOptions: TestJsonContext.Default.Options,
            clientHydrationState: payload);

        client.MountProbe(() => clientResource = SwrResource.Use(["user", "1"], clientFetcher.FetchAsync));

        await Assert.That(clientFetcher.CallCount).IsEqualTo(1);
        await Assert.That(clientResource!.Data.Value).IsEqualTo(new TestUser("Ada", 1843));
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
            lifecycleHooks: false,
            serializerOptions: TestJsonContext.Default.Options,
            serverPrefetch: prefetch,
            hydrationState: new ServerHydrationStateFeature());

        server.MountProbe(() => SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        await prefetch.WaitForCompletionAsync();

        await Assert.That(fetcher.CallCount).IsEqualTo(1);
    }

    [Test]
    public async Task Server_does_not_prefetch_without_serializer_options()
    {
        // Prefetching a value that cannot be transferred would render data on the server and a
        // loading state on the client.
        var fetcher = new RecordingFetcher<TestUser>((_, _) => Task.FromResult(new TestUser("Ada", 1843)));
        var prefetch = new ServerPrefetchFeature();
        SwrResource<TestUser>? resource = null;

        using var server = new TestApp(
            NoRetries,
            lifecycleHooks: false,
            serverPrefetch: prefetch,
            hydrationState: new ServerHydrationStateFeature());

        server.MountProbe(() => resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        await prefetch.WaitForCompletionAsync();

        await Assert.That(fetcher.CallCount).IsEqualTo(0);
        await Assert.That(resource!.IsLoading.Value).IsTrue();
    }

    [Test]
    public async Task A_payload_the_client_cannot_read_is_reported()
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

        using var client = new TestApp(NoRetries, clientHydrationState: payload);

        await Assert.That(() => client.MountProbe(() => SwrResource.Use(
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
            lifecycleHooks: false,
            serializerOptionsFeature: TestJsonContext.Default.Options,
            serverPrefetch: prefetch,
            hydrationState: hydration);

        server.MountProbe(() => SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        await prefetch.WaitForCompletionAsync();

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
            lifecycleHooks: false,
            serializerOptions: TestJsonContext.Default.Options,
            serializerOptionsFeature: new JsonSerializerOptions(),
            serverPrefetch: prefetch,
            hydrationState: new ServerHydrationStateFeature());

        server.MountProbe(() => SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        await prefetch.WaitForCompletionAsync();

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
