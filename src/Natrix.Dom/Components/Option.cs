using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class OptionProps : GlobalHtmlComponentProps<HTMLOptionElement>
{
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

    private static PropDescriptor<string>? s_label;

    public IReadOnlySignal<string>? Label
    {
        get => Get(s_label);
        init => Set(ref s_label, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Label = s.Value;
            },
            static (el, s) => el.SetAttribute("label", s)));
    }

    private static PropDescriptor<bool>? s_defaultSelected;

    public IReadOnlySignal<bool>? DefaultSelected
    {
        get => Get(s_defaultSelected);
        init => Set(ref s_defaultSelected, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.DefaultSelected = s.Value;
            },
            static (el, s) => el.SetBoolean("selected", s)));
    }

    private static PropDescriptor<bool>? s_selected;

    public IReadOnlySignal<bool>? Selected
    {
        get => Get(s_selected);
        init => Set(ref s_selected, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Selected = s.Value;
            },
            static (el, s) => el.SetBoolean("selected", s)));
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

public class OptionEvents : HtmlElementComponentEvents<HTMLOptionElement>
{
}

public class Option() : BaseNonVoidDomComponent<HTMLOptionElement, OptionProps, OptionEvents>("option")
{
}
