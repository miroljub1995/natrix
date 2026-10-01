// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGCircleElement: global::Natrix.StdWeb.SVGGeometryElement, global::Natrix.JSCore.IJSObjectProxy<SVGCircleElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGCircleElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGCircleElement global::Natrix.JSCore.IJSObjectProxy<SVGCircleElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGCircleElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLength Cx
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedLength>.Get(JSObject, "cx");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLength Cy
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedLength>.Get(JSObject, "cy");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLength R
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedLength>.Get(JSObject, "r");
    }
}

#nullable disable