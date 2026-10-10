using System.Globalization;
using Natrix.Core.Components;
using Natrix.Signals;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class TimeInputDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class TimeField : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                // Always 24-hour "HH:mm", even where the browser shows AM and PM.
                var time = new Signal<string>("09:30");
                var summary = new Computed<string>(() => Describe(time.Value));

                return
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "time".ToConstSignal(),
                            Value = time,
                        },
                        Events = new InputEvents { OnInput = time.ToDomEvent() },
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
                if (!TimeOnly.TryParse(value, CultureInfo.InvariantCulture, out var time))
                {
                    return "Pick a time";
                }

                var left = TimeSpan.FromDays(1) - time.ToTimeSpan();
                return $"{time.ToString("h:mm tt", CultureInfo.InvariantCulture)} · {left.Hours}h {left.Minutes}m before midnight";
            }
        }
        """;

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var time = new Signal<string>("09:30");
        var summary = new Computed<string>(() => Describe(time.Value));

        return [BoundField("time", "Alarm", time, summary)];
    }

    private static string Describe(string value)
    {
        if (!TimeOnly.TryParse(value, CultureInfo.InvariantCulture, out var time))
        {
            return "Pick a time";
        }

        var left = TimeSpan.FromDays(1) - time.ToTimeSpan();
        return $"{time.ToString("h:mm tt", CultureInfo.InvariantCulture)} · {left.Hours}h {left.Minutes}m before midnight";
    }
}
