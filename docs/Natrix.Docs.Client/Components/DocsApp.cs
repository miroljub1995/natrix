using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Core.Features.Routing;
using Natrix.Docs.Client.Components.Examples.BouncingBalls;
using Natrix.Docs.Client.Components.Examples.Todo;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components;

public class DocsAppProps { }

public class DocsApp : BaseComponent<DocsAppProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

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
                    Class = "flex min-h-[calc(100vh-4rem)] bg-white dark:bg-gray-950".ToConstSignal(),
                },
                Children =
                [
                    new Sidebar
                    {
                        Props = new NoProps(),
                    },
                    // Main content
                    new Main
                    {
                        Props = new MainProps
                        {
                            Class = "flex-1 px-4 sm:px-8 py-8 max-w-4xl".ToConstSignal(),
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
                                        Render = () => [new HomePage { Props = new HomePageProps() }],
                                    },
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
                                ],
                            },
                        ],
                    },
                ],
            },
        ];
    }
}
