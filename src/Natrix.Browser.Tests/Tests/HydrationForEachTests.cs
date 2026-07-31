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
/// Hydration tests for <see cref="ForEach{TElement,TKey}"/>.
/// The markup fed to the container must match what the SSR renderer emits.
/// Natrix.Ssr cannot be referenced from this browser-wasm project (it carries a
/// Microsoft.AspNetCore.App framework reference), so the markup is written by hand
/// here and pinned on the server side by Natrix.Ssr.Tests/Tests/ForEachTests.cs.
/// </summary>
public class HydrationForEachTests
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

    private static NatrixHost BuildHydrationHost(Element container, Func<IComponent> componentFactory)
    {
        return new NatrixHostBuilder()
            .UseRootRenderer(new DomRenderRoot(container))
            .UseLifecycleHooks()
            .SetFeature<IClientHydrationStateFeature>(new TestHydrationState())
            .UseRootComponent(() => new HydrationRoot { Children = [componentFactory()] })
            .Build();
    }

    private static ForEach<string, string> CreateForEach(Signal<IList<string>> items) => new()
    {
        Items = items,
        Key = s => s,
        ElementSetup = s =>
        [
            new Li
            {
                Props = new LiProps(),
                Children = [new DomText { Text = new Computed<string>(() => s.Value) }],
            },
        ],
    };

    [Test]
    public async Task Hydrates_ForEach_with_items()
    {
        // SSR output: <ul><!--[--><li>a</li><li>b</li><li>c</li><!--]--></ul>
        var container = CreateContainerWithHtml("<ul><!--[--><li>a</li><li>b</li><li>c</li><!--]--></ul>");
        var items = new Signal<IList<string>>(["a", "b", "c"]);

        using var _ = BuildHydrationHost(container, () => new Ul
        {
            Props = new UlProps(),
            Children = [CreateForEach(items)],
        }).Mount();

        var ul = container.ChildNodes.Item(0)!;
        // 5 nodes: <!--[-->, <li>a</li>, <li>b</li>, <li>c</li>, <!--]-->
        await Assert.That(ul.ChildNodes.Length).IsEqualTo(5u);
        await Assert.That(ul.ChildNodes.Item(1)!.TextContent).IsEqualTo("a");
        await Assert.That(ul.ChildNodes.Item(2)!.TextContent).IsEqualTo("b");
        await Assert.That(ul.ChildNodes.Item(3)!.TextContent).IsEqualTo("c");
        await Assert.That(ul.ChildNodes.Item(4)!.NodeType).IsEqualTo(Node.COMMENT_NODE);
    }

    [Test]
    public async Task Hydrates_empty_ForEach()
    {
        // SSR output with no items: <ul><!--[--><!--]--></ul>
        var container = CreateContainerWithHtml("<ul><!--[--><!--]--></ul>");
        var items = new Signal<IList<string>>([]);

        using var _ = BuildHydrationHost(container, () => new Ul
        {
            Props = new UlProps(),
            Children = [CreateForEach(items)],
        }).Mount();

        var ul = container.ChildNodes.Item(0)!;
        await Assert.That(ul.ChildNodes.Length).IsEqualTo(2u);
    }

    [Test]
    public async Task Hydrates_ForEach_followed_by_sibling()
    {
        // SSR output: <ul><!--[--><li>a</li><li>b</li><!--]--><li>static</li></ul>
        var container = CreateContainerWithHtml(
            "<ul><!--[--><li>a</li><li>b</li><!--]--><li>static</li></ul>");
        var items = new Signal<IList<string>>(["a", "b"]);

        using var _ = BuildHydrationHost(container, () => new Ul
        {
            Props = new UlProps(),
            Children =
            [
                CreateForEach(items),
                new Li
                {
                    Props = new LiProps(),
                    Children = [new DomText { Text = new Signal<string>("static") }],
                },
            ],
        }).Mount();

        var ul = container.ChildNodes.Item(0)!;
        // 5 nodes: <!--[-->, <li>a</li>, <li>b</li>, <!--]-->, <li>static</li>
        await Assert.That(ul.ChildNodes.Length).IsEqualTo(5u);
        await Assert.That(ul.ChildNodes.Item(3)!.NodeType).IsEqualTo(Node.COMMENT_NODE);
        await Assert.That(ul.ChildNodes.Item(4)!.TextContent).IsEqualTo("static");
    }

    [Test]
    public async Task Hydrated_ForEach_stays_reactive()
    {
        var container = CreateContainerWithHtml("<ul><!--[--><li>a</li><li>b</li><!--]--></ul>");
        var items = new Signal<IList<string>>(["a", "b"]);

        using var _ = BuildHydrationHost(container, () => new Ul
        {
            Props = new UlProps(),
            Children = [CreateForEach(items)],
        }).Mount();

        items.Value = ["a", "b", "c"];

        var ul = container.ChildNodes.Item(0)!;
        // 5 nodes: <!--[-->, <li>a</li>, <li>b</li>, <li>c</li>, <!--]-->
        await Assert.That(ul.ChildNodes.Length).IsEqualTo(5u);
        await Assert.That(ul.ChildNodes.Item(3)!.TextContent).IsEqualTo("c");
        await Assert.That(ul.ChildNodes.Item(4)!.NodeType).IsEqualTo(Node.COMMENT_NODE);

        items.Value = ["b"];

        await Assert.That(ul.ChildNodes.Length).IsEqualTo(3u);
        await Assert.That(ul.ChildNodes.Item(1)!.TextContent).IsEqualTo("b");
        await Assert.That(ul.ChildNodes.Item(2)!.NodeType).IsEqualTo(Node.COMMENT_NODE);
    }

    [Test]
    public async Task Throws_when_ForEach_item_count_does_not_match_server_output()
    {
        // SSR rendered 2 items but the client has 3.
        var container = CreateContainerWithHtml("<ul><!--[--><li>a</li><li>b</li><!--]--></ul>");
        var items = new Signal<IList<string>>(["a", "b", "c"]);

        var act = () =>
        {
            using var _ = BuildHydrationHost(container, () => new Ul
            {
                Props = new UlProps(),
                Children = [CreateForEach(items)],
            }).Mount();
        };

        await Assert.That(act).Throws<HydrationMismatchException>();
    }
}
