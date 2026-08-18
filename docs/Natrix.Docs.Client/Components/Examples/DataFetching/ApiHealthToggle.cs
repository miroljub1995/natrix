using Natrix.Core.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.DataFetching;

public class ApiHealthToggleProps
{
    public required IReadOnlySignal<bool> IsBroken { get; init; }
}

[GeneratedEvents]
public partial class ApiHealthToggleEvents
{
    public partial void Toggle();
}

/// <summary>
/// Breaks and repairs the fake API. It reads the current state through props and reports the
/// press, rather than being handed the API to flip itself.
/// </summary>
public class ApiHealthToggle : BaseComponent<ApiHealthToggleProps, ApiHealthToggleEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        return
        [
            new DemoButton
            {
                Props = new DemoButtonProps
                {
                    Label = new Computed<string>(() =>
                        Props.IsBroken.Value ? "Repair the API" : "Break the API"),
                    Variant = DemoButtonVariant.Secondary.ToConstSignal(),
                    ExtraClass = "ml-auto px-4 py-1 text-sm".ToConstSignal(),
                    Title = ("While broken, every request fails and the resource retries twice "
                        + "before giving up").ToConstSignal(),
                },
                Events = new DemoButtonEvents
                {
                    OnClick = () => Events?.Toggle(),
                },
            },
        ];
    }
}
