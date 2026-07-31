using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.Todo;

public class TodoDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var nextId = 0;

        TodoItem Create(string text) => new(nextId++, text);

        var todos = new Signal<IList<TodoItem>>(
        [
            Create("Learn Natrix framework"),
            Create("Build awesome WebAssembly apps"),
            Create("Share with the community"),
        ]);

        var draft = new Signal<string>("");

        void AddTodo()
        {
            var text = draft.Value.Trim();
            if (text.Length == 0)
            {
                return;
            }

            todos.Value = [.. todos.Value, Create(text)];
            draft.Value = "";
        }

        void RemoveTodo(int id)
        {
            todos.Value = [.. todos.Value.Where(t => t.Id != id)];
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
                            Props = new TodoInputProps { Draft = draft },
                            Events = new TodoInputEvents { OnSubmit = AddTodo },
                        },
                        new Ul
                        {
                            Props = new UlProps
                            {
                                Class = "space-y-2".ToConstSignal(),
                            },
                            Children =
                            [
                                new ForEach<TodoItem, int>
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
