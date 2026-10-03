using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class ButtonProps : GlobalHtmlComponentProps<HTMLButtonElement>
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

    private static readonly PropDescriptor<string> s_name = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Name = s.Value;
        },
        static (el, s) => el.SetAttribute("name", s));

    public IReadOnlySignal<string>? Name
    {
        get => Get(s_name);
        init => Set(s_name, value);
    }

    private static readonly PropDescriptor<string> s_type = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Type = s.Value;
        },
        static (el, s) => el.SetAttribute("type", s));

    public IReadOnlySignal<string>? Type
    {
        get => Get(s_type);
        init => Set(s_type, value);
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

    private static readonly PropDescriptor<string> s_formAction = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.FormAction = s.Value;
        },
        static (el, s) => el.SetAttribute("formaction", s));

    public IReadOnlySignal<string>? FormAction
    {
        get => Get(s_formAction);
        init => Set(s_formAction, value);
    }

    private static readonly PropDescriptor<string> s_formEnctype = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.FormEnctype = s.Value;
        },
        static (el, s) => el.SetAttribute("formenctype", s));

    public IReadOnlySignal<string>? FormEnctype
    {
        get => Get(s_formEnctype);
        init => Set(s_formEnctype, value);
    }

    private static readonly PropDescriptor<string> s_formMethod = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.FormMethod = s.Value;
        },
        static (el, s) => el.SetAttribute("formmethod", s));

    public IReadOnlySignal<string>? FormMethod
    {
        get => Get(s_formMethod);
        init => Set(s_formMethod, value);
    }

    private static readonly PropDescriptor<bool> s_formNoValidate = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.FormNoValidate = s.Value;
        },
        static (el, s) => el.SetBoolean("formnovalidate", s));

    public IReadOnlySignal<bool>? FormNoValidate
    {
        get => Get(s_formNoValidate);
        init => Set(s_formNoValidate, value);
    }

    private static readonly PropDescriptor<string> s_formTarget = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.FormTarget = s.Value;
        },
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
