using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components;

public class LivePanelProps
{
    /// <summary>What the bar above the demo says, beside the pulsing dot.</summary>
    public required string Label { get; init; }

    /// <summary>A note below the demo; none when <c>null</c>.</summary>
    public string? Caption { get; init; }

    /// <summary>Classes added to the panel, for its place in the parent's layout.</summary>
    public string ExtraClass { get; init; } = "";
}

public class LivePanelSlots
{
    public required Func<IComponent[]> Default { get; init; }
}

/// <summary>
/// The frame a running demo sits in, beside the listing of its code: the home page counter, and
/// every section of the inputs example.
/// </summary>
public class LivePanel : BaseComponent<LivePanelProps, NoEvents, LivePanelSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        IComponent[] caption = Props.Caption is { } text
            ?
            [
                new P
                {
                    Props = new PProps
                    {
                        Class = "border-t border-gray-200 dark:border-gray-800 px-4 py-3 text-xs leading-relaxed text-gray-500 dark:text-gray-400".ToConstSignal(),
                    },
                    Children = [new DomText { Text = text.ToConstSignal() }],
                },
            ]
            : [];

        return
        [
            new Div
            {
                Props = new DivProps
                {
                    Class = $"flex min-w-0 flex-col overflow-hidden rounded-xl border border-gray-200 dark:border-gray-800 bg-gradient-to-b from-gray-50 to-white dark:from-gray-900 dark:to-gray-950 {Props.ExtraClass}".TrimEnd().ToConstSignal(),
                },
                Children =
                [
                    new Div
                    {
                        Props = new DivProps
                        {
                            Class = "flex items-center gap-2 border-b border-gray-200 dark:border-gray-800 px-4 py-3 text-xs font-medium text-gray-500 dark:text-gray-400".ToConstSignal(),
                        },
                        Children =
                        [
                            new Span
                            {
                                Props = new SpanProps
                                {
                                    Class = "relative flex h-2 w-2".ToConstSignal(),
                                },
                                Children =
                                [
                                    new Span
                                    {
                                        Props = new SpanProps
                                        {
                                            Class = "absolute inline-flex h-full w-full animate-ping rounded-full bg-emerald-400 opacity-75".ToConstSignal(),
                                        },
                                    },
                                    new Span
                                    {
                                        Props = new SpanProps
                                        {
                                            Class = "relative inline-flex h-2 w-2 rounded-full bg-emerald-500".ToConstSignal(),
                                        },
                                    },
                                ],
                            },
                            new DomText { Text = Props.Label.ToConstSignal() },
                        ],
                    },
                    new Div
                    {
                        Props = new DivProps
                        {
                            Class = "flex-1".ToConstSignal(),
                        },
                        Children = Slots?.Default() ?? [],
                    },
                    .. caption,
                ],
            },
        ];
    }
}
