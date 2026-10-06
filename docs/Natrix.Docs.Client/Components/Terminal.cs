using System.Runtime.InteropServices.JavaScript;
using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.JSCore;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Docs.Client.Components;

public class TerminalProps
{
    /// <summary>One shell command per line. Lines starting with <c>#</c> are shown as comments.</summary>
    public required string[] Lines { get; init; }
}

/// <summary>
/// Shell commands in a dark terminal panel, with a button that copies them - without the
/// comments and the prompt - ready to paste.
/// </summary>
public class Terminal : BaseComponent<TerminalProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var commands = string.Join('\n', Props.Lines.Where(line => !line.StartsWith('#')));
        var copied = new Signal<bool>(false);

        return
        [
            new Div
            {
                Props = new DivProps
                {
                    Class = "flex items-start overflow-hidden rounded-xl border border-gray-800 bg-gray-950 ring-1 ring-white/5".ToConstSignal(),
                },
                Children =
                [
                    new Pre
                    {
                        Props = new PreProps
                        {
                            Class = "min-w-0 flex-1 overflow-x-auto py-3.5 pl-4 pr-2 font-mono text-[13px] leading-relaxed".ToConstSignal(),
                        },
                        Children =
                        [
                            new Code
                            {
                                Props = new CodeProps(),
                                Children = [.. Props.Lines.Select(Line)],
                            },
                        ],
                    },
                    new Button
                    {
                        Props = new ButtonProps
                        {
                            Title = "Copy to clipboard".ToConstSignal(),
                            Class = "m-2 shrink-0 rounded-md px-2.5 py-1 font-sans text-xs font-medium text-gray-400 hover:bg-white/10 hover:text-white transition-colors".ToConstSignal(),
                        },
                        Events = new ButtonEvents
                        {
                            OnClick = async _ =>
                            {
                                if (!OperatingSystem.IsBrowser())
                                {
                                    return;
                                }

                                var window = JSObjectProxyFactory.GetProxy<Window>(JSHost.GlobalThis);
                                try
                                {
                                    await window.Navigator.Clipboard.WriteText(commands);
                                }
                                catch (JSException)
                                {
                                    // Clipboard access denied; there is nothing to confirm.
                                    return;
                                }

                                copied.Value = true;
                                await Task.Delay(2000);
                                copied.Value = false;
                            },
                        },
                        Children = [new DomText { Text = new Computed<string>(() => copied.Value ? "Copied" : "Copy") }],
                    },
                ],
            },
        ];
    }

    private static Span Line(string line) => new()
    {
        Props = new SpanProps
        {
            Class = "block whitespace-pre".ToConstSignal(),
        },
        Children = line.StartsWith('#')
            ? [new Span { Props = new SpanProps { Class = "text-gray-500".ToConstSignal() }, Children = [Text(line)] }]
            :
            [
                new Span { Props = new SpanProps { Class = "select-none text-emerald-400".ToConstSignal() }, Children = [Text("$ ")] },
                new Span { Props = new SpanProps { Class = "text-gray-100".ToConstSignal() }, Children = [Text(line)] },
            ],
    };

    private static DomText Text(string text) => new() { Text = text.ToConstSignal() };
}
