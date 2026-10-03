using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class InputProps : GlobalHtmlComponentProps<HTMLInputElement>
{
    private static PropDescriptor<string>? s_accept;

    public IReadOnlySignal<string>? Accept
    {
        get => Get(s_accept);
        init => Set(ref s_accept, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Accept = s.Value;
            },
            static (el, s) => el.SetAttribute("accept", s)));
    }

    private static PropDescriptor<string>? s_alt;

    public IReadOnlySignal<string>? Alt
    {
        get => Get(s_alt);
        init => Set(ref s_alt, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Alt = s.Value;
            },
            static (el, s) => el.SetAttribute("alt", s)));
    }

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

    private static PropDescriptor<string>? s_capture;

    public IReadOnlySignal<string>? Capture
    {
        get => Get(s_capture);
        init => Set(ref s_capture, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Capture = s.Value;
            },
            static (el, s) => el.SetAttribute("capture", s)));
    }

    private static PropDescriptor<bool>? s_checked;

    public IReadOnlySignal<bool>? Checked
    {
        get => Get(s_checked);
        init => Set(ref s_checked, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Checked = s.Value;
            },
            static (el, s) => el.SetBoolean("checked", s)));
    }

    private static PropDescriptor<bool>? s_defaultChecked;

    public IReadOnlySignal<bool>? DefaultChecked
    {
        get => Get(s_defaultChecked);
        init => Set(ref s_defaultChecked, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.DefaultChecked = s.Value;
            },
            static (el, s) => el.SetBoolean("checked", s)));
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

    private static PropDescriptor<string>? s_formAction;

    public IReadOnlySignal<string>? FormAction
    {
        get => Get(s_formAction);
        init => Set(ref s_formAction, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.FormAction = s.Value;
            },
            static (el, s) => el.SetAttribute("formaction", s)));
    }

    private static PropDescriptor<string>? s_formEnctype;

    public IReadOnlySignal<string>? FormEnctype
    {
        get => Get(s_formEnctype);
        init => Set(ref s_formEnctype, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.FormEnctype = s.Value;
            },
            static (el, s) => el.SetAttribute("formenctype", s)));
    }

    private static PropDescriptor<string>? s_formMethod;

    public IReadOnlySignal<string>? FormMethod
    {
        get => Get(s_formMethod);
        init => Set(ref s_formMethod, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.FormMethod = s.Value;
            },
            static (el, s) => el.SetAttribute("formmethod", s)));
    }

    private static PropDescriptor<bool>? s_formNoValidate;

    public IReadOnlySignal<bool>? FormNoValidate
    {
        get => Get(s_formNoValidate);
        init => Set(ref s_formNoValidate, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.FormNoValidate = s.Value;
            },
            static (el, s) => el.SetBoolean("formnovalidate", s)));
    }

    private static PropDescriptor<string>? s_formTarget;

    public IReadOnlySignal<string>? FormTarget
    {
        get => Get(s_formTarget);
        init => Set(ref s_formTarget, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.FormTarget = s.Value;
            },
            static (el, s) => el.SetAttribute("formtarget", s)));
    }

    private static PropDescriptor<uint>? s_height;

    public IReadOnlySignal<uint>? Height
    {
        get => Get(s_height);
        init => Set(ref s_height, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Height = s.Value;
            },
            static (el, s) => el.SetUInt("height", s)));
    }

    private static PropDescriptor<string>? s_max;

    public IReadOnlySignal<string>? Max
    {
        get => Get(s_max);
        init => Set(ref s_max, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Max = s.Value;
            },
            static (el, s) => el.SetAttribute("max", s)));
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

    private static PropDescriptor<string>? s_min;

    public IReadOnlySignal<string>? Min
    {
        get => Get(s_min);
        init => Set(ref s_min, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Min = s.Value;
            },
            static (el, s) => el.SetAttribute("min", s)));
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

    private static PropDescriptor<string>? s_pattern;

    public IReadOnlySignal<string>? Pattern
    {
        get => Get(s_pattern);
        init => Set(ref s_pattern, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Pattern = s.Value;
            },
            static (el, s) => el.SetAttribute("pattern", s)));
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

    private static PropDescriptor<string>? s_src;

    public IReadOnlySignal<string>? Src
    {
        get => Get(s_src);
        init => Set(ref s_src, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Src = s.Value;
            },
            static (el, s) => el.SetAttribute("src", s)));
    }

    private static PropDescriptor<string>? s_step;

    public IReadOnlySignal<string>? Step
    {
        get => Get(s_step);
        init => Set(ref s_step, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Step = s.Value;
            },
            static (el, s) => el.SetAttribute("step", s)));
    }

    private static PropDescriptor<string>? s_type;

    public IReadOnlySignal<string>? Type
    {
        get => Get(s_type);
        init => Set(ref s_type, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Type = s.Value;
            },
            static (el, s) => el.SetAttribute("type", s)));
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

    private static PropDescriptor<uint>? s_width;

    public IReadOnlySignal<uint>? Width
    {
        get => Get(s_width);
        init => Set(ref s_width, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Width = s.Value;
            },
            static (el, s) => el.SetUInt("width", s)));
    }
}

public class InputEvents : HtmlElementComponentEvents<HTMLInputElement>
{
}

public class Input() : BaseVoidDomComponent<HTMLInputElement, InputProps, InputEvents>("input")
{
}