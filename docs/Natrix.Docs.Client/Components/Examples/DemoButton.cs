using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples;

public enum DemoButtonVariant
{
    Primary,
    Secondary,
    Ghost,
}

public class DemoButtonProps
{
    public required IReadOnlySignal<string> Label { get; init; }
    public IReadOnlySignal<DemoButtonVariant> Variant { get; init; } = DemoButtonVariant.Primary.ToConstSignal();
    public IReadOnlySignal<string>? Title { get; init; }
    public IReadOnlySignal<string> ExtraClass { get; init; } = "".ToConstSignal();
}

[GeneratedEvents]
public partial class DemoButtonEvents
{
    public partial void Click();
}

/// <summary>
/// Button styled for the example demos, shared so the demos stay free of styling noise.
/// </summary>
public class DemoButton : BaseComponent<DemoButtonProps, DemoButtonEvents, NoSlots, NoExpose>
{
    private const string PrimaryClass =
        "rounded-md bg-indigo-600 px-6 py-2 font-medium text-white hover:bg-indigo-700 transition-colors";

    private const string SecondaryClass =
        "rounded-md border border-gray-300 dark:border-gray-600 px-6 py-2 font-medium text-gray-700 dark:text-gray-300 hover:border-indigo-400 hover:text-indigo-600 dark:hover:text-indigo-400 transition-colors";

    private const string GhostClass =
        "rounded-md px-2 py-1 text-sm text-gray-500 dark:text-gray-400 hover:text-red-600 dark:hover:text-red-400 transition-colors";

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var buttonClass = new Computed<string>(() =>
        {
            var variantClass = Props.Variant.Value switch
            {
                DemoButtonVariant.Secondary => SecondaryClass,
                DemoButtonVariant.Ghost => GhostClass,
                _ => PrimaryClass,
            };

            var extra = Props.ExtraClass.Value;
            return extra.Length == 0 ? variantClass : $"{variantClass} {extra}";
        });

        return
        [
            new Button
            {
                Props = new ButtonProps
                {
                    Class = buttonClass,
                    Title = Props.Title,
                },
                Events = new ButtonEvents
                {
                    OnClick = (_) => Events?.Click(),
                },
                Children = [new DomText { Text = Props.Label }],
            },
        ];
    }
}
