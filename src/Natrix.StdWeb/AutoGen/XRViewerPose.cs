// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRViewerPose: global::Natrix.StdWeb.XRPose
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRViewerPose(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.XRView, global::Natrix.StdWeb.PropertyAccessor> Views
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.XRView, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "views");
    }
}

#nullable disable