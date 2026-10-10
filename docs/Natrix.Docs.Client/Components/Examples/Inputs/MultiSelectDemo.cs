using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class MultiSelectDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class ToppingsPicker : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            private static readonly string[] Toppings =
                ["Basil", "Mushrooms", "Olives", "Onions", "Peppers", "Pineapple"];

            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                var chosen = new Signal<IReadOnlyList<string>>(["Basil", "Olives"]);
                var order = new Computed<string>(() => chosen.Value.Count == 0
                    ? "Margherita, nothing on top"
                    : $"Pizza with {string.Join(", ", chosen.Value)}: ${8 + chosen.Value.Count}");

                return
                [
                    new Select
                    {
                        Props = new SelectProps
                        {
                            Multiple = true.ToConstSignal(),
                            Size = 6u.ToConstSignal(),
                            // Values, not Value: every selected option, as a list.
                            Values = chosen,
                        },
                        Events = new SelectEvents { OnChange = chosen.ToDomEvent() },
                        Children =
                        [
                            .. Toppings.Select(topping => new Option
                            {
                                Props = new OptionProps { Value = topping.ToConstSignal() },
                                Children = [new DomText { Text = topping.ToConstSignal() }],
                            }),
                        ],
                    },
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = order }],
                    },
                ];
            }
        }
        """;

    private static readonly string[] Toppings =
        ["Basil", "Mushrooms", "Olives", "Onions", "Peppers", "Pineapple"];

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var chosen = new Signal<IReadOnlyList<string>>(["Basil", "Olives"]);
        var order = new Computed<string>(() => chosen.Value.Count == 0
            ? "Margherita, nothing on top"
            : $"Pizza with {string.Join(", ", chosen.Value)}: ${8 + chosen.Value.Count}");

        return
        [
            Stack(
                Field("Toppings", "inputs-multiselect-field", new Select
                {
                    Props = new SelectProps
                    {
                        Id = "inputs-multiselect-field".ToConstSignal(),
                        Multiple = true.ToConstSignal(),
                        Size = 6u.ToConstSignal(),
                        Values = chosen,
                        Class = FieldClass.Replace("py-2", "py-1").ToConstSignal(),
                    },
                    Events = new SelectEvents { OnChange = chosen.ToDomEvent() },
                    Children =
                    [
                        .. Toppings.Select(topping => new Option
                        {
                            Props = new OptionProps
                            {
                                Value = topping.ToConstSignal(),
                                Class = "rounded px-2 py-0.5 checked:bg-indigo-100 dark:checked:bg-indigo-500/30".ToConstSignal(),
                            },
                            Children = [Text(topping)],
                        }),
                    ],
                }),
                Result(order),
                Hint("Ctrl or ⌘ click to pick more than one.".ToConstSignal())),
        ];
    }
}
