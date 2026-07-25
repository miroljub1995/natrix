// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGFEDistantLightElement: global::Natrix.StdWeb.SVGElement
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGFEDistantLightElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedNumber Azimuth
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedNumber, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "azimuth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedNumber Elevation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedNumber, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "elevation");
    }
}

#nullable disable