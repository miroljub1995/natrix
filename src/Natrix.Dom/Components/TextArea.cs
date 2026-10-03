using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class TextAreaProps : GlobalHtmlComponentProps<HTMLTextAreaElement>
{
    private static readonly PropDescriptor<string> s_autocomplete = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Autocomplete = s.Value
            : null,
        static (el, s) => el.SetAttribute("autocomplete", s));

    public IReadOnlySignal<string>? Autocomplete
    {
        get => Get(s_autocomplete);
        init => Set(s_autocomplete, value);
    }

    private static readonly PropDescriptor<uint> s_cols = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Cols = s.Value
            : null,
        static (el, s) => el.SetUInt("cols", s));

    public IReadOnlySignal<uint>? Cols
    {
        get => Get(s_cols);
        init => Set(s_cols, value);
    }

    private static readonly PropDescriptor<string> s_dirName = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.DirName = s.Value
            : null,
        static (el, s) => el.SetAttribute("dirname", s));

    public IReadOnlySignal<string>? DirName
    {
        get => Get(s_dirName);
        init => Set(s_dirName, value);
    }

    private static readonly PropDescriptor<bool> s_disabled = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Disabled = s.Value
            : null,
        static (el, s) => el.SetBoolean("disabled", s));

    public IReadOnlySignal<bool>? Disabled
    {
        get => Get(s_disabled);
        init => Set(s_disabled, value);
    }

    private static readonly PropDescriptor<int> s_maxLength = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.MaxLength = s.Value
            : null,
        static (el, s) => el.SetInt("maxlength", s));

    public IReadOnlySignal<int>? MaxLength
    {
        get => Get(s_maxLength);
        init => Set(s_maxLength, value);
    }

    private static readonly PropDescriptor<int> s_minLength = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.MinLength = s.Value
            : null,
        static (el, s) => el.SetInt("minlength", s));

    public IReadOnlySignal<int>? MinLength
    {
        get => Get(s_minLength);
        init => Set(s_minLength, value);
    }

    private static readonly PropDescriptor<string> s_name = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Name = s.Value
            : null,
        static (el, s) => el.SetAttribute("name", s));

    public IReadOnlySignal<string>? Name
    {
        get => Get(s_name);
        init => Set(s_name, value);
    }

    private static readonly PropDescriptor<string> s_placeholder = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Placeholder = s.Value
            : null,
        static (el, s) => el.SetAttribute("placeholder", s));

    public IReadOnlySignal<string>? Placeholder
    {
        get => Get(s_placeholder);
        init => Set(s_placeholder, value);
    }

    private static readonly PropDescriptor<bool> s_readOnly = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.ReadOnly = s.Value
            : null,
        static (el, s) => el.SetBoolean("readonly", s));

    public IReadOnlySignal<bool>? ReadOnly
    {
        get => Get(s_readOnly);
        init => Set(s_readOnly, value);
    }

    private static readonly PropDescriptor<bool> s_required = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Required = s.Value
            : null,
        static (el, s) => el.SetBoolean("required", s));

    public IReadOnlySignal<bool>? Required
    {
        get => Get(s_required);
        init => Set(s_required, value);
    }

    private static readonly PropDescriptor<uint> s_rows = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Rows = s.Value
            : null,
        static (el, s) => el.SetUInt("rows", s));

    public IReadOnlySignal<uint>? Rows
    {
        get => Get(s_rows);
        init => Set(s_rows, value);
    }

    private static readonly PropDescriptor<string> s_wrap = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Wrap = s.Value
            : null,
        static (el, s) => el.SetAttribute("wrap", s));

    public IReadOnlySignal<string>? Wrap
    {
        get => Get(s_wrap);
        init => Set(s_wrap, value);
    }

    private static readonly PropDescriptor<string> s_value = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Value = s.Value
            : null,
        static (el, s) => el.SetAttribute("value", s));

    public IReadOnlySignal<string>? Value
    {
        get => Get(s_value);
        init => Set(s_value, value);
    }

    private static readonly PropDescriptor<string> s_defaultValue = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.DefaultValue = s.Value
            : null,
        static (el, s) => el.SetAttribute("value", s));

    public IReadOnlySignal<string>? DefaultValue
    {
        get => Get(s_defaultValue);
        init => Set(s_defaultValue, value);
    }
}

public class TextAreaEvents : HtmlElementComponentEvents<HTMLTextAreaElement>
{
}

public class TextArea() : BaseNonVoidDomComponent<HTMLTextAreaElement, TextAreaProps, TextAreaEvents>("textarea")
{
}
