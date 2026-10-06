using Natrix.Composables.Dom.Head;
using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Ssr.Features.HydrationState;
using Natrix.Ssr.HotReload;
using Natrix.Docs.Client;
using Natrix.Docs.Client.Components;
using Natrix.Ssr.Components;
using Natrix.Signals;
using Natrix.TailwindCss;

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
                            new Meta
                            {
                                Props = new MetaProps
                                {
                                    Name = "viewport".ToConstSignal(),
                                    Content = "width=device-width, initial-scale=1".ToConstSignal(),
                                },
                            },
                            new Meta
                            {
                                Props = new MetaProps
                                {
                                    Name = "description".ToConstSignal(),
                                    Content = "Natrix is a .NET WebAssembly toolkit for building browser applications in C#, with reactive signals, generated Web API bindings and server-side rendering.".ToConstSignal(),
                                },
                            },
                            // The title the page's components set with UseHead.
                            new HeadTags { Props = new NoProps() },
                            new Link
                            {
                                Props = new LinkProps
                                {
                                    Rel = "icon".ToConstSignal(),
                                    Type = "image/svg+xml".ToConstSignal(),
                                    Href = WwwRoot.Assets_Icon_Svg.ToConstSignal(),
                                },
                            },
                            new MainScript(),
                            new HydrationStateScript(),
                            new TailwindCssStyle { Css = Styles.GetCss() },
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
