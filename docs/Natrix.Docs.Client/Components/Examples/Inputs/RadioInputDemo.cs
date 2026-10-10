using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;
using Natrix.StdWeb;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class RadioInputDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class PlanPicker : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            private record Plan(string Id, string Name, int Price);

            private static readonly Plan[] Plans =
                [new("free", "Free", 0), new("pro", "Pro", 12), new("team", "Team", 49)];

            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                var selected = new Signal<string>("pro");
                var summary = new Computed<string>(() =>
                    Plans.Single(p => p.Id == selected.Value) is var plan && plan.Price == 0
                        ? $"{plan.Name}: free forever"
                        : $"{plan.Name}: ${plan.Price} a month");

                return
                [
                    // One shared name makes them a group: checking one unchecks the rest.
                    .. Plans.Select(plan => new Input
                    {
                        Props = new InputProps
                        {
                            Type = "radio".ToConstSignal(),
                            Name = "plan".ToConstSignal(),
                            Value = plan.Id.ToConstSignal(),
                            Checked = new Computed<bool>(() => selected.Value == plan.Id),
                        },
                        Events = new InputEvents { OnChange = _ => selected.Value = plan.Id },
                    }),
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = summary }],
                    },
                ];
            }
        }
        """;

    private record Plan(string Id, string Name, int Price);

    private static readonly Plan[] Plans =
        [new("free", "Free", 0), new("pro", "Pro", 12), new("team", "Team", 49)];

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var selected = new Signal<string>("pro");
        var summary = new Computed<string>(() =>
            Plans.Single(p => p.Id == selected.Value) is var plan && plan.Price == 0
                ? $"{plan.Name}: free forever"
                : $"{plan.Name}: ${plan.Price} a month");

        return
        [
            Stack(
                new FieldSet
                {
                    Props = new FieldSetProps
                    {
                        Class = "flex flex-col gap-1".ToConstSignal(),
                    },
                    Children =
                    [
                        new Legend
                        {
                            Props = new LegendProps
                            {
                                Class = "mb-1 text-sm font-medium text-gray-700 dark:text-gray-300".ToConstSignal(),
                            },
                            Children = [Text("Plan")],
                        },
                        .. Plans.Select(plan => Choice(
                            new Input
                            {
                                Props = new InputProps
                                {
                                    Type = "radio".ToConstSignal(),
                                    Name = "inputs-plan".ToConstSignal(),
                                    Value = plan.Id.ToConstSignal(),
                                    Checked = new Computed<bool>(() => selected.Value == plan.Id),
                                    Class = ChoiceClass.ToConstSignal(),
                                },
                                Events = new InputEvents { OnChange = _ => selected.Value = plan.Id },
                            },
                            Text(plan.Name))),
                    ],
                },
                Result(summary)),
        ];
    }
}
