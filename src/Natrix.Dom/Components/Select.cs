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
}

public class SelectEvents : HtmlElementComponentEvents<HTMLSelectElement>
{
}

public class Select() : BaseNonVoidDomComponent<HTMLSelectElement, SelectProps, SelectEvents>("select")
{
}
