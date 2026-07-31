using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Docs.Client.Components.Examples.Todo;

public class TodoInputProps
{
    public required Signal<string> Draft { get; init; }
    public IReadOnlySignal<string> Placeholder { get; init; } = "Enter a new task...".ToConstSignal();
}

[GeneratedEvents]
public partial class TodoInputEvents
{
    public partial void Submit();
}

/// <summary>
/// Text field plus Add button. Submits on click or on Enter.
/// </summary>
public class TodoInput : BaseComponent<TodoInputProps, TodoInputEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        return
        [
            new Div
            {
                Props = new DivProps
                {
                    Class = "flex gap-2 mb-4".ToConstSignal(),
                },
                Children =
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "text".ToConstSignal(),
                            Placeholder = Props.Placeholder,
                            Value = Props.Draft,
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
                                    Props.Draft.Value = input.Value;
                                }
                            },
                            OnKeyDown = (e) =>
                            {
                                if (!OperatingSystem.IsBrowser())
                                {
                                    return;
                                }

                                if (e.Key == "Enter")
                                {
                                    Events?.Submit();
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
                        Events = new DemoButtonEvents
                        {
                            OnClick = () => Events?.Submit(),
                        },
                    },
                ],
            },
        ];
    }
}
