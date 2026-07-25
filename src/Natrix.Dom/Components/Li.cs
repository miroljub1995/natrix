using System.Runtime.Versioning;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class LiProps : GlobalHtmlComponentProps<HTMLLIElement>
{
    public IReadOnlySignal<int>? Value { get; init; }

    [SupportedOSPlatform("browser")]
    protected internal override void RegisterClientEffects(Action<Action<HTMLLIElement>> register)
    {
        base.RegisterClientEffects(register);

        if (Value != null)
        {
            register(el => el.Value = Value.Value);
        }
    }

    protected internal override void RegisterServerEffects(SsrElementNode el)
    {
        base.RegisterServerEffects(el);

        if (Value != null)
        {
            el.SetInt("value", Value);
        }
    }
}

public class LiEvents : HtmlElementComponentEvents<HTMLLIElement>
{
}

public class Li() : BaseNonVoidDomComponent<HTMLLIElement, LiProps, LiEvents>("li")
{
}
