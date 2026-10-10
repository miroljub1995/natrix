using Natrix.Dom.Components;
using Natrix.Dom.TestCases;
using Natrix.JSCore;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Browser.Tests;

public class ComponentPropTests
{
    [Test]
    [MethodDataSource(typeof(ComponentPropCases), nameof(ComponentPropCases.All))]
    public async Task Renders_prop(DomCase c) => await DomCaseAssert.RendersAsync(c);

    [Test]
    public async Task Combines_component_and_global_props()
    {
        var (container, host) = DomRenderer.Mount(() => new A
        {
            Props = new AProps
            {
                Href = new Signal<string>("/docs"),
                Target = new Signal<string>("_blank"),
                Rel = new Signal<string>("noopener"),
                Id = new Signal<string>("link"),
            },
            Children = [new DomText { Text = new Signal<string>("Docs") }],
        });
        using var _ = host;

        await Assert.That(DomRenderer.Serialize(container))
            .IsEqualTo("""<a href="/docs" id="link" rel="noopener" target="_blank">Docs</a>""");
    }

    [Test]
    public async Task Reflects_unsigned_prop_updates()
    {
        var width = new Signal<uint>(100);
        var (container, host) = DomRenderer.Mount(() => new Canvas { Props = new CanvasProps { Width = width } });
        using var _ = host;

        width.Value = 200;

        await Assert.That(DomRenderer.Serialize(container)).IsEqualTo("""<canvas width="200"></canvas>""");
    }

    [Test]
    public async Task Removes_boolean_prop_when_it_becomes_false()
    {
        var open = new Signal<bool>(true);
        var (container, host) = DomRenderer.Mount(() => new Dialog { Props = new DialogProps { Open = open } });
        using var _ = host;

        open.Value = false;

        await Assert.That(DomRenderer.Serialize(container)).IsEqualTo("<dialog></dialog>");
    }

    [Test]
    public async Task Updates_input_value_when_signal_changes()
    {
        var value = new Signal<string>("a");
        var (container, host) = DomRenderer.Mount(() => new Input { Props = new InputProps { Value = value } });
        using var _ = host;

        value.Value = "b";

        await Assert.That(DomRenderer.GetProperty(container.FirstElementChild!, "value")).IsEqualTo("b");
    }

    [Test]
    public async Task Selects_the_option_matching_select_value_when_it_changes()
    {
        var value = new Signal<string>("a");
        var (container, host) = DomRenderer.Mount(() => new Select
        {
            Props = new SelectProps { Value = value },
            Children = [Option("a"), Option("b")],
        });
        using var _ = host;

        value.Value = "b";

        await Assert.That(DomRenderer.GetProperty(container.FirstElementChild!, "value")).IsEqualTo("b");
    }

    [Test]
    public async Task Selects_every_option_in_select_values_when_they_change()
    {
        var values = new Signal<IReadOnlyList<string>>(["a"]);
        var (container, host) = DomRenderer.Mount(() => new Select
        {
            Props = new SelectProps { Multiple = new Signal<bool>(true), Values = values },
            Children = [Option("a"), Option("b"), Option("c")],
        });
        using var _ = host;

        await Assert.That(SelectedValues(container)).IsEqualTo("a");

        values.Value = ["b", "c"];

        await Assert.That(SelectedValues(container)).IsEqualTo("b,c");
    }

    [Test]
    public async Task Selects_first_enabled_option_when_select_value_matches_none()
    {
        var (container, host) = DomRenderer.Mount(() => new Select
        {
            Props = new SelectProps { Value = new Signal<string>("z") },
            Children = [Option("a", disabled: true), Option("b"), Option("c")],
        });
        using var _ = host;

        await Assert.That(SelectedValues(container)).IsEqualTo("b");
    }

    [Test]
    public async Task Select_value_overrides_option_selected()
    {
        var (container, host) = DomRenderer.Mount(() => new Select
        {
            Props = new SelectProps { Value = new Signal<string>("a") },
            Children = [Option("a"), Option("b", selected: true)],
        });
        using var _ = host;

        await Assert.That(SelectedValues(container)).IsEqualTo("a");
    }

    /// <summary>The values of the selected options, comma-separated in document order.</summary>
    private static string SelectedValues(Element container)
    {
        var select = JSObjectProxyFactory.GetProxy<HTMLSelectElement>(container.FirstElementChild!.JSObject);
        var selected = select.SelectedOptions;
        var values = new string?[selected.Length];
        for (uint i = 0; i < selected.Length; i++)
        {
            values[i] = selected.Item(i)!.GetAttribute("value");
        }

        return string.Join(",", values);
    }

    private static Option Option(string value, bool selected = false, bool disabled = false) => new()
    {
        Props = new OptionProps
        {
            Value = new Signal<string>(value),
            Selected = selected ? new Signal<bool>(true) : null,
            Disabled = disabled ? new Signal<bool>(true) : null,
        },
        Children = [new DomText { Text = new Signal<string>(value) }],
    };
}
