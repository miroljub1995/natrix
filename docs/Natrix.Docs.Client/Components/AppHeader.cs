using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Core.Features;
using Natrix.Core.Features.Routing;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Docs.Client.Components;

public class AppHeaderProps { }

/// <summary>
/// The bar on every page: the brand, and the site's sections, which fit beside it at any width,
/// so there is no menu to open. The docs' own pages are in their sidebar.
/// </summary>
public class AppHeader : BaseComponent<AppHeaderProps, NoEvents, NoSlots, NoExpose>
{
    private const string LinkClass =
        "rounded-lg px-2 sm:px-3 py-2 text-sm font-medium text-gray-600 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white transition-colors";

    private const string ActiveLinkClass =
        "rounded-lg px-2 sm:px-3 py-2 text-sm font-medium text-indigo-600 dark:text-indigo-400";

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var navigation = AppFeatures.Features.GetRequired<INavigationFeature>();

        return
        [
            new Header
            {
                Props = new HeaderProps
                {
                    Class = "bg-white/80 dark:bg-gray-900/80 backdrop-blur-md border-b border-gray-200 dark:border-gray-700 sticky top-0 z-50".ToConstSignal(),
                },
                Children =
                [
                    new Div
                    {
                        Props = new DivProps
                        {
                            Class = "mx-auto flex max-w-7xl items-center justify-between gap-4 h-16 px-4 sm:px-6".ToConstSignal(),
                        },
                        Children =
                        [
                            // Logo + brand
                            new A
                            {
                                Props = new AProps
                                {
                                    Href = "/".ToConstSignal(),
                                    Class = "flex items-center gap-3 shrink-0".ToConstSignal(),
                                },
                                Events = new AEvents
                                {
                                    OnClick = (e) => Navigate(e, navigation, "/"),
                                },
                                Children =
                                [
                                    new Img
                                    {
                                        Props = new ImgProps
                                        {
                                            Src = WwwRoot.Assets_Icon_Svg.ToConstSignal(),
                                            Alt = "".ToConstSignal(),
                                            Class = "h-8 w-8".ToConstSignal(),
                                        },
                                    },
                                    new Span
                                    {
                                        Props = new SpanProps
                                        {
                                            Class = "text-xl font-bold text-gray-900 dark:text-white tracking-tight".ToConstSignal(),
                                        },
                                        Children = [new DomText { Text = "Natrix".ToConstSignal() }],
                                    },
                                ],
                            },
                            new Nav
                            {
                                Props = new NavProps
                                {
                                    AriaLabel = "Main".ToConstSignal(),
                                    Class = "flex items-center gap-1 sm:gap-2".ToConstSignal(),
                                },
                                Children =
                                [
                                    SectionLink(navigation, "Docs", "/docs/quick-start",
                                        path => path.StartsWith("/docs/", StringComparison.Ordinal)),
                                    new Span
                                    {
                                        Props = new SpanProps
                                        {
                                            Class = "mx-1 h-5 w-px bg-gray-200 dark:bg-gray-700".ToConstSignal(),
                                            AriaHidden = true.ToConstSignal(),
                                        },
                                    },
                                    new A
                                    {
                                        Props = new AProps
                                        {
                                            Href = Site.GitHubUrl.ToConstSignal(),
                                            Title = "Natrix on GitHub".ToConstSignal(),
                                            Class = "inline-flex rounded-lg p-2 opacity-70 hover:opacity-100 transition-opacity".ToConstSignal(),
                                        },
                                        Children =
                                        [
                                            new Img
                                            {
                                                Props = new ImgProps
                                                {
                                                    Src = WwwRoot.Assets_Github_Mark_Svg.ToConstSignal(),
                                                    Alt = "GitHub".ToConstSignal(),
                                                    Class = "h-5 w-5 dark:invert".ToConstSignal(),
                                                },
                                            },
                                        ],
                                    },
                                ],
                            },
                        ],
                    },
                ],
            },
        ];
    }

    /// <summary>A link to a section, marked current on any of the section's pages.</summary>
    private static A SectionLink(INavigationFeature navigation, string label, string href, Func<string, bool> isInSection)
    {
        var isActive = new Computed<bool>(() => isInSection(navigation.CurrentPath.Value));

        return new A
        {
            Props = new AProps
            {
                Href = href.ToConstSignal(),
                Class = new Computed<string>(() => isActive.Value ? ActiveLinkClass : LinkClass),
                AriaCurrent = new Computed<string?>(() => isActive.Value ? "true" : null),
            },
            Events = new AEvents
            {
                OnClick = (e) => Navigate(e, navigation, href),
            },
            Children = [new DomText { Text = label.ToConstSignal() }],
        };
    }

    private static void Navigate(MouseEvent e, INavigationFeature navigation, string href)
    {
        if (!OperatingSystem.IsBrowser()) return;
        e.PreventDefault();
        navigation.PushAsync(href);
        RouterLink.ScrollToTop();
    }
}
