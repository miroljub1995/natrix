using System.Text.Json.Nodes;
using Natrix.Browser.Components;
using Natrix.Core;
using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Browser.Abstractions.Features.HydrationState;
using Natrix.Core.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Browser.Tests;

public class HydrationIfTests
{
    private sealed class TestHydrationState : IClientHydrationStateFeature
    {
        public JsonObject Value { get; } = new() { ["hydrate"] = true };
    }

    private static Element CreateContainerWithHtml(string html)
    {
        var container = DomHelpers.CreateContainer();
        container.InnerHTML = html;
        return container;
    }

    private static NatrixHostBuilder CreateHydrationBuilder(Element container)
    {
        return new NatrixHostBuilder()
            .UseRootRenderer(new DomRenderRoot(container))
            .UseLifecycleHooks()
            .SetFeature<IClientHydrationStateFeature>(new TestHydrationState());
    }

    private static NatrixHost BuildHydrationHost(Element container, Func<IComponent> componentFactory)
    {
        return CreateHydrationBuilder(container)
            .UseRootComponent(() => new HydrationRoot { Children = [componentFactory()] })
            .Build();
    }

    [Test]
    public async Task Hydrates_If_then_branch()
    {
        // SSR output when condition is true: <span>yes</span>
        var container = CreateContainerWithHtml("<span>yes</span>");
        var condition = new Signal<bool>(true);

        using var _ = BuildHydrationHost(container, () => new If
            {
                Condition = condition,
                Then = () =>
                [
                    new Span
                    {
                        Props = new SpanProps(),
                        Children = [new DomText { Text = new Signal<string>("yes") }],
                    },
                ],
                Otherwise = () =>
                [
                    new Span
                    {
                        Props = new SpanProps(),
                        Children = [new DomText { Text = new Signal<string>("no") }],
                    },
                ],
            }).Mount();

        await Assert.That(container.TextContent).IsEqualTo("yes");
        await Assert.That(container.ChildNodes.Length).IsEqualTo(1u);
    }

    [Test]
    public async Task Hydrates_If_otherwise_branch()
    {
        // SSR output when condition is false: <span>no</span>
        var container = CreateContainerWithHtml("<span>no</span>");
        var condition = new Signal<bool>(false);

        using var _ = BuildHydrationHost(container, () => new If
            {
                Condition = condition,
                Then = () =>
                [
                    new Span
                    {
                        Props = new SpanProps(),
                        Children = [new DomText { Text = new Signal<string>("yes") }],
                    },
                ],
                Otherwise = () =>
                [
                    new Span
                    {
                        Props = new SpanProps(),
                        Children = [new DomText { Text = new Signal<string>("no") }],
                    },
                ],
            }).Mount();

        await Assert.That(container.TextContent).IsEqualTo("no");
        await Assert.That(container.ChildNodes.Length).IsEqualTo(1u);
    }

    [Test]
    public async Task Hydrates_If_then_switches_branch()
    {
        var container = CreateContainerWithHtml("<span>yes</span>");
        var condition = new Signal<bool>(true);

        using var _ = BuildHydrationHost(container, () => new If
            {
                Condition = condition,
                Then = () =>
                [
                    new Span
                    {
                        Props = new SpanProps(),
                        Children = [new DomText { Text = new Signal<string>("yes") }],
                    },
                ],
                Otherwise = () =>
                [
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = new Signal<string>("no") }],
                    },
                ],
            }).Mount();

        await Assert.That(container.TextContent).IsEqualTo("yes");

        condition.Value = false;

        await Assert.That(container.TextContent).IsEqualTo("no");
        await Assert.That(container.ChildNodes.Length).IsEqualTo(1u);
        await Assert.That(container.ChildNodes.Item(0)!.NodeName).IsEqualTo("P", StringComparison.OrdinalIgnoreCase);
    }

    [Test]
    public async Task Hydrates_If_inside_parent_with_siblings()
    {
        // SSR: <div><p>before</p><span>content</span><p>after</p></div>
        // The If renders the middle <span> (then branch).
        var container = CreateContainerWithHtml(
            "<div><p>before</p><span>content</span><p>after</p></div>");
        var condition = new Signal<bool>(true);

        using var _ = BuildHydrationHost(container, () => new Div
            {
                Props = new DivProps(),
                Children =
                [
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = new Signal<string>("before") }],
                    },
                    new If
                    {
                        Condition = condition,
                        Then = () =>
                        [
                            new Span
                            {
                                Props = new SpanProps(),
                                Children = [new DomText { Text = new Signal<string>("content") }],
                            },
                        ],
                    },
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = new Signal<string>("after") }],
                    },
                ],
            }).Mount();

        var div = container.ChildNodes.Item(0)!;
        await Assert.That(div.ChildNodes.Length).IsEqualTo(3u);
        await Assert.That(div.ChildNodes.Item(0)!.TextContent).IsEqualTo("before");
        await Assert.That(div.ChildNodes.Item(1)!.TextContent).IsEqualTo("content");
        await Assert.That(div.ChildNodes.Item(2)!.TextContent).IsEqualTo("after");
    }

    [Test]
    public async Task Hydrates_If_with_no_otherwise_and_false_condition()
    {
        // When condition is false and no Otherwise, SSR emits nothing.
        var container = CreateContainerWithHtml("");
        var condition = new Signal<bool>(false);

        using var _ = BuildHydrationHost(container, () => new If
            {
                Condition = condition,
                Then = () =>
                [
                    new Span
                    {
                        Props = new SpanProps(),
                        Children = [new DomText { Text = new Signal<string>("visible") }],
                    },
                ],
            }).Mount();

        await Assert.That(container.TextContent).IsEqualTo("");
        await Assert.That(container.ChildNodes.Length).IsEqualTo(0u);

        condition.Value = true;

        await Assert.That(container.TextContent).IsEqualTo("visible");
        await Assert.That(container.ChildNodes.Length).IsEqualTo(1u);
    }
}
