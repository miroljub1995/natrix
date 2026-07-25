using System.Runtime.Versioning;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class DetailsProps : GlobalHtmlComponentProps<HTMLDetailsElement>
{
    public IReadOnlySignal<string>? Name { get; init; }
    public IReadOnlySignal<bool>? Open { get; init; }

    [SupportedOSPlatform("browser")]
    protected internal override void RegisterClientEffects(Action<Action<HTMLDetailsElement>> register)
    {
        base.RegisterClientEffects(register);

        if (Name != null)
        {
            register(el => el.Name = Name.Value);
        }

        if (Open != null)
        {
            register(el => el.Open = Open.Value);
        }
    }

    protected internal override void RegisterServerEffects(SsrElementNode el)
    {
        base.RegisterServerEffects(el);

        if (Name != null)
        {
            el.SetAttribute("name", Name);
        }

        if (Open != null)
        {
            el.SetBoolean("open", Open);
        }
    }
}

public class DetailsEvents : HtmlElementComponentEvents<HTMLDetailsElement>
{
}

public class Details() : BaseNonVoidDomComponent<HTMLDetailsElement, DetailsProps, DetailsEvents>("details")
{
}
