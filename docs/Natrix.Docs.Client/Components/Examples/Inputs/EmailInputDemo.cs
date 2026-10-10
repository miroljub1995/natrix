using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;
using Natrix.StdWeb;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class EmailInputDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class EmailField : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                var email = new Signal<string>("");
                var error = new Signal<string>("");
                var status = new Computed<string>(() =>
                    email.Value.Length == 0 ? "Waiting for an address"
                    : error.Value.Length == 0 ? $"✓ {email.Value}"
                    : $"✗ {error.Value}");

                return
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "email".ToConstSignal(),
                            Placeholder = "you@example.com".ToConstSignal(),
                            Value = email,
                        },
                        Events = new InputEvents
                        {
                            OnInput = e =>
                            {
                                if (OperatingSystem.IsBrowser() && e.Target is HTMLInputElement input)
                                {
                                    email.Value = input.Value;
                                    // The browser checks the address; its message says what's wrong.
                                    error.Value = input.ValidationMessage;
                                }
                            },
                        },
                    },
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = status }],
                    },
                ];
            }
        }
        """;

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var email = new Signal<string>("");
        var error = new Signal<string>("");
        var status = new Computed<string>(() =>
            email.Value.Length == 0 ? "Waiting for an address"
            : error.Value.Length == 0 ? $"✓ {email.Value}"
            : $"✗ {error.Value}");

        return
        [
            Stack(
                Field("Email", "inputs-email-field", new Input
                {
                    Props = new InputProps
                    {
                        Id = "inputs-email-field".ToConstSignal(),
                        Type = "email".ToConstSignal(),
                        Placeholder = "you@example.com".ToConstSignal(),
                        Value = email,
                        Class = new Computed<string>(() => error.Value.Length == 0
                            ? FieldClass
                            : $"{FieldClass} border-red-400 dark:border-red-500"),
                    },
                    Events = new InputEvents
                    {
                        OnInput = e =>
                        {
                            if (OperatingSystem.IsBrowser() && e.Target is HTMLInputElement input)
                            {
                                email.Value = input.Value;
                                error.Value = input.ValidationMessage;
                            }
                        },
                    },
                }),
                Result(status)),
        ];
    }
}
