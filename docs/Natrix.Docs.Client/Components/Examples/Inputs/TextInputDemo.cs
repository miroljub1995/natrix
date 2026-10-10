using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class TextInputDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class NameField : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                var name = new Signal<string>("");
                var greeting = new Computed<string>(() => name.Value.Trim() is { Length: > 0 } trimmed
                    ? $"Hello, {trimmed}!"
                    : "Hello, stranger.");

                return
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "text".ToConstSignal(),
                            Placeholder = "Your name".ToConstSignal(),
                            Value = name,
                        },
                        // Writes every keystroke into the signal.
                        Events = new InputEvents { OnInput = name.ToDomEvent() },
                    },
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = greeting }],
                    },
                ];
            }
        }
        """;

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var name = new Signal<string>("");
        var greeting = new Computed<string>(() => name.Value.Trim() is { Length: > 0 } trimmed
            ? $"Hello, {trimmed}!"
            : "Hello, stranger.");

        return
        [
            Stack(
                Field("Name", "inputs-text-field", new Input
                {
                    Props = new InputProps
                    {
                        Id = "inputs-text-field".ToConstSignal(),
                        Type = "text".ToConstSignal(),
                        Placeholder = "Your name".ToConstSignal(),
                        Value = name,
                        Class = FieldClass.ToConstSignal(),
                    },
                    Events = new InputEvents { OnInput = name.ToDomEvent() },
                }),
                Result(greeting)),
        ];
    }
}
