using System.Runtime.Versioning;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public abstract class BaseDomComponentProps<TElement>
    where TElement : Element
{
    [SupportedOSPlatform("browser")]
    protected internal virtual void RegisterClientEffects(Action<Action<TElement>> register)
    {
    }

    protected internal virtual void RegisterServerEffects(SsrElementNode el)
    {
    }
}