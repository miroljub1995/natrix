using System.Globalization;
using Natrix.Core.Components;
using Natrix.Signals;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class WeekInputDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class WeekField : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                // "yyyy-Www", an ISO 8601 week, which .NET's ISOWeek understands.
                var week = new Signal<string>("2026-W27");
                var summary = new Computed<string>(() => Describe(week.Value));

                return
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "week".ToConstSignal(),
                            Value = week,
                        },
                        Events = new InputEvents { OnInput = week.ToDomEvent() },
                    },
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = summary }],
                    },
                ];
            }

            private static string Describe(string value)
            {
                var parts = value.Split("-W");
                if (parts.Length != 2 || !int.TryParse(parts[0], out var year) || !int.TryParse(parts[1], out var week)
                    || week < 1 || week > ISOWeek.GetWeeksInYear(year))
                {
                    return "Pick a week";
                }

                var monday = DateOnly.FromDateTime(ISOWeek.ToDateTime(year, week, DayOfWeek.Monday));
                return $"Week {week}: {monday.ToString("ddd MMM d", CultureInfo.InvariantCulture)} – {monday.AddDays(6).ToString("ddd MMM d, yyyy", CultureInfo.InvariantCulture)}";
            }
        }
        """;

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var week = new Signal<string>("2026-W27");
        var summary = new Computed<string>(() => Describe(week.Value));

        return [BoundField("week", "Week", week, summary)];
    }

    private static string Describe(string value)
    {
        var parts = value.Split("-W");
        if (parts.Length != 2 || !int.TryParse(parts[0], out var year) || !int.TryParse(parts[1], out var week)
            || week < 1 || week > ISOWeek.GetWeeksInYear(year))
        {
            return "Pick a week";
        }

        var monday = DateOnly.FromDateTime(ISOWeek.ToDateTime(year, week, DayOfWeek.Monday));
        return $"Week {week}: {monday.ToString("ddd MMM d", CultureInfo.InvariantCulture)} – {monday.AddDays(6).ToString("ddd MMM d, yyyy", CultureInfo.InvariantCulture)}";
    }
}
