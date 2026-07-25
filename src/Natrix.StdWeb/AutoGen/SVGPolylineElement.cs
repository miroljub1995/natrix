// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGPolylineElement: global::Natrix.StdWeb.SVGGeometryElement
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGPolylineElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGPointList Points
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGPointList, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "points");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGPointList AnimatedPoints
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGPointList, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "animatedPoints");
    }
}

#nullable disable