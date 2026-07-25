// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGAnimatedNumber: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGAnimatedNumber(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float BaseVal
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "baseVal");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "baseVal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float AnimVal
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "animVal");
    }
}

#nullable disable