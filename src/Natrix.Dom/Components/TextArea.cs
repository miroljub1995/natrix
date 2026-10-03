using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class TextAreaProps : GlobalHtmlComponentProps<HTMLTextAreaElement>
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

    private static PropDescriptor<uint>? s_cols;

    public IReadOnlySignal<uint>? Cols
    {
        get => Get(s_cols);
        init => Set(ref s_cols, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Cols = s.Value;
            },
            static (el, s) => el.SetUInt("cols", s)));
    }

    private static PropDescriptor<string>? s_dirName;

    public IReadOnlySignal<string>? DirName
    {
        get => Get(s_dirName);
        init => Set(ref s_dirName, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.DirName = s.Value;
            },
            static (el, s) => el.SetAttribute("dirname", s)));
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

    private static PropDescriptor<int>? s_maxLength;

    public IReadOnlySignal<int>? MaxLength
    {
        get => Get(s_maxLength);
        init => Set(ref s_maxLength, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.MaxLength = s.Value;
            },
            static (el, s) => el.SetInt("maxlength", s)));
    }

    private static PropDescriptor<int>? s_minLength;

    public IReadOnlySignal<int>? MinLength
    {
        get => Get(s_minLength);
        init => Set(ref s_minLength, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.MinLength = s.Value;
            },
            static (el, s) => el.SetInt("minlength", s)));
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

    private static PropDescriptor<string>? s_placeholder;

    public IReadOnlySignal<string>? Placeholder
    {
        get => Get(s_placeholder);
        init => Set(ref s_placeholder, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Placeholder = s.Value;
            },
            static (el, s) => el.SetAttribute("placeholder", s)));
    }

    private static PropDescriptor<bool>? s_readOnly;

    public IReadOnlySignal<bool>? ReadOnly
    {
        get => Get(s_readOnly);
        init => Set(ref s_readOnly, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.ReadOnly = s.Value;
            },
            static (el, s) => el.SetBoolean("readonly", s)));
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

    private static PropDescriptor<uint>? s_rows;

    public IReadOnlySignal<uint>? Rows
    {
        get => Get(s_rows);
        init => Set(ref s_rows, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Rows = s.Value;
            },
            static (el, s) => el.SetUInt("rows", s)));
    }

    private static PropDescriptor<string>? s_wrap;

    public IReadOnlySignal<string>? Wrap
    {
        get => Get(s_wrap);
        init => Set(ref s_wrap, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Wrap = s.Value;
            },
            static (el, s) => el.SetAttribute("wrap", s)));
    }

    private static PropDescriptor<string>? s_value;

    public IReadOnlySignal<string>? Value
    {
        get => Get(s_value);
        init => Set(ref s_value, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Value = s.Value;
            },
            static (el, s) => el.SetAttribute("value", s)));
    }

    private static PropDescriptor<string>? s_defaultValue;

    public IReadOnlySignal<string>? DefaultValue
    {
        get => Get(s_defaultValue);
        init => Set(ref s_defaultValue, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.DefaultValue = s.Value;
            },
            static (el, s) => el.SetAttribute("value", s)));
    }
}

public class TextAreaEvents : HtmlElementComponentEvents<HTMLTextAreaElement>
{
}

public class TextArea() : BaseNonVoidDomComponent<HTMLTextAreaElement, TextAreaProps, TextAreaEvents>("textarea")
{
}
