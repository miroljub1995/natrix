// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGAnimatedLength: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SVGAnimatedLength>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGAnimatedLength(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGAnimatedLength global::Natrix.JSCore.IJSObjectProxy<SVGAnimatedLength>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGAnimatedLength>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGLength BaseVal
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGLength>.Get(JSObject, "baseVal");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGLength AnimVal
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGLength>.Get(JSObject, "animVal");
    }
}

#nullable disable