using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class OutputProps : GlobalHtmlComponentProps<HTMLOutputElement>
{
    private static PropDescriptor<string>? s_htmlFor;

    public IReadOnlySignal<string>? HtmlFor
    {
        get => Get(s_htmlFor);
        init => Set(ref s_htmlFor, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.HtmlFor.Value = s.Value;
            },
            static (el, s) => el.SetAttribute("for", s)));
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

    private static PropDescriptor<string>? s_defaultValue;

    public IReadOnlySignal<string>? DefaultValue
    {
        get => Get(s_defaultValue);
        init => Set(ref s_defaultValue, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.DefaultValue = s.Value;
            },
            static (el, s) => el.SetAttribute("value", s)));
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
}

public class OutputEvents : HtmlElementComponentEvents<HTMLOutputElement>
{
}

public class Output() : BaseNonVoidDomComponent<HTMLOutputElement, OutputProps, OutputEvents>("output")
{
}
