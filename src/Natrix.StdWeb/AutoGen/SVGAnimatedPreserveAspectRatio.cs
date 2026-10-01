// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGAnimatedPreserveAspectRatio: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SVGAnimatedPreserveAspectRatio>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGAnimatedPreserveAspectRatio(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGAnimatedPreserveAspectRatio global::Natrix.JSCore.IJSObjectProxy<SVGAnimatedPreserveAspectRatio>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGAnimatedPreserveAspectRatio>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGPreserveAspectRatio BaseVal
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGPreserveAspectRatio, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGPreserveAspectRatio>>(JSObject, "baseVal");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGPreserveAspectRatio AnimVal
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGPreserveAspectRatio, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGPreserveAspectRatio>>(JSObject, "animVal");
    }
}

#nullable disable