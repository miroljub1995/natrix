using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class TextAreaProps : GlobalHtmlComponentProps<HTMLTextAreaElement>
{
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

    private static readonly object s_colsKey = new();

    public IReadOnlySignal<uint>? Cols
    {
        get => Get<IReadOnlySignal<uint>>(s_colsKey);
        init => Set(
            s_colsKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Cols = ((IReadOnlySignal<uint>)s).Value
                : null,
            static (el, s) => el.SetUInt("cols", (IReadOnlySignal<uint>)s));
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

    private static readonly object s_rowsKey = new();

    public IReadOnlySignal<uint>? Rows
    {
        get => Get<IReadOnlySignal<uint>>(s_rowsKey);
        init => Set(
            s_rowsKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Rows = ((IReadOnlySignal<uint>)s).Value
                : null,
            static (el, s) => el.SetUInt("rows", (IReadOnlySignal<uint>)s));
    }

    private static readonly object s_wrapKey = new();

    public IReadOnlySignal<string>? Wrap
    {
        get => Get<IReadOnlySignal<string>>(s_wrapKey);
        init => Set(
            s_wrapKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Wrap = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("wrap", (IReadOnlySignal<string>)s));
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
}

public class TextAreaEvents : HtmlElementComponentEvents<HTMLTextAreaElement>
{
}

public class TextArea() : BaseNonVoidDomComponent<HTMLTextAreaElement, TextAreaProps, TextAreaEvents>("textarea")
{
}
