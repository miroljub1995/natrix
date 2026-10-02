using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class InsProps : GlobalHtmlComponentProps<HTMLModElement>
{
    private static readonly object s_citeKey = new();

    public IReadOnlySignal<string>? Cite
    {
        get => Get<IReadOnlySignal<string>>(s_citeKey);
        init => Set(
            s_citeKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Cite = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("cite", (IReadOnlySignal<string>)s));
    }

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

public class InsEvents : HtmlElementComponentEvents<HTMLModElement>
{
}

public class Ins() : BaseNonVoidDomComponent<HTMLModElement, InsProps, InsEvents>("ins")
{
}
