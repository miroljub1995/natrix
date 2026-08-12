using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Ssr.Features.HydrationState;
using Natrix.Ssr.HotReload;
using Natrix.Docs.Client;
using Natrix.Docs.Client.Components;
using Natrix.Ssr.Components;
using Natrix.Signals;

namespace Natrix.Docs.Components;

public class DocsPageProps
{
}

public class DocsPage : BaseComponent<DocsPageProps, NoEvents, NoSlots, NoExpose>
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
                            new Title
                            {
                                Props = new TitleProps(),
                                Children = [new DomText { Text = "Natrix Docs (SSR)".ToConstSignal() }],
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
                            Class = Styles.Body.ToConstSignal(),
                        },
                        Children =
                        [
                            new Div
                            {
                                Props = new DivProps { Id = "app".ToConstSignal() },
                                Children = [new DocsApp { Props = new DocsAppProps() }],
                            },
                            new HotReloadInterceptionScript(),
                        ],
                    },
                ],
            },
        ];
    }

}
