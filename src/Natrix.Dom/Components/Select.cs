using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class SelectProps : GlobalHtmlComponentProps<HTMLSelectElement>
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
}

public class SelectEvents : HtmlElementComponentEvents<HTMLSelectElement>
{
}

public class Select() : BaseNonVoidDomComponent<HTMLSelectElement, SelectProps, SelectEvents>("select")
{
}
