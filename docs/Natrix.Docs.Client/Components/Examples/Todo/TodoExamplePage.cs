using Natrix.Core.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.Todo;

public class TodoExamplePage : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    private const string ItemSource = """
        public sealed record TodoItem(int Id, string Text);
        """;

    private const string RowSource = """
        public class TodoItemRowProps
        {
            public required IReadOnlySignal<TodoItem> Item { get; init; }
        }

        [GeneratedEvents]
        public partial class TodoItemRowEvents
        {
            public partial void Remove(int id);
        }

        public class TodoItemRow : BaseComponent<TodoItemRowProps, TodoItemRowEvents, NoSlots, NoExpose>
        {
            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                return
                [
                    new Li
                    {
                        Props = new LiProps(),
                        Children =
                        [
                            new Span
                            {
                                Props = new SpanProps(),
                                Children =
                                [
                                    new DomText
                                    {
                                        Text = new Computed<string>(() => Props.Item.Value.Text),
                                    },
                                ],
                            },
                            new Button
                            {
                                Props = new ButtonProps(),
                                Events = new ButtonEvents
                                {
                                    OnClick = _ => Events?.Remove(Props.Item.Value.Id),
                                },
                                Children = [new DomText { Text = "Remove".ToConstSignal() }],
                            },
                        ],
                    },
                ];
            }
        }
        """;

    private const string InputSource = """
        public class TodoInputProps
        {
            public required Signal<string> Draft { get; init; }
        }

        [GeneratedEvents]
        public partial class TodoInputEvents
        {
            public partial void Submit();
        }

        public class TodoInput : BaseComponent<TodoInputProps, TodoInputEvents, NoSlots, NoExpose>
        {
            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                return
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "text".ToConstSignal(),
                            Value = Props.Draft,
                        },
                        Events = new InputEvents
                        {
                            OnInput = e =>
                            {
                                if (e.Target is HTMLInputElement input) Props.Draft.Value = input.Value;
                            },
                            OnKeyDown = e =>
                            {
                                if (e.Key == "Enter") Events?.Submit();
                            },
                        },
                    },
                    new Button
                    {
                        Props = new ButtonProps(),
                        Events = new ButtonEvents { OnClick = _ => Events?.Submit() },
                        Children = [new DomText { Text = "Add".ToConstSignal() }],
                    },
                ];
            }
        }
        """;

    private const string DemoSource = """
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
                    if (text.Length == 0) return;

                    todos.Value = [.. todos.Value, Create(text)];
                    draft.Value = "";
                }

                void RemoveTodo(int id) => todos.Value = [.. todos.Value.Where(t => t.Id != id)];

                return
                [
                    new TodoInput
                    {
                        Props = new TodoInputProps { Draft = draft },
                        Events = new TodoInputEvents { OnSubmit = AddTodo },
                    },
                    new Ul
                    {
                        Props = new UlProps(),
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
                                        Props = new LiProps(),
                                        Children =
                                        [
                                            new DomText
                                            {
                                                Text = "No tasks yet. Add one above!".ToConstSignal(),
                                            },
                                        ],
                                    },
                                ],
                            },
                        ],
                    },
                ];
            }
        }
        """;

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
                },
                Slots = new ExamplePageSlots
                {
                    Demo = () => [new TodoDemo { Props = new NoProps() }],
                    Source = () =>
                    [
                        new CodeBlock
                        {
                            Props = new CodeBlockProps
                            {
                                Title = "TodoItem.cs".ToConstSignal(),
                                Code = ItemSource.ToConstSignal(),
                            },
                        },
                        new CodeBlock
                        {
                            Props = new CodeBlockProps
                            {
                                Title = "TodoItemRow.cs".ToConstSignal(),
                                Code = RowSource.ToConstSignal(),
                            },
                        },
                        new CodeBlock
                        {
                            Props = new CodeBlockProps
                            {
                                Title = "TodoInput.cs".ToConstSignal(),
                                Code = InputSource.ToConstSignal(),
                            },
                        },
                        new CodeBlock
                        {
                            Props = new CodeBlockProps
                            {
                                Title = "TodoDemo.cs".ToConstSignal(),
                                Code = DemoSource.ToConstSignal(),
                            },
                        },
                    ],
                },
            },
        ];
    }
}
