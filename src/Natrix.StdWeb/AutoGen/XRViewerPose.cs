// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRViewerPose: global::Natrix.StdWeb.XRPose, global::Natrix.JSCore.IJSObjectProxy<XRViewerPose>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRViewerPose(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRViewerPose global::Natrix.JSCore.IJSObjectProxy<XRViewerPose>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRViewerPose>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.XRView, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRView>> Views
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.XRView, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRView>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.XRView, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRView>>>>(JSObject, "views");
    }
}

#nullable disable