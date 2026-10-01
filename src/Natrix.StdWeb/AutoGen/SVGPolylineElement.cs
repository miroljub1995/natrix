// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGPolylineElement: global::Natrix.StdWeb.SVGGeometryElement, global::Natrix.JSCore.IJSObjectProxy<SVGPolylineElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGPolylineElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGPolylineElement global::Natrix.JSCore.IJSObjectProxy<SVGPolylineElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGPolylineElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGPointList Points
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGPointList>.Get(JSObject, "points");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGPointList AnimatedPoints
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGPointList>.Get(JSObject, "animatedPoints");
    }
}

#nullable disable