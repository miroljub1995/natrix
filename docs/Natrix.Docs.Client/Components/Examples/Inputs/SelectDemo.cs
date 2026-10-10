using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class SelectDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class CountryPicker : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            private static readonly Dictionary<string, string> Capitals = new()
            {
                ["Brazil"] = "Brasília",
                ["Canada"] = "Ottawa",
                ["Japan"] = "Tokyo",
                ["Kenya"] = "Nairobi",
                ["Serbia"] = "Belgrade",
            };

            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                var country = new Signal<string>("Japan");

                return
                [
                    new Select
                    {
                        // Selects the option with this value, on the server too.
                        Props = new SelectProps { Value = country },
                        Events = new SelectEvents { OnChange = country.ToDomEvent() },
                        Children =
                        [
                            .. Capitals.Keys.Select(name => new Option
                            {
                                Props = new OptionProps { Value = name.ToConstSignal() },
                                Children = [new DomText { Text = name.ToConstSignal() }],
                            }),
                        ],
                    },
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = new Computed<string>(
                            () => $"The capital of {country.Value} is {Capitals[country.Value]}.") }],
                    },
                ];
            }
        }
        """;

    private static readonly Dictionary<string, string> Capitals = new()
    {
        ["Brazil"] = "Brasília",
        ["Canada"] = "Ottawa",
        ["Japan"] = "Tokyo",
        ["Kenya"] = "Nairobi",
        ["Serbia"] = "Belgrade",
    };

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var country = new Signal<string>("Japan");

        return
        [
            Stack(
                Field("Country", "inputs-select-field", new Select
                {
                    Props = new SelectProps
                    {
                        Id = "inputs-select-field".ToConstSignal(),
                        Value = country,
                        Class = FieldClass.ToConstSignal(),
                    },
                    Events = new SelectEvents { OnChange = country.ToDomEvent() },
                    Children =
                    [
                        .. Capitals.Keys.Select(name => new Option
                        {
                            Props = new OptionProps { Value = name.ToConstSignal() },
                            Children = [Text(name)],
                        }),
                    ],
                }),
                Result(new Computed<string>(() => $"The capital of {country.Value} is {Capitals[country.Value]}."))),
        ];
    }
}
