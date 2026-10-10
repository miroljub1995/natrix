using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class ColorInputDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class ColorPicker : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                // Always "#rrggbb", lowercase.
                var color = new Signal<string>("#6366f1");
                var rgb = new Computed<string>(() =>
                {
                    var value = Convert.FromHexString(color.Value[1..]);
                    return $"rgb({value[0]}, {value[1]}, {value[2]})";
                });

                return
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "color".ToConstSignal(),
                            Value = color,
                        },
                        Events = new InputEvents { OnInput = color.ToDomEvent() },
                    },
                    new Div
                    {
                        Props = new DivProps
                        {
                            Style = new Computed<string>(() => $"background-color: {color.Value}"),
                        },
                        Children = [new DomText { Text = new Computed<string>(() => $"{color.Value} · {rgb.Value}") }],
                    },
                ];
            }
        }
        """;

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var color = new Signal<string>("#6366f1");
        var rgb = new Computed<string>(() =>
        {
            var value = Convert.FromHexString(color.Value[1..]);
            return $"rgb({value[0]}, {value[1]}, {value[2]})";
        });

        // Dark text on light swatches, light text on dark ones.
        var textClass = new Computed<string>(() =>
        {
            var value = Convert.FromHexString(color.Value[1..]);
            var luminance = (0.299 * value[0]) + (0.587 * value[1]) + (0.114 * value[2]);
            return luminance > 150 ? "text-gray-900" : "text-white";
        });

        return
        [
            Stack(
                new Div
                {
                    Props = new DivProps
                    {
                        Class = "flex items-center gap-3".ToConstSignal(),
                    },
                    Children =
                    [
                        new Input
                        {
                            Props = new InputProps
                            {
                                Id = "inputs-color-field".ToConstSignal(),
                                Type = "color".ToConstSignal(),
                                Value = color,
                                Class = "h-10 w-14 cursor-pointer rounded-md border border-gray-300 dark:border-gray-600 bg-white dark:bg-gray-800 p-1".ToConstSignal(),
                            },
                            Events = new InputEvents { OnInput = color.ToDomEvent() },
                        },
                        new Label
                        {
                            Props = new LabelProps
                            {
                                HtmlFor = "inputs-color-field".ToConstSignal(),
                                Class = "text-sm font-medium text-gray-700 dark:text-gray-300".ToConstSignal(),
                            },
                            Children = [Text("Brand colour")],
                        },
                    ],
                },
                new Div
                {
                    Props = new DivProps
                    {
                        Style = new Computed<string>(() => $"background-color: {color.Value}"),
                        Class = new Computed<string>(() => $"flex h-20 items-center justify-center rounded-lg font-mono text-sm shadow-inner {textClass.Value}"),
                    },
                    Children = [new DomText { Text = new Computed<string>(() => $"{color.Value} · {rgb.Value}") }],
                }),
        ];
    }
}
