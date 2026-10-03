using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class OptionProps : GlobalHtmlComponentProps<HTMLOptionElement>
{
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

    private static readonly PropDescriptor<string> s_label = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Label = s.Value
            : null,
        static (el, s) => el.SetAttribute("label", s));

    public IReadOnlySignal<string>? Label
    {
        get => Get(s_label);
        init => Set(s_label, value);
    }

    private static readonly PropDescriptor<bool> s_defaultSelected = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.DefaultSelected = s.Value
            : null,
        static (el, s) => el.SetBoolean("selected", s));

    public IReadOnlySignal<bool>? DefaultSelected
    {
        get => Get(s_defaultSelected);
        init => Set(s_defaultSelected, value);
    }

    private static readonly PropDescriptor<bool> s_selected = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Selected = s.Value
            : null,
        static (el, s) => el.SetBoolean("selected", s));

    public IReadOnlySignal<bool>? Selected
    {
        get => Get(s_selected);
        init => Set(s_selected, value);
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

public class OptionEvents : HtmlElementComponentEvents<HTMLOptionElement>
{
}

public class Option() : BaseNonVoidDomComponent<HTMLOptionElement, OptionProps, OptionEvents>("option")
{
}
