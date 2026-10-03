using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class SelectProps : GlobalHtmlComponentProps<HTMLSelectElement>
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
}

public class SelectEvents : HtmlElementComponentEvents<HTMLSelectElement>
{
}

public class Select() : BaseNonVoidDomComponent<HTMLSelectElement, SelectProps, SelectEvents>("select")
{
}
