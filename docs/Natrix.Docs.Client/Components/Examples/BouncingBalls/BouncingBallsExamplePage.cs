using Natrix.Core.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.BouncingBalls;

public class BouncingBallsExamplePage : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        return
        [
            new ExamplePage
            {
                Props = new ExamplePageProps
                {
                    Title = "Canvas".ToConstSignal(),
                    Id = "canvas-example".ToConstSignal(),
                    Description = "A bouncing balls animation showing how to reach the raw Canvas API through a component Ref, and how to drive requestAnimationFrame from OnMounted while cleaning it up on unmount. The simulation lives in a plain class so it stays testable and platform independent.".ToConstSignal(),
                    GitHubUrl = "https://github.com/miroljub1995/natrix/tree/main/docs/Natrix.Docs.Client/Components/Examples/BouncingBalls".ToConstSignal(),
                },
                Slots = new ExamplePageSlots
                {
                    Demo = () => [new BouncingBallsDemo { Props = new NoProps() }],
                },
            },
        ];
    }
}
