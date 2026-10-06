using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components;

/// <summary>The docs pages, beside the page from <c>md</c> up. Smaller screens use the docs bar's menu.</summary>
public class Sidebar : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        return
        [
            new Nav
            {
                Props = new NavProps
                {
                    AriaLabel = "Docs".ToConstSignal(),
                    // Sticks under the header, scrolling on its own if it outgrows the screen.
                    Class = "hidden md:block w-56 shrink-0 sticky top-16 h-[calc(100vh-4rem)] overflow-y-auto py-8 pl-4 sm:pl-6 pr-4".ToConstSignal(),
                },
                Children =
                [
                    new NavItems
                    {
                        Props = new NoProps(),
                    },
                ],
            },
        ];
    }
}
