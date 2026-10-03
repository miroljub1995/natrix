using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class BaseProps : GlobalHtmlComponentProps<HTMLBaseElement>
{
    private static readonly PropDescriptor<string> s_href = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Href = s.Value
            : null,
        static (el, s) => el.SetAttribute("href", s));

    public IReadOnlySignal<string>? Href
    {
        get => Get(s_href);
        init => Set(s_href, value);
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
}

public class BaseEvents : HtmlElementComponentEvents<HTMLBaseElement>
{
}

public class Base() : BaseVoidDomComponent<HTMLBaseElement, BaseProps, BaseEvents>("base")
{
}
