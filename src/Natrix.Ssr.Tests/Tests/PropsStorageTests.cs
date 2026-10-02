using Natrix.Core;
using Natrix.Dom.Components;
using Natrix.Ssr.RenderRoot;
using Natrix.Signals;

namespace Natrix.Ssr.Tests.Tests;

/// <summary>
/// Tests for the sparse props storage in <see cref="BaseDomComponentProps{TElement}"/>: getters, and
/// props declared at different levels of the hierarchy rendering together.
/// </summary>
public class PropsStorageTests
{
    [Test]
    public async Task Getter_returns_the_signal_that_was_set()
    {
        var disabled = new Signal<bool>(true);
        var id = new Signal<string>("save");
        var label = new Signal<string?>("Save");

        var props = new ButtonProps { Disabled = disabled, Id = id, AriaLabel = label };

        await Assert.That(props.Disabled).IsSameReferenceAs(disabled);
        await Assert.That(props.Id).IsSameReferenceAs(id);
        await Assert.That(props.AriaLabel).IsSameReferenceAs(label);
    }

    [Test]
    public async Task Getter_returns_null_for_props_that_were_not_set()
    {
        var props = new ButtonProps { Disabled = new Signal<bool>(true) };

        await Assert.That(props.Name).IsNull();
        await Assert.That(props.Class).IsNull();
        await Assert.That(props.Role).IsNull();
    }

    [Test]
    public async Task Hidden_Data_prop_is_stored_separately_from_the_base_one()
    {
        var data = new Signal<string>("movie.swf");

        var props = new ObjectProps { Data = data };

        await Assert.That(props.Data).IsSameReferenceAs(data);
        await Assert.That(((GlobalHtmlComponentProps<Natrix.StdWeb.HTMLObjectElement>)props).Data).IsNull();
    }

    [Test]
    public async Task Props_from_every_level_of_the_hierarchy_render_together()
    {
        var root = new SsrRenderRoot();

        using var _ = new NatrixHostBuilder()
            .UseRootRenderer(root)
            .UseRootComponent(() => new Button
            {
                Props = new ButtonProps
                {
                    Type = new Signal<string>("submit"),
                    Class = new Signal<string>("btn"),
                    AriaLabel = new Signal<string?>("Save"),
                    Disabled = new Signal<bool>(true),
                },
            })
            .Build()
            .Mount();

        var output = await SsrHelpers.RenderAsync(root);

        await Assert.That(output).IsEqualTo("<button aria-label=\"Save\" class=\"btn\" disabled type=\"submit\"></button>");
    }
}
