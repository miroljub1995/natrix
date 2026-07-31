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
/// Body rendered by <c>MountMutator</c>.
/// </summary>
internal sealed class MountMutatorProps
{
    public required Func<IComponent[]> Body { get; init; }
}

/// <summary>
/// Emitted from <c>OnMounted</c> so the parent can mutate state right after the DOM
/// has been claimed.
/// </summary>
[GeneratedEvents]
public partial class MountMutatorEvents
{
    public partial void Mutate();
}

/// <summary>
/// Hydration must be validated against the state the component tree had at Setup time.
/// <c>OnMounted</c> runs after the DOM has been claimed, so any mutation performed there
/// (adding/removing ForEach items, flipping an If condition, changing an attribute or a
/// text binding) is a normal client-side update and must never surface as a
/// <see cref="HydrationMismatchException"/>.
/// </summary>
public class HydrationOnMountedTests
{
    private sealed class TestHydrationState : IClientHydrationStateFeature
    {
        public JsonObject Value { get; } = new() { ["hydrate"] = true };
    }

    /// <summary>
    /// Renders <see cref="MountMutatorProps.Body"/> and emits
    /// <see cref="MountMutatorEvents.Mutate"/> from within <c>OnMounted</c>.
    /// SSR emits <c>&lt;!--[--&gt;...&lt;!--]--&gt;</c> markers around the body.
    /// </summary>
    private sealed class MountMutator : BaseComponent<MountMutatorProps, MountMutatorEvents, NoSlots, NoExpose>
    {
        protected override IComponent[] Setup(out NoExpose exposed)
        {
            exposed = default;

            OnMounted(_ => Events?.Mutate());

            return Props.Body();
        }
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

    private static NatrixHost BuildMutatingHost(
        Element container,
        Func<IComponent[]> body,
        Action mutate)
    {
        return BuildHydrationHost(container, () => new MountMutator
        {
            Props = new MountMutatorProps { Body = body },
            Events = new MountMutatorEvents { OnMutate = mutate },
        });
    }

    private static ForEach<string, string> CreateForEach(IReadOnlySignal<IList<string>> items) => new()
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
    public async Task OnMounted_appending_ForEach_item_does_not_break_hydration()
    {
        // SSR: <!--[--><ul><!--[--><li>a</li><li>b</li><!--]--></ul><!--]-->
        var container = CreateContainerWithHtml(
            "<!--[--><ul><!--[--><li>a</li><li>b</li><!--]--></ul><!--]-->");
        var items = new Signal<IList<string>>(["a", "b"]);

        using var _ = BuildMutatingHost(
            container,
            () =>
            [
                new Ul { Props = new UlProps(), Children = [CreateForEach(items)] },
            ],
            () => items.Value = ["a", "b", "c"]).Mount();

        var ul = container.QuerySelector("ul")!;
        // <!--[-->, <li>a</li>, <li>b</li>, <li>c</li>, <!--]-->
        await Assert.That(ul.ChildNodes.Length).IsEqualTo(5u);
        await Assert.That(ul.ChildNodes.Item(3)!.TextContent).IsEqualTo("c");
    }

    [Test]
    public async Task OnMounted_removing_ForEach_item_does_not_break_hydration()
    {
        var container = CreateContainerWithHtml(
            "<!--[--><ul><!--[--><li>a</li><li>b</li><li>c</li><!--]--></ul><!--]-->");
        var items = new Signal<IList<string>>(["a", "b", "c"]);

        using var _ = BuildMutatingHost(
            container,
            () =>
            [
                new Ul { Props = new UlProps(), Children = [CreateForEach(items)] },
            ],
            () => items.Value = ["b"]).Mount();

        var ul = container.QuerySelector("ul")!;
        // <!--[-->, <li>b</li>, <!--]-->
        await Assert.That(ul.ChildNodes.Length).IsEqualTo(3u);
        await Assert.That(ul.ChildNodes.Item(1)!.TextContent).IsEqualTo("b");
    }

    [Test]
    public async Task OnMounted_flipping_If_condition_does_not_break_hydration()
    {
        // SSR rendered the Otherwise branch.
        var container = CreateContainerWithHtml("<!--[--><span>no</span><!--]-->");
        var condition = new Signal<bool>(false);

        using var _ = BuildMutatingHost(
            container,
            () =>
            [
                new If
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
                },
            ],
            () => condition.Value = true).Mount();

        await Assert.That(container.QuerySelector("span")!.TextContent).IsEqualTo("yes");
        await Assert.That(container.QuerySelectorAll("span").Length).IsEqualTo(1u);
    }

    [Test]
    public async Task OnMounted_changing_attribute_does_not_break_hydration()
    {
        var container = CreateContainerWithHtml(
            "<!--[--><div class=\"initial\" id=\"first\">text</div><!--]-->");
        var cssClass = new Signal<string>("initial");
        var id = new Signal<string>("first");

        using var _ = BuildMutatingHost(
            container,
            () =>
            [
                new Div
                {
                    Props = new DivProps { Class = cssClass, Id = id },
                    Children = [new DomText { Text = new Signal<string>("text") }],
                },
            ],
            () =>
            {
                cssClass.Value = "changed";
                id.Value = "second";
            }).Mount();

        var div = container.QuerySelector("div")!;
        await Assert.That(div.GetAttribute("class")).IsEqualTo("changed");
        await Assert.That(div.GetAttribute("id")).IsEqualTo("second");
    }

    [Test]
    public async Task OnMounted_changing_text_does_not_break_hydration()
    {
        var container = CreateContainerWithHtml("<!--[--><p>initial</p><!--]-->");
        var text = new Signal<string>("initial");

        using var _ = BuildMutatingHost(
            container,
            () =>
            [
                new P { Props = new PProps(), Children = [new DomText { Text = text }] },
            ],
            () => text.Value = "changed").Mount();

        await Assert.That(container.QuerySelector("p")!.TextContent).IsEqualTo("changed");
    }

    [Test]
    public async Task OnMounted_mutating_everything_at_once_does_not_break_hydration()
    {
        // SSR: markers + <div class="initial">initial</div> + <span>no</span> + <ul> ForEach </ul>
        var container = CreateContainerWithHtml(
            "<!--[-->"
            + "<div class=\"initial\">initial</div>"
            + "<span>no</span>"
            + "<ul><!--[--><li>a</li><li>b</li><!--]--></ul>"
            + "<!--]-->");

        var cssClass = new Signal<string>("initial");
        var text = new Signal<string>("initial");
        var condition = new Signal<bool>(false);
        var items = new Signal<IList<string>>(["a", "b"]);

        using var _ = BuildMutatingHost(
            container,
            () =>
            [
                new Div
                {
                    Props = new DivProps { Class = cssClass },
                    Children = [new DomText { Text = text }],
                },
                new If
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
                },
                new Ul { Props = new UlProps(), Children = [CreateForEach(items)] },
            ],
            () =>
            {
                cssClass.Value = "changed";
                text.Value = "changed";
                condition.Value = true;
                items.Value = ["a", "b", "c", "d"];
            }).Mount();

        var div = container.QuerySelector("div")!;
        await Assert.That(div.GetAttribute("class")).IsEqualTo("changed");
        await Assert.That(div.TextContent).IsEqualTo("changed");
        await Assert.That(container.QuerySelector("span")!.TextContent).IsEqualTo("yes");

        var ul = container.QuerySelector("ul")!;
        // <!--[-->, 4 <li>, <!--]-->
        await Assert.That(ul.ChildNodes.Length).IsEqualTo(6u);
        await Assert.That(ul.ChildNodes.Item(4)!.TextContent).IsEqualTo("d");
    }

    [Test]
    public async Task OnMounted_of_nested_child_does_not_break_hydration()
    {
        // Outer component wraps an inner component; the inner one mutates on mount
        // while the outer tree is still being hydrated.
        var container = CreateContainerWithHtml(
            "<!--[--><div><!--[--><span>initial</span><!--]--><p>after</p></div><!--]-->");
        var text = new Signal<string>("initial");

        using var _ = BuildHydrationHost(container, () => new MountMutator
        {
            Props = new MountMutatorProps
            {
                Body = () =>
                [
                    new Div
                    {
                        Props = new DivProps(),
                        Children =
                        [
                            new MountMutator
                            {
                                Props = new MountMutatorProps
                                {
                                    Body = () =>
                                    [
                                        new Span
                                        {
                                            Props = new SpanProps(),
                                            Children = [new DomText { Text = text }],
                                        },
                                    ],
                                },
                                Events = new MountMutatorEvents
                                {
                                    OnMutate = () => text.Value = "changed",
                                },
                            },
                            new P
                            {
                                Props = new PProps(),
                                Children = [new DomText { Text = new Signal<string>("after") }],
                            },
                        ],
                    },
                ],
            },
        }).Mount();

        await Assert.That(container.QuerySelector("span")!.TextContent).IsEqualTo("changed");
        await Assert.That(container.QuerySelector("p")!.TextContent).IsEqualTo("after");
    }
}
