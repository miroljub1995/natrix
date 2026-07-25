// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGClipPathElement: global::Natrix.StdWeb.SVGElement
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGClipPathElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedEnumeration ClipPathUnits
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedEnumeration, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "clipPathUnits");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedTransformList Transform
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedTransformList, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "transform");
    }
}

#nullable disable