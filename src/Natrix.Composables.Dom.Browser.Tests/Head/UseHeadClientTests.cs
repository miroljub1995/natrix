using System.Runtime.InteropServices.JavaScript;
using Natrix.Composables.Dom.Head;
using Natrix.Core;
using Natrix.Core.Components;
using Natrix.Core.RenderRoot;
using Natrix.JSCore;
using Natrix.Signals;
using Natrix.StdWeb;
using static Natrix.Composables.Dom.DomComposables;

namespace Natrix.Composables.Dom.Browser.Tests.Head;

/// <summary>
/// The browser side: the live document's title follows what the mounted components resolve to.
/// </summary>
/// <remarks>
/// Not parallel: every test owns the one <c>document.title</c> there is.
/// </remarks>
[NotInParallel]
public class UseHeadClientTests
{
    private const string PageTitle = "Served title";

    private static readonly Document Document =
        JSObjectProxyFactory.GetProxy<Window>(JSHost.GlobalThis).Document;

    private sealed class ProbeProps
    {
        public required Action Body { get; init; }
        public IComponent[] Children { get; init; } = [];
    }

    private sealed class Probe : BaseComponent<ProbeProps, NoEvents, NoSlots, NoExpose>
    {
        protected override IComponent[] Setup(out NoExpose exposed)
        {
            Props.Body();
            exposed = default;
            return Props.Children;
        }
    }

    private static Probe CreateProbe(Action body, params IComponent[] children) =>
        new() { Props = new ProbeProps { Body = body, Children = children } };

    private static void Title(IReadOnlySignal<string?> title) => UseHead(new HeadInput { Title = title });

    private static IDisposable Mount(Func<IComponent> root) =>
        new NatrixHostBuilder()
            .UseRootRenderer(new DomRenderRoot(Document.CreateElement("div")))
            .UseClientHead()
            .UseRootComponent(root)
            .Build()
            .Mount();

    private const string PageDescription = "Served description";

    private static void Description(IReadOnlySignal<string?> content) =>
        UseHead(new HeadInput { Meta = [new HeadMeta { Name = "description", Content = content }] });

    private static Element? FindMeta(string attribute, string value) =>
        Document.Head!.QuerySelector($"meta[{attribute}=\"{value}\"]");

    private static HeadMeta OgImage(IReadOnlySignal<string?> url) => new() { Property = "og:image", Content = url };

    private static HeadMeta OgImage(string url) => OgImage(url.ToConstSignal());

    // Every meta tag in <head>, in document order, as "key=content" joined by " | ".
    private static string HeadMetas()
    {
        var nodes = Document.Head!.QuerySelectorAll("meta");
        var metas = new List<string>();
        for (uint i = 0; i < nodes.Length; i++)
        {
            var meta = JSObjectProxyFactory.GetProxy<Element>(nodes.Item(i)!.JSObject);
            var key = meta.GetAttribute("name") ?? meta.GetAttribute("property");
            metas.Add($"{key}={meta.GetAttribute("content")}");
        }

        return string.Join(" | ", metas);
    }

    private static void AddDocumentMeta(string property, string content)
    {
        var meta = Document.CreateElement("meta");
        meta.SetAttribute("property", property);
        meta.SetAttribute("content", content);
        Document.Head!.AppendChild(meta);
    }

    [Before(Test)]
    public void ResetHead()
    {
        Document.Title = PageTitle;

        while (Document.Head!.QuerySelector("meta") is { } meta)
        {
            meta.Remove();
        }

        var description = Document.CreateElement("meta");
        description.SetAttribute("name", "description");
        description.SetAttribute("content", PageDescription);
        Document.Head.AppendChild(description);
    }

    [Test]
    public async Task Document_title_follows_the_resolved_title()
    {
        using var _ = Mount(() => CreateProbe(
            () => UseHead(new HeadInput { TitleTemplate = t => $"{t} · Natrix" }),
            CreateProbe(() => Title("Todo".ToConstSignal()))));

        await Assert.That(Document.Title).IsEqualTo("Todo · Natrix");
    }

    [Test]
    public async Task Document_title_updates_when_the_signal_changes()
    {
        var title = new Signal<string?>("Loading");
        using var _ = Mount(() => CreateProbe(() => Title(title)));

        title.Value = "Ada Lovelace";

        await Assert.That(Document.Title).IsEqualTo("Ada Lovelace");
    }

    [Test]
    public async Task Unmounting_a_page_brings_back_the_layout_title()
    {
        var showPage = new Signal<bool>(true);
        using var _ = Mount(() => CreateProbe(
            () => Title("Layout".ToConstSignal()),
            new If { Condition = showPage, Then = () => [CreateProbe(() => Title("Page".ToConstSignal()))] }));

        await Assert.That(Document.Title).IsEqualTo("Page");

        showPage.Value = false;
        await Assert.That(Document.Title).IsEqualTo("Layout");

        showPage.Value = true;
        await Assert.That(Document.Title).IsEqualTo("Page");
    }

    [Test]
    public async Task Document_title_stays_while_nothing_sets_one()
    {
        // On a server-rendered page that is the title the server wrote, so hydrating an app that
        // has not set its own yet changes nothing.
        var title = new Signal<string?>(null);
        using var _ = Mount(() => CreateProbe(() => Title(title)));

        await Assert.That(Document.Title).IsEqualTo(PageTitle);

        title.Value = "Todo";
        await Assert.That(Document.Title).IsEqualTo("Todo");

        title.Value = null;
        await Assert.That(Document.Title).IsEqualTo(PageTitle);
    }

    [Test]
    public async Task Disposing_the_host_restores_the_document_title()
    {
        var host = Mount(() => CreateProbe(() => Title("Todo".ToConstSignal())));
        await Assert.That(Document.Title).IsEqualTo("Todo");

        host.Dispose();

        await Assert.That(Document.Title).IsEqualTo(PageTitle);
    }

    [Test]
    public async Task Existing_meta_follows_the_resolved_content_and_falls_back()
    {
        var content = new Signal<string?>("Todo list");
        var host = Mount(() => CreateProbe(() => Description(content)));

        await Assert.That(FindMeta("name", "description")!.GetAttribute("content")).IsEqualTo("Todo list");

        content.Value = null;
        await Assert.That(FindMeta("name", "description")!.GetAttribute("content")).IsEqualTo(PageDescription);

        content.Value = "Again";
        host.Dispose();
        await Assert.That(FindMeta("name", "description")!.GetAttribute("content")).IsEqualTo(PageDescription);
    }

    [Test]
    public async Task Meta_the_document_lacks_is_added_and_removed()
    {
        var showPage = new Signal<bool>(true);
        var host = Mount(() => CreateProbe(
            () => { },
            new If
            {
                Condition = showPage,
                Then = () =>
                [
                    CreateProbe(() => UseHead(new HeadInput
                    {
                        Meta = [new HeadMeta { Property = "og:title", Content = "Todo".ToConstSignal() }],
                    })),
                ],
            }));

        await Assert.That(FindMeta("property", "og:title")?.GetAttribute("content")).IsEqualTo("Todo");

        showPage.Value = false;
        await Assert.That(FindMeta("property", "og:title")).IsNull();

        showPage.Value = true;
        await Assert.That(FindMeta("property", "og:title")?.GetAttribute("content")).IsEqualTo("Todo");

        host.Dispose();
        await Assert.That(FindMeta("property", "og:title")).IsNull();
    }

    [Test]
    public async Task Page_meta_overrides_the_layout_meta()
    {
        var showPage = new Signal<bool>(true);
        using var _ = Mount(() => CreateProbe(
            () => Description("Layout".ToConstSignal()),
            new If { Condition = showPage, Then = () => [CreateProbe(() => Description("Page".ToConstSignal()))] }));

        await Assert.That(FindMeta("name", "description")!.GetAttribute("content")).IsEqualTo("Page");

        showPage.Value = false;
        await Assert.That(FindMeta("name", "description")!.GetAttribute("content")).IsEqualTo("Layout");
    }

    [Test]
    public async Task Repeated_list_keys_are_added_in_resolved_order()
    {
        var host = Mount(() => CreateProbe(() => UseHead(new HeadInput
        {
            Meta =
            [
                OgImage("a.png"),
                new HeadMeta { Property = "og:image:width", Content = "100".ToConstSignal() },
                OgImage("b.png"),
                new HeadMeta { Property = "og:image:width", Content = "200".ToConstSignal() },
            ],
        })));

        await Assert.That(HeadMetas()).IsEqualTo($"description={PageDescription} | og:image=a.png | og:image:width=100 | og:image=b.png | og:image:width=200");

        host.Dispose();
        await Assert.That(HeadMetas()).IsEqualTo($"description={PageDescription}");
    }

    [Test]
    public async Task Page_list_replaces_the_layout_list_as_a_whole()
    {
        var showPage = new Signal<bool>(true);
        using var _ = Mount(() => CreateProbe(
            () => UseHead(new HeadInput { Meta = [OgImage("a.png"), OgImage("b.png")] }),
            new If
            {
                Condition = showPage,
                Then = () => [CreateProbe(() => UseHead(new HeadInput { Meta = [OgImage("c.png")] }))],
            }));

        await Assert.That(HeadMetas()).IsEqualTo($"description={PageDescription} | og:image=c.png");

        showPage.Value = false;
        await Assert.That(HeadMetas()).IsEqualTo($"description={PageDescription} | og:image=a.png | og:image=b.png");
    }

    [Test]
    public async Task List_reuses_the_document_tags_and_gives_them_back()
    {
        // As on a server-rendered page: the server already wrote two images.
        AddDocumentMeta("og:image", "served-a.png");
        AddDocumentMeta("og:image", "served-b.png");

        var third = new Signal<string?>("c.png");
        var second = new Signal<string?>("b.png");
        var host = Mount(() => CreateProbe(() => UseHead(new HeadInput
        {
            Meta = [OgImage("a.png"), OgImage(second), OgImage(third)],
        })));

        await Assert.That(HeadMetas()).IsEqualTo($"description={PageDescription} | og:image=a.png | og:image=b.png | og:image=c.png");

        // Fewer images than the document had: the surplus served tag stays but says nothing.
        third.Value = null;
        second.Value = null;
        await Assert.That(HeadMetas()).IsEqualTo($"description={PageDescription} | og:image=a.png | og:image=");

        host.Dispose();
        await Assert.That(HeadMetas()).IsEqualTo($"description={PageDescription} | og:image=served-a.png | og:image=served-b.png");
    }
}
