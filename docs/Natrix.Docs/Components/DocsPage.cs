using Natrix.Composables.Dom.Head;
using Natrix.Core.Components;
using Natrix.Core.Features;
using Natrix.Core.Features.Routing;
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
    // Tells search engines what the site is, and that it is about an open-source C# library,
    // which they can show as a rich result. The same on every page.
    private static readonly string StructuredData = $$"""
        {
          "@context": "https://schema.org",
          "@graph": [
            {
              "@type": "WebSite",
              "@id": "{{Site.Origin}}/#website",
              "name": "{{Site.Name}}",
              "url": "{{Site.Origin}}/",
              "description": "{{Site.Description}}",
              "inLanguage": "en"
            },
            {
              "@type": "SoftwareSourceCode",
              "name": "{{Site.Name}}",
              "description": "{{Site.Description}}",
              "url": "{{Site.Origin}}/",
              "codeRepository": "https://github.com/miroljub1995/natrix",
              "programmingLanguage": "C#",
              "runtimePlatform": ".NET",
              "license": "https://opensource.org/licenses/MIT"
            }
          ]
        }
        """;

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var navigation = AppFeatures.Features.GetRequired<INavigationFeature>();
        var status = AppFeatures.Features.GetRequired<PageStatus>();

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
                            // The title, description and Open Graph tags the page's components set
                            // with UseHead.
                            new HeadTags { Props = new NoProps() },
                            // Only for a page that exists: a 404 has no URL to be known by.
                            new If
                            {
                                Condition = new Computed<bool>(() => status.StatusCode.Value == 200),
                                Then = () =>
                                [
                                    new Link
                                    {
                                        Props = new LinkProps
                                        {
                                            Rel = "canonical".ToConstSignal(),
                                            Href = new Computed<string>(() => Site.CanonicalUrl(navigation.CurrentPath.Value)),
                                        },
                                    },
                                ],
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
                            new Link
                            {
                                Props = new LinkProps
                                {
                                    Rel = "apple-touch-icon".ToConstSignal(),
                                    Href = WwwRoot.Assets_Apple_Touch_Icon_Png.ToConstSignal(),
                                },
                            },
                            new Script
                            {
                                Props = new ScriptProps { Type = "application/ld+json".ToConstSignal() },
                                Children = [new DomText { Text = StructuredData.ToConstSignal() }],
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
