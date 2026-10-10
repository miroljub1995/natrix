using Natrix.Core;
using Natrix.Core.Components;
using Natrix.Core.Features.Routing;
using Natrix.Dom.Components;
using Natrix.Signals;
using Natrix.Ssr.Features.Routing;
using Natrix.Ssr.RenderRoot;

namespace Natrix.Ssr.Tests.Tests;

public class RoutesTests
{
    private static (SsrRenderRoot Root, ServerNavigationFeature Navigation, IDisposable Host) BuildHost(string path)
    {
        var root = new SsrRenderRoot();
        var navigation = new ServerNavigationFeature(path);

        var host = new NatrixHostBuilder()
            .UseRootRenderer(root)
            .SetFeature<INavigationFeature>(navigation)
            .UseRootComponent(() => new Routes
            {
                Items =
                [
                    new Route
                    {
                        Pattern = "/docs",
                        Render = () => [new Outlet()],
                        Children =
                        [
                            Route.Redirect("/", "/docs/quick-start"),
                            new Route
                            {
                                Pattern = "/quick-start",
                                Render = () => [new Span { Children = [new DomText { Text = new Signal<string>("quick-start") }] }],
                            },
                        ],
                    },
                ],
            })
            .Build()
            .Mount();

        return (root, navigation, host);
    }

    [Test]
    public async Task Redirect_route_records_the_redirect_for_the_host()
    {
        var (_, navigation, host) = BuildHost("/docs");
        using var _ = host;

        await Assert.That(navigation.RedirectLocation).IsEqualTo("/docs/quick-start");
    }

    [Test]
    public async Task Route_that_renders_records_no_redirect()
    {
        var (root, navigation, host) = BuildHost("/docs/quick-start");
        using var _ = host;

        await Assert.That(navigation.RedirectLocation).IsNull();
        await Assert.That(await SsrHelpers.RenderAsync(root)).IsEqualTo("<span>quick-start</span>");
    }
}
