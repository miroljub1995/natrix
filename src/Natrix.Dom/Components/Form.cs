using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class FormProps : GlobalHtmlComponentProps<HTMLFormElement>
{
    private static readonly PropDescriptor<string> s_action = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Action = s.Value;
        },
        static (el, s) => el.SetAttribute("action", s));

    public IReadOnlySignal<string>? Action
    {
        get => Get(s_action);
        init => Set(s_action, value);
    }

    private static readonly PropDescriptor<string> s_autocomplete = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Autocomplete = s.Value;
        },
        static (el, s) => el.SetAttribute("autocomplete", s));

    public IReadOnlySignal<string>? Autocomplete
    {
        get => Get(s_autocomplete);
        init => Set(s_autocomplete, value);
    }

    private static readonly PropDescriptor<string> s_enctype = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Enctype = s.Value;
        },
        static (el, s) => el.SetAttribute("enctype", s));

    public IReadOnlySignal<string>? Enctype
    {
        get => Get(s_enctype);
        init => Set(s_enctype, value);
    }

    private static readonly PropDescriptor<string> s_method = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Method = s.Value;
        },
        static (el, s) => el.SetAttribute("method", s));

    public IReadOnlySignal<string>? Method
    {
        get => Get(s_method);
        init => Set(s_method, value);
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

    private static readonly PropDescriptor<bool> s_noValidate = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.NoValidate = s.Value;
        },
        static (el, s) => el.SetBoolean("novalidate", s));

    public IReadOnlySignal<bool>? NoValidate
    {
        get => Get(s_noValidate);
        init => Set(s_noValidate, value);
    }

    private static readonly PropDescriptor<string> s_target = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Target = s.Value;
        },
        static (el, s) => el.SetAttribute("target", s));

    public IReadOnlySignal<string>? Target
    {
        get => Get(s_target);
        init => Set(s_target, value);
    }

    private static readonly PropDescriptor<string> s_rel = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Rel = s.Value;
        },
        static (el, s) => el.SetAttribute("rel", s));

    public IReadOnlySignal<string>? Rel
    {
        get => Get(s_rel);
        init => Set(s_rel, value);
    }
}

public class FormEvents : HtmlElementComponentEvents<HTMLFormElement>
{
}

public class Form() : BaseNonVoidDomComponent<HTMLFormElement, FormProps, FormEvents>("form")
{
}
