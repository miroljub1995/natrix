using System.Globalization;
using Natrix.Core.Components;
using Natrix.Signals;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class DateInputDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class DateField : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                // Always "yyyy-MM-dd", whatever the browser shows, or "" while incomplete.
                var date = new Signal<string>("2026-07-04");
                var summary = new Computed<string>(() => Describe(date.Value));

                return
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "date".ToConstSignal(),
                            Value = date,
                        },
                        Events = new InputEvents { OnInput = date.ToDomEvent() },
                    },
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = summary }],
                    },
                ];
            }

            private static string Describe(string value) =>
                DateOnly.TryParse(value, CultureInfo.InvariantCulture, out var date)
                    ? $"{date.ToString("dddd, MMMM d", CultureInfo.InvariantCulture)} · day {date.DayOfYear} of {date.Year}"
                    : "Pick a date";
        }
        """;

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var date = new Signal<string>("2026-07-04");
        var summary = new Computed<string>(() => Describe(date.Value));

        return [BoundField("date", "Date", date, summary)];
    }

    private static string Describe(string value) =>
        DateOnly.TryParse(value, CultureInfo.InvariantCulture, out var date)
            ? $"{date.ToString("dddd, MMMM d", CultureInfo.InvariantCulture)} · day {date.DayOfYear} of {date.Year}"
            : "Pick a date";
}
