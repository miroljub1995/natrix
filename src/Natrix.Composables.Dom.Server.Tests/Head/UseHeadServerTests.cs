using Natrix.Composables.Dom.Head;
using Natrix.Core;
using Natrix.Core.Components;
using Natrix.Signals;
using static Natrix.Composables.Dom.DomComposables;

namespace Natrix.Composables.Dom.Server.Tests.Head;

public class UseHeadServerTests
{
    private static void Title(string? title, Func<string, string>? template = null) =>
        UseHead(new HeadInput { Title = new Signal<string?>(title), TitleTemplate = template });

    [Test]
    public async Task Writes_no_title_while_nothing_sets_one()
    {
        var output = await Ssr.RenderAsync(() => Ssr.Page());

        await Assert.That(output).Contains("<head><!--[--><!--]--></head>");
    }

    [Test]
    public async Task Title_set_in_the_body_reaches_the_head_above_it()
    {
        var output = await Ssr.RenderAsync(() => Ssr.Page(Ssr.Probe(() => Title("Todo"))));

        await Assert.That(output).Contains("<head><!--[--><title>Todo</title><!--]--></head>");
    }

    [Test]
    public async Task Latest_call_wins()
    {
        var output = await Ssr.RenderAsync(() => Ssr.Page(
            Ssr.Probe(() => Title("Layout"), Ssr.Probe(() => Title("Page")))));

        await Assert.That(output).Contains("<title>Page</title>");
    }

    [Test]
    public async Task Null_title_falls_back_to_an_earlier_call()
    {
        var output = await Ssr.RenderAsync(() => Ssr.Page(
            Ssr.Probe(() => Title("Layout"), Ssr.Probe(() => Title(null)))));

        await Assert.That(output).Contains("<title>Layout</title>");
    }

    [Test]
    public async Task Template_from_a_layout_wraps_the_page_title()
    {
        var output = await Ssr.RenderAsync(() => Ssr.Page(
            Ssr.Probe(
                () => UseHead(new HeadInput { TitleTemplate = t => $"{t} · Natrix" }),
                Ssr.Probe(() => Title("Todo")))));

        await Assert.That(output).Contains("<title>Todo · Natrix</title>");
    }

    [Test]
    public async Task Later_template_replaces_an_earlier_one()
    {
        var output = await Ssr.RenderAsync(() => Ssr.Page(
            Ssr.Probe(
                () => UseHead(new HeadInput { TitleTemplate = t => $"{t} · Natrix" }),
                Ssr.Probe(() => Title("Natrix", template: t => t)))));

        await Assert.That(output).Contains("<title>Natrix</title>");
    }

    [Test]
    public async Task Template_without_a_title_writes_no_title()
    {
        var output = await Ssr.RenderAsync(() => Ssr.Page(
            Ssr.Probe(() => UseHead(new HeadInput { TitleTemplate = t => $"{t} · Natrix" }))));

        await Assert.That(output).Contains("<head><!--[--><!--]--></head>");
    }

    [Test]
    public async Task Title_is_escaped()
    {
        var output = await Ssr.RenderAsync(() => Ssr.Page(
            Ssr.Probe(() => Title("</title><script>alert('x')</script> & co"))));

        await Assert.That(output).Contains(
            "<title>&lt;/title&gt;&lt;script&gt;alert('x')&lt;/script&gt; &amp; co</title>");
    }

    [Test]
    public async Task Title_is_read_when_the_page_is_written()
    {
        // A component that changes its title after mounting — when its data arrives, say — still
        // gets the title it ends up with, since the head is written after the prefetches land.
        var title = new Signal<string?>("Loading");
        var (root, host) = Ssr.Mount(() => Ssr.Page(
            Ssr.Probe(() => UseHead(new HeadInput { Title = title }))));

        using (host)
        {
            title.Value = "Ada Lovelace";

            await Assert.That(await Ssr.WriteAsync(root)).Contains("<title>Ada Lovelace</title>");
        }
    }

    [Test]
    public async Task Unmounting_a_component_removes_its_title()
    {
        var showPage = new Signal<bool>(true);
        var (root, host) = Ssr.Mount(() => Ssr.Page(
            Ssr.Probe(
                () => Title("Layout"),
                new If { Condition = showPage, Then = () => [Ssr.Probe(() => Title("Page"))] })));

        using (host)
        {
            await Assert.That(await Ssr.WriteAsync(root)).Contains("<title>Page</title>");

            showPage.Value = false;

            await Assert.That(await Ssr.WriteAsync(root)).Contains("<title>Layout</title>");
        }
    }

    [Test]
    public async Task Hosts_do_not_share_a_head()
    {
        var first = await Ssr.RenderAsync(() => Ssr.Page(Ssr.Probe(() => Title("First"))));
        var second = await Ssr.RenderAsync(() => Ssr.Page());

        await Assert.That(first).Contains("<title>First</title>");
        await Assert.That(second).DoesNotContain("<title>");
    }

    [Test]
    public async Task UseHead_without_a_managed_head_throws()
    {
        var builder = new NatrixHostBuilder()
            .UseRootRenderer(new Natrix.Ssr.RenderRoot.SsrRenderRoot())
            .UseRootComponent(() => Ssr.Probe(() => Title("Todo")));

        await Assert.That(() => builder.Build().Mount())
            .Throws<InvalidOperationException>()
            .WithMessageContaining("HeadManager");
    }

    [Test]
    public async Task UseHead_outside_setup_throws()
    {
        await Assert.That(() => Title("Todo")).Throws<InvalidOperationException>();
    }

    [Test]
    public async Task Registering_the_head_twice_throws()
    {
        await Assert.That(() => Ssr.Mount(() => Ssr.Page(), builder => builder.UseServerHead()))
            .Throws<InvalidOperationException>()
            .WithMessageContaining("already managed");
    }

    [Test]
    public async Task HeadTags_without_a_managed_head_throws()
    {
        var builder = new NatrixHostBuilder()
            .UseRootRenderer(new Natrix.Ssr.RenderRoot.SsrRenderRoot())
            .UseRootComponent(() => new HeadTags { Props = new NoProps() });

        await Assert.That(() => builder.Build().Mount())
            .Throws<InvalidOperationException>()
            .WithMessageContaining("HeadManager");
    }
}
