// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGTextPositioningElement: global::Natrix.StdWeb.SVGTextContentElement, global::Natrix.JSCore.IJSObjectProxy<SVGTextPositioningElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGTextPositioningElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGTextPositioningElement global::Natrix.JSCore.IJSObjectProxy<SVGTextPositioningElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGTextPositioningElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLengthList X
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedLengthList>.Get(JSObject, "x");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLengthList Y
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedLengthList>.Get(JSObject, "y");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLengthList Dx
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedLengthList>.Get(JSObject, "dx");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLengthList Dy
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedLengthList>.Get(JSObject, "dy");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedNumberList Rotate
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedNumberList>.Get(JSObject, "rotate");
    }
}

#nullable disable