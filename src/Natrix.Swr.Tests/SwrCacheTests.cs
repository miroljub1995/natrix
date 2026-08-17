using Natrix.Core.Components;
using Natrix.Signals;

namespace Natrix.Swr.Tests;

public class SwrCacheTests
{
    private static readonly SwrOptions NoRetries = new() { ShouldRetryOnError = false };

    [Test]
    public async Task Entries_outlive_the_components_that_created_them()
    {
        var fetcher = new RecordingFetcher<string>((_, _) => Task.FromResult("Ada"));
        var cache = new SwrCache();

        using (var app = new TestApp(NoRetries, cache))
        {
            app.MountProbe(() => SwrResource.Use(["user", "1"], fetcher.FetchAsync));
        }

        await Assert.That(cache.Count).IsEqualTo(1);

        // A second app on the same cache renders the value without waiting for its own request.
        string? dataAtSetup = null;
        using var second = new TestApp(NoRetries, cache);
        second.MountProbe(() =>
        {
            var resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync);
            dataAtSetup = resource.Data.Value;
        });

        await Assert.That(dataAtSetup).IsEqualTo("Ada");
    }

    [Test]
    public async Task Remove_drops_the_entry()
    {
        var fetcher = new RecordingFetcher<string>((_, _) => Task.FromResult("Ada"));
        var cache = new SwrCache();

        using (var app = new TestApp(NoRetries, cache))
        {
            app.MountProbe(() => SwrResource.Use(["user", "1"], fetcher.FetchAsync));
        }

        await Assert.That(cache.Remove(new SwrKey("user", "1"))).IsTrue();
        await Assert.That(cache.Count).IsEqualTo(0);
        await Assert.That(cache.Remove(new SwrKey("user", "1"))).IsFalse();

        string? dataAtSetup = "not-set";
        using var second = new TestApp(NoRetries, cache);
        second.MountProbe(() =>
        {
            var resource = SwrResource.Use(["user", "1"], fetcher.FetchAsync);
            dataAtSetup = resource.Data.Value;
        });

        await Assert.That(dataAtSetup).IsNull();
    }

    [Test]
    public async Task Remove_abandons_a_request_in_flight()
    {
        var completion = new TaskCompletionSource<string>();
        var fetcher = new RecordingFetcher<string>((_, _) => completion.Task);

        using var app = new TestApp(NoRetries);
        app.MountProbe(() => SwrResource.Use(["user", "1"], fetcher.FetchAsync));

        app.Cache.Remove(new SwrKey("user", "1"));

        await Assert.That(fetcher.Tokens[0].IsCancellationRequested).IsTrue();
    }

    [Test]
    public async Task Clear_drops_every_entry()
    {
        var fetcher = new RecordingFetcher<string>((_, key) => Task.FromResult(key[1]));

        using var app = new TestApp(NoRetries);
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
                            Body = () => SwrResource.Use(["user", "2"], fetcher.FetchAsync),
                        },
                    },
                ],
            },
        });

        await Assert.That(app.Cache.Count).IsEqualTo(2);

        app.Cache.Clear();

        await Assert.That(app.Cache.Count).IsEqualTo(0);
    }

    [Test]
    public async Task A_key_cannot_be_shared_by_two_data_types()
    {
        using var app = new TestApp(NoRetries);

        await Assert.That(() => app.MountProbe(() =>
        {
            SwrResource.Use(["thing"], (_, _) => Task.FromResult("text"));
            SwrResource.Use(["thing"], (_, _) => Task.FromResult(42));
        })).Throws<InvalidOperationException>();
    }

    [Test]
    public async Task Use_outside_a_component_setup_throws()
    {
        await Assert.That(() => SwrResource.Use(["user", "1"], (_, _) => Task.FromResult("Ada")))
            .Throws<InvalidOperationException>();
    }

    [Test]
    public async Task Use_without_a_registered_cache_throws()
    {
        using var app = new TestApp(swr: false);

        await Assert.That(() =>
                app.MountProbe(() => SwrResource.Use(["user", "1"], (_, _) => Task.FromResult("Ada"))))
            .Throws<InvalidOperationException>();
    }

    [Test]
    public async Task Negative_retry_count_is_rejected()
    {
        using var app = new TestApp();

        await Assert.That(() => app.MountProbe(() => SwrResource.Use(
                ["user", "1"],
                (_, _) => Task.FromResult("Ada"),
                new SwrOptions { ErrorRetryCount = -1 })))
            .Throws<ArgumentOutOfRangeException>();
    }

    [Test]
    public async Task Negative_retry_interval_is_rejected()
    {
        using var app = new TestApp();

        await Assert.That(() => app.MountProbe(() => SwrResource.Use(
                ["user", "1"],
                (_, _) => Task.FromResult("Ada"),
                new SwrOptions { ErrorRetryInterval = TimeSpan.FromSeconds(-1) })))
            .Throws<ArgumentOutOfRangeException>();
    }

    [Test]
    public async Task Retry_delay_doubles_and_stops_doubling_at_the_cap()
    {
        var options = new SwrOptions { ErrorRetryInterval = TimeSpan.FromSeconds(1) };

        await Assert.That(options.GetRetryDelay(0)).IsEqualTo(TimeSpan.FromSeconds(1));
        await Assert.That(options.GetRetryDelay(1)).IsEqualTo(TimeSpan.FromSeconds(2));
        await Assert.That(options.GetRetryDelay(3)).IsEqualTo(TimeSpan.FromSeconds(8));
        await Assert.That(options.GetRetryDelay(8)).IsEqualTo(TimeSpan.FromSeconds(256));
        await Assert.That(options.GetRetryDelay(20)).IsEqualTo(TimeSpan.FromSeconds(256));
    }

    [Test]
    public async Task Default_options_retry_three_times()
    {
        await Assert.That(SwrOptions.Default.ShouldRetryOnError).IsTrue();
        await Assert.That(SwrOptions.Default.ErrorRetryCount).IsEqualTo(3);
    }
}
