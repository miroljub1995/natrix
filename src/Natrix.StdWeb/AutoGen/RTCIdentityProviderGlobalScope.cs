// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCIdentityProviderGlobalScope: global::Natrix.StdWeb.WorkerGlobalScope
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIdentityProviderGlobalScope(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIdentityProviderRegistrar RtcIdentityProvider
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCIdentityProviderRegistrar, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "rtcIdentityProvider");
    }
}

#nullable disable