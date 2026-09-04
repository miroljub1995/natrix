using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.DataFetching;

public class CardHeadingProps
{
    public required IReadOnlySignal<string> Label { get; init; }

    /// <summary>
    /// Which of the resource's states the card is in: <c>loading</c>, <c>revalidating</c>,
    /// <c>error</c> or <c>ready</c>.
    /// </summary>
    public required IReadOnlySignal<string> Status { get; init; }
}

/// <summary>
/// A card's title with its status badge. Owns the mapping from status to colour so the card
/// itself is left describing what to show rather than how to paint it.
/// </summary>
public class CardHeading : BaseComponent<CardHeadingProps, NoEvents, NoSlots, NoExpose>
{
    private const string BadgeClass = "rounded-full px-2 py-0.5 text-xs font-medium";

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var badgeClass = new Computed<string>(() => Props.Status.Value switch
        {
            "loading" or "revalidating" =>
                $"{BadgeClass} bg-amber-100 text-amber-800 dark:bg-amber-900/40 dark:text-amber-300",
            "error" =>
                $"{BadgeClass} bg-red-100 text-red-800 dark:bg-red-900/40 dark:text-red-300",
            _ =>
                $"{BadgeClass} bg-emerald-100 text-emerald-800 dark:bg-emerald-900/40 dark:text-emerald-300",
        });

        return
        [
            new Div
            {
                Props = new DivProps
                {
                    Class = "mb-3 flex items-center justify-between gap-2".ToConstSignal(),
                },
                Children =
                [
                    new Span
                    {
                        Props = new SpanProps
                        {
                            Class = "text-sm font-semibold text-gray-500 dark:text-gray-400".ToConstSignal(),
                        },
                        Children = [new DomText { Text = Props.Label }],
                    },
                    new Span
                    {
                        Props = new SpanProps { Class = badgeClass },
                        Children = [new DomText { Text = Props.Status }],
                    },
                ],
            },
        ];
    }
}
