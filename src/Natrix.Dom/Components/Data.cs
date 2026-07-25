using System.Runtime.Versioning;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class DataProps : GlobalHtmlComponentProps<HTMLDataElement>
{
    public IReadOnlySignal<string>? Value { get; init; }

    [SupportedOSPlatform("browser")]
    protected internal override void RegisterClientEffects(Action<Action<HTMLDataElement>> register)
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
            el.SetAttribute("value", Value);
        }
    }
}

public class DataEvents : HtmlElementComponentEvents<HTMLDataElement>
{
}

public class Data() : BaseNonVoidDomComponent<HTMLDataElement, DataProps, DataEvents>("data")
{
}
