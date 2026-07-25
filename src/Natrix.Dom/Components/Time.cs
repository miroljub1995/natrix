using System.Runtime.Versioning;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class TimeProps : GlobalHtmlComponentProps<HTMLTimeElement>
{
    public IReadOnlySignal<string>? DateTime { get; init; }

    [SupportedOSPlatform("browser")]
    protected internal override void RegisterClientEffects(Action<Action<HTMLTimeElement>> register)
    {
        base.RegisterClientEffects(register);

        if (DateTime != null)
        {
            register(el => el.DateTime = DateTime.Value);
        }
    }

    protected internal override void RegisterServerEffects(SsrElementNode el)
    {
        base.RegisterServerEffects(el);

        if (DateTime != null)
        {
            el.SetAttribute("datetime", DateTime);
        }
    }
}

public class TimeEvents : HtmlElementComponentEvents<HTMLTimeElement>
{
}

public class Time() : BaseNonVoidDomComponent<HTMLTimeElement, TimeProps, TimeEvents>("time")
{
}
