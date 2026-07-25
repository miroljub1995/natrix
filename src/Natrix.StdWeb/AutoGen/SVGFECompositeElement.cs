// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGFECompositeElement: global::Natrix.StdWeb.SVGElement
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGFECompositeElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    public const ushort SVG_FECOMPOSITE_OPERATOR_UNKNOWN = 0;

    public const ushort SVG_FECOMPOSITE_OPERATOR_OVER = 1;

    public const ushort SVG_FECOMPOSITE_OPERATOR_IN = 2;

    public const ushort SVG_FECOMPOSITE_OPERATOR_OUT = 3;

    public const ushort SVG_FECOMPOSITE_OPERATOR_ATOP = 4;

    public const ushort SVG_FECOMPOSITE_OPERATOR_XOR = 5;

    public const ushort SVG_FECOMPOSITE_OPERATOR_ARITHMETIC = 6;

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
    public global::Natrix.StdWeb.SVGAnimatedEnumeration Operator
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedEnumeration, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "operator");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedNumber K1
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedNumber, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "k1");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedNumber K2
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedNumber, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "k2");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedNumber K3
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedNumber, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "k3");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedNumber K4
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedNumber, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "k4");
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