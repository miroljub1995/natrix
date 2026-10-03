using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class InsProps : GlobalHtmlComponentProps<HTMLModElement>
{
    private static readonly PropDescriptor<string> s_cite = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Cite = s.Value
            : null,
        static (el, s) => el.SetAttribute("cite", s));

    public IReadOnlySignal<string>? Cite
    {
        get => Get(s_cite);
        init => Set(s_cite, value);
    }

    private static readonly PropDescriptor<string> s_dateTime = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.DateTime = s.Value
            : null,
        static (el, s) => el.SetAttribute("datetime", s));

    public IReadOnlySignal<string>? DateTime
    {
        get => Get(s_dateTime);
        init => Set(s_dateTime, value);
    }
}

public class InsEvents : HtmlElementComponentEvents<HTMLModElement>
{
}

public class Ins() : BaseNonVoidDomComponent<HTMLModElement, InsProps, InsEvents>("ins")
{
}
