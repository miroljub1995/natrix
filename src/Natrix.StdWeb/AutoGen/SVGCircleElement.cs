// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGCircleElement: global::Natrix.StdWeb.SVGGeometryElement
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGCircleElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLength Cx
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedLength, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "cx");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLength Cy
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedLength, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "cy");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedLength R
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedLength, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "r");
    }
}

#nullable disable