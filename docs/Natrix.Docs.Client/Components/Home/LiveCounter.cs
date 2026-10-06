using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Home;

/// <summary>
/// The counter from the home page listing, running for real: same signals, same computed, with
/// the styling the listing leaves out.
/// </summary>
public class LiveCounter : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the home page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class Counter : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                // Runs once. From here on, only what reads a signal updates.
                var count = new Signal<int>(0);
                var doubled = new Computed<int>(() => count.Value * 2);

                return
                [
                    new Button
                    {
                        Props = new ButtonProps(),
                        Events = new ButtonEvents { OnClick = _ => count.Value++ },
                        Children = [new DomText { Text = "Click me".ToConstSignal() }],
                    },
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = new Computed<string>(
                            () => $"{count.Value} × 2 = {doubled.Value}") }],
                    },
                ];
            }
        }
        """;

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var count = new Signal<int>(0);
        var doubled = new Computed<int>(() => count.Value * 2);

        return
        [
            new Div
            {
                Props = new DivProps
                {
                    Class = "flex h-full flex-col items-center justify-center gap-6 px-6 py-10 text-center".ToConstSignal(),
                },
                Children =
                [
                    new Div
                    {
                        Props = new DivProps
                        {
                            Class = "font-mono text-6xl font-bold tabular-nums tracking-tight text-gray-900 dark:text-white".ToConstSignal(),
                        },
                        Children = [new DomText { Text = new Computed<string>(() => count.Value.ToString()) }],
                    },
                    new P
                    {
                        Props = new PProps
                        {
                            Class = "font-mono text-sm text-gray-500 dark:text-gray-400".ToConstSignal(),
                        },
                        Children = [new DomText { Text = new Computed<string>(() => $"{count.Value} × 2 = {doubled.Value}") }],
                    },
                    new Div
                    {
                        Props = new DivProps
                        {
                            Class = "flex items-center gap-3".ToConstSignal(),
                        },
                        Children =
                        [
                            new Button
                            {
                                Props = new ButtonProps
                                {
                                    Class = "rounded-lg bg-indigo-600 px-6 py-2.5 font-semibold text-white shadow-lg shadow-indigo-600/25 hover:bg-indigo-500 active:scale-95 transition".ToConstSignal(),
                                },
                                Events = new ButtonEvents { OnClick = _ => count.Value++ },
                                Children = [new DomText { Text = "Click me".ToConstSignal() }],
                            },
                            new Button
                            {
                                Props = new ButtonProps
                                {
                                    Class = "rounded-lg px-4 py-2.5 text-sm font-medium text-gray-500 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white transition-colors".ToConstSignal(),
                                },
                                Events = new ButtonEvents { OnClick = _ => count.Value = 0 },
                                Children = [new DomText { Text = "Reset".ToConstSignal() }],
                            },
                        ],
                    },
                ],
            },
        ];
    }
}
