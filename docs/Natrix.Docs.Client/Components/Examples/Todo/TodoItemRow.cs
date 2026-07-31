using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.Todo;

public class TodoItemRowProps
{
    public required IReadOnlySignal<TodoItem> Item { get; init; }
}

[GeneratedEvents]
public partial class TodoItemRowEvents
{
    public partial void Remove(Guid id);
}

/// <summary>
/// A single row of the todo list. Reads the item reactively so that
/// <see cref="ForEach{TElement,TKey}"/> can reuse the row when only the value changes.
/// </summary>
public class TodoItemRow : BaseComponent<TodoItemRowProps, TodoItemRowEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        return
        [
            new Li
            {
                Props = new LiProps
                {
                    Class = "flex items-center justify-between gap-4 rounded-md bg-gray-50 dark:bg-gray-800 px-4 py-3".ToConstSignal(),
                },
                Children =
                [
                    new Span
                    {
                        Props = new SpanProps
                        {
                            Class = "flex-1 min-w-0 break-words text-gray-900 dark:text-gray-100".ToConstSignal(),
                        },
                        Children = [new DomText { Text = new Computed<string>(() => Props.Item.Value.Text) }],
                    },
                    new DemoButton
                    {
                        Props = new DemoButtonProps
                        {
                            Label = "Remove".ToConstSignal(),
                            Variant = DemoButtonVariant.Secondary.ToConstSignal(),
                            Title = "Remove task".ToConstSignal(),
                            ExtraClass = "shrink-0".ToConstSignal(),
                        },
                        Events = new DemoButtonEvents
                        {
                            OnClick = () => Events?.Remove(Props.Item.Value.Id),
                        },
                    },
                ],
            },
        ];
    }
}
