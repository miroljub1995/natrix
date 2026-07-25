// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCConfiguration: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCConfiguration(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCConfiguration(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCIceServer, global::Natrix.StdWeb.PropertyAccessor> IceServers
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCIceServer, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "iceServers");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCIceServer, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "iceServers", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceTransportPolicy IceTransportPolicy
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCIceTransportPolicy, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "iceTransportPolicy");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.RTCIceTransportPolicy, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "iceTransportPolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCBundlePolicy BundlePolicy
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCBundlePolicy, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "bundlePolicy");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.RTCBundlePolicy, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "bundlePolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCRtcpMuxPolicy RtcpMuxPolicy
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCRtcpMuxPolicy, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "rtcpMuxPolicy");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.RTCRtcpMuxPolicy, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "rtcpMuxPolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCCertificate, global::Natrix.StdWeb.PropertyAccessor> Certificates
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCCertificate, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "certificates");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCCertificate, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "certificates", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte IceCandidatePoolSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<byte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "iceCandidatePoolSize");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<byte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "iceCandidatePoolSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PeerIdentity
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "peerIdentity");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "peerIdentity", value);
    }
}

#nullable disable