// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGStopElement: global::Natrix.StdWeb.SVGElement
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGStopElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedNumber Offset
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.SVGAnimatedNumber, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "offset");
    }
}

#nullable disable