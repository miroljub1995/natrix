// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCConfiguration: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCConfiguration>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCConfiguration(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCConfiguration global::Natrix.JSCore.IJSObjectProxy<RTCConfiguration>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCConfiguration(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PeerIdentity
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "peerIdentity");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "peerIdentity", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCIceServer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCIceServer>> IceServers
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCIceServer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCIceServer>>>.Get(JSObject, "iceServers");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCIceServer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCIceServer>>>.Set(JSObject, "iceServers", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceTransportPolicy IceTransportPolicy
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCIceTransportPolicy>.Get(JSObject, "iceTransportPolicy");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCIceTransportPolicy>.Set(JSObject, "iceTransportPolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCBundlePolicy BundlePolicy
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCBundlePolicy>.Get(JSObject, "bundlePolicy");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCBundlePolicy>.Set(JSObject, "bundlePolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCRtcpMuxPolicy RtcpMuxPolicy
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCRtcpMuxPolicy>.Get(JSObject, "rtcpMuxPolicy");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCRtcpMuxPolicy>.Set(JSObject, "rtcpMuxPolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCCertificate, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCCertificate>> Certificates
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCCertificate, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCCertificate>>>.Get(JSObject, "certificates");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCCertificate, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCCertificate>>>.Set(JSObject, "certificates", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte IceCandidatePoolSize
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "iceCandidatePoolSize");
        set => global::Natrix.JSCore.Generics.ByteAccessor.Set(JSObject, "iceCandidatePoolSize", value);
    }
}

#nullable disable