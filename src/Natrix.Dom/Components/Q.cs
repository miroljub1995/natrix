using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class QProps : GlobalHtmlComponentProps<HTMLQuoteElement>
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
}

public class QEvents : HtmlElementComponentEvents<HTMLQuoteElement>
{
}

public class Q() : BaseNonVoidDomComponent<HTMLQuoteElement, QProps, QEvents>("q")
{
}
