// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGSymbolElement: global::Natrix.StdWeb.SVGGraphicsElement, global::Natrix.JSCore.IJSObjectProxy<SVGSymbolElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGSymbolElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGSymbolElement global::Natrix.JSCore.IJSObjectProxy<SVGSymbolElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGSymbolElement>(obj);

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