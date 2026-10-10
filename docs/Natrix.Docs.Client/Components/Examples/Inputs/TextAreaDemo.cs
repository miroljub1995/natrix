using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class TextAreaDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class BioField : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            private const int Limit = 140;

            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                var bio = new Signal<string>("Writes C# for the browser.");
                var words = new Computed<int>(() =>
                    bio.Value.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries).Length);

                return
                [
                    new TextArea
                    {
                        Props = new TextAreaProps
                        {
                            Rows = 4u.ToConstSignal(),
                            MaxLength = Limit.ToConstSignal(),
                            Value = bio,
                        },
                        // The same binding as a text input: ToDomEvent knows both.
                        Events = new TextAreaEvents { OnInput = bio.ToDomEvent() },
                    },
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = new Computed<string>(
                            () => $"{words.Value} words · {Limit - bio.Value.Length} characters left") }],
                    },
                ];
            }
        }
        """;

    private const int Limit = 140;

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var bio = new Signal<string>("Writes C# for the browser.");
        var words = new Computed<int>(() =>
            bio.Value.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries).Length);

        return
        [
            Stack(
                Field("Bio", "inputs-textarea-field", new TextArea
                {
                    Props = new TextAreaProps
                    {
                        Id = "inputs-textarea-field".ToConstSignal(),
                        Rows = 4u.ToConstSignal(),
                        MaxLength = Limit.ToConstSignal(),
                        Value = bio,
                        Class = $"{FieldClass} resize-none".ToConstSignal(),
                    },
                    Events = new TextAreaEvents { OnInput = bio.ToDomEvent() },
                }),
                Result(new Computed<string>(() => $"{words.Value} words · {Limit - bio.Value.Length} characters left"))),
        ];
    }
}
