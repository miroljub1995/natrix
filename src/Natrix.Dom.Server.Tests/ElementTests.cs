using Natrix.Dom.Components;
using Natrix.Dom.TestCases;
using Natrix.Signals;

namespace Natrix.Dom.Server.Tests;

public class ElementTests
{
    [Test]
    [MethodDataSource(typeof(ElementCases), nameof(ElementCases.All))]
    public async Task Renders_element(DomCase c)
    {
        var html = await SsrRenderer.RenderAsync(c.Create);

        await Assert.That(html).IsEqualTo(c.Html);
    }

    [Test]
    public async Task Escapes_text_in_ordinary_elements()
    {
        var html = await SsrRenderer.RenderAsync(() => new P { Children = [Text("a < b && c")] });

        await Assert.That(html).IsEqualTo("<p>a &lt; b &amp;&amp; c</p>");
    }

    [Test]
    public async Task Writes_script_content_verbatim()
    {
        var html = await SsrRenderer.RenderAsync(() => new Script { Children = [Text("if (a < b && c) {}")] });

        await Assert.That(html).IsEqualTo("<script>if (a < b && c) {}</script>");
    }

    [Test]
    public async Task Writes_style_content_verbatim()
    {
        var html = await SsrRenderer.RenderAsync(() => new Style { Children = [Text("a > b { color: red; }")] });

        await Assert.That(html).IsEqualTo("<style>a > b { color: red; }</style>");
    }

    [Test]
    public async Task Writes_void_elements_without_closing_tags_between_siblings()
    {
        var html = await SsrRenderer.RenderAsync(() => new P { Children = [new Br(), Text("x"), new Hr()] });

        await Assert.That(html).IsEqualTo("<p><br>x<hr></p>");
    }

    private static DomText Text(string text) => new() { Text = new Signal<string>(text) };
}
