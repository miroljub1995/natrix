using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class ButtonProps : GlobalHtmlComponentProps<HTMLButtonElement>
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

    private static PropDescriptor<string>? s_type;

    public IReadOnlySignal<string>? Type
    {
        get => Get(s_type);
        init => Set(ref s_type, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Type = s.Value;
            },
            static (el, s) => el.SetAttribute("type", s)));
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

    private static PropDescriptor<string>? s_formAction;

    public IReadOnlySignal<string>? FormAction
    {
        get => Get(s_formAction);
        init => Set(ref s_formAction, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.FormAction = s.Value;
            },
            static (el, s) => el.SetAttribute("formaction", s)));
    }

    private static PropDescriptor<string>? s_formEnctype;

    public IReadOnlySignal<string>? FormEnctype
    {
        get => Get(s_formEnctype);
        init => Set(ref s_formEnctype, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.FormEnctype = s.Value;
            },
            static (el, s) => el.SetAttribute("formenctype", s)));
    }

    private static PropDescriptor<string>? s_formMethod;

    public IReadOnlySignal<string>? FormMethod
    {
        get => Get(s_formMethod);
        init => Set(ref s_formMethod, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.FormMethod = s.Value;
            },
            static (el, s) => el.SetAttribute("formmethod", s)));
    }

    private static PropDescriptor<bool>? s_formNoValidate;

    public IReadOnlySignal<bool>? FormNoValidate
    {
        get => Get(s_formNoValidate);
        init => Set(ref s_formNoValidate, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.FormNoValidate = s.Value;
            },
            static (el, s) => el.SetBoolean("formnovalidate", s)));
    }

    private static PropDescriptor<string>? s_formTarget;

    public IReadOnlySignal<string>? FormTarget
    {
        get => Get(s_formTarget);
        init => Set(ref s_formTarget, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.FormTarget = s.Value;
            },
            static (el, s) => el.SetAttribute("formtarget", s)));
    }
}

public class ButtonEvents : HtmlElementComponentEvents<HTMLButtonElement>
{
}

public class Button() : BaseNonVoidDomComponent<HTMLButtonElement, ButtonProps, ButtonEvents>("button")
{
}
