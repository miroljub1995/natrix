using Natrix.Dom.Components;
using Natrix.Dom.TestCases;
using Natrix.Signals;

namespace Natrix.Dom.Server.Tests;

/// <summary>
/// The props every element inherits, checked once on <see cref="Div"/>.
/// </summary>
public class GlobalPropTests
{
    [Test]
    [MethodDataSource(typeof(GlobalPropCases), nameof(GlobalPropCases.All))]
    public async Task Renders_prop(DomCase c)
    {
        var html = await SsrRenderer.RenderAsync(c.Create);

        await Assert.That(html).IsEqualTo(c.Html);
    }

    [Test]
    public async Task Reflects_string_prop_updates()
    {
        var id = new Signal<string>("a");

        var html = await RenderAfter(new DivProps { Id = id }, () => id.Value = "b");

        await Assert.That(html).IsEqualTo("""<div id="b"></div>""");
    }

    [Test]
    public async Task Removes_nullable_prop_when_it_becomes_null()
    {
        var label = new Signal<string?>("Close");

        var html = await RenderAfter(new DivProps { AriaLabel = label }, () => label.Value = null);

        await Assert.That(html).IsEqualTo("<div></div>");
    }

    [Test]
    public async Task Removes_boolean_prop_when_it_becomes_false()
    {
        var inert = new Signal<bool>(true);

        var html = await RenderAfter(new DivProps { Inert = inert }, () => inert.Value = false);

        await Assert.That(html).IsEqualTo("<div></div>");
    }

    [Test]
    public async Task Reflects_enumerated_boolean_prop_updates()
    {
        var translate = new Signal<bool>(true);

        var html = await RenderAfter(new DivProps { Translate = translate }, () => translate.Value = false);

        await Assert.That(html).IsEqualTo("""<div translate="no"></div>""");
    }

    [Test]
    public async Task Reflects_numeric_prop_updates()
    {
        var tabIndex = new Signal<int>(0);
        var valueNow = new Signal<double>(0);

        var html = await RenderAfter(
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

        var html = await RenderAfter(new DivProps { Hidden = hidden }, () => hidden.Value = HiddenOption.False);

        await Assert.That(html).IsEqualTo("<div></div>");
    }

    [Test]
    public async Task Replaces_data_attributes_when_the_dictionary_changes()
    {
        var data = new Signal<IDictionary<string, string>>(new Dictionary<string, string> { ["a"] = "1", ["b"] = "2" });

        var html = await RenderAfter(
            new DivProps { Data = data },
            () => data.Value = new Dictionary<string, string> { ["b"] = "3" });

        await Assert.That(html).IsEqualTo("""<div data-b="3"></div>""");
    }

    [Test]
    public async Task Escapes_attribute_values()
    {
        var html = await SsrRenderer.RenderAsync(() => new Div
        {
            Props = new DivProps { Title = new Signal<string>("\"a\" & <b>") },
        });

        await Assert.That(html).IsEqualTo("""<div title="&quot;a&quot; &amp; &lt;b&gt;"></div>""");
    }

    private static async Task<string> RenderAfter(DivProps props, Action update)
    {
        var (root, host) = SsrRenderer.Mount(() => new Div { Props = props });
        using (host)
        {
            update();
            return await SsrRenderer.WriteAsync(root);
        }
    }
}
