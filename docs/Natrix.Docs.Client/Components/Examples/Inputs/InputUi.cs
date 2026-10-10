using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

/// <summary>
/// The styling the input listings leave out, shared so each demo reads like its listing.
/// </summary>
internal static class InputUi
{
    public const string FieldClass =
        "block w-full min-w-0 rounded-md border border-gray-300 dark:border-gray-600 bg-white dark:bg-gray-800 px-3 py-2 text-gray-900 dark:text-gray-100 placeholder-gray-400 dark:placeholder-gray-500 focus:border-indigo-500 focus:outline-none focus:ring-2 focus:ring-indigo-500/20";

    public const string ChoiceClass =
        "h-4 w-4 shrink-0 accent-indigo-600";

    public const string ButtonClass =
        "rounded-md bg-indigo-600 px-4 py-2 text-sm font-medium text-white hover:bg-indigo-500 disabled:cursor-not-allowed disabled:bg-gray-300 dark:disabled:bg-gray-700 disabled:text-gray-500 transition-colors";

    /// <summary>The demo's content, in a column centred in the live panel.</summary>
    public static Div Stack(params IComponent[] children) => new()
    {
        Props = new DivProps
        {
            Class = "mx-auto flex w-full max-w-md flex-col gap-4 px-6 py-8".ToConstSignal(),
        },
        Children = children,
    };

    /// <summary>A label above the field it names.</summary>
    public static Div Field(string label, string inputId, IComponent input) => new()
    {
        Props = new DivProps
        {
            Class = "flex flex-col gap-1.5".ToConstSignal(),
        },
        Children =
        [
            new Label
            {
                Props = new LabelProps
                {
                    HtmlFor = inputId.ToConstSignal(),
                    Class = "text-sm font-medium text-gray-700 dark:text-gray-300".ToConstSignal(),
                },
                Children = [Text(label)],
            },
            input,
        ],
    };

    /// <summary>
    /// A labelled field of <paramref name="type"/> bound to <paramref name="value"/>, and what the
    /// demo makes of it below: the shape of every date and time demo.
    /// </summary>
    public static Div BoundField(string type, string label, Signal<string> value, IReadOnlySignal<string> result)
    {
        var id = $"inputs-{type}-field";

        return Stack(
            Field(label, id, new Input
            {
                Props = new InputProps
                {
                    Id = id.ToConstSignal(),
                    Type = type.ToConstSignal(),
                    Value = value,
                    Class = FieldClass.ToConstSignal(),
                },
                Events = new InputEvents { OnInput = value.ToDomEvent() },
            }),
            Result(result));
    }

    /// <summary>A checkbox or radio button with its label beside it.</summary>
    public static Label Choice(Input input, IComponent label) => new()
    {
        Props = new LabelProps
        {
            Class = "flex cursor-pointer items-center gap-3 rounded-md px-1 py-1 text-sm text-gray-700 dark:text-gray-300".ToConstSignal(),
        },
        Children = [input, label],
    };

    /// <summary>What the demo computed from the input.</summary>
    public static P Result(IReadOnlySignal<string> text) => new()
    {
        Props = new PProps
        {
            Class = "rounded-md bg-gray-100 dark:bg-gray-800/60 px-3 py-2 font-mono text-sm text-gray-800 dark:text-gray-200 break-words".ToConstSignal(),
        },
        Children = [new DomText { Text = text }],
    };

    /// <summary>A smaller line under the result.</summary>
    public static P Hint(IReadOnlySignal<string> text) => new()
    {
        Props = new PProps
        {
            Class = "text-xs text-gray-500 dark:text-gray-400".ToConstSignal(),
        },
        Children = [new DomText { Text = text }],
    };

    public static DomText Text(string text) => new() { Text = text.ToConstSignal() };
}
