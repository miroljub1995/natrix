using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Core.Features;
using Natrix.Core.Features.Routing;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components;

internal record NavItem(string Label, string Href);

internal record NavGroup(string Label, NavItem[] Items);

[GeneratedEvents]
public partial class NavItemsEvents
{
    public partial void Navigate();
}

/// <summary>
/// The docs pages, in their groups: what the sidebar lists, and the mobile docs menu.
/// </summary>
public class NavItems : BaseComponent<NoProps, NavItemsEvents, NoSlots, NoExpose>
{
    internal static readonly NavGroup[] Groups =
    [
        new("Getting Started",
        [
            new("Quick Start", "/docs/quick-start"),
        ]),
        new("Examples",
        [
            new("Todo List", "/docs/examples/todo"),
            new("Canvas", "/docs/examples/canvas"),
            new("Data Fetching", "/docs/examples/data-fetching"),
            new("Form Inputs", "/docs/examples/inputs"),
        ]),
    ];

    private const string LinkClass =
        "-ml-px block border-l border-transparent pl-4 py-1 text-sm text-gray-600 dark:text-gray-400 hover:border-gray-400 dark:hover:border-gray-500 hover:text-gray-900 dark:hover:text-white transition-colors";

    private const string ActiveLinkClass =
        "-ml-px block border-l border-indigo-600 dark:border-indigo-400 pl-4 py-1 text-sm font-semibold text-indigo-600 dark:text-indigo-400";

    /// <summary>The group and item the path belongs to, or <c>null</c> off the docs.</summary>
    internal static (NavGroup Group, NavItem Item)? Find(string path) =>
        Groups
            .SelectMany(group => group.Items, (group, item) => (group, item))
            .Where(pair => pair.item.Href == path)
            .Select(pair => ((NavGroup, NavItem)?)pair)
            .FirstOrDefault();

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var navigation = AppFeatures.Features.GetRequired<INavigationFeature>();

        return [.. Groups.Select(group => GroupList(group, navigation))];
    }

    private Div GroupList(NavGroup group, INavigationFeature navigation) => new()
    {
        Props = new DivProps
        {
            Class = "mb-8".ToConstSignal(),
        },
        Children =
        [
            new H5
            {
                Props = new H5Props
                {
                    Class = "mb-3 text-sm font-semibold text-gray-900 dark:text-white".ToConstSignal(),
                },
                Children = [new DomText { Text = group.Label.ToConstSignal() }],
            },
            new Ul
            {
                Props = new UlProps
                {
                    Class = "flex flex-col gap-1 border-l border-gray-200 dark:border-gray-800".ToConstSignal(),
                },
                Children = [.. group.Items.Select(item => ItemLink(item, navigation))],
            },
        ],
    };

    private Li ItemLink(NavItem item, INavigationFeature navigation)
    {
        var isActive = new Computed<bool>(() => navigation.CurrentPath.Value == item.Href);

        return new Li
        {
            Props = new LiProps(),
            Children =
            [
                new A
                {
                    Props = new AProps
                    {
                        Href = item.Href.ToConstSignal(),
                        Class = new Computed<string>(() => isActive.Value ? ActiveLinkClass : LinkClass),
                        AriaCurrent = new Computed<string?>(() => isActive.Value ? "page" : null),
                    },
                    Events = new AEvents
                    {
                        OnClick = (e) =>
                        {
                            if (!OperatingSystem.IsBrowser()) return;
                            if (!RouterLink.IsPlainClick(e)) return;
                            e.PreventDefault();
                            Events?.Navigate();
                            navigation.PushAsync(item.Href);
                            RouterLink.ScrollToTop();
                        },
                    },
                    Children = [new DomText { Text = item.Label.ToConstSignal() }],
                },
            ],
        };
    }
}
