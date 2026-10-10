using Natrix.Dom.Components;
using Natrix.Dom.TestCases;
using Natrix.Signals;

namespace Natrix.Dom.Browser.Tests;

/// <summary>
/// The props every element inherits, checked once on <see cref="Div"/>.
/// </summary>
public class GlobalPropTests
{
    [Test]
    [MethodDataSource(typeof(GlobalPropCases), nameof(GlobalPropCases.All))]
    public async Task Renders_prop(DomCase c) => await DomCaseAssert.RendersAsync(c);

    [Test]
    public async Task Reflects_string_prop_updates()
    {
        var id = new Signal<string>("a");

        var html = RenderAfter(new DivProps { Id = id }, () => id.Value = "b");

        await Assert.That(html).IsEqualTo("""<div id="b"></div>""");
    }

    [Test]
    public async Task Replaces_classes_when_class_changes()
    {
        var cls = new Signal<string>("a b");

        var html = RenderAfter(new DivProps { Class = cls }, () => cls.Value = "c");

        await Assert.That(html).IsEqualTo("""<div class="c"></div>""");
    }

    [Test]
    public async Task Replaces_inline_style_when_style_changes()
    {
        var style = new Signal<string>("color: red;");

        var html = RenderAfter(new DivProps { Style = style }, () => style.Value = "margin: 0px;");

        await Assert.That(html).IsEqualTo("""<div style="margin: 0px;"></div>""");
    }

    [Test]
    public async Task Removes_nullable_prop_when_it_becomes_null()
    {
        var label = new Signal<string?>("Close");

        var html = RenderAfter(new DivProps { AriaLabel = label }, () => label.Value = null);

        await Assert.That(html).IsEqualTo("<div></div>");
    }

    [Test]
    public async Task Removes_boolean_prop_when_it_becomes_false()
    {
        var inert = new Signal<bool>(true);

        var html = RenderAfter(new DivProps { Inert = inert }, () => inert.Value = false);

        await Assert.That(html).IsEqualTo("<div></div>");
    }

    [Test]
    public async Task Reflects_enumerated_boolean_prop_updates()
    {
        var translate = new Signal<bool>(true);

        var html = RenderAfter(new DivProps { Translate = translate }, () => translate.Value = false);

        await Assert.That(html).IsEqualTo("""<div translate="no"></div>""");
    }

    [Test]
    public async Task Reflects_numeric_prop_updates()
    {
        var tabIndex = new Signal<int>(0);
        var valueNow = new Signal<double>(0);

        var html = RenderAfter(
            new DivProps { TabIndex = tabIndex, AriaValueNow = valueNow },
            () =>
            {
                tabIndex.Value = -1;
                valueNow.Value = 0.25;
            });

        await Assert.That(html).IsEqualTo("""<div aria-valuenow="0.25" tabindex="-1"></div>""");
    }

    [Test]
    public async Task Removes_hidden_when_it_becomes_false()
    {
        var hidden = new Signal<HiddenOption>(HiddenOption.UntilFound);

        var html = RenderAfter(new DivProps { Hidden = hidden }, () => hidden.Value = HiddenOption.False);

        await Assert.That(html).IsEqualTo("<div></div>");
    }

    [Test]
    public async Task Replaces_data_attributes_when_the_dictionary_changes()
    {
        var data = new Signal<IDictionary<string, string>>(new Dictionary<string, string> { ["a"] = "1", ["b"] = "2" });

        var html = RenderAfter(
            new DivProps { Data = data },
            () => data.Value = new Dictionary<string, string> { ["b"] = "3" });

        await Assert.That(html).IsEqualTo("""<div data-b="3"></div>""");
    }

    private static string RenderAfter(DivProps props, Action update)
    {
        var (container, host) = DomRenderer.Mount(() => new Div { Props = props });
        using (host)
        {
            update();
            return DomRenderer.Serialize(container);
        }
    }
}
