using System.Runtime.Versioning;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class QProps : GlobalHtmlComponentProps<HTMLQuoteElement>
{
    public IReadOnlySignal<string>? Cite { get; init; }

    [SupportedOSPlatform("browser")]
    protected internal override void RegisterClientEffects(Action<Action<HTMLQuoteElement>> register)
    {
        base.RegisterClientEffects(register);

        if (Cite != null)
        {
            register(el => el.Cite = Cite.Value);
        }
    }

    protected internal override void RegisterServerEffects(SsrElementNode el)
    {
        base.RegisterServerEffects(el);

        if (Cite != null)
        {
            el.SetAttribute("cite", Cite);
        }
    }
}

public class QEvents : HtmlElementComponentEvents<HTMLQuoteElement>
{
}

public class Q() : BaseNonVoidDomComponent<HTMLQuoteElement, QProps, QEvents>("q")
{
}
