using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class OptionProps : GlobalHtmlComponentProps<HTMLOptionElement>
{
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

    private static readonly object s_labelKey = new();

    public IReadOnlySignal<string>? Label
    {
        get => Get<IReadOnlySignal<string>>(s_labelKey);
        init => Set(
            s_labelKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Label = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("label", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_defaultSelectedKey = new();

    public IReadOnlySignal<bool>? DefaultSelected
    {
        get => Get<IReadOnlySignal<bool>>(s_defaultSelectedKey);
        init => Set(
            s_defaultSelectedKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.DefaultSelected = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("selected", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_selectedKey = new();

    public IReadOnlySignal<bool>? Selected
    {
        get => Get<IReadOnlySignal<bool>>(s_selectedKey);
        init => Set(
            s_selectedKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Selected = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("selected", (IReadOnlySignal<bool>)s));
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

public class OptionEvents : HtmlElementComponentEvents<HTMLOptionElement>
{
}

public class Option() : BaseNonVoidDomComponent<HTMLOptionElement, OptionProps, OptionEvents>("option")
{
}
