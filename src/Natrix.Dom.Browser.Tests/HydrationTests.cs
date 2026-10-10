using System.Text.Json.Nodes;
using Natrix.Browser.Abstractions.Features.HydrationState;
using Natrix.Browser.Components;
using Natrix.Core;
using Natrix.Core.Components;
using Natrix.Core.RenderRoot;
using Natrix.Dom.Components;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Browser.Tests;

/// <summary>
/// Components whose server markup differs from what the client renders, hydrated from that markup.
/// </summary>
public class HydrationTests
{
    private sealed class HydrationState : IClientHydrationStateFeature
    {
        public JsonObject Value { get; } = new() { ["hydrate"] = true };
    }

    [Test]
    public async Task Hydrates_textarea_whose_value_the_server_wrote_as_content()
    {
        var container = DomRenderer.CreateContainer();
        container.InnerHTML = "<textarea>v</textarea>";

        using var _ = Hydrate(container, () => new TextArea { Props = new TextAreaProps { Value = new Signal<string>("v") } });

        await Assert.That(DomRenderer.Serialize(container)).IsEqualTo("<textarea>v</textarea>");
        await Assert.That(DomRenderer.GetProperty(container.FirstElementChild!, "value")).IsEqualTo("v");
    }

    [Test]
    public async Task Hydrates_output_whose_value_the_server_wrote_as_content()
    {
        var container = DomRenderer.CreateContainer();
        container.InnerHTML = "<output>v</output>";

        using var _ = Hydrate(container, () => new Output { Props = new OutputProps { Value = new Signal<string>("v") } });

        await Assert.That(DomRenderer.Serialize(container)).IsEqualTo("<output>v</output>");
        await Assert.That(DomRenderer.GetProperty(container.FirstElementChild!, "value")).IsEqualTo("v");
    }

    [Test]
    public async Task Hydrates_select_whose_value_the_server_wrote_on_its_options()
    {
        var container = DomRenderer.CreateContainer();
        container.InnerHTML = """<select><option value="a">a</option><option selected value="b">b</option></select>""";

        using var _ = Hydrate(container, () => new Select
        {
            Props = new SelectProps { Value = new Signal<string>("b") },
            Children = [Option("a"), Option("b")],
        });

        await Assert.That(container.ChildNodes.Length).IsEqualTo(1u);
        await Assert.That(DomRenderer.GetProperty(container.FirstElementChild!, "value")).IsEqualTo("b");
    }

    private static Option Option(string value) => new()
    {
        Props = new OptionProps { Value = new Signal<string>(value) },
        Children = [new DomText { Text = new Signal<string>(value) }],
    };

    private static IDisposable Hydrate(Element container, Func<IComponent> root) =>
        new NatrixHostBuilder()
            .UseRootRenderer(new DomRenderRoot(container))
            .UseLifecycleHooks()
            .SetFeature<IClientHydrationStateFeature>(new HydrationState())
            .UseRootComponent(() => new HydrationRoot { Children = [root()] })
            .Build()
            .Mount();
}
