using Natrix.Dom.Components;
using Natrix.Core.RenderRoot;
using Natrix.Signals;

namespace Natrix.Browser.Tests;

public class AriaAttributesTests
{
    [Test]
    public async Task Renders_aria_attributes_of_every_value_kind()
    {
        var container = DomHelpers.CreateContainer();

        using var _ = new NatrixHostBuilder()
            .UseRootRenderer(new DomRenderRoot(container))
            .UseLifecycleHooks()
            .UseRootComponent(() => new Button
            {
                Props = new ButtonProps
                {
                    Role = new Signal<string?>("switch"),
                    AriaLabel = new Signal<string?>("Dark mode"),
                    AriaControls = new Signal<string?>("panel"),
                    AriaDescription = new Signal<string?>("Switches the colour scheme"),
                    AriaHidden = new Signal<bool>(false),
                    AriaLevel = new Signal<int>(2),
                    AriaValueNow = new Signal<double>(0.5),
                },
            })
            .Build()
            .Mount();

        var button = container.FirstElementChild!;

        await Assert.That(button.GetAttribute("role")).IsEqualTo("switch");
        await Assert.That(button.GetAttribute("aria-label")).IsEqualTo("Dark mode");
        await Assert.That(button.GetAttribute("aria-controls")).IsEqualTo("panel");
        await Assert.That(button.GetAttribute("aria-description")).IsEqualTo("Switches the colour scheme");
        await Assert.That(button.GetAttribute("aria-hidden")).IsEqualTo("false");
        await Assert.That(button.GetAttribute("aria-level")).IsEqualTo("2");
        await Assert.That(button.GetAttribute("aria-valuenow")).IsEqualTo("0.5");
    }

    [Test]
    public async Task Updates_and_removes_aria_attribute_when_signal_changes()
    {
        var container = DomHelpers.CreateContainer();

        var expanded = new Signal<string?>("false");
        using var _ = new NatrixHostBuilder()
            .UseRootRenderer(new DomRenderRoot(container))
            .UseLifecycleHooks()
            .UseRootComponent(() => new Div
            {
                Props = new DivProps { AriaExpanded = expanded },
            })
            .Build()
            .Mount();

        var div = container.FirstElementChild!;

        expanded.Value = "true";
        await Assert.That(div.GetAttribute("aria-expanded")).IsEqualTo("true");

        expanded.Value = null;
        await Assert.That(div.HasAttribute("aria-expanded")).IsFalse();
    }

    [Test]
    public async Task Removes_id_reference_attribute_when_signal_becomes_null()
    {
        var container = DomHelpers.CreateContainer();

        var labelledBy = new Signal<string?>("heading");
        using var _ = new NatrixHostBuilder()
            .UseRootRenderer(new DomRenderRoot(container))
            .UseLifecycleHooks()
            .UseRootComponent(() => new Div
            {
                Props = new DivProps { AriaLabelledBy = labelledBy },
            })
            .Build()
            .Mount();

        var div = container.FirstElementChild!;
        await Assert.That(div.GetAttribute("aria-labelledby")).IsEqualTo("heading");

        labelledBy.Value = null;
        await Assert.That(div.HasAttribute("aria-labelledby")).IsFalse();
    }

    [Test]
    public async Task Renders_autocapitalize_as_attribute()
    {
        var container = DomHelpers.CreateContainer();

        using var _ = new NatrixHostBuilder()
            .UseRootRenderer(new DomRenderRoot(container))
            .UseLifecycleHooks()
            .UseRootComponent(() => new Div
            {
                Props = new DivProps { Autocapitalize = new Signal<string>("words") },
            })
            .Build()
            .Mount();

        await Assert.That(container.FirstElementChild!.GetAttribute("autocapitalize")).IsEqualTo("words");
    }
}
