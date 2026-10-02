using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class InputProps : GlobalHtmlComponentProps<HTMLInputElement>
{
    private static readonly object s_acceptKey = new();

    public IReadOnlySignal<string>? Accept
    {
        get => Get<IReadOnlySignal<string>>(s_acceptKey);
        init => Set(
            s_acceptKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Accept = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("accept", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_altKey = new();

    public IReadOnlySignal<string>? Alt
    {
        get => Get<IReadOnlySignal<string>>(s_altKey);
        init => Set(
            s_altKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Alt = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("alt", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_autocompleteKey = new();

    public IReadOnlySignal<string>? Autocomplete
    {
        get => Get<IReadOnlySignal<string>>(s_autocompleteKey);
        init => Set(
            s_autocompleteKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Autocomplete = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("autocomplete", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_captureKey = new();

    public IReadOnlySignal<string>? Capture
    {
        get => Get<IReadOnlySignal<string>>(s_captureKey);
        init => Set(
            s_captureKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Capture = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("capture", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_checkedKey = new();

    public IReadOnlySignal<bool>? Checked
    {
        get => Get<IReadOnlySignal<bool>>(s_checkedKey);
        init => Set(
            s_checkedKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Checked = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("checked", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_defaultCheckedKey = new();

    public IReadOnlySignal<bool>? DefaultChecked
    {
        get => Get<IReadOnlySignal<bool>>(s_defaultCheckedKey);
        init => Set(
            s_defaultCheckedKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.DefaultChecked = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("checked", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_dirNameKey = new();

    public IReadOnlySignal<string>? DirName
    {
        get => Get<IReadOnlySignal<string>>(s_dirNameKey);
        init => Set(
            s_dirNameKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.DirName = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("dirname", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_disabledKey = new();

    public IReadOnlySignal<bool>? Disabled
    {
        get => Get<IReadOnlySignal<bool>>(s_disabledKey);
        init => Set(
            s_disabledKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Disabled = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("disabled", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_formActionKey = new();

    public IReadOnlySignal<string>? FormAction
    {
        get => Get<IReadOnlySignal<string>>(s_formActionKey);
        init => Set(
            s_formActionKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.FormAction = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("formaction", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_formEnctypeKey = new();

    public IReadOnlySignal<string>? FormEnctype
    {
        get => Get<IReadOnlySignal<string>>(s_formEnctypeKey);
        init => Set(
            s_formEnctypeKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.FormEnctype = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("formenctype", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_formMethodKey = new();

    public IReadOnlySignal<string>? FormMethod
    {
        get => Get<IReadOnlySignal<string>>(s_formMethodKey);
        init => Set(
            s_formMethodKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.FormMethod = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("formmethod", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_formNoValidateKey = new();

    public IReadOnlySignal<bool>? FormNoValidate
    {
        get => Get<IReadOnlySignal<bool>>(s_formNoValidateKey);
        init => Set(
            s_formNoValidateKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.FormNoValidate = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("formnovalidate", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_formTargetKey = new();

    public IReadOnlySignal<string>? FormTarget
    {
        get => Get<IReadOnlySignal<string>>(s_formTargetKey);
        init => Set(
            s_formTargetKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.FormTarget = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("formtarget", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_heightKey = new();

    public IReadOnlySignal<uint>? Height
    {
        get => Get<IReadOnlySignal<uint>>(s_heightKey);
        init => Set(
            s_heightKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Height = ((IReadOnlySignal<uint>)s).Value
                : null,
            static (el, s) => el.SetUInt("height", (IReadOnlySignal<uint>)s));
    }

    private static readonly object s_maxKey = new();

    public IReadOnlySignal<string>? Max
    {
        get => Get<IReadOnlySignal<string>>(s_maxKey);
        init => Set(
            s_maxKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Max = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("max", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_maxLengthKey = new();

    public IReadOnlySignal<int>? MaxLength
    {
        get => Get<IReadOnlySignal<int>>(s_maxLengthKey);
        init => Set(
            s_maxLengthKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.MaxLength = ((IReadOnlySignal<int>)s).Value
                : null,
            static (el, s) => el.SetInt("maxlength", (IReadOnlySignal<int>)s));
    }

    private static readonly object s_minKey = new();

    public IReadOnlySignal<string>? Min
    {
        get => Get<IReadOnlySignal<string>>(s_minKey);
        init => Set(
            s_minKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Min = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("min", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_minLengthKey = new();

    public IReadOnlySignal<int>? MinLength
    {
        get => Get<IReadOnlySignal<int>>(s_minLengthKey);
        init => Set(
            s_minLengthKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.MinLength = ((IReadOnlySignal<int>)s).Value
                : null,
            static (el, s) => el.SetInt("minlength", (IReadOnlySignal<int>)s));
    }

    private static readonly object s_multipleKey = new();

    public IReadOnlySignal<bool>? Multiple
    {
        get => Get<IReadOnlySignal<bool>>(s_multipleKey);
        init => Set(
            s_multipleKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Multiple = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("multiple", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_nameKey = new();

    public IReadOnlySignal<string>? Name
    {
        get => Get<IReadOnlySignal<string>>(s_nameKey);
        init => Set(
            s_nameKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Name = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("name", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_patternKey = new();

    public IReadOnlySignal<string>? Pattern
    {
        get => Get<IReadOnlySignal<string>>(s_patternKey);
        init => Set(
            s_patternKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Pattern = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("pattern", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_placeholderKey = new();

    public IReadOnlySignal<string>? Placeholder
    {
        get => Get<IReadOnlySignal<string>>(s_placeholderKey);
        init => Set(
            s_placeholderKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Placeholder = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("placeholder", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_readOnlyKey = new();

    public IReadOnlySignal<bool>? ReadOnly
    {
        get => Get<IReadOnlySignal<bool>>(s_readOnlyKey);
        init => Set(
            s_readOnlyKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.ReadOnly = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("readonly", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_requiredKey = new();

    public IReadOnlySignal<bool>? Required
    {
        get => Get<IReadOnlySignal<bool>>(s_requiredKey);
        init => Set(
            s_requiredKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Required = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("required", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_sizeKey = new();

    public IReadOnlySignal<uint>? Size
    {
        get => Get<IReadOnlySignal<uint>>(s_sizeKey);
        init => Set(
            s_sizeKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Size = ((IReadOnlySignal<uint>)s).Value
                : null,
            static (el, s) => el.SetUInt("size", (IReadOnlySignal<uint>)s));
    }

    private static readonly object s_srcKey = new();

    public IReadOnlySignal<string>? Src
    {
        get => Get<IReadOnlySignal<string>>(s_srcKey);
        init => Set(
            s_srcKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Src = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("src", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_stepKey = new();

    public IReadOnlySignal<string>? Step
    {
        get => Get<IReadOnlySignal<string>>(s_stepKey);
        init => Set(
            s_stepKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Step = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("step", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_typeKey = new();

    public IReadOnlySignal<string>? Type
    {
        get => Get<IReadOnlySignal<string>>(s_typeKey);
        init => Set(
            s_typeKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Type = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("type", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_valueKey = new();

    public IReadOnlySignal<string>? Value
    {
        get => Get<IReadOnlySignal<string>>(s_valueKey);
        init => Set(
            s_valueKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Value = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("value", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_defaultValueKey = new();

    public IReadOnlySignal<string>? DefaultValue
    {
        get => Get<IReadOnlySignal<string>>(s_defaultValueKey);
        init => Set(
            s_defaultValueKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.DefaultValue = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("value", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_widthKey = new();

    public IReadOnlySignal<uint>? Width
    {
        get => Get<IReadOnlySignal<uint>>(s_widthKey);
        init => Set(
            s_widthKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Width = ((IReadOnlySignal<uint>)s).Value
                : null,
            static (el, s) => el.SetUInt("width", (IReadOnlySignal<uint>)s));
    }
}

public class InputEvents : HtmlElementComponentEvents<HTMLInputElement>
{
}

public class Input() : BaseVoidDomComponent<HTMLInputElement, InputProps, InputEvents>("input")
{
}