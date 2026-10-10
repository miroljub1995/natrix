using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class RangeInputDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class FontSizeSlider : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                var size = new Signal<string>("24");

                return
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "range".ToConstSignal(),
                            Min = "12".ToConstSignal(),
                            Max = "64".ToConstSignal(),
                            Value = size,
                        },
                        // Input fires while dragging; Change only on release.
                        Events = new InputEvents { OnInput = size.ToDomEvent() },
                    },
                    new P
                    {
                        // Only this one attribute is written as the slider moves.
                        Props = new PProps { Style = new Computed<string>(() => $"font-size: {size.Value}px") },
                        Children = [new DomText { Text = new Computed<string>(() => $"Aa · {size.Value}px") }],
                    },
                ];
            }
        }
        """;

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var size = new Signal<string>("24");

        return
        [
            Stack(
                Field("Font size", "inputs-range-field", new Input
                {
                    Props = new InputProps
                    {
                        Id = "inputs-range-field".ToConstSignal(),
                        Type = "range".ToConstSignal(),
                        Min = "12".ToConstSignal(),
                        Max = "64".ToConstSignal(),
                        Value = size,
                        Class = "w-full accent-indigo-600".ToConstSignal(),
                    },
                    Events = new InputEvents { OnInput = size.ToDomEvent() },
                }),
                new P
                {
                    Props = new PProps
                    {
                        Style = new Computed<string>(() => $"font-size: {size.Value}px"),
                        Class = "flex h-20 items-center justify-center overflow-hidden whitespace-nowrap font-semibold leading-none text-gray-900 dark:text-white".ToConstSignal(),
                    },
                    Children = [new DomText { Text = new Computed<string>(() => $"Aa · {size.Value}px") }],
                }),
        ];
    }
}
