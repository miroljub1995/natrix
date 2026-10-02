using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class OutputProps : GlobalHtmlComponentProps<HTMLOutputElement>
{
    private static readonly object s_htmlForKey = new();

    public IReadOnlySignal<string>? HtmlFor
    {
        get => Get<IReadOnlySignal<string>>(s_htmlForKey);
        init => Set(
            s_htmlForKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.HtmlFor.Value = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("for", (IReadOnlySignal<string>)s));
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

    private static readonly object s_defaultValueKey = new();

    public IReadOnlySignal<string>? DefaultValue
    {
        get => Get<IReadOnlySignal<string>>(s_defaultValueKey);
        init => Set(
            s_defaultValueKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.DefaultValue = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("value", (IReadOnlySignal<string>)s));
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
}

public class OutputEvents : HtmlElementComponentEvents<HTMLOutputElement>
{
}

public class Output() : BaseNonVoidDomComponent<HTMLOutputElement, OutputProps, OutputEvents>("output")
{
}
