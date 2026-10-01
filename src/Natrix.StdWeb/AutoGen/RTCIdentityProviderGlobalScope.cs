// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCIdentityProviderGlobalScope: global::Natrix.StdWeb.WorkerGlobalScope, global::Natrix.JSCore.IJSObjectProxy<RTCIdentityProviderGlobalScope>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIdentityProviderGlobalScope(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCIdentityProviderGlobalScope global::Natrix.JSCore.IJSObjectProxy<RTCIdentityProviderGlobalScope>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<RTCIdentityProviderGlobalScope>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIdentityProviderRegistrar RtcIdentityProvider
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCIdentityProviderRegistrar, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCIdentityProviderRegistrar>>(JSObject, "rtcIdentityProvider");
    }
}

#nullable disable