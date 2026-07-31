using System.Text.Json.Nodes;
using Natrix.Browser.Abstractions.Features.HydrationState;
using Natrix.Browser.Components;
using Natrix.Core;
using Natrix.Core.Components;
using Natrix.Core.RenderRoot;
using Natrix.Dom.Components;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Browser.Tests;

/// <summary>
/// A DOM element ref is published through the mount pass rather than the moment the
/// element is created, so it lands together with the mounted hooks — once the tree is
/// complete. These tests pin that contract: what a ref holds during <c>Setup</c> and
/// inside a hook, what a watcher of the ref may do during hydration, and how the ref
/// behaves for elements that appear or disappear after the initial pass.
/// </summary>
public class DomRefTests
{
    private sealed class TestHydrationState : IClientHydrationStateFeature
    {
        public JsonObject Value { get; } = new() { ["hydrate"] = true };
    }

    private sealed class RefProbeProps
    {
        public required Func<ISignal<HTMLDivElement?>, IComponent[]> Body { get; init; }
        public Action<ISignal<HTMLDivElement?>>? Setup { get; init; }
        public Action<ISignal<HTMLDivElement?>>? Mounted { get; init; }
    }

    /// <summary>
    /// Owns a ref, hands it to <see cref="RefProbeProps.Body"/> to attach to an element,
    /// and reports what the ref holds at each lifecycle phase.
    /// </summary>
    private sealed class RefProbe : BaseComponent<RefProbeProps, NoEvents, NoSlots, NoExpose>
    {
        private readonly Signal<HTMLDivElement?> _ref = new(null);

        protected override IComponent[] Setup(out NoExpose exposed)
        {
            exposed = default;

            var children = Props.Body(_ref);

            Props.Setup?.Invoke(_ref);

            if (Props.Mounted is not null)
            {
                var mounted = Props.Mounted;
                OnMounted(_ => mounted(_ref));
            }

            return children;
        }
    }

    private sealed class MountedProbeProps
    {
        public required Action Mounted { get; init; }
    }

    /// <summary>
    /// Contributes nothing to the DOM; exists only to place a mounted hook at a known
    /// position in the pass queue.
    /// </summary>
    private sealed class MountedProbe : BaseComponent<MountedProbeProps, NoEvents, NoSlots, NoExpose>
    {
        protected override IComponent[] Setup(out NoExpose exposed)
        {
            exposed = default;

            var mounted = Props.Mounted;
            OnMounted(_ => mounted());

            return [];
        }
    }

    private static Element CreateContainerWithHtml(string html)
    {
        var container = DomHelpers.CreateContainer();
        container.InnerHTML = html;
        return container;
    }

    private static NatrixHost BuildHost(Element container, Func<IComponent> componentFactory)
    {
        return new NatrixHostBuilder()
            .UseRootRenderer(new DomRenderRoot(container))
            .UseLifecycleHooks()
            .UseRootComponent(componentFactory)
            .Build();
    }

    private static NatrixHost BuildHydrationHost(Element container, Func<IComponent> componentFactory)
    {
        return new NatrixHostBuilder()
            .UseRootRenderer(new DomRenderRoot(container))
            .UseLifecycleHooks()
            .SetFeature<IClientHydrationStateFeature>(new TestHydrationState())
            .UseRootComponent(() => new HydrationRoot { Children = [componentFactory()] })
            .Build();
    }

    private static Div CreateDiv(ISignal<HTMLDivElement?> elementRef, string text) => new()
    {
        Props = new DivProps(),
        Ref = elementRef,
        Children = [new DomText { Text = text.ToConstSignal() }],
    };

    [Test]
    public async Task Ref_is_null_during_Setup_and_populated_by_the_time_hooks_run()
    {
        var container = DomHelpers.CreateContainer();
        HTMLDivElement? duringSetup = null;
        HTMLDivElement? duringMounted = null;

        using var _ = BuildHost(container, () => new RefProbe
        {
            Props = new RefProbeProps
            {
                Body = elementRef => [CreateDiv(elementRef, "content")],
                Setup = elementRef => duringSetup = elementRef.Value,
                Mounted = elementRef => duringMounted = elementRef.Value,
            },
        }).Mount();

        // The element does not exist yet while the tree is being described.
        await Assert.That(duringSetup).IsNull();

        // The ref is queued by the element, which mounts before its owner queues hooks,
        // so a hook always observes the populated ref.
        await Assert.That(duringMounted).IsNotNull();
        await Assert.That(duringMounted!.TextContent).IsEqualTo("content");
        await Assert.That(duringMounted.IsSameNode(container.QuerySelector("div"))).IsTrue();
    }

    [Test]
    public async Task Watcher_of_a_ref_may_mutate_state_without_breaking_hydration()
    {
        // SSR: <!--[--><div>content</div><ul><!--[--><li>a</li><li>b</li><!--]--></ul><!--]-->
        var container = CreateContainerWithHtml(
            "<!--[--><div>content</div><ul><!--[--><li>a</li><li>b</li><!--]--></ul><!--]-->");
        var items = new Signal<IList<string>>(["a", "b"]);

        using var _ = BuildHydrationHost(container, () => new RefProbe
        {
            Props = new RefProbeProps
            {
                Body = elementRef =>
                {
                    // Reacts to the ref being published. Were the ref written while the
                    // tree was still being claimed, this mutation would re-render markup
                    // hydration had not reached yet and throw a mismatch.
                    new Effect(_ =>
                    {
                        if (elementRef.Value is not null)
                        {
                            items.Value = ["a", "b", "c"];
                        }
                    });

                    return
                    [
                        CreateDiv(elementRef, "content"),
                        new Ul
                        {
                            Props = new UlProps(),
                            Children =
                            [
                                new ForEach<string, string>
                                {
                                    Items = items,
                                    Key = s => s,
                                    ElementSetup = s =>
                                    [
                                        new Li
                                        {
                                            Props = new LiProps(),
                                            Children =
                                            [
                                                new DomText { Text = new Computed<string>(() => s.Value) },
                                            ],
                                        },
                                    ],
                                },
                            ],
                        },
                    ];
                },
            },
        }).Mount();

        var ul = container.QuerySelector("ul")!;
        // <!--[-->, <li>a</li>, <li>b</li>, <li>c</li>, <!--]-->
        await Assert.That(ul.ChildNodes.Length).IsEqualTo(5u);
        await Assert.That(ul.ChildNodes.Item(3)!.TextContent).IsEqualTo("c");
        await Assert.That(container.QuerySelector("div")!.TextContent).IsEqualTo("content");
    }

    [Test]
    public async Task Ref_of_an_element_mounted_after_the_initial_pass_is_published()
    {
        var container = DomHelpers.CreateContainer();
        var show = new Signal<bool>(false);
        var elementRef = new Signal<HTMLDivElement?>(null);

        using var _ = BuildHost(container, () => new If
        {
            Condition = show,
            Then = () => [CreateDiv(elementRef, "late")],
        }).Mount();

        await Assert.That(elementRef.Value).IsNull();

        // No component wraps the element, so the element itself has to own the pass that
        // flushes its ref.
        show.Value = true;

        await Assert.That(elementRef.Value).IsNotNull();
        await Assert.That(elementRef.Value!.TextContent).IsEqualTo("late");
    }

    [Test]
    public async Task Ref_is_cleared_when_the_element_unmounts()
    {
        var container = DomHelpers.CreateContainer();
        var show = new Signal<bool>(true);
        var elementRef = new Signal<HTMLDivElement?>(null);

        using var _ = BuildHost(container, () => new If
        {
            Condition = show,
            Then = () => [CreateDiv(elementRef, "content")],
        }).Mount();

        await Assert.That(elementRef.Value).IsNotNull();

        show.Value = false;

        // Left populated, the ref would keep a detached element alive and reachable.
        await Assert.That(elementRef.Value).IsNull();
    }

    [Test]
    public async Task Ref_is_cleared_when_the_host_is_disposed()
    {
        var container = DomHelpers.CreateContainer();
        var elementRef = new Signal<HTMLDivElement?>(null);

        using (var _ = BuildHost(container, () => CreateDiv(elementRef, "content")).Mount())
        {
            await Assert.That(elementRef.Value).IsNotNull();
        }

        await Assert.That(elementRef.Value).IsNull();
    }

    [Test]
    public async Task Ref_of_an_element_unmounted_during_the_flush_is_never_published()
    {
        var container = DomHelpers.CreateContainer();
        var show = new Signal<bool>(true);
        var elementRef = new Signal<HTMLDivElement?>(null);
        var observed = new List<bool>();

        using var _ = BuildHost(container, () => new RefProbe
        {
            Props = new RefProbeProps
            {
                Body = _ =>
                {
                    new Effect(_ => observed.Add(elementRef.Value is not null));

                    return
                    [
                        // Mounts first, so its hook is queued ahead of the element's ref
                        // assignment and tears the element down before the queue reaches it.
                        new MountedProbe { Props = new MountedProbeProps { Mounted = () => show.Value = false } },
                        new If
                        {
                            Condition = show,
                            Then = () => [CreateDiv(elementRef, "doomed")],
                        },
                    ];
                },
            },
        }).Mount();

        // Only the initial null observation: publishing a torn-down element would leave
        // the ref pointing at a detached node for good.
        await Assert.That(observed).IsEquivalentTo(new List<bool> { false });
        await Assert.That(elementRef.Value).IsNull();
    }

    [Test]
    public async Task Ref_is_published_immediately_without_the_lifecycle_hooks_feature()
    {
        var container = DomHelpers.CreateContainer();
        var elementRef = new Signal<HTMLDivElement?>(null);

        // No UseLifecycleHooks: there is no pass to defer to, and a ref must not be
        // dropped the way a mounted hook is.
        using var _ = new NatrixHostBuilder()
            .UseRootRenderer(new DomRenderRoot(container))
            .UseRootComponent(() => CreateDiv(elementRef, "content"))
            .Build()
            .Mount();

        await Assert.That(elementRef.Value).IsNotNull();
        await Assert.That(elementRef.Value!.TextContent).IsEqualTo("content");
    }
}
