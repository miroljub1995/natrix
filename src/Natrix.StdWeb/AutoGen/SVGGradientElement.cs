// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGGradientElement: global::Natrix.StdWeb.SVGElement
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGGradientElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    public const ushort SVG_SPREADMETHOD_UNKNOWN = 0;

    public const ushort SVG_SPREADMETHOD_PAD = 1;

    public const ushort SVG_SPREADMETHOD_REFLECT = 2;

    public const ushort SVG_SPREADMETHOD_REPEAT = 3;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedEnumeration GradientUnits
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedEnumeration, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "gradientUnits");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedTransformList GradientTransform
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedTransformList, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "gradientTransform");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedEnumeration SpreadMethod
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedEnumeration, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "spreadMethod");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedString Href
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedString, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "href");
    }
}

#nullable disable