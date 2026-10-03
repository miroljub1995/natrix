using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class InputProps : GlobalHtmlComponentProps<HTMLInputElement>
{
    private static readonly PropDescriptor<string> s_accept = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Accept = s.Value
            : null,
        static (el, s) => el.SetAttribute("accept", s));

    public IReadOnlySignal<string>? Accept
    {
        get => Get(s_accept);
        init => Set(s_accept, value);
    }

    private static readonly PropDescriptor<string> s_alt = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Alt = s.Value
            : null,
        static (el, s) => el.SetAttribute("alt", s));

    public IReadOnlySignal<string>? Alt
    {
        get => Get(s_alt);
        init => Set(s_alt, value);
    }

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

    private static readonly PropDescriptor<string> s_capture = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Capture = s.Value
            : null,
        static (el, s) => el.SetAttribute("capture", s));

    public IReadOnlySignal<string>? Capture
    {
        get => Get(s_capture);
        init => Set(s_capture, value);
    }

    private static readonly PropDescriptor<bool> s_checked = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Checked = s.Value
            : null,
        static (el, s) => el.SetBoolean("checked", s));

    public IReadOnlySignal<bool>? Checked
    {
        get => Get(s_checked);
        init => Set(s_checked, value);
    }

    private static readonly PropDescriptor<bool> s_defaultChecked = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.DefaultChecked = s.Value
            : null,
        static (el, s) => el.SetBoolean("checked", s));

    public IReadOnlySignal<bool>? DefaultChecked
    {
        get => Get(s_defaultChecked);
        init => Set(s_defaultChecked, value);
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

    private static readonly PropDescriptor<string> s_formAction = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.FormAction = s.Value
            : null,
        static (el, s) => el.SetAttribute("formaction", s));

    public IReadOnlySignal<string>? FormAction
    {
        get => Get(s_formAction);
        init => Set(s_formAction, value);
    }

    private static readonly PropDescriptor<string> s_formEnctype = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.FormEnctype = s.Value
            : null,
        static (el, s) => el.SetAttribute("formenctype", s));

    public IReadOnlySignal<string>? FormEnctype
    {
        get => Get(s_formEnctype);
        init => Set(s_formEnctype, value);
    }

    private static readonly PropDescriptor<string> s_formMethod = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.FormMethod = s.Value
            : null,
        static (el, s) => el.SetAttribute("formmethod", s));

    public IReadOnlySignal<string>? FormMethod
    {
        get => Get(s_formMethod);
        init => Set(s_formMethod, value);
    }

    private static readonly PropDescriptor<bool> s_formNoValidate = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.FormNoValidate = s.Value
            : null,
        static (el, s) => el.SetBoolean("formnovalidate", s));

    public IReadOnlySignal<bool>? FormNoValidate
    {
        get => Get(s_formNoValidate);
        init => Set(s_formNoValidate, value);
    }

    private static readonly PropDescriptor<string> s_formTarget = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.FormTarget = s.Value
            : null,
        static (el, s) => el.SetAttribute("formtarget", s));

    public IReadOnlySignal<string>? FormTarget
    {
        get => Get(s_formTarget);
        init => Set(s_formTarget, value);
    }

    private static readonly PropDescriptor<uint> s_height = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Height = s.Value
            : null,
        static (el, s) => el.SetUInt("height", s));

    public IReadOnlySignal<uint>? Height
    {
        get => Get(s_height);
        init => Set(s_height, value);
    }

    private static readonly PropDescriptor<string> s_max = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Max = s.Value
            : null,
        static (el, s) => el.SetAttribute("max", s));

    public IReadOnlySignal<string>? Max
    {
        get => Get(s_max);
        init => Set(s_max, value);
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

    private static readonly PropDescriptor<string> s_min = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Min = s.Value
            : null,
        static (el, s) => el.SetAttribute("min", s));

    public IReadOnlySignal<string>? Min
    {
        get => Get(s_min);
        init => Set(s_min, value);
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

    private static readonly PropDescriptor<bool> s_multiple = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Multiple = s.Value
            : null,
        static (el, s) => el.SetBoolean("multiple", s));

    public IReadOnlySignal<bool>? Multiple
    {
        get => Get(s_multiple);
        init => Set(s_multiple, value);
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

    private static readonly PropDescriptor<string> s_pattern = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Pattern = s.Value
            : null,
        static (el, s) => el.SetAttribute("pattern", s));

    public IReadOnlySignal<string>? Pattern
    {
        get => Get(s_pattern);
        init => Set(s_pattern, value);
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

    private static readonly PropDescriptor<uint> s_size = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Size = s.Value
            : null,
        static (el, s) => el.SetUInt("size", s));

    public IReadOnlySignal<uint>? Size
    {
        get => Get(s_size);
        init => Set(s_size, value);
    }

    private static readonly PropDescriptor<string> s_src = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Src = s.Value
            : null,
        static (el, s) => el.SetAttribute("src", s));

    public IReadOnlySignal<string>? Src
    {
        get => Get(s_src);
        init => Set(s_src, value);
    }

    private static readonly PropDescriptor<string> s_step = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Step = s.Value
            : null,
        static (el, s) => el.SetAttribute("step", s));

    public IReadOnlySignal<string>? Step
    {
        get => Get(s_step);
        init => Set(s_step, value);
    }

    private static readonly PropDescriptor<string> s_type = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Type = s.Value
            : null,
        static (el, s) => el.SetAttribute("type", s));

    public IReadOnlySignal<string>? Type
    {
        get => Get(s_type);
        init => Set(s_type, value);
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

    private static readonly PropDescriptor<uint> s_width = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Width = s.Value
            : null,
        static (el, s) => el.SetUInt("width", s));

    public IReadOnlySignal<uint>? Width
    {
        get => Get(s_width);
        init => Set(s_width, value);
    }
}

public class InputEvents : HtmlElementComponentEvents<HTMLInputElement>
{
}

public class Input() : BaseVoidDomComponent<HTMLInputElement, InputProps, InputEvents>("input")
{
}