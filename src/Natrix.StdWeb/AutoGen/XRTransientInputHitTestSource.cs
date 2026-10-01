// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRTransientInputHitTestSource: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRTransientInputHitTestSource>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRTransientInputHitTestSource(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRTransientInputHitTestSource global::Natrix.JSCore.IJSObjectProxy<XRTransientInputHitTestSource>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRTransientInputHitTestSource>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Cancel()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "cancel", JSObject);
    }
}

#nullable disable