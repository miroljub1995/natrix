using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class TimeProps : GlobalHtmlComponentProps<HTMLTimeElement>
{
    private static readonly object s_dateTimeKey = new();

    public IReadOnlySignal<string>? DateTime
    {
        get => Get<IReadOnlySignal<string>>(s_dateTimeKey);
        init => Set(
            s_dateTimeKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.DateTime = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("datetime", (IReadOnlySignal<string>)s));
    }
}

public class TimeEvents : HtmlElementComponentEvents<HTMLTimeElement>
{
}

public class Time() : BaseNonVoidDomComponent<HTMLTimeElement, TimeProps, TimeEvents>("time")
{
}
