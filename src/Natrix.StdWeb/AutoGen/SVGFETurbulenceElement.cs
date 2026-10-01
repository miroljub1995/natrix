// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGFETurbulenceElement: global::Natrix.StdWeb.SVGElement, global::Natrix.JSCore.IJSObjectProxy<SVGFETurbulenceElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGFETurbulenceElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGFETurbulenceElement global::Natrix.JSCore.IJSObjectProxy<SVGFETurbulenceElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGFETurbulenceElement>(obj);

    public const ushort SVG_TURBULENCE_TYPE_UNKNOWN = 0;

    public const ushort SVG_TURBULENCE_TYPE_FRACTALNOISE = 1;

    public const ushort SVG_TURBULENCE_TYPE_TURBULENCE = 2;

    public const ushort SVG_STITCHTYPE_UNKNOWN = 0;

    public const ushort SVG_STITCHTYPE_STITCH = 1;

    public const ushort SVG_STITCHTYPE_NOSTITCH = 2;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedNumber BaseFrequencyX
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedNumber>.Get(JSObject, "baseFrequencyX");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedNumber BaseFrequencyY
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedNumber>.Get(JSObject, "baseFrequencyY");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedInteger NumOctaves
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedInteger>.Get(JSObject, "numOctaves");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedNumber Seed
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedNumber>.Get(JSObject, "seed");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedEnumeration StitchTiles
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedEnumeration>.Get(JSObject, "stitchTiles");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedEnumeration Type
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedEnumeration>.Get(JSObject, "type");
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