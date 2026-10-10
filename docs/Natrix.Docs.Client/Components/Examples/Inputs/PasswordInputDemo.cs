using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class PasswordInputDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class PasswordField : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                var password = new Signal<string>("");
                var visible = new Signal<bool>(false);
                var strength = new Computed<string>(() => Score(password.Value) switch
                {
                    0 => "Empty",
                    1 => "Weak",
                    2 => "Fair",
                    3 => "Good",
                    _ => "Strong",
                });

                return
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            // Swapping the type shows or hides what was typed.
                            Type = new Computed<string>(() => visible.Value ? "text" : "password"),
                            Value = password,
                        },
                        Events = new InputEvents { OnInput = password.ToDomEvent() },
                    },
                    new Button
                    {
                        Props = new ButtonProps(),
                        Events = new ButtonEvents { OnClick = _ => visible.Value = !visible.Value },
                        Children = [new DomText { Text = new Computed<string>(
                            () => visible.Value ? "Hide" : "Show") }],
                    },
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = strength }],
                    },
                ];
            }

            // One point for being long enough, and one each for a capital, a digit and a symbol.
            private static int Score(string value) => value.Length == 0 ? 0 :
                1 + (value.Length >= 8 && value.Any(char.IsUpper) ? 1 : 0)
                  + (value.Any(char.IsDigit) ? 1 : 0)
                  + (value.Any(c => !char.IsLetterOrDigit(c)) ? 1 : 0);
        }
        """;

    private static readonly string[] BarClasses =
    [
        "w-0",
        "w-1/4 bg-red-500",
        "w-2/4 bg-amber-500",
        "w-3/4 bg-lime-500",
        "w-full bg-emerald-500",
    ];

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var password = new Signal<string>("");
        var visible = new Signal<bool>(false);
        var score = new Computed<int>(() => Score(password.Value));
        var strength = new Computed<string>(() => score.Value switch
        {
            0 => "Empty",
            1 => "Weak",
            2 => "Fair",
            3 => "Good",
            _ => "Strong",
        });

        return
        [
            Stack(
                Field("Password", "inputs-password-field", new Div
                {
                    Props = new DivProps
                    {
                        Class = "flex gap-2".ToConstSignal(),
                    },
                    Children =
                    [
                        new Input
                        {
                            Props = new InputProps
                            {
                                Id = "inputs-password-field".ToConstSignal(),
                                Type = new Computed<string>(() => visible.Value ? "text" : "password"),
                                Value = password,
                                Autocomplete = "new-password".ToConstSignal(),
                                Class = FieldClass.ToConstSignal(),
                            },
                            Events = new InputEvents { OnInput = password.ToDomEvent() },
                        },
                        new Button
                        {
                            Props = new ButtonProps
                            {
                                Type = "button".ToConstSignal(),
                                Class = "w-16 shrink-0 rounded-md border border-gray-300 dark:border-gray-600 px-3 text-sm font-medium text-gray-700 dark:text-gray-300 hover:border-indigo-400 hover:text-indigo-600 dark:hover:text-indigo-400 transition-colors".ToConstSignal(),
                            },
                            Events = new ButtonEvents { OnClick = _ => visible.Value = !visible.Value },
                            Children = [new DomText { Text = new Computed<string>(() => visible.Value ? "Hide" : "Show") }],
                        },
                    ],
                }),
                new Div
                {
                    Props = new DivProps
                    {
                        Class = "h-1.5 overflow-hidden rounded-full bg-gray-200 dark:bg-gray-800".ToConstSignal(),
                    },
                    Children =
                    [
                        new Div
                        {
                            Props = new DivProps
                            {
                                Class = new Computed<string>(() => $"h-full rounded-full transition-all {BarClasses[score.Value]}"),
                            },
                        },
                    ],
                },
                Result(strength),
                Hint("Try a capital, a digit and a symbol.".ToConstSignal())),
        ];
    }

    private static int Score(string value) => value.Length == 0 ? 0 :
        1 + (value.Length >= 8 && value.Any(char.IsUpper) ? 1 : 0)
          + (value.Any(char.IsDigit) ? 1 : 0)
          + (value.Any(c => !char.IsLetterOrDigit(c)) ? 1 : 0);
}
