using System.Runtime.Versioning;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class SelectProps : GlobalHtmlComponentProps<HTMLSelectElement>
{
    private static PropDescriptor<string>? s_autocomplete;

    public IReadOnlySignal<string>? Autocomplete
    {
        get => Get(s_autocomplete);
        init => Set(ref s_autocomplete, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Autocomplete = s.Value;
            },
            static (el, s) => el.SetAttribute("autocomplete", s)));
    }

    private static PropDescriptor<bool>? s_disabled;

    public IReadOnlySignal<bool>? Disabled
    {
        get => Get(s_disabled);
        init => Set(ref s_disabled, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Disabled = s.Value;
            },
            static (el, s) => el.SetBoolean("disabled", s)));
    }

    private static PropDescriptor<bool>? s_multiple;

    public IReadOnlySignal<bool>? Multiple
    {
        get => Get(s_multiple);
        init => Set(ref s_multiple, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Multiple = s.Value;
            },
            static (el, s) => el.SetBoolean("multiple", s)));
    }

    private static PropDescriptor<string>? s_name;

    public IReadOnlySignal<string>? Name
    {
        get => Get(s_name);
        init => Set(ref s_name, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Name = s.Value;
            },
            static (el, s) => el.SetAttribute("name", s)));
    }

    private static PropDescriptor<bool>? s_required;

    public IReadOnlySignal<bool>? Required
    {
        get => Get(s_required);
        init => Set(ref s_required, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Required = s.Value;
            },
            static (el, s) => el.SetBoolean("required", s)));
    }

    private static PropDescriptor<uint>? s_size;

    public IReadOnlySignal<uint>? Size
    {
        get => Get(s_size);
        init => Set(ref s_size, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Size = s.Value;
            },
            static (el, s) => el.SetUInt("size", s)));
    }

    private static PropDescriptor<string>? s_value;

    /// <summary>
    /// Selects the option whose value equals this, or the first enabled option if none
    /// does. Set either this or <see cref="Values"/>.
    /// </summary>
    /// <remarks>
    /// Applied by selecting options, not through the select's own value, which HTML does not have as
    /// an attribute: on the client once the options are mounted, and again when the value changes;
    /// on the server as the <c>selected</c> attribute of the options mounted with the select,
    /// overriding their own. Options added later do not pick it up until the value changes.
    /// </remarks>
    public IReadOnlySignal<string>? Value
    {
        get => Get(s_value);
        init
        {
            ThrowIfBothSet(value, Values);
            Set(ref s_value, value, static () => new(
                static (el, s) =>
                {
                    if (OperatingSystem.IsBrowser()) SelectOption(el, s.Value);
                },
                static (el, s) => SsrSelect(el, new SsrSingleSelection(s)),
                afterChildren: true));
        }
    }

    private static PropDescriptor<IReadOnlyList<string>>? s_values;

    /// <summary>
    /// Selects every option whose value is in this list, for a <see cref="Multiple"/>
    /// select. Set either this or <see cref="Value"/>.
    /// </summary>
    /// <remarks>Applied like <see cref="Value"/>. Assign a new list to change it.</remarks>
    public IReadOnlySignal<IReadOnlyList<string>>? Values
    {
        get => Get(s_values);
        init
        {
            ThrowIfBothSet(Value, value);
            Set(ref s_values, value, static () => new(
                static (el, s) =>
                {
                    if (OperatingSystem.IsBrowser()) SelectOptions(el, s.Value);
                },
                static (el, s) => SsrSelect(el, new SsrMultipleSelection(s)),
                afterChildren: true));
        }
    }

    private static void ThrowIfBothSet(object? value, object? values)
    {
        if (value is not null && values is not null)
        {
            throw new InvalidOperationException($"Set either {nameof(Value)} or {nameof(Values)} on a select, not both.");
        }
    }

    // An option's value is its value attribute or, without one, its text, as in HTML: the value property
    // on the client, SsrOptionValue on the server.

    [SupportedOSPlatform("browser")]
    internal static void SelectOption(HTMLSelectElement el, string value)
    {
        var options = el.Options;
        for (uint i = 0; i < options.Length; i++)
        {
            if (options.Item(i) is HTMLOptionElement option && option.Value == value)
            {
                option.Selected = true;
                return;
            }
        }

        // As React does when nothing matches.
        for (uint i = 0; i < options.Length; i++)
        {
            if (options.Item(i) is HTMLOptionElement { Disabled: false } option)
            {
                option.Selected = true;
                return;
            }
        }
    }

    [SupportedOSPlatform("browser")]
    internal static void SelectOptions(HTMLSelectElement el, IReadOnlyList<string> values)
    {
        var options = el.Options;
        for (uint i = 0; i < options.Length; i++)
        {
            if (options.Item(i) is HTMLOptionElement option)
            {
                option.Selected = values.Contains(option.Value);
            }
        }
    }


    /// <summary>
    /// Marks the options under <paramref name="select"/> as selected according to
    /// <paramref name="selection"/>, which decides when the page is written.
    /// </summary>
    private static void SsrSelect(SsrElementNode select, SsrSelection selection)
    {
        selection.Options = [.. SsrOptions(select)];
        foreach (var option in selection.Options)
        {
            option.SetAttribute("selected", (selection, option), static obj =>
            {
                var (selection, option) = ((SsrSelection, SsrElementNode))obj;
                return selection.IsSelected(option) ? new SsrAttributeValue(null) : null;
            });
        }
    }

    private static IEnumerable<SsrElementNode> SsrOptions(SsrElementNode parent)
    {
        foreach (var child in parent.GetChildNodes())
        {
            if (child is not SsrElementNode element)
            {
                continue;
            }

            if (element.TagName == "option")
            {
                yield return element;
            }
            else
            {
                // optgroup
                foreach (var option in SsrOptions(element))
                {
                    yield return option;
                }
            }
        }
    }

    private static string SsrOptionValue(SsrElementNode option) =>
        option.GetAttribute("value")?.Value ?? StripAndCollapseWhitespace(SsrText(option));

    private static string SsrText(ISsrNode node) => node is SsrTextNode text
        ? text.TextContent?.Value ?? string.Empty
        : string.Concat(node.GetChildNodes().Select(SsrText));

    /// <summary>
    /// What HTML does to an option's text to get its value: trims ASCII whitespace and collapses runs
    /// of it into a single space.
    /// </summary>
    private static string StripAndCollapseWhitespace(string text) =>
        string.Join(' ', text.Split([' ', '\t', '\n', '\f', '\r'], StringSplitOptions.RemoveEmptyEntries));

    private abstract class SsrSelection
    {
        public SsrElementNode[] Options { get; set; } = [];

        public abstract bool IsSelected(SsrElementNode option);
    }

    /// <summary>The first option matching the value, or the first enabled one, as on the client.</summary>
    private sealed class SsrSingleSelection(IReadOnlySignal<string> value) : SsrSelection
    {
        public override bool IsSelected(SsrElementNode option)
        {
            var current = value.Value;
            var selected = Array.Find(Options, o => SsrOptionValue(o) == current)
                ?? Array.Find(Options, static o => o.GetAttribute("disabled") is null);
            return ReferenceEquals(selected, option);
        }
    }

    private sealed class SsrMultipleSelection(IReadOnlySignal<IReadOnlyList<string>> values) : SsrSelection
    {
        public override bool IsSelected(SsrElementNode option) =>
            values.Value.Contains(SsrOptionValue(option));
    }
}

public class SelectEvents : HtmlElementComponentEvents<HTMLSelectElement>
{
}

public class Select() : BaseNonVoidDomComponent<HTMLSelectElement, SelectProps, SelectEvents>("select")
{
}
