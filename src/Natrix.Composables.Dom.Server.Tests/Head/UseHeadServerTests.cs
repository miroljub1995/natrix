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

    private static HeadMeta OgImage(string url) => new() { Property = "og:image", Content = url.ToConstSignal() };

    private static void Description(IReadOnlySignal<string?> content) =>
        UseHead(new HeadInput { Meta = [new HeadMeta { Name = "description", Content = content }] });

    [Test]
    public async Task Writes_no_title_while_nothing_sets_one()
    {
        var output = await Ssr.RenderAsync(() => Ssr.Page());

        await Assert.That(output).Contains("<head><!--[--><!--[--><!--]--><!--]--></head>");
    }

    [Test]
    public async Task Title_set_in_the_body_reaches_the_head_above_it()
    {
        var output = await Ssr.RenderAsync(() => Ssr.Page(Ssr.Probe(() => Title("Todo"))));

        await Assert.That(output).Contains("<head><!--[--><title>Todo</title><!--[--><!--]--><!--]--></head>");
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

        await Assert.That(output).Contains("<head><!--[--><!--[--><!--]--><!--]--></head>");
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
    public async Task Meta_set_in_the_body_reaches_the_head_above_it()
    {
        var output = await Ssr.RenderAsync(() => Ssr.Page(Ssr.Probe(() => UseHead(new HeadInput
        {
            Title = "Todo".ToConstSignal(),
            Meta =
            [
                new HeadMeta { Name = "description", Content = "A list".ToConstSignal() },
                new HeadMeta { Property = "og:title", Content = "Todo".ToConstSignal() },
                new HeadMeta { HttpEquiv = "refresh", Content = "30".ToConstSignal() },
            ],
        }))));

        await Assert.That(output).Contains(
            "<title>Todo</title><!--[-->"
            + "<meta content=\"A list\" name=\"description\">"
            + "<meta content=\"Todo\" property=\"og:title\">"
            + "<meta content=\"30\" http-equiv=\"refresh\"><!--]-->");
    }

    [Test]
    public async Task Latest_meta_wins_and_takes_its_place()
    {
        // As in unhead: the winning tag is written where its own call puts it.
        var output = await Ssr.RenderAsync(() => Ssr.Page(
            Ssr.Probe(
                () => UseHead(new HeadInput
                {
                    Meta =
                    [
                        new HeadMeta { Name = "description", Content = "Layout".ToConstSignal() },
                        new HeadMeta { Name = "robots", Content = "index".ToConstSignal() },
                    ],
                }),
                Ssr.Probe(() => Description("Page".ToConstSignal())))));

        await Assert.That(output).Contains(
            "<meta content=\"index\" name=\"robots\"><meta content=\"Page\" name=\"description\">");
        await Assert.That(output).DoesNotContain("Layout");
    }

    [Test]
    public async Task One_call_can_repeat_a_list_key_and_keeps_its_order()
    {
        var output = await Ssr.RenderAsync(() => Ssr.Page(Ssr.Probe(() => UseHead(new HeadInput
        {
            Meta =
            [
                OgImage("a.png"),
                new HeadMeta { Property = "og:image:width", Content = "100".ToConstSignal() },
                OgImage("b.png"),
                new HeadMeta { Property = "og:image:width", Content = "200".ToConstSignal() },
            ],
        }))));

        await Assert.That(output).Contains(
            "<!--[-->"
            + "<meta content=\"a.png\" property=\"og:image\">"
            + "<meta content=\"100\" property=\"og:image:width\">"
            + "<meta content=\"b.png\" property=\"og:image\">"
            + "<meta content=\"200\" property=\"og:image:width\">"
            + "<!--]-->");
    }

    [Test]
    public async Task One_call_repeating_another_key_keeps_its_last_tag()
    {
        var output = await Ssr.RenderAsync(() => Ssr.Page(Ssr.Probe(() => UseHead(new HeadInput
        {
            Meta =
            [
                new HeadMeta { Name = "description", Content = "First".ToConstSignal() },
                new HeadMeta { Name = "description", Content = "Second".ToConstSignal() },
            ],
        }))));

        await Assert.That(output).Contains("<meta content=\"Second\" name=\"description\">");
        await Assert.That(output).DoesNotContain("First");
    }

    [Test]
    public async Task Later_call_replaces_a_list_as_a_whole()
    {
        var output = await Ssr.RenderAsync(() => Ssr.Page(
            Ssr.Probe(
                () => UseHead(new HeadInput { Meta = [OgImage("a.png"), OgImage("b.png")] }),
                Ssr.Probe(() => UseHead(new HeadInput { Meta = [OgImage("c.png")] })))));

        await Assert.That(output).Contains("<!--[--><meta content=\"c.png\" property=\"og:image\"><!--]-->");
    }

    [Test]
    public async Task Later_call_without_content_leaves_the_list_alone()
    {
        var output = await Ssr.RenderAsync(() => Ssr.Page(
            Ssr.Probe(
                () => UseHead(new HeadInput { Meta = [OgImage("a.png"), OgImage("b.png")] }),
                Ssr.Probe(() => UseHead(new HeadInput
                {
                    Meta = [new HeadMeta { Property = "og:image", Content = new Signal<string?>(null) }],
                })))));

        await Assert.That(output).Contains(
            "<meta content=\"a.png\" property=\"og:image\"><meta content=\"b.png\" property=\"og:image\">");
    }

    [Test]
    public async Task List_follows_its_signals_and_unmounting()
    {
        var showPage = new Signal<bool>(true);
        var second = new Signal<string?>("b.png");
        var (root, host) = Ssr.Mount(() => Ssr.Page(
            Ssr.Probe(
                () => UseHead(new HeadInput { Meta = [OgImage("layout.png")] }),
                new If
                {
                    Condition = showPage,
                    Then = () =>
                    [
                        Ssr.Probe(() => UseHead(new HeadInput
                        {
                            Meta = [OgImage("a.png"), new HeadMeta { Property = "og:image", Content = second }],
                        })),
                    ],
                })));

        using (host)
        {
            second.Value = "c.png";
            await Assert.That(await Ssr.WriteAsync(root)).Contains(
                "<meta content=\"a.png\" property=\"og:image\"><meta content=\"c.png\" property=\"og:image\">");

            second.Value = null;
            await Assert.That(await Ssr.WriteAsync(root)).Contains(
                "<!--[--><meta content=\"a.png\" property=\"og:image\"><!--]-->");

            showPage.Value = false;
            await Assert.That(await Ssr.WriteAsync(root)).Contains(
                "<!--[--><meta content=\"layout.png\" property=\"og:image\"><!--]-->");
        }
    }

    [Test]
    public async Task Null_meta_falls_back_to_an_earlier_call()
    {
        var output = await Ssr.RenderAsync(() => Ssr.Page(
            Ssr.Probe(
                () => Description("Layout".ToConstSignal()),
                Ssr.Probe(() => Description(new Signal<string?>(null))))));

        await Assert.That(output).Contains("<meta content=\"Layout\" name=\"description\">");
    }

    [Test]
    public async Task Meta_without_content_is_left_out()
    {
        var output = await Ssr.RenderAsync(() => Ssr.Page(
            Ssr.Probe(() => Description(new Signal<string?>(null)))));

        await Assert.That(output).DoesNotContain("<meta");
    }

    [Test]
    public async Task Meta_content_is_escaped()
    {
        var output = await Ssr.RenderAsync(() => Ssr.Page(
            Ssr.Probe(() => Description("\"><script>alert('x')</script>".ToConstSignal()))));

        await Assert.That(output).DoesNotContain("<script>");
    }

    [Test]
    public async Task Unmounting_a_component_removes_its_meta()
    {
        var showPage = new Signal<bool>(true);
        var (root, host) = Ssr.Mount(() => Ssr.Page(
            Ssr.Probe(
                () => Description("Layout".ToConstSignal()),
                new If
                {
                    Condition = showPage,
                    Then = () =>
                    [
                        Ssr.Probe(() => UseHead(new HeadInput
                        {
                            Meta =
                            [
                                new HeadMeta { Name = "description", Content = "Page".ToConstSignal() },
                                new HeadMeta { Property = "og:type", Content = "article".ToConstSignal() },
                            ],
                        })),
                    ],
                })));

        using (host)
        {
            var page = await Ssr.WriteAsync(root);
            await Assert.That(page).Contains("<meta content=\"Page\" name=\"description\">");
            await Assert.That(page).Contains("og:type");

            showPage.Value = false;

            var layout = await Ssr.WriteAsync(root);
            await Assert.That(layout).Contains("<meta content=\"Layout\" name=\"description\">");
            await Assert.That(layout).DoesNotContain("og:type");
        }
    }

    [Test]
    public async Task Meta_without_exactly_one_key_throws()
    {
        await Assert.That(() => Ssr.Mount(() => Ssr.Page(Ssr.Probe(() => UseHead(new HeadInput
            {
                Meta = [new HeadMeta { Name = "description", Property = "og:description", Content = "x".ToConstSignal() }],
            })))))
            .Throws<InvalidOperationException>()
            .WithMessageContaining("exactly one");
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
