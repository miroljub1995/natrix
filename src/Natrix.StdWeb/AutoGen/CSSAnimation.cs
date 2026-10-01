// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSAnimation: global::Natrix.StdWeb.Animation, global::Natrix.JSCore.IJSObjectProxy<CSSAnimation>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSAnimation(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSAnimation global::Natrix.JSCore.IJSObjectProxy<CSSAnimation>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSAnimation>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string AnimationName
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "animationName");
    }
}

#nullable disable