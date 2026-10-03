using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class FormProps : GlobalHtmlComponentProps<HTMLFormElement>
{
    private static PropDescriptor<string>? s_action;

    public IReadOnlySignal<string>? Action
    {
        get => Get(s_action);
        init => Set(ref s_action, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Action = s.Value;
            },
            static (el, s) => el.SetAttribute("action", s)));
    }

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

    private static PropDescriptor<string>? s_enctype;

    public IReadOnlySignal<string>? Enctype
    {
        get => Get(s_enctype);
        init => Set(ref s_enctype, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Enctype = s.Value;
            },
            static (el, s) => el.SetAttribute("enctype", s)));
    }

    private static PropDescriptor<string>? s_method;

    public IReadOnlySignal<string>? Method
    {
        get => Get(s_method);
        init => Set(ref s_method, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Method = s.Value;
            },
            static (el, s) => el.SetAttribute("method", s)));
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

    private static PropDescriptor<bool>? s_noValidate;

    public IReadOnlySignal<bool>? NoValidate
    {
        get => Get(s_noValidate);
        init => Set(ref s_noValidate, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.NoValidate = s.Value;
            },
            static (el, s) => el.SetBoolean("novalidate", s)));
    }

    private static PropDescriptor<string>? s_target;

    public IReadOnlySignal<string>? Target
    {
        get => Get(s_target);
        init => Set(ref s_target, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Target = s.Value;
            },
            static (el, s) => el.SetAttribute("target", s)));
    }

    private static PropDescriptor<string>? s_rel;

    public IReadOnlySignal<string>? Rel
    {
        get => Get(s_rel);
        init => Set(ref s_rel, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Rel = s.Value;
            },
            static (el, s) => el.SetAttribute("rel", s)));
    }
}

public class FormEvents : HtmlElementComponentEvents<HTMLFormElement>
{
}

public class Form() : BaseNonVoidDomComponent<HTMLFormElement, FormProps, FormEvents>("form")
{
}
