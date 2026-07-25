// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGFEBlendElement: global::Natrix.StdWeb.SVGElement
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGFEBlendElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    public const ushort SVG_FEBLEND_MODE_UNKNOWN = 0;

    public const ushort SVG_FEBLEND_MODE_NORMAL = 1;

    public const ushort SVG_FEBLEND_MODE_MULTIPLY = 2;

    public const ushort SVG_FEBLEND_MODE_SCREEN = 3;

    public const ushort SVG_FEBLEND_MODE_DARKEN = 4;

    public const ushort SVG_FEBLEND_MODE_LIGHTEN = 5;

    public const ushort SVG_FEBLEND_MODE_OVERLAY = 6;

    public const ushort SVG_FEBLEND_MODE_COLOR_DODGE = 7;

    public const ushort SVG_FEBLEND_MODE_COLOR_BURN = 8;

    public const ushort SVG_FEBLEND_MODE_HARD_LIGHT = 9;

    public const ushort SVG_FEBLEND_MODE_SOFT_LIGHT = 10;

    public const ushort SVG_FEBLEND_MODE_DIFFERENCE = 11;

    public const ushort SVG_FEBLEND_MODE_EXCLUSION = 12;

    public const ushort SVG_FEBLEND_MODE_HUE = 13;

    public const ushort SVG_FEBLEND_MODE_SATURATION = 14;

    public const ushort SVG_FEBLEND_MODE_COLOR = 15;

    public const ushort SVG_FEBLEND_MODE_LUMINOSITY = 16;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedString In1
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedString, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "in1");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedString In2
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedString, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "in2");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedEnumeration Mode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedEnumeration, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "mode");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLength X
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedLength, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "x");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLength Y
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedLength, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "y");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLength Width
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedLength, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "width");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLength Height
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedLength, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "height");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedString Result
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedString, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "result");
    }
}

#nullable disable