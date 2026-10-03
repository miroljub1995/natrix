using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class InsProps : GlobalHtmlComponentProps<HTMLModElement>
{
    private static PropDescriptor<string>? s_cite;

    public IReadOnlySignal<string>? Cite
    {
        get => Get(s_cite);
        init => Set(ref s_cite, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Cite = s.Value;
            },
            static (el, s) => el.SetAttribute("cite", s)));
    }

    private static PropDescriptor<string>? s_dateTime;

    public IReadOnlySignal<string>? DateTime
    {
        get => Get(s_dateTime);
        init => Set(ref s_dateTime, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.DateTime = s.Value;
            },
            static (el, s) => el.SetAttribute("datetime", s)));
    }
}

public class InsEvents : HtmlElementComponentEvents<HTMLModElement>
{
}

public class Ins() : BaseNonVoidDomComponent<HTMLModElement, InsProps, InsEvents>("ins")
{
}
