using System.Runtime.InteropServices.JavaScript;
using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.JSCore;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Docs.Client.Components;

public class CodeBlockProps
{
    public required IReadOnlySignal<string> Code { get; init; }
    public IReadOnlySignal<string>? Title { get; init; }
}

public class CodeBlock : BaseComponent<CodeBlockProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        return
        [
            new Div
            {
                Props = new DivProps
                {
                    Class = "relative my-4 rounded-lg border border-gray-200 dark:border-gray-700 bg-gray-50 dark:bg-gray-900".ToConstSignal(),
                },
                Children =
                [
                    new Div
                    {
                        Props = new DivProps
                        {
                            Class = "flex items-center justify-between gap-4 border-b border-gray-200 dark:border-gray-700 px-4 py-2".ToConstSignal(),
                        },
                        Children =
                        [
                            new Span
                            {
                                Props = new SpanProps
                                {
                                    Class = "text-xs font-medium text-gray-500 dark:text-gray-400".ToConstSignal(),
                                },
                                Children = [new DomText { Text = Props.Title ?? "".ToConstSignal() }],
                            },
                            new Button
                            {
                                Props = new ButtonProps
                                {
                                    Class = "shrink-0 inline-flex items-center justify-center w-8 h-8 rounded-md border border-gray-300 dark:border-gray-600 text-gray-600 dark:text-gray-300 hover:text-indigo-600 dark:hover:text-indigo-400 hover:border-indigo-400 transition-colors".ToConstSignal(),
                                    Title = "Copy code".ToConstSignal(),
                                },
                                Events = new ButtonEvents
                                {
                                    OnClick = (_) =>
                                    {
                                        if (!OperatingSystem.IsBrowser())
                                        {
                                            return;
                                        }

                                        var window = JSObjectProxyFactory.GetProxy<Window>(JSHost.GlobalThis);
                                        window.Navigator.Clipboard.WriteText(Props.Code.Value);
                                    },
                                },
                                Children =
                                [
                                    new Span
                                    {
                                        Props = new SpanProps
                                        {
                                            Class = "relative inline-block w-4 h-4".ToConstSignal(),
                                        },
                                        Children =
                                        [
                                            new Span
                                            {
                                                Props = new SpanProps
                                                {
                                                    Class = "absolute top-0 left-0 w-3 h-3 rounded border border-current".ToConstSignal(),
                                                },
                                            },
                                            new Span
                                            {
                                                Props = new SpanProps
                                                {
                                                    Class = "absolute bottom-0 right-0 w-3 h-3 rounded border border-current".ToConstSignal(),
                                                },
                                            },
                                        ],
                                    },
                                ],
                            },
                        ],
                    },
                    new Pre
                    {
                        Props = new PreProps
                        {
                            Class = "overflow-x-auto px-4 py-3 text-sm leading-relaxed".ToConstSignal(),
                        },
                        Children =
                        [
                            new Code
                            {
                                Props = new CodeProps
                                {
                                    Class = "text-gray-900 dark:text-gray-100 whitespace-pre".ToConstSignal(),
                                },
                                Children = [new DomText { Text = Props.Code }],
                            },
                        ],
                    },
                ],
            },
        ];
    }
}
