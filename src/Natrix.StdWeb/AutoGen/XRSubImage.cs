// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRSubImage: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRSubImage(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRViewport Viewport
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRViewport, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "viewport");
    }
}

#nullable disable