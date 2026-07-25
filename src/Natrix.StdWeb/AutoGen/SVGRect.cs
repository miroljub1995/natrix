// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGRect: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGRect(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float X
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "x");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "x", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Y
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "y");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "y", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Width
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "width");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Height
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "height");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "height", value);
    }
}

#nullable disable