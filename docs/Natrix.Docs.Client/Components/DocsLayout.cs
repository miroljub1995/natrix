using Natrix.Core.Components;
using Natrix.Core.Features;
using Natrix.Core.Features.Routing;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components;

/// <summary>
/// What every page under <c>/docs</c> sits in: the sidebar beside it, or on small screens a bar
/// that says where in the docs the page is and opens the docs menu.
/// </summary>
public class DocsLayout : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var navigation = AppFeatures.Features.GetRequired<INavigationFeature>();

        var menuOpen = new Signal<bool>(false);
        var current = new Computed<(NavGroup Group, NavItem Item)?>(() => NavItems.Find(navigation.CurrentPath.Value));

        return
        [
            // The docs menu opens over the page rather than pushing it down, and a tap on the dimmed
            // page around it closes it. Outside the bar, whose backdrop blur would otherwise make it
            // the box this fixed layer fills.
            new Div
            {
                Props = new DivProps
                {
                    AriaHidden = true.ToConstSignal(),
                    Class = new Computed<string>(() => menuOpen.Value
                        ? "md:hidden fixed inset-0 z-30 bg-gray-950/40 backdrop-blur-sm"
                        : "hidden"),
                },
                Events = new DivEvents
                {
                    OnClick = (_) => menuOpen.Value = false,
                },
            },
            // Docs bar, below md only
            new Div
            {
                Props = new DivProps
                {
                    Class = "md:hidden sticky top-16 z-40 border-b border-gray-200 dark:border-gray-800 bg-white/90 dark:bg-gray-950/90 backdrop-blur-md".ToConstSignal(),
                },
                Children =
                [
                    new Div
                    {
                        Props = new DivProps
                        {
                            Class = "flex items-center gap-3 h-12 px-4".ToConstSignal(),
                        },
                        Children =
                        [
                            new Button
                            {
                                Props = new ButtonProps
                                {
                                    AriaLabel = "Toggle docs menu".ToConstSignal(),
                                    AriaExpanded = new Computed<string?>(() => menuOpen.Value ? "true" : "false"),
                                    AriaControls = "docs-menu".ToConstSignal(),
                                    Class = "inline-flex items-center justify-center rounded-lg p-2 -ml-2 text-gray-600 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white hover:bg-gray-100 dark:hover:bg-gray-800 transition-colors".ToConstSignal(),
                                },
                                Events = new ButtonEvents
                                {
                                    OnClick = (_) => menuOpen.Value = !menuOpen.Value,
                                },
                                Children = [BurgerIcon()],
                            },
                            new Span
                            {
                                Props = new SpanProps
                                {
                                    Class = "min-w-0 truncate text-sm text-gray-500 dark:text-gray-400".ToConstSignal(),
                                },
                                Children = [new DomText { Text = new Computed<string>(() => current.Value?.Group.Label ?? "Docs") }],
                            },
                            new Span
                            {
                                Props = new SpanProps
                                {
                                    Class = "text-gray-300 dark:text-gray-600".ToConstSignal(),
                                    AriaHidden = true.ToConstSignal(),
                                },
                                Children = [new DomText { Text = "›".ToConstSignal() }],
                            },
                            new Span
                            {
                                Props = new SpanProps
                                {
                                    Class = "min-w-0 truncate text-sm font-semibold text-gray-900 dark:text-white".ToConstSignal(),
                                },
                                Children = [new DomText { Text = new Computed<string>(() => current.Value?.Item.Label ?? "Page not found") }],
                            },
                        ],
                    },
                    new Nav
                    {
                        Props = new NavProps
                        {
                            Id = "docs-menu".ToConstSignal(),
                            AriaLabel = "Docs".ToConstSignal(),
                            Class = new Computed<string>(() => menuOpen.Value
                                ? "absolute inset-x-0 top-full max-h-[calc(100vh-7rem)] overflow-y-auto border-b border-gray-200 dark:border-gray-800 bg-white dark:bg-gray-950 px-4 pt-4 pb-2 shadow-lg"
                                : "hidden"),
                        },
                        Children =
                        [
                            new NavItems
                            {
                                Props = new NoProps(),
                                Events = new NavItemsEvents
                                {
                                    OnNavigate = () => menuOpen.Value = false,
                                },
                            },
                        ],
                    },
                ],
            },
            new Div
            {
                Props = new DivProps
                {
                    Class = "mx-auto flex max-w-7xl".ToConstSignal(),
                },
                Children =
                [
                    new Sidebar
                    {
                        Props = new NoProps(),
                    },
                    new Main
                    {
                        Props = new MainProps
                        {
                            Class = "min-w-0 flex-1 px-4 sm:px-8 py-8".ToConstSignal(),
                        },
                        Children = [new Outlet()],
                    },
                ],
            },
        ];
    }

    private static Span BurgerIcon() => new()
    {
        Props = new SpanProps
        {
            Class = "flex flex-col gap-1 w-5".ToConstSignal(),
        },
        Children =
        [
            .. Enumerable.Range(0, 3).Select(_ => new Span
            {
                Props = new SpanProps
                {
                    Class = "block h-0.5 w-full bg-current rounded-full".ToConstSignal(),
                },
            }),
        ],
    };
}
