// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGAnimatedTransformList: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SVGAnimatedTransformList>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGAnimatedTransformList(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGAnimatedTransformList global::Natrix.JSCore.IJSObjectProxy<SVGAnimatedTransformList>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGAnimatedTransformList>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGTransformList BaseVal
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGTransformList>.Get(JSObject, "baseVal");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGTransformList AnimVal
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGTransformList>.Get(JSObject, "animVal");
    }
}

#nullable disable