using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class OptionProps : GlobalHtmlComponentProps<HTMLOptionElement>
{
    private static readonly PropDescriptor<bool> s_disabled = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Disabled = s.Value;
        },
        static (el, s) => el.SetBoolean("disabled", s));

    public IReadOnlySignal<bool>? Disabled
    {
        get => Get(s_disabled);
        init => Set(s_disabled, value);
    }

    private static readonly PropDescriptor<string> s_label = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Label = s.Value;
        },
        static (el, s) => el.SetAttribute("label", s));

    public IReadOnlySignal<string>? Label
    {
        get => Get(s_label);
        init => Set(s_label, value);
    }

    private static readonly PropDescriptor<bool> s_defaultSelected = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.DefaultSelected = s.Value;
        },
        static (el, s) => el.SetBoolean("selected", s));

    public IReadOnlySignal<bool>? DefaultSelected
    {
        get => Get(s_defaultSelected);
        init => Set(s_defaultSelected, value);
    }

    private static readonly PropDescriptor<bool> s_selected = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Selected = s.Value;
        },
        static (el, s) => el.SetBoolean("selected", s));

    public IReadOnlySignal<bool>? Selected
    {
        get => Get(s_selected);
        init => Set(s_selected, value);
    }

    private static readonly PropDescriptor<string> s_value = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Value = s.Value;
        },
        static (el, s) => el.SetAttribute("value", s));

    public IReadOnlySignal<string>? Value
    {
        get => Get(s_value);
        init => Set(s_value, value);
    }
}

public class OptionEvents : HtmlElementComponentEvents<HTMLOptionElement>
{
}

public class Option() : BaseNonVoidDomComponent<HTMLOptionElement, OptionProps, OptionEvents>("option")
{
}
