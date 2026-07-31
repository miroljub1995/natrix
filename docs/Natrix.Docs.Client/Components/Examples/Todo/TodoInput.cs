using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Docs.Client.Components.Examples.Todo;

public class TodoInputProps
{
    public IReadOnlySignal<string> Placeholder { get; init; } = "Enter a new task...".ToConstSignal();
}

[GeneratedEvents]
public partial class TodoInputEvents
{
    public partial void Submit(string value);
}

/// <summary>
/// Text field plus Add button wrapped in a form so Enter submits natively.
/// </summary>
public class TodoInput : BaseComponent<TodoInputProps, TodoInputEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var draft = new Signal<string>("");

        return
        [
            new Form
            {
                Props = new FormProps
                {
                    Class = "flex gap-2 mb-4".ToConstSignal(),
                },
                Events = new FormEvents
                {
                    OnSubmit = (e) =>
                    {
                        if (!OperatingSystem.IsBrowser())
                        {
                            return;
                        }

                        e.PreventDefault();

                        var value = draft.Value;
                        if (value.Trim().Length == 0)
                        {
                            return;
                        }

                        Events?.Submit(value);
                        draft.Value = "";
                    },
                },
                Children =
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "text".ToConstSignal(),
                            Id = "todo-input".ToConstSignal(),
                            Name = "todo".ToConstSignal(),
                            Placeholder = Props.Placeholder,
                            Value = draft,
                            Class = "flex-1 min-w-0 rounded-md border border-gray-300 dark:border-gray-600 bg-white dark:bg-gray-800 px-3 py-2 text-gray-900 dark:text-gray-100 placeholder-gray-400 dark:placeholder-gray-500 focus:border-indigo-500 focus:outline-none".ToConstSignal(),
                        },
                        Events = new InputEvents
                        {
                            OnInput = (e) =>
                            {
                                if (!OperatingSystem.IsBrowser())
                                {
                                    return;
                                }

                                if (e.Target is HTMLInputElement input)
                                {
                                    draft.Value = input.Value;
                                }
                            },
                        },
                    },
                    new DemoButton
                    {
                        Props = new DemoButtonProps
                        {
                            Label = "Add".ToConstSignal(),
                            ExtraClass = "shrink-0".ToConstSignal(),
                        },
                    },
                ],
            },
        ];
    }
}
