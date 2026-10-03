using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class DelProps : GlobalHtmlComponentProps<HTMLModElement>
{
    private static readonly PropDescriptor<string> s_cite = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Cite = s.Value;
        },
        static (el, s) => el.SetAttribute("cite", s));

    public IReadOnlySignal<string>? Cite
    {
        get => Get(s_cite);
        init => Set(s_cite, value);
    }

    private static readonly PropDescriptor<string> s_dateTime = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.DateTime = s.Value;
        },
        static (el, s) => el.SetAttribute("datetime", s));

    public IReadOnlySignal<string>? DateTime
    {
        get => Get(s_dateTime);
        init => Set(s_dateTime, value);
    }
}

public class DelEvents : HtmlElementComponentEvents<HTMLModElement>
{
}

public class Del() : BaseNonVoidDomComponent<HTMLModElement, DelProps, DelEvents>("del")
{
}
