// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGTextPathElement: global::Natrix.StdWeb.SVGTextContentElement
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGTextPathElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    public const ushort TEXTPATH_METHODTYPE_UNKNOWN = 0;

    public const ushort TEXTPATH_METHODTYPE_ALIGN = 1;

    public const ushort TEXTPATH_METHODTYPE_STRETCH = 2;

    public const ushort TEXTPATH_SPACINGTYPE_UNKNOWN = 0;

    public const ushort TEXTPATH_SPACINGTYPE_AUTO = 1;

    public const ushort TEXTPATH_SPACINGTYPE_EXACT = 2;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLength StartOffset
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedLength, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "startOffset");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedEnumeration Method
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedEnumeration, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "method");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedEnumeration Spacing
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedEnumeration, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "spacing");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedString Href
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedString, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "href");
    }
}

#nullable disable