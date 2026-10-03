using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class OutputProps : GlobalHtmlComponentProps<HTMLOutputElement>
{
    private static readonly PropDescriptor<string> s_htmlFor = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.HtmlFor.Value = s.Value
            : null,
        static (el, s) => el.SetAttribute("for", s));

    public IReadOnlySignal<string>? HtmlFor
    {
        get => Get(s_htmlFor);
        init => Set(s_htmlFor, value);
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

    private static readonly PropDescriptor<string> s_defaultValue = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.DefaultValue = s.Value
            : null,
        static (el, s) => el.SetAttribute("value", s));

    public IReadOnlySignal<string>? DefaultValue
    {
        get => Get(s_defaultValue);
        init => Set(s_defaultValue, value);
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

public class OutputEvents : HtmlElementComponentEvents<HTMLOutputElement>
{
}

public class Output() : BaseNonVoidDomComponent<HTMLOutputElement, OutputProps, OutputEvents>("output")
{
}
