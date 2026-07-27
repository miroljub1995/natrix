using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Ssr.Features.HydrationState;
using Natrix.Ssr.Components;
using Natrix.Ssr.HotReload;
using MyNatrixApp.Client;
using MyNatrixApp.Client.Components;
using Natrix.Signals;

namespace MyNatrixApp.Components;

public class AppPageProps
{
}

public class AppPage : BaseComponent<AppPageProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        return
        [
            new Html
            {
                Props = new HtmlProps { Lang = "en".ToConstSignal() },
                Children =
                [
                    new Head
                    {
                        Props = new HeadProps(),
                        Children =
                        [
                            new Meta
                            {
                                Props = new MetaProps
                                {
                                    HttpEquiv = "Content-Type".ToConstSignal(),
                                    Content = "text/html; charset=utf-8".ToConstSignal(),
                                },
                            },
                            new Meta
                            {
                                Props = new MetaProps
                                {
                                    Name = "viewport".ToConstSignal(),
                                    Content = "width=device-width, initial-scale=1".ToConstSignal(),
                                },
                            },
                            new Link
                            {
                                Props = new LinkProps
                                {
                                    Rel = "icon".ToConstSignal(),
                                    Type = "image/svg+xml".ToConstSignal(),
                                    Href = WwwRoot.Assets_Icon_Svg.ToConstSignal(),
                                },
                            },
                            new Title
                            {
                                Props = new TitleProps(),
                                Children = [new DomText { Text = "MyNatrixApp".ToConstSignal() }],
                            },
                            new MainScript(),
                            new HydrationStateScript(),
                            new Style
                            {
                                Props = new StyleProps(),
                                Children = [new DomText { Text = Styles.GetCss().ToConstSignal() }],
                            },
                        ],
                    },
                    new Body
                    {
                        Props = new BodyProps
                        {
                            Class = "bg-white dark:bg-gray-950 text-gray-900 dark:text-gray-100".ToConstSignal(),
                        },
                        Children =
                        [
                            new Div
                            {
                                Props = new DivProps { Id = "app".ToConstSignal() },
                                Children = [new App { Props = new AppProps() }],
                            },
                            new HotReloadInterceptionScript(),
                        ],
                    },
                ],
            },
        ];
    }

}
