// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGTextPathElement: global::Natrix.StdWeb.SVGTextContentElement, global::Natrix.JSCore.IJSObjectProxy<SVGTextPathElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGTextPathElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGTextPathElement global::Natrix.JSCore.IJSObjectProxy<SVGTextPathElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGTextPathElement>(obj);

    public const ushort TEXTPATH_METHODTYPE_UNKNOWN = 0;

    public const ushort TEXTPATH_METHODTYPE_ALIGN = 1;

    public const ushort TEXTPATH_METHODTYPE_STRETCH = 2;

    public const ushort TEXTPATH_SPACINGTYPE_UNKNOWN = 0;

    public const ushort TEXTPATH_SPACINGTYPE_AUTO = 1;

    public const ushort TEXTPATH_SPACINGTYPE_EXACT = 2;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLength StartOffset
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedLength, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedLength>>(JSObject, "startOffset");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedEnumeration Method
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedEnumeration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedEnumeration>>(JSObject, "method");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedEnumeration Spacing
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedEnumeration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedEnumeration>>(JSObject, "spacing");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedString Href
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedString, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedString>>(JSObject, "href");
    }
}

#nullable disable