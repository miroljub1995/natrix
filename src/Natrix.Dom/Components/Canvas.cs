using System.Runtime.Versioning;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class CanvasProps : GlobalHtmlComponentProps<HTMLCanvasElement>
{
    public IReadOnlySignal<uint>? Width { get; init; }
    public IReadOnlySignal<uint>? Height { get; init; }

    [SupportedOSPlatform("browser")]
    protected internal override void RegisterClientEffects(Action<Action<HTMLCanvasElement>> register)
    {
        base.RegisterClientEffects(register);

        if (Width != null)
        {
            register(el => el.Width = Width.Value);
        }

        if (Height != null)
        {
            register(el => el.Height = Height.Value);
        }
    }

    protected internal override void RegisterServerEffects(SsrElementNode el)
    {
        base.RegisterServerEffects(el);

        if (Width != null)
        {
            el.SetUInt("width", Width);
        }

        if (Height != null)
        {
            el.SetUInt("height", Height);
        }
    }
}

public class CanvasEvents : HtmlElementComponentEvents<HTMLCanvasElement>
{
}

public class Canvas() : BaseNonVoidDomComponent<HTMLCanvasElement, CanvasProps, CanvasEvents>("canvas")
{
}
