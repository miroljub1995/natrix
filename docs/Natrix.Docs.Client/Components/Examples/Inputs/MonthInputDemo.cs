using System.Globalization;
using Natrix.Core.Components;
using Natrix.Signals;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class MonthInputDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class MonthField : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                // "yyyy-MM": a month with no day.
                var month = new Signal<string>("2026-02");
                var summary = new Computed<string>(() => Describe(month.Value));

                return
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "month".ToConstSignal(),
                            Value = month,
                        },
                        Events = new InputEvents { OnInput = month.ToDomEvent() },
                    },
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = summary }],
                    },
                ];
            }

            private static string Describe(string value) =>
                DateOnly.TryParse($"{value}-01", CultureInfo.InvariantCulture, out var first)
                    ? $"{first.ToString("MMMM yyyy", CultureInfo.InvariantCulture)} · {DateTime.DaysInMonth(first.Year, first.Month)} days, starts on a {first.DayOfWeek}"
                    : "Pick a month";
        }
        """;

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var month = new Signal<string>("2026-02");
        var summary = new Computed<string>(() => Describe(month.Value));

        return [BoundField("month", "Month", month, summary)];
    }

    private static string Describe(string value) =>
        DateOnly.TryParse($"{value}-01", CultureInfo.InvariantCulture, out var first)
            ? $"{first.ToString("MMMM yyyy", CultureInfo.InvariantCulture)} · {DateTime.DaysInMonth(first.Year, first.Month)} days, starts on a {first.DayOfWeek}"
            : "Pick a month";
}
