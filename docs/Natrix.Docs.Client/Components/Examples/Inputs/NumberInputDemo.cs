using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class NumberInputDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class TicketField : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            private const int TicketPrice = 12;

            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                // The field's value is always a string; parse it where it's read.
                var quantity = new Signal<string>("3");
                var total = new Computed<string>(() =>
                    int.TryParse(quantity.Value, out var n) && n is >= 1 and <= 20
                        ? $"{n} × ${TicketPrice} = ${n * TicketPrice}"
                        : "Pick between 1 and 20");

                return
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "number".ToConstSignal(),
                            Min = "1".ToConstSignal(),
                            Max = "20".ToConstSignal(),
                            Step = "1".ToConstSignal(),
                            Value = quantity,
                        },
                        Events = new InputEvents { OnInput = quantity.ToDomEvent() },
                    },
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = total }],
                    },
                ];
            }
        }
        """;

    private const int TicketPrice = 12;

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var quantity = new Signal<string>("3");
        var total = new Computed<string>(() =>
            int.TryParse(quantity.Value, out var n) && n is >= 1 and <= 20
                ? $"{n} × ${TicketPrice} = ${n * TicketPrice}"
                : "Pick between 1 and 20");

        return
        [
            Stack(
                Field("Tickets", "inputs-number-field", new Input
                {
                    Props = new InputProps
                    {
                        Id = "inputs-number-field".ToConstSignal(),
                        Type = "number".ToConstSignal(),
                        Min = "1".ToConstSignal(),
                        Max = "20".ToConstSignal(),
                        Step = "1".ToConstSignal(),
                        Value = quantity,
                        Class = FieldClass.Replace("w-full", "w-28 tabular-nums").ToConstSignal(),
                    },
                    Events = new InputEvents { OnInput = quantity.ToDomEvent() },
                }),
                Result(total)),
        ];
    }
}
