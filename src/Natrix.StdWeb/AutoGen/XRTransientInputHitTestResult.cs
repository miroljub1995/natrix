// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRTransientInputHitTestResult: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRTransientInputHitTestResult>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRTransientInputHitTestResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRTransientInputHitTestResult global::Natrix.JSCore.IJSObjectProxy<XRTransientInputHitTestResult>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRTransientInputHitTestResult>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRInputSource InputSource
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRInputSource, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRInputSource>>(JSObject, "inputSource");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.XRHitTestResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRHitTestResult>> Results
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.XRHitTestResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRHitTestResult>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.XRHitTestResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRHitTestResult>>>>(JSObject, "results");
    }
}

#nullable disable