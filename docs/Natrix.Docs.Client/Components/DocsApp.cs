using Natrix.Composables.Dom.Head;
using Natrix.Core.Components;
using Natrix.Core.Features;
using Natrix.Dom.Components;
using Natrix.Core.Features.Routing;
using Natrix.Docs.Client.Components.Examples.BouncingBalls;
using Natrix.Docs.Client.Components.Examples.DataFetching;
using Natrix.Docs.Client.Components.Examples.Inputs;
using Natrix.Docs.Client.Components.Examples.Todo;
using Natrix.Signals;
using static Natrix.Composables.Dom.DomComposables;

namespace Natrix.Docs.Client.Components;

public class DocsAppProps { }

public class DocsApp : BaseComponent<DocsAppProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var navigation = AppFeatures.Features.GetRequired<INavigationFeature>();

        // What every page shares. Pages set only their own part of the title, the site name is
        // added here, once; a page that sets no description of its own gets the site's.
        UseHead(new HeadInput
        {
            TitleTemplate = title => $"{title} · {Site.Name}",
            Meta =
            [
                new HeadMeta { Name = "description", Content = Site.Description.ToConstSignal() },
                new HeadMeta { Property = "og:site_name", Content = Site.Name.ToConstSignal() },
                new HeadMeta { Property = "og:type", Content = "website".ToConstSignal() },
                new HeadMeta { Property = "og:locale", Content = "en_US".ToConstSignal() },
                new HeadMeta
                {
                    Property = "og:url",
                    Content = new Computed<string?>(() => Site.CanonicalUrl(navigation.CurrentPath.Value)),
                },
                new HeadMeta { Property = "og:title", Content = Site.Name.ToConstSignal() },
                new HeadMeta { Property = "og:description", Content = Site.Description.ToConstSignal() },
                new HeadMeta { Property = "og:image", Content = Site.SocialImageUrl.ToConstSignal() },
                new HeadMeta { Property = "og:image:type", Content = "image/png".ToConstSignal() },
                new HeadMeta { Property = "og:image:width", Content = "1200".ToConstSignal() },
                new HeadMeta { Property = "og:image:height", Content = "630".ToConstSignal() },
                new HeadMeta { Property = "og:image:alt", Content = Site.SocialImageAlt.ToConstSignal() },
                // X reads the Open Graph tags for everything but the card size.
                new HeadMeta { Name = "twitter:card", Content = "summary_large_image".ToConstSignal() },
            ],
        });

        return
        [
            new AppHeader
            {
                Props = new AppHeaderProps(),
            },
            new Div
            {
                Props = new DivProps
                {
                    Class = "min-h-[calc(100vh-4rem)] bg-white dark:bg-gray-950".ToConstSignal(),
                },
                Children =
                [
                    new Routes
                    {
                        Items =
                        [
                            new Route
                            {
                                Pattern = "/",
                                Render = () => [PageMain(new HomePage { Props = new HomePageProps() })],
                            },
                            new Route
                            {
                                Pattern = "/docs",
                                Render = () => [new DocsLayout { Props = new NoProps() }],
                                Children =
                                [
                                    new Route
                                    {
                                        Pattern = "/quick-start",
                                        Render = () => [new QuickStart { Props = new QuickStartProps() }],
                                    },
                                    new Route
                                    {
                                        Pattern = "/examples/todo",
                                        Render = () => [new TodoExamplePage { Props = new NoProps() }],
                                    },
                                    new Route
                                    {
                                        Pattern = "/examples/canvas",
                                        Render = () => [new BouncingBallsExamplePage { Props = new NoProps() }],
                                    },
                                    new Route
                                    {
                                        Pattern = "/examples/data-fetching",
                                        Render = () => [new DataFetchingExamplePage { Props = new NoProps() }],
                                    },
                                    new Route
                                    {
                                        Pattern = "/examples/inputs",
                                        Render = () => [new InputsExamplePage { Props = new NoProps() }],
                                    },
                                    // A docs path no page claims keeps the sidebar, to find the page it meant.
                                    new Route
                                    {
                                        Pattern = "/{**path}",
                                        Render = () => [new NotFoundPage { Props = new NoProps() }],
                                    },
                                ],
                            },
                            // Last, so it only gets what no page above claims.
                            new Route
                            {
                                Pattern = "/{**path}",
                                Render = () => [PageMain(new NotFoundPage { Props = new NoProps() })],
                            },
                        ],
                    },
                ],
            },
        ];
    }

    private static Main PageMain(IComponent page) => new()
    {
        Props = new MainProps
        {
            Class = "min-w-0 px-4 sm:px-8 py-8".ToConstSignal(),
        },
        Children = [page],
    };
}
