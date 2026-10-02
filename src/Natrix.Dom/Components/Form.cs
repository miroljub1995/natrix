using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class FormProps : GlobalHtmlComponentProps<HTMLFormElement>
{
    private static readonly object s_actionKey = new();

    public IReadOnlySignal<string>? Action
    {
        get => Get<IReadOnlySignal<string>>(s_actionKey);
        init => Set(
            s_actionKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Action = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("action", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_autocompleteKey = new();

    public IReadOnlySignal<string>? Autocomplete
    {
        get => Get<IReadOnlySignal<string>>(s_autocompleteKey);
        init => Set(
            s_autocompleteKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Autocomplete = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("autocomplete", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_enctypeKey = new();

    public IReadOnlySignal<string>? Enctype
    {
        get => Get<IReadOnlySignal<string>>(s_enctypeKey);
        init => Set(
            s_enctypeKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Enctype = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("enctype", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_methodKey = new();

    public IReadOnlySignal<string>? Method
    {
        get => Get<IReadOnlySignal<string>>(s_methodKey);
        init => Set(
            s_methodKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Method = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("method", (IReadOnlySignal<string>)s));
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

    private static readonly object s_noValidateKey = new();

    public IReadOnlySignal<bool>? NoValidate
    {
        get => Get<IReadOnlySignal<bool>>(s_noValidateKey);
        init => Set(
            s_noValidateKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.NoValidate = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("novalidate", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_targetKey = new();

    public IReadOnlySignal<string>? Target
    {
        get => Get<IReadOnlySignal<string>>(s_targetKey);
        init => Set(
            s_targetKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Target = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("target", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_relKey = new();

    public IReadOnlySignal<string>? Rel
    {
        get => Get<IReadOnlySignal<string>>(s_relKey);
        init => Set(
            s_relKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Rel = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("rel", (IReadOnlySignal<string>)s));
    }
}

public class FormEvents : HtmlElementComponentEvents<HTMLFormElement>
{
}

public class Form() : BaseNonVoidDomComponent<HTMLFormElement, FormProps, FormEvents>("form")
{
}
