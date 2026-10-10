using System.Globalization;
using Natrix.Core.Components;
using Natrix.Signals;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class DateTimeLocalInputDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class MeetingField : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                // "yyyy-MM-ddTHH:mm", with no time zone: it means the time on the reader's clock.
                var start = new Signal<string>("2026-12-31T23:30");
                var summary = new Computed<string>(() => Describe(start.Value));

                return
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "datetime-local".ToConstSignal(),
                            Value = start,
                        },
                        Events = new InputEvents { OnInput = start.ToDomEvent() },
                    },
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = summary }],
                    },
                ];
            }

            private static string Describe(string value) =>
                DateTime.TryParse(value, CultureInfo.InvariantCulture, out var start)
                    ? $"{start.ToString("ddd, MMM d, yyyy 'at' HH:mm", CultureInfo.InvariantCulture)} → ends {start.AddMinutes(45).ToString("ddd HH:mm", CultureInfo.InvariantCulture)}"
                    : "Pick a date and time";
        }
        """;

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var start = new Signal<string>("2026-12-31T23:30");
        var summary = new Computed<string>(() => Describe(start.Value));

        return [BoundField("datetime-local", "Meeting starts", start, summary)];
    }

    private static string Describe(string value) =>
        DateTime.TryParse(value, CultureInfo.InvariantCulture, out var start)
            ? $"{start.ToString("ddd, MMM d, yyyy 'at' HH:mm", CultureInfo.InvariantCulture)} → ends {start.AddMinutes(45).ToString("ddd HH:mm", CultureInfo.InvariantCulture)}"
            : "Pick a date and time";
}
