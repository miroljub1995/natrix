using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.DataFetching;

public class ErrorBannerProps
{
    public required IReadOnlySignal<string> Message { get; init; }
}

/// <summary>
/// Sits above the content rather than in place of it, so a failed revalidation adds a warning
/// instead of blanking out the last good value.
/// </summary>
public class ErrorBanner : BaseComponent<ErrorBannerProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        return
        [
            new P
            {
                Props = new PProps
                {
                    Class = ("mb-3 rounded-md bg-red-50 px-3 py-2 text-sm text-red-700 "
                        + "dark:bg-red-900/30 dark:text-red-300").ToConstSignal(),
                },
                Children = [new DomText { Text = Props.Message }],
            },
        ];
    }
}
