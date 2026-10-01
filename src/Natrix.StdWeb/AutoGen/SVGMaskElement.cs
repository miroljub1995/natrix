// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGMaskElement: global::Natrix.StdWeb.SVGElement, global::Natrix.JSCore.IJSObjectProxy<SVGMaskElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGMaskElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGMaskElement global::Natrix.JSCore.IJSObjectProxy<SVGMaskElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGMaskElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedEnumeration MaskUnits
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedEnumeration>.Get(JSObject, "maskUnits");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedEnumeration MaskContentUnits
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedEnumeration>.Get(JSObject, "maskContentUnits");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLength X
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedLength>.Get(JSObject, "x");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLength Y
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedLength>.Get(JSObject, "y");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLength Width
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedLength>.Get(JSObject, "width");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLength Height
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedLength>.Get(JSObject, "height");
    }
}

#nullable disable