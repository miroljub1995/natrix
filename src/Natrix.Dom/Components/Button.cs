using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class ButtonProps : GlobalHtmlComponentProps<HTMLButtonElement>
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

    private static readonly PropDescriptor<string> s_type = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Type = s.Value
            : null,
        static (el, s) => el.SetAttribute("type", s));

    public IReadOnlySignal<string>? Type
    {
        get => Get(s_type);
        init => Set(s_type, value);
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

    private static readonly PropDescriptor<string> s_formAction = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.FormAction = s.Value
            : null,
        static (el, s) => el.SetAttribute("formaction", s));

    public IReadOnlySignal<string>? FormAction
    {
        get => Get(s_formAction);
        init => Set(s_formAction, value);
    }

    private static readonly PropDescriptor<string> s_formEnctype = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.FormEnctype = s.Value
            : null,
        static (el, s) => el.SetAttribute("formenctype", s));

    public IReadOnlySignal<string>? FormEnctype
    {
        get => Get(s_formEnctype);
        init => Set(s_formEnctype, value);
    }

    private static readonly PropDescriptor<string> s_formMethod = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.FormMethod = s.Value
            : null,
        static (el, s) => el.SetAttribute("formmethod", s));

    public IReadOnlySignal<string>? FormMethod
    {
        get => Get(s_formMethod);
        init => Set(s_formMethod, value);
    }

    private static readonly PropDescriptor<bool> s_formNoValidate = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.FormNoValidate = s.Value
            : null,
        static (el, s) => el.SetBoolean("formnovalidate", s));

    public IReadOnlySignal<bool>? FormNoValidate
    {
        get => Get(s_formNoValidate);
        init => Set(s_formNoValidate, value);
    }

    private static readonly PropDescriptor<string> s_formTarget = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.FormTarget = s.Value
            : null,
        static (el, s) => el.SetAttribute("formtarget", s));

    public IReadOnlySignal<string>? FormTarget
    {
        get => Get(s_formTarget);
        init => Set(s_formTarget, value);
    }
}

public class ButtonEvents : HtmlElementComponentEvents<HTMLButtonElement>
{
}

public class Button() : BaseNonVoidDomComponent<HTMLButtonElement, ButtonProps, ButtonEvents>("button")
{
}
