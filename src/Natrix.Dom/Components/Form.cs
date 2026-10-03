using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class FormProps : GlobalHtmlComponentProps<HTMLFormElement>
{
    private static readonly PropDescriptor<string> s_action = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Action = s.Value
            : null,
        static (el, s) => el.SetAttribute("action", s));

    public IReadOnlySignal<string>? Action
    {
        get => Get(s_action);
        init => Set(s_action, value);
    }

    private static readonly PropDescriptor<string> s_autocomplete = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Autocomplete = s.Value
            : null,
        static (el, s) => el.SetAttribute("autocomplete", s));

    public IReadOnlySignal<string>? Autocomplete
    {
        get => Get(s_autocomplete);
        init => Set(s_autocomplete, value);
    }

    private static readonly PropDescriptor<string> s_enctype = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Enctype = s.Value
            : null,
        static (el, s) => el.SetAttribute("enctype", s));

    public IReadOnlySignal<string>? Enctype
    {
        get => Get(s_enctype);
        init => Set(s_enctype, value);
    }

    private static readonly PropDescriptor<string> s_method = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Method = s.Value
            : null,
        static (el, s) => el.SetAttribute("method", s));

    public IReadOnlySignal<string>? Method
    {
        get => Get(s_method);
        init => Set(s_method, value);
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

    private static readonly PropDescriptor<bool> s_noValidate = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.NoValidate = s.Value
            : null,
        static (el, s) => el.SetBoolean("novalidate", s));

    public IReadOnlySignal<bool>? NoValidate
    {
        get => Get(s_noValidate);
        init => Set(s_noValidate, value);
    }

    private static readonly PropDescriptor<string> s_target = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Target = s.Value
            : null,
        static (el, s) => el.SetAttribute("target", s));

    public IReadOnlySignal<string>? Target
    {
        get => Get(s_target);
        init => Set(s_target, value);
    }

    private static readonly PropDescriptor<string> s_rel = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Rel = s.Value
            : null,
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
