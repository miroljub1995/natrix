using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class TelInputDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class PhoneField : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                var phone = new Signal<string>("");

                return
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "tel".ToConstSignal(),
                            Placeholder = "(555) 123-4567".ToConstSignal(),
                            Value = phone,
                        },
                        Events = new InputEvents { OnInput = phone.ToDomEvent() },
                    },
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = new Computed<string>(() => Format(phone.Value)) }],
                    },
                ];
            }

            // Plain C#. The Computed above calls it again whenever phone changes.
            private static string Format(string value)
            {
                var digits = new string([.. value.Where(char.IsDigit)]);
                return digits.Length == 10
                    ? $"({digits[..3]}) {digits[3..6]}-{digits[6..]}"
                    : $"{digits.Length} of 10 digits";
            }
        }
        """;

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var phone = new Signal<string>("");

        return
        [
            Stack(
                Field("Phone", "inputs-tel-field", new Input
                {
                    Props = new InputProps
                    {
                        Id = "inputs-tel-field".ToConstSignal(),
                        Type = "tel".ToConstSignal(),
                        Placeholder = "(555) 123-4567".ToConstSignal(),
                        Value = phone,
                        Class = FieldClass.ToConstSignal(),
                    },
                    Events = new InputEvents { OnInput = phone.ToDomEvent() },
                }),
                Result(new Computed<string>(() => Format(phone.Value))),
                Hint("On a phone, this field opens the dial pad.".ToConstSignal())),
        ];
    }

    private static string Format(string value)
    {
        var digits = new string([.. value.Where(char.IsDigit)]);
        return digits.Length == 10
            ? $"({digits[..3]}) {digits[3..6]}-{digits[6..]}"
            : $"{digits.Length} of 10 digits";
    }
}
