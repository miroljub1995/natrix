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

    [Before(Test)]
    public void ResetTitle() => Document.Title = PageTitle;

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
}
