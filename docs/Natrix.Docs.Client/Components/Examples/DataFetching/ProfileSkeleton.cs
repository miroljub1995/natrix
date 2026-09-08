using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.DataFetching;

/// <summary>
/// Placeholder shown while a key that has never resolved is loading.
/// </summary>
public class ProfileSkeleton : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    private const string LineClass = "animate-pulse rounded bg-gray-200 dark:bg-gray-700";

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        return
        [
            new Div
            {
                Props = new DivProps { Class = "space-y-2".ToConstSignal() },
                Children =
                [
                    new Div { Props = new DivProps { Class = $"h-5 w-40 {LineClass}".ToConstSignal() } },
                    new Div { Props = new DivProps { Class = $"h-4 w-28 {LineClass}".ToConstSignal() } },
                ],
            },
        ];
    }
}
