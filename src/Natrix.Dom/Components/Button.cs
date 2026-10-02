using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class ButtonProps : GlobalHtmlComponentProps<HTMLButtonElement>
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
}

public class ButtonEvents : HtmlElementComponentEvents<HTMLButtonElement>
{
}

public class Button() : BaseNonVoidDomComponent<HTMLButtonElement, ButtonProps, ButtonEvents>("button")
{
}
