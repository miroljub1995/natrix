// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGComponentTransferFunctionElement: global::Natrix.StdWeb.SVGElement, global::Natrix.JSCore.IJSObjectProxy<SVGComponentTransferFunctionElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGComponentTransferFunctionElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGComponentTransferFunctionElement global::Natrix.JSCore.IJSObjectProxy<SVGComponentTransferFunctionElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGComponentTransferFunctionElement>(obj);

    public const ushort SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN = 0;

    public const ushort SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY = 1;

    public const ushort SVG_FECOMPONENTTRANSFER_TYPE_TABLE = 2;

    public const ushort SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE = 3;

    public const ushort SVG_FECOMPONENTTRANSFER_TYPE_LINEAR = 4;

    public const ushort SVG_FECOMPONENTTRANSFER_TYPE_GAMMA = 5;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedEnumeration Type
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedEnumeration>.Get(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedNumberList TableValues
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedNumberList>.Get(JSObject, "tableValues");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedNumber Slope
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedNumber>.Get(JSObject, "slope");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedNumber Intercept
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedNumber>.Get(JSObject, "intercept");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedNumber Amplitude
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedNumber>.Get(JSObject, "amplitude");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedNumber Exponent
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedNumber>.Get(JSObject, "exponent");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedNumber Offset
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedNumber>.Get(JSObject, "offset");
    }
}

#nullable disable