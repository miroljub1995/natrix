using Natrix.Core;
using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Ssr.RenderRoot;
using Natrix.Signals;

namespace Natrix.Ssr.Tests.Tests;

public class SsrEscapingTests
{
    private static async Task<string> RenderAsync(Func<IComponent> rootComponent)
    {
        var root = new SsrRenderRoot();

        using var _ = new NatrixHostBuilder()
            .UseRootRenderer(root)
            .UseRootComponent(rootComponent)
            .Build()
            .Mount();

        return await SsrHelpers.RenderAsync(root);
    }

    private static DomText Text(string value) => new() { Text = value.ToConstSignal() };

    [Test]
    public async Task Escapes_text_content()
    {
        var output = await RenderAsync(() => new Div
        {
            Props = new DivProps(),
            Children = [Text("<script>alert('x')</script> & \"quotes\"")],
        });

        await Assert.That(output).IsEqualTo(
            "<div>&lt;script&gt;alert('x')&lt;/script&gt; &amp; \"quotes\"</div>");
    }

    [Test]
    public async Task Escapes_attribute_values()
    {
        var output = await RenderAsync(() => new Div
        {
            Props = new DivProps { Title = "\" onclick=\"alert('x')".ToConstSignal() },
        });

        await Assert.That(output).IsEqualTo(
            "<div title=\"&quot; onclick=&quot;alert('x')\"></div>");
    }

    [Test]
    public async Task Writes_style_content_verbatim()
    {
        const string css = ":where(& > :not(:last-child)) { color: red; }";

        var output = await RenderAsync(() => new Style
        {
            Props = new StyleProps(),
            Children = [Text(css)],
        });

        await Assert.That(output).IsEqualTo($"<style>{css}</style>");
    }

    [Test]
    public async Task Writes_script_content_verbatim()
    {
        const string js = "if (a < b && c > d) { go(); }";

        var output = await RenderAsync(() => new Script
        {
            Props = new ScriptProps(),
            Children = [Text(js)],
        });

        await Assert.That(output).IsEqualTo($"<script>{js}</script>");
    }

    [Test]
    public async Task Raw_text_feature_reaches_nested_children()
    {
        var output = await RenderAsync(() => new Style
        {
            Props = new StyleProps(),
            Children =
            [
                new If
                {
                    Condition = new Signal<bool>(true),
                    Then = () => [Text("a > b")],
                },
            ],
        });

        await Assert.That(output).Contains("a > b");
        await Assert.That(output).DoesNotContain("&gt;");
    }

    [Test]
    public async Task Does_not_leak_raw_text_feature_to_siblings()
    {
        var output = await RenderAsync(() => new Head
        {
            Props = new HeadProps(),
            Children =
            [
                new Style { Props = new StyleProps(), Children = [Text("a > b")] },
                new Title { Props = new TitleProps(), Children = [Text("c > d")] },
            ],
        });

        await Assert.That(output).Contains("<style>a > b</style>");
        await Assert.That(output).Contains("<title>c &gt; d</title>");
    }

    [Test]
    public async Task Escapes_escapable_raw_text_elements()
    {
        var output = await RenderAsync(() => new TextArea
        {
            Props = new TextAreaProps(),
            Children = [Text("</textarea><img src=x>")],
        });

        await Assert.That(output).IsEqualTo(
            "<textarea>&lt;/textarea&gt;&lt;img src=x&gt;</textarea>");
    }
}
