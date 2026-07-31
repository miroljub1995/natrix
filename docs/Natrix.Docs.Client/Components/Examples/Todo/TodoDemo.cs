using System.Collections.Immutable;
using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.Todo;

public class TodoDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        TodoItem Create(string text) => new(Guid.NewGuid(), text);

        var todos = new Signal<ImmutableList<TodoItem>>(
        [
            Create("Learn Natrix framework"),
            Create("Build awesome WebAssembly apps"),
            Create("Share with the community"),
        ]);

        void AddTodo(string draftValue)
        {
            var text = draftValue.Trim();
            if (text.Length == 0)
            {
                return;
            }

            todos.Value = todos.Value.Add(Create(text));
        }

        void RemoveTodo(Guid id)
        {
            todos.Value = todos.Value.RemoveAll(t => t.Id == id);
        }

        return
        [
            new DemoCard
            {
                Props = new DemoCardProps
                {
                    Title = "Todo List".ToConstSignal(),
                },
                Slots = new DemoCardSlots
                {
                    Default = () =>
                    [
                        new TodoInput
                        {
                            Props = new TodoInputProps(),
                            Events = new TodoInputEvents
                            {
                                OnSubmit = AddTodo,
                            },
                        },
                        new Ul
                        {
                            Props = new UlProps
                            {
                                Class = "space-y-2".ToConstSignal(),
                            },
                            Children =
                            [
                                new ForEach<TodoItem, Guid>
                                {
                                    Items = todos,
                                    Key = item => item.Id,
                                    ElementSetup = item =>
                                    [
                                        new TodoItemRow
                                        {
                                            Props = new TodoItemRowProps { Item = item },
                                            Events = new TodoItemRowEvents { OnRemove = RemoveTodo },
                                        },
                                    ],
                                },
                                new If
                                {
                                    Condition = new Computed<bool>(() => todos.Value.Count == 0),
                                    Then = () =>
                                    [
                                        new Li
                                        {
                                            Props = new LiProps
                                            {
                                                Class = "rounded-md px-4 py-8 text-center italic text-gray-500 dark:text-gray-400".ToConstSignal(),
                                            },
                                            Children = [new DomText { Text = "No tasks yet. Add one above!".ToConstSignal() }],
                                        },
                                    ],
                                },
                            ],
                        },
                    ],
                },
            },
        ];
    }
}
