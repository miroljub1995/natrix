// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCIceGatherOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCIceGatherOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIceGatherOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCIceGatherOptions global::Natrix.JSCore.IJSObjectProxy<RTCIceGatherOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIceGatherOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceTransportPolicy GatherPolicy
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCIceTransportPolicy, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCIceTransportPolicy>>(JSObject, "gatherPolicy");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.RTCIceTransportPolicy, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCIceTransportPolicy>>(JSObject, "gatherPolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCIceServer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCIceServer>> IceServers
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCIceServer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCIceServer>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCIceServer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCIceServer>>>>(JSObject, "iceServers");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCIceServer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCIceServer>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCIceServer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCIceServer>>>>(JSObject, "iceServers", value);
    }
}

#nullable disable