// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRHitTestSource: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRHitTestSource>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRHitTestSource(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRHitTestSource global::Natrix.JSCore.IJSObjectProxy<XRHitTestSource>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRHitTestSource>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Cancel()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "cancel", JSObject);
    }
}

#nullable disable