using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples;

public class DemoCardProps
{
    public required IReadOnlySignal<string> Title { get; init; }
}

public class DemoCardSlots
{
    public required Func<IComponent[]> Default { get; init; }
}

/// <summary>
/// Bordered surface with a heading that every example demo is wrapped in.
/// </summary>
public class DemoCard : BaseComponent<DemoCardProps, NoEvents, DemoCardSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var content = Slots?.Default() ?? [];

        return
        [
            new Div
            {
                Props = new DivProps
                {
                    Class = "rounded-lg border border-gray-200 dark:border-gray-700 bg-white dark:bg-gray-900 p-6".ToConstSignal(),
                },
                Children =
                [
                    new H3
                    {
                        Props = new H3Props
                        {
                            Class = "text-xl font-bold text-gray-900 dark:text-white mb-4".ToConstSignal(),
                        },
                        Children = [new DomText { Text = Props.Title }],
                    },
                    .. content,
                ],
            },
        ];
    }
}
