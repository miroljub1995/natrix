using Natrix.Dom.Components;
using Natrix.Dom.TestCases;
using Natrix.Signals;

namespace Natrix.Dom.Browser.Tests;

public class ElementTests
{
    [Test]
    [MethodDataSource(typeof(ElementCases), nameof(ElementCases.All))]
    public async Task Renders_element(DomCase c) => await DomCaseAssert.RendersAsync(c);

    [Test]
    public async Task Sets_script_content_as_text()
    {
        var (container, host) = DomRenderer.Mount(() => new Script { Children = [Text("if (a < b && c) {}")] });
        using var _ = host;

        await Assert.That(container.FirstElementChild!.TextContent).IsEqualTo("if (a < b && c) {}");
    }

    [Test]
    public async Task Sets_style_content_as_text()
    {
        var (container, host) = DomRenderer.Mount(() => new Style { Children = [Text("a > b { color: red; }")] });
        using var _ = host;

        await Assert.That(container.FirstElementChild!.TextContent).IsEqualTo("a > b { color: red; }");
    }

    [Test]
    public async Task Updates_comment_when_signal_changes()
    {
        var data = new Signal<string>("a");
        var (container, host) = DomRenderer.Mount(() => new DomComment { Data = data });
        using var _ = host;

        data.Value = "b";

        await Assert.That(DomRenderer.Serialize(container)).IsEqualTo("<!--b-->");
    }

    [Test]
    public async Task Removes_element_on_unmount()
    {
        var (container, host) = DomRenderer.Mount(() => new P { Children = [Text("x")] });

        host.Dispose();

        await Assert.That(container.ChildNodes.Length).IsEqualTo(0u);
    }

    private static DomText Text(string text) => new() { Text = new Signal<string>(text) };
}
