using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class TimeProps : GlobalHtmlComponentProps<HTMLTimeElement>
{
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

public class TimeEvents : HtmlElementComponentEvents<HTMLTimeElement>
{
}

public class Time() : BaseNonVoidDomComponent<HTMLTimeElement, TimeProps, TimeEvents>("time")
{
}
