// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGViewElement: global::Natrix.StdWeb.SVGElement
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGViewElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedRect ViewBox
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedRect, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "viewBox");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedPreserveAspectRatio PreserveAspectRatio
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedPreserveAspectRatio, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "preserveAspectRatio");
    }
}

#nullable disable