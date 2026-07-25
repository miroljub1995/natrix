// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Viewport: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Viewport(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMRect, global::Natrix.StdWeb.PropertyAccessor>? Segments
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMRect, global::Natrix.StdWeb.PropertyAccessor>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "segments");
    }
}

#nullable disable