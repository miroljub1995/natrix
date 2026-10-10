using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;
using Natrix.StdWeb;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class CheckboxInputDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class TermsCheckbox : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                var agreed = new Signal<bool>(false);
                var signedUp = new Signal<bool>(false);

                return
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "checkbox".ToConstSignal(),
                            Checked = agreed,
                        },
                        Events = new InputEvents
                        {
                            // A checkbox has no text value to bind: read Checked off the element.
                            OnChange = e =>
                            {
                                if (OperatingSystem.IsBrowser() && e.Target is HTMLInputElement input)
                                {
                                    agreed.Value = input.Checked;
                                    signedUp.Value = false;
                                }
                            },
                        },
                    },
                    new Button
                    {
                        Props = new ButtonProps { Disabled = new Computed<bool>(() => !agreed.Value) },
                        Events = new ButtonEvents { OnClick = _ => signedUp.Value = true },
                        Children = [new DomText { Text = new Computed<string>(
                            () => signedUp.Value ? "Signed up ✓" : "Sign up") }],
                    },
                ];
            }
        }
        """;

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var agreed = new Signal<bool>(false);
        var signedUp = new Signal<bool>(false);

        return
        [
            Stack(
                Choice(
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "checkbox".ToConstSignal(),
                            Checked = agreed,
                            Class = ChoiceClass.ToConstSignal(),
                        },
                        Events = new InputEvents
                        {
                            OnChange = e =>
                            {
                                if (OperatingSystem.IsBrowser() && e.Target is HTMLInputElement input)
                                {
                                    agreed.Value = input.Checked;
                                    signedUp.Value = false;
                                }
                            },
                        },
                    },
                    Text("I agree to the terms")),
                new Div
                {
                    Props = new DivProps(),
                    Children =
                    [
                        new Button
                        {
                            Props = new ButtonProps
                            {
                                Type = "button".ToConstSignal(),
                                Disabled = new Computed<bool>(() => !agreed.Value),
                                Class = ButtonClass.ToConstSignal(),
                            },
                            Events = new ButtonEvents { OnClick = _ => signedUp.Value = true },
                            Children = [new DomText { Text = new Computed<string>(() => signedUp.Value ? "Signed up ✓" : "Sign up") }],
                        },
                    ],
                }),
        ];
    }
}
