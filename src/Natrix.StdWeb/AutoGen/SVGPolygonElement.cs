// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGPolygonElement: global::Natrix.StdWeb.SVGGeometryElement, global::Natrix.JSCore.IJSObjectProxy<SVGPolygonElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGPolygonElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGPolygonElement global::Natrix.JSCore.IJSObjectProxy<SVGPolygonElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGPolygonElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGPointList Points
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGPointList, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGPointList>>(JSObject, "points");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGPointList AnimatedPoints
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGPointList, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGPointList>>(JSObject, "animatedPoints");
    }
}

#nullable disable