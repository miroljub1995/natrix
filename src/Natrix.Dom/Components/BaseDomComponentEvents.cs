using System.Runtime.Versioning;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public abstract class BaseDomComponentEvents<TElement>
    where TElement : Element
{
    [SupportedOSPlatform("browser")]
    protected internal virtual void RegisterClientEffects(Action<Func<TElement, Action>> register)
    {
    }

    [SupportedOSPlatform("browser")]
    protected static void RegisterEventListener<TEvent>(
        Action<Func<TElement, Action>> register,
        Action<TEvent> handler,
        string eventName) where TEvent : Event
    {
        var listener = new EventListener(ev => { handler((TEvent)ev); });

        register(el =>
        {
            el.AddEventListener(eventName, listener);
            return () => el.RemoveEventListener(eventName, listener);
        });
    }
}
