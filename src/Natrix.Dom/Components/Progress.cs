using System.Runtime.Versioning;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class ProgressProps : GlobalHtmlComponentProps<HTMLProgressElement>
{
    public IReadOnlySignal<double>? Value { get; init; }
    public IReadOnlySignal<double>? Max { get; init; }

    [SupportedOSPlatform("browser")]
    protected internal override void RegisterClientEffects(Action<Action<HTMLProgressElement>> register)
    {
        base.RegisterClientEffects(register);

        if (Value != null)
        {
            register(el => el.Value = Value.Value);
        }

        if (Max != null)
        {
            register(el => el.Max = Max.Value);
        }
    }

    protected internal override void RegisterServerEffects(SsrElementNode el)
    {
        base.RegisterServerEffects(el);

        if (Value != null)
        {
            el.SetDouble("value", Value);
        }

        if (Max != null)
        {
            el.SetDouble("max", Max);
        }
    }
}

public class ProgressEvents : HtmlElementComponentEvents<HTMLProgressElement>
{
}

public class Progress() : BaseNonVoidDomComponent<HTMLProgressElement, ProgressProps, ProgressEvents>("progress")
{
}
