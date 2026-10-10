using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Dom.TestCases;
using Natrix.Signals;

namespace Natrix.Dom.Server.Tests;

public class ComponentPropTests
{
    [Test]
    [MethodDataSource(typeof(ComponentPropCases), nameof(ComponentPropCases.All))]
    public async Task Renders_prop(DomCase c)
    {
        Skip.When(c.ServerIssue is not null, c.ServerIssue!);

        var html = await SsrRenderer.RenderAsync(c.Create);

        await Assert.That(html).IsEqualTo(c.Html);
    }

    [Test]
    public async Task Combines_component_and_global_props()
    {
        var html = await SsrRenderer.RenderAsync(() => new A
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

        await Assert.That(html)
            .IsEqualTo("""<a href="/docs" id="link" rel="noopener" target="_blank">Docs</a>""");
    }

    [Test]
    public async Task Reflects_unsigned_prop_updates()
    {
        var width = new Signal<uint>(100);
        var (root, host) = SsrRenderer.Mount(() => new Canvas { Props = new CanvasProps { Width = width } });
        using var _ = host;

        width.Value = 200;

        await Assert.That(await SsrRenderer.WriteAsync(root)).IsEqualTo("""<canvas width="200"></canvas>""");
    }

    [Test]
    public async Task Removes_boolean_prop_when_it_becomes_false()
    {
        var open = new Signal<bool>(true);
        var (root, host) = SsrRenderer.Mount(() => new Dialog { Props = new DialogProps { Open = open } });
        using var _ = host;

        open.Value = false;

        await Assert.That(await SsrRenderer.WriteAsync(root)).IsEqualTo("<dialog></dialog>");
    }

    [Test]
    public async Task Writes_textarea_value_before_default_value_and_children()
    {
        var html = await SsrRenderer.RenderAsync(() => new TextArea
        {
            Props = new TextAreaProps { Value = new Signal<string>("value"), DefaultValue = new Signal<string>("default") },
            Children = [new DomText { Text = new Signal<string>("child") }],
        });

        await Assert.That(html).IsEqualTo("<textarea>value</textarea>");
    }

    [Test]
    public async Task Writes_textarea_default_value_before_children()
    {
        var html = await SsrRenderer.RenderAsync(() => new TextArea
        {
            Props = new TextAreaProps { DefaultValue = new Signal<string>("default") },
            Children = [new DomText { Text = new Signal<string>("child") }],
        });

        await Assert.That(html).IsEqualTo("<textarea>default</textarea>");
    }

    [Test]
    public async Task Writes_textarea_children_without_a_value()
    {
        var html = await SsrRenderer.RenderAsync(() => new TextArea
        {
            Props = new TextAreaProps { Rows = new Signal<uint>(2) },
            Children = [new DomText { Text = new Signal<string>("child") }],
        });

        await Assert.That(html).IsEqualTo("""<textarea rows="2">child</textarea>""");
    }

    [Test]
    public async Task Escapes_textarea_value()
    {
        var html = await SsrRenderer.RenderAsync(() => new TextArea
        {
            Props = new TextAreaProps { Value = new Signal<string>("</textarea><b>") },
        });

        await Assert.That(html).IsEqualTo("<textarea>&lt;/textarea&gt;&lt;b&gt;</textarea>");
    }

    [Test]
    public async Task Writes_output_value_before_default_value_and_children()
    {
        var html = await SsrRenderer.RenderAsync(() => new Output
        {
            Props = new OutputProps { Value = new Signal<string>("value"), DefaultValue = new Signal<string>("default") },
            Children = [new DomText { Text = new Signal<string>("child") }],
        });

        await Assert.That(html).IsEqualTo("<output>value</output>");
    }

    [Test]
    public async Task Reflects_textarea_value_updates()
    {
        var value = new Signal<string>("a");
        var (root, host) = SsrRenderer.Mount(() => new TextArea { Props = new TextAreaProps { Value = value } });
        using var _ = host;

        value.Value = "b";

        await Assert.That(await SsrRenderer.WriteAsync(root)).IsEqualTo("<textarea>b</textarea>");
    }

    [Test]
    public async Task Selects_option_matching_select_value_inside_optgroup()
    {
        var html = await SsrRenderer.RenderAsync(() => new Select
        {
            Props = new SelectProps { Value = new Signal<string>("b") },
            Children =
            [
                new OptGroup { Props = new OptGroupProps { Label = new Signal<string>("g") }, Children = [Option("a"), Option("b")] },
            ],
        });

        await Assert.That(html).IsEqualTo(
            """<select><optgroup label="g"><option value="a">a</option><option selected value="b">b</option></optgroup></select>""");
    }

    [Test]
    public async Task Select_value_overrides_option_selected()
    {
        var html = await SsrRenderer.RenderAsync(() => new Select
        {
            Props = new SelectProps { Value = new Signal<string>("a") },
            Children = [Option("a"), Option("b", selected: true)],
        });

        await Assert.That(html).IsEqualTo(
            """<select><option selected value="a">a</option><option value="b">b</option></select>""");
    }

    [Test]
    public async Task Keeps_option_selected_without_select_value()
    {
        var html = await SsrRenderer.RenderAsync(() => new Select { Children = [Option("a"), Option("b", selected: true)] });

        await Assert.That(html).IsEqualTo(
            """<select><option value="a">a</option><option selected value="b">b</option></select>""");
    }

    [Test]
    public async Task Selects_first_enabled_option_when_select_value_matches_none()
    {
        var html = await SsrRenderer.RenderAsync(() => new Select
        {
            Props = new SelectProps { Value = new Signal<string>("z") },
            Children = [Option("a", disabled: true), Option("b"), Option("c")],
        });

        await Assert.That(html).IsEqualTo(
            """<select><option disabled value="a">a</option><option selected value="b">b</option><option value="c">c</option></select>""");
    }

    [Test]
    public async Task Selects_every_option_in_select_values()
    {
        var html = await SsrRenderer.RenderAsync(() => new Select
        {
            Props = new SelectProps { Values = new Signal<IReadOnlyList<string>>(["a", "c"]) },
            Children = [Option("a"), Option("b", selected: true), Option("c")],
        });

        await Assert.That(html).IsEqualTo(
            """<select><option selected value="a">a</option><option value="b">b</option><option selected value="c">c</option></select>""");
    }

    [Test]
    public async Task Matches_option_without_a_value_on_its_text()
    {
        var html = await SsrRenderer.RenderAsync(() => new Select
        {
            Props = new SelectProps { Value = new Signal<string>("Dark green") },
            Children = [TextOption("Red"), TextOption("  Dark \n  green ")],
        });

        await Assert.That(html).IsEqualTo("<select><option>Red</option><option selected>  Dark \n  green </option></select>");
    }

    [Test]
    public async Task Selects_option_rendered_by_a_nested_component()
    {
        var html = await SsrRenderer.RenderAsync(() => new Select
        {
            Props = new SelectProps { Value = new Signal<string>("b") },
            Children = [new ComposedComponent([Option("a"), Option("b")])],
        });

        await Assert.That(html).IsEqualTo(
            """<select><option value="a">a</option><option selected value="b">b</option></select>""");
    }

    [Test]
    public async Task Reflects_select_value_updates()
    {
        var value = new Signal<string>("a");
        var (root, host) = SsrRenderer.Mount(() => new Select
        {
            Props = new SelectProps { Value = value },
            Children = [Option("a"), Option("b")],
        });
        using var _ = host;

        value.Value = "b";

        await Assert.That(await SsrRenderer.WriteAsync(root)).IsEqualTo(
            """<select><option value="a">a</option><option selected value="b">b</option></select>""");
    }

    [Test]
    public async Task Throws_when_select_value_and_values_are_both_set()
    {
        await Assert.That(() => new SelectProps
        {
            Value = new Signal<string>("a"),
            Values = new Signal<IReadOnlyList<string>>(["a"]),
        }).Throws<InvalidOperationException>();
    }

    private static Option TextOption(string text) => new() { Children = [new DomText { Text = new Signal<string>(text) }] };

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
