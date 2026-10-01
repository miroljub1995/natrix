// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRSubImage: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRSubImage>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRSubImage(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRSubImage global::Natrix.JSCore.IJSObjectProxy<XRSubImage>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRSubImage>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRViewport Viewport
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRViewport, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRViewport>>(JSObject, "viewport");
    }
}

#nullable disable