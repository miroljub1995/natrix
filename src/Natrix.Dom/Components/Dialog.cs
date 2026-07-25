using System.Runtime.Versioning;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class DialogProps : GlobalHtmlComponentProps<HTMLDialogElement>
{
    public IReadOnlySignal<bool>? Open { get; init; }

    [SupportedOSPlatform("browser")]
    protected internal override void RegisterClientEffects(Action<Action<HTMLDialogElement>> register)
    {
        base.RegisterClientEffects(register);

        if (Open != null)
        {
            register(el => el.Open = Open.Value);
        }
    }

    protected internal override void RegisterServerEffects(SsrElementNode el)
    {
        base.RegisterServerEffects(el);

        if (Open != null)
        {
            el.SetBoolean("open", Open);
        }
    }
}

public class DialogEvents : HtmlElementComponentEvents<HTMLDialogElement>
{
}

public class Dialog() : BaseNonVoidDomComponent<HTMLDialogElement, DialogProps, DialogEvents>("dialog")
{
}
