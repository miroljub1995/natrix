// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGViewElement: global::Natrix.StdWeb.SVGElement, global::Natrix.JSCore.IJSObjectProxy<SVGViewElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGViewElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGViewElement global::Natrix.JSCore.IJSObjectProxy<SVGViewElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGViewElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedRect ViewBox
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedRect>.Get(JSObject, "viewBox");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedPreserveAspectRatio PreserveAspectRatio
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedPreserveAspectRatio>.Get(JSObject, "preserveAspectRatio");
    }
}

#nullable disable