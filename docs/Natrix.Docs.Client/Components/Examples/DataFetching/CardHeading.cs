using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.DataFetching;

public class CardHeadingProps
{
    public required IReadOnlySignal<string> Label { get; init; }

    /// <summary>
    /// The resource's raw <c>IsLoading</c> and <c>IsValidating</c>, shown as their own flags so
    /// the difference between them can be watched directly.
    /// </summary>
    public required IReadOnlySignal<bool> IsLoading { get; init; }

    public required IReadOnlySignal<bool> IsValidating { get; init; }
}

/// <summary>
/// A card's title with the resource's two flags. Owns how a flag is painted so the card itself is
/// left describing what to show rather than how to paint it.
/// </summary>
public class CardHeading : BaseComponent<CardHeadingProps, NoEvents, NoSlots, NoExpose>
{
    // Whole class lists as plain literals: the Tailwind generator collects candidates from string
    // literals only, so a name that exists just inside an interpolated string gets no CSS.
    //
    // A fixed width in ch, sized to the longer "IsValidating=False", keeps a flag from shifting its
    // neighbours when its value flips; the border is always drawn and only its colour changes, so
    // it never costs a pixel either.
    private const string FlagOnClass =
        "inline-block w-[21ch] rounded-md border px-2 py-0.5 text-center font-mono text-xs border-emerald-500 text-emerald-700 dark:text-emerald-300";

    private const string FlagOffClass =
        "inline-block w-[21ch] rounded-md border px-2 py-0.5 text-center font-mono text-xs border-transparent text-gray-400 dark:text-gray-500";

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        // A flag spells out its value, and shows a green border while true, so a glance shows
        // which of the two a request is currently counted under.
        static Span Flag(string name, IReadOnlySignal<bool> value) => new()
        {
            Props = new SpanProps
            {
                Class = new Computed<string>(() => value.Value ? FlagOnClass : FlagOffClass),
            },
            Children =
            [
                new DomText
                {
                    Text = new Computed<string>(() => $"{name}={(value.Value ? "True" : "False")}"),
                },
            ],
        };

        return
        [
            new Div
            {
                Props = new DivProps
                {
                    Class = "mb-3 flex flex-wrap items-center gap-2".ToConstSignal(),
                },
                Children =
                [
                    new Span
                    {
                        Props = new SpanProps
                        {
                            Class = "mr-auto text-sm font-semibold text-gray-500 dark:text-gray-400".ToConstSignal(),
                        },
                        Children = [new DomText { Text = Props.Label }],
                    },
                    Flag("IsLoading", Props.IsLoading),
                    Flag("IsValidating", Props.IsValidating),
                ],
            },
        ];
    }
}
