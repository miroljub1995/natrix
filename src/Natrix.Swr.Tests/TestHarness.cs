using Natrix.Core;
using Natrix.Core.Components;
using Natrix.Core.RenderRoot;

namespace Natrix.Swr.Tests;

/// <summary>
/// A render root that renders nothing. The resource under test never touches the DOM, so the
/// tests only need the component lifecycle — mount, unmount, mounted hooks — and not any output.
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
/// semantics: its own feature layer, its own effect scope, and lifecycle hooks.
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
internal sealed class TestApp : IDisposable
{
    private readonly NatrixHostBuilder _builder;
    private IDisposable? _mounted;

    public TestApp(
        SwrOptions? defaultOptions = null,
        SwrCache? cache = null,
        bool lifecycleHooks = true,
        bool swr = true)
    {
        Cache = cache ?? new SwrCache();

        _builder = new NatrixHostBuilder().UseRootRenderer(new NullRenderRoot());

        if (swr)
        {
            _builder.UseSwr(defaultOptions, Cache);
        }

        if (lifecycleHooks)
        {
            _builder.UseLifecycleHooks();
        }
    }

    public SwrCache Cache { get; }

    public TestApp Mount(Func<IComponent> root)
    {
        _mounted = _builder.UseRootComponent(root).Build().Mount();
        return this;
    }

    /// <summary>
    /// Mounts a single probe running <paramref name="body"/>.
    /// </summary>
    public TestApp MountProbe(Action body) =>
        Mount(() => new Probe { Props = new ProbeProps { Body = body } });

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
