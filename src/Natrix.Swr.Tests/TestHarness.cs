using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Natrix.Browser.Abstractions.Features.HydrationState;
using Natrix.Core;
using Natrix.Core.Components;
using Natrix.Core.Features;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.Features;
using Natrix.Ssr.Abstractions.Features.HydrationState;
using Natrix.Ssr.Features;
using Natrix.Ssr.Features.HydrationState;

namespace Natrix.Swr.Tests;

/// <summary>
/// A render root that renders nothing. The resource under test never touches the DOM, so the
/// tests only need the component lifecycle — mount and unmount — and not any output.
/// </summary>
internal sealed class NullRenderRoot : IRenderRoot
{
    public IRenderSlot CreateFirstSlot() => new NullRenderSlot();
}

internal sealed class NullRenderSlot : IRenderSlot
{
    public IRenderSlot CreateSlotAfter() => new NullRenderSlot();

    public void MoveRangeAfter(IRenderSlot rangeEnd, IRenderSlot anchor)
    {
    }

    public (IComponent? Open, IComponent? Close) CreateComponentBounds() => (null, null);

    public (IComponent? Open, IComponent? Close) CreateForEachBounds() => (null, null);

    public void Dispose()
    {
    }
}

internal sealed class ProbeProps
{
    /// <summary>
    /// Runs in the component's <c>Setup</c>, which is the only place <c>SwrResource.Use</c> is
    /// valid.
    /// </summary>
    public required Action Body { get; init; }

    public IComponent[] Children { get; init; } = [];
}

/// <summary>
/// Minimal component whose only job is to run a test's setup body under real component
/// semantics: its own feature layer and its own effect scope.
/// </summary>
internal sealed class Probe : BaseComponent<ProbeProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        Props.Body();
        exposed = default;
        return Props.Children;
    }
}

/// <summary>
/// Mounts a component tree with SWR registered, the way an application host would.
/// </summary>
/// <remarks>
/// Every request yields to the next cycle of the event loop before it calls its fetcher. Here
/// that cycle is run by hand — <see cref="Mount"/> runs it once the tree is up, <see cref="Pump"/>
/// runs it after anything else that starts a request, and <see cref="DrainAsync"/> runs it
/// alongside the server's prefetch drain — so a test observes the deferral where it matters and
/// never waits on a real scheduler.
/// </remarks>
internal sealed class TestApp : IDisposable
{
    private readonly NatrixHostBuilder _builder;
    private readonly Queue<TaskCompletionSource> _deferred = new();
    private IDisposable? _mounted;
    private IFeatureCollection? _mountedFeatures;

    public TestApp(
        SwrOptions? defaultOptions = null,
        SwrCache? cache = null,
        bool swr = true,
        bool serialization = true,
        JsonSerializerOptions? serializerOptions = null,
        JsonSerializerOptions? serializerOptionsFeature = null,
        ServerPrefetchFeature? serverPrefetch = null,
        ServerHydrationStateFeature? hydrationState = null,
        JsonObject? clientHydrationState = null)
    {
        // Every host has to be able to serialize what it fetches, so tests that are not about the
        // wire format still get the shared context — which is why it covers the primitives they
        // fetch as well as TestUser.
        if (serialization && serializerOptions is null && serializerOptionsFeature is null)
        {
            serializerOptionsFeature = TestJsonContext.Default.Options;
        }

        _cache = cache;

        _builder = new NatrixHostBuilder().UseRootRenderer(new NullRenderRoot());

        if (swr)
        {
            _builder.UseSwr(defaultOptions, cache, serializerOptions);
        }

        // Registered the way an application that already configures serialization would, rather
        // than handed to UseSwr.
        if (serializerOptionsFeature is not null)
        {
            _builder.SetFeature(serializerOptionsFeature);
        }

        if (serverPrefetch is not null)
        {
            _builder.SetFeature<IServerPrefetchFeature>(serverPrefetch);
        }

        if (hydrationState is not null)
        {
            _builder.SetFeature<IServerHydrationStateFeature>(hydrationState);
        }

        if (clientHydrationState is not null)
        {
            _builder.SetFeature<IClientHydrationStateFeature>(new TestClientHydrationState(clientHydrationState));
        }
    }

    private readonly SwrCache? _cache;

    /// <summary>
    /// The cache the application is using. Only resolvable once mounted, since a host that was not
    /// given one builds it from the serialization it finds — which is a mount-time question.
    /// </summary>
    public SwrCache Cache =>
        _cache
        ?? _mountedFeatures?.Get<SwrFeature>()?.Cache
        ?? throw new InvalidOperationException("Mount first, or pass a cache in.");

    /// <summary>
    /// Mounts the tree and, unless <paramref name="pump"/> is <c>false</c>, runs the cycle that
    /// follows — the one in which resources issue their first requests. Pass <c>false</c> to look
    /// at the tree between the two.
    /// </summary>
    public TestApp Mount(Func<IComponent> root, bool pump = true)
    {
        // Captured from inside the tree, which is the only place a feature published by middleware
        // is visible - the host's own collection never sees it.
        _builder.Use(next => new FeatureProvider
        {
            Configure = _ => { },
            Child = () =>
            {
                var features = AppFeatures.Current;
                _mountedFeatures = features;

                if (features?.Get<SwrFeature>() is { } feature)
                {
                    feature.Cache.YieldAsync = DeferAsync;
                }

                return next();
            },
        });

        _mounted = _builder.UseRootComponent(root).Build().Mount();
        return pump ? Pump() : this;
    }

    /// <summary>
    /// Mounts a single probe running <paramref name="body"/>.
    /// </summary>
    public TestApp MountProbe(Action body, bool pump = true) =>
        Mount(() => new Probe { Props = new ProbeProps { Body = body } }, pump);

    /// <summary>
    /// Runs everything waiting for the next cycle, and whatever that work defers in turn, until
    /// nothing is left — the browser's event loop, fast-forwarded to idle.
    /// </summary>
    public TestApp Pump()
    {
        while (_deferred.TryDequeue(out var cycle))
        {
            cycle.SetResult();
        }

        return this;
    }

    /// <summary>
    /// Runs the cycle an imperative operation deferred its request to, and hands the operation
    /// back to be awaited: <c>await app.Pumped(resource.RevalidateAsync())</c>.
    /// </summary>
    public Task Pumped(Task operation)
    {
        Pump();
        return operation;
    }

    /// <summary>
    /// Drains the server's prefetch queue the way the SSR host does, running the deferred cycle
    /// as it goes: each prefetch's request yields before it fetches, and on this host that yield
    /// lands on the same hand-run queue.
    /// </summary>
    public async Task DrainAsync(ServerPrefetchFeature prefetch)
    {
        var drain = prefetch.WaitForCompletionAsync();

        while (!drain.IsCompleted)
        {
            Pump();
            await Task.Yield();
        }

        await drain;
    }

    private Task DeferAsync()
    {
        var cycle = new TaskCompletionSource();
        _deferred.Enqueue(cycle);
        return cycle.Task;
    }

    public void Dispose() => _mounted?.Dispose();
}

/// <summary>
/// Fetcher that records what it was asked for and hands each call's result back to the test.
/// </summary>
internal sealed class RecordingFetcher<TData>(Func<int, SwrKey, Task<TData>> handler)
{
    public List<SwrKey> Keys { get; } = [];

    public List<CancellationToken> Tokens { get; } = [];

    public int CallCount => Keys.Count;

    public Task<TData> FetchAsync(SwrKey key, CancellationToken token)
    {
        var index = Keys.Count;
        Keys.Add(key);
        Tokens.Add(token);

        return handler(index, key);
    }
}

internal sealed class TestClientHydrationState(JsonObject value) : IClientHydrationStateFeature
{
    public JsonObject Value => value;
}

internal sealed record TestUser(string Name, int Followers);

/// <summary>
/// A key segment that is an object rather than a scalar, for the encoding tests: it has a
/// nullable property, which is what an application's ignore-null setting would drop.
/// </summary>
internal sealed record TestFilter(string? Team, int Page);

[JsonSerializable(typeof(TestUser))]
[JsonSerializable(typeof(TestFilter))]
[JsonSerializable(typeof(Dictionary<string, int>))]
[JsonSerializable(typeof(string))]
[JsonSerializable(typeof(int))]
internal sealed partial class TestJsonContext : JsonSerializerContext;
