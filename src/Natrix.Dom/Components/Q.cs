using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class QProps : GlobalHtmlComponentProps<HTMLQuoteElement>
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
}

public class QEvents : HtmlElementComponentEvents<HTMLQuoteElement>
{
}

public class Q() : BaseNonVoidDomComponent<HTMLQuoteElement, QProps, QEvents>("q")
{
}
