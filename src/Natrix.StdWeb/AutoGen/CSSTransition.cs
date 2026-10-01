// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSTransition: global::Natrix.StdWeb.Animation, global::Natrix.JSCore.IJSObjectProxy<CSSTransition>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSTransition(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSTransition global::Natrix.JSCore.IJSObjectProxy<CSSTransition>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSTransition>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string TransitionProperty
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "transitionProperty");
    }
}

#nullable disable