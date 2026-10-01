// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGFEDisplacementMapElement: global::Natrix.StdWeb.SVGElement, global::Natrix.JSCore.IJSObjectProxy<SVGFEDisplacementMapElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGFEDisplacementMapElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGFEDisplacementMapElement global::Natrix.JSCore.IJSObjectProxy<SVGFEDisplacementMapElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGFEDisplacementMapElement>(obj);

    public const ushort SVG_CHANNEL_UNKNOWN = 0;

    public const ushort SVG_CHANNEL_R = 1;

    public const ushort SVG_CHANNEL_G = 2;

    public const ushort SVG_CHANNEL_B = 3;

    public const ushort SVG_CHANNEL_A = 4;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedString In1
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedString>.Get(JSObject, "in1");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedString In2
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedString>.Get(JSObject, "in2");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedNumber Scale
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedNumber>.Get(JSObject, "scale");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedEnumeration XChannelSelector
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedEnumeration>.Get(JSObject, "xChannelSelector");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedEnumeration YChannelSelector
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedEnumeration>.Get(JSObject, "yChannelSelector");
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

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedString Result
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedString>.Get(JSObject, "result");
    }
}

#nullable disable