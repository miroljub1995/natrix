using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Core.Features;
using Natrix.Core.Features.Routing;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components;

internal record NavItem(string Label, string Href);

internal record NavGroup(string? Label, NavItem[] Items);

public class NavItemsProps
{
    public required string LinkClass { get; init; }
    public required string ActiveLinkClass { get; init; }
}

[GeneratedEvents]
public partial class NavItemsEvents
{
    public partial void Navigate();
}

public class NavItems : BaseComponent<NavItemsProps, NavItemsEvents, NoSlots, NoExpose>
{
    internal static readonly NavGroup[] Groups =
    [
        new(null,
        [
            new("Home", "/"),
            new("Quick Start", "/quick-start"),
        ]),
        new("Examples",
        [
            new("Todo List", "/examples/todo"),
            new("Canvas", "/examples/canvas"),
        ]),
    ];

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var navigation = AppFeatures.Features.Get<INavigationFeature>()
            ?? throw new InvalidOperationException("INavigationFeature is not registered.");

        var components = new List<IComponent>();

        foreach (var group in Groups)
        {
            if (group.Label is { } label)
            {
                components.Add(new Div
                {
                    Props = new DivProps
                    {
                        Class = "px-3 pt-4 pb-1 text-xs font-semibold uppercase tracking-wide text-gray-400 dark:text-gray-500".ToConstSignal(),
                    },
                    Children = [new DomText { Text = label.ToConstSignal() }],
                });
            }

            foreach (var item in group.Items)
            {
                var computedClass = new Computed<string>(() =>
                    navigation.CurrentPath.Value == item.Href
                        ? Props.ActiveLinkClass
                        : Props.LinkClass);

                components.Add(new A
                {
                    Props = new AProps
                    {
                        Href = item.Href.ToConstSignal(),
                        Class = computedClass,
                    },
                    Events = new AEvents
                    {
                        OnClick = (e) =>
                        {
                            if (!OperatingSystem.IsBrowser()) return;
                            e.PreventDefault();
                            Events?.Navigate();
                            navigation.PushAsync(item.Href);
                        },
                    },
                    Children = [new DomText { Text = item.Label.ToConstSignal() }],
                });
            }
        }

        return [.. components];
    }
}
