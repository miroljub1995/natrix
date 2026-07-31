using Natrix.Core.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.Todo;

public class TodoExamplePage : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
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
                    Title = "Todo List".ToConstSignal(),
                    Id = "todo-example".ToConstSignal(),
                    Description = "An interactive todo list split into small reusable components. It shows reactive state with Signal, keyed list rendering with ForEach, conditional rendering with If, and how a child component reports back through generated events.".ToConstSignal(),
                    GitHubUrl = "https://github.com/miroljub1995/natrix/tree/main/docs/Natrix.Docs.Client/Components/Examples/Todo".ToConstSignal(),
                },
                Slots = new ExamplePageSlots
                {
                    Demo = () => [new TodoDemo { Props = new NoProps() }],
                },
            },
        ];
    }
}
