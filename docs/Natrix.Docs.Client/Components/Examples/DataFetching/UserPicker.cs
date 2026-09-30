using Natrix.Core.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.DataFetching;

public class UserPickerProps
{
    public required IReadOnlySignal<string> SelectedId { get; init; }
}

[GeneratedEvents]
public partial class UserPickerEvents
{
    public partial void Select(string id);
}

/// <summary>
/// Picks which user the cards are bound to. Props down, events up: the selection lives with the
/// demo that owns it, and this component only reports which button was pressed.
/// </summary>
public class UserPicker : BaseComponent<UserPickerProps, UserPickerEvents, NoSlots, NoExpose>
{
    private static readonly (string Id, string Name)[] Users =
    [
        ("ada", "Ada"),
        ("grace", "Grace"),
        ("linus", "Linus"),
        // Bound by no other card on the page, so this is the switch that costs a request.
        ("barbara", "Barbara"),
    ];

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var buttons = new List<IComponent>();

        foreach (var (id, name) in Users)
        {
            buttons.Add(new DemoButton
            {
                Props = new DemoButtonProps
                {
                    Label = name.ToConstSignal(),
                    Variant = new Computed<DemoButtonVariant>(() => Props.SelectedId.Value == id
                        ? DemoButtonVariant.Primary
                        : DemoButtonVariant.Secondary),
                    ExtraClass = "px-4 py-1 text-sm".ToConstSignal(),
                },
                Events = new DemoButtonEvents
                {
                    OnClick = () => Events?.Select(id),
                },
            });
        }

        return [.. buttons];
    }
}
