using System.Runtime.Versioning;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class InsProps : GlobalHtmlComponentProps<HTMLModElement>
{
    public IReadOnlySignal<string>? Cite { get; init; }
    public IReadOnlySignal<string>? DateTime { get; init; }

    [SupportedOSPlatform("browser")]
    protected internal override void RegisterClientEffects(Action<Action<HTMLModElement>> register)
    {
        base.RegisterClientEffects(register);

        if (Cite != null)
        {
            register(el => el.Cite = Cite.Value);
        }

        if (DateTime != null)
        {
            register(el => el.DateTime = DateTime.Value);
        }
    }

    protected internal override void RegisterServerEffects(SsrElementNode el)
    {
        base.RegisterServerEffects(el);

        if (Cite != null)
        {
            el.SetAttribute("cite", Cite);
        }

        if (DateTime != null)
        {
            el.SetAttribute("datetime", DateTime);
        }
    }
}

public class InsEvents : HtmlElementComponentEvents<HTMLModElement>
{
}

public class Ins() : BaseNonVoidDomComponent<HTMLModElement, InsProps, InsEvents>("ins")
{
}
