// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCTransportStats: global::Natrix.StdWeb.RTCStats, global::Natrix.JSCore.IJSObjectProxy<RTCTransportStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCTransportStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCTransportStats global::Natrix.JSCore.IJSObjectProxy<RTCTransportStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCTransportStats(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsSent
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "packetsSent");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "packetsSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsReceived
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "packetsReceived");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "packetsReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesSent
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytesSent");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytesSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesReceived
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytesReceived");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytesReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceRole IceRole
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCIceRole>.Get(JSObject, "iceRole");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCIceRole>.Set(JSObject, "iceRole", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string IceLocalUsernameFragment
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "iceLocalUsernameFragment");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "iceLocalUsernameFragment", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.RTCDtlsTransportState DtlsState
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCDtlsTransportState>.Get(JSObject, "dtlsState");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCDtlsTransportState>.Set(JSObject, "dtlsState", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceTransportState IceState
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCIceTransportState>.Get(JSObject, "iceState");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCIceTransportState>.Set(JSObject, "iceState", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SelectedCandidatePairId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "selectedCandidatePairId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "selectedCandidatePairId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string LocalCertificateId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "localCertificateId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "localCertificateId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string RemoteCertificateId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "remoteCertificateId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "remoteCertificateId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string TlsVersion
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "tlsVersion");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "tlsVersion", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DtlsCipher
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "dtlsCipher");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "dtlsCipher", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCDtlsRole DtlsRole
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCDtlsRole>.Get(JSObject, "dtlsRole");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCDtlsRole>.Set(JSObject, "dtlsRole", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SrtpCipher
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "srtpCipher");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "srtpCipher", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SelectedCandidatePairChanges
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "selectedCandidatePairChanges");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "selectedCandidatePairChanges", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint CcfbMessagesSent
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "ccfbMessagesSent");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "ccfbMessagesSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint CcfbMessagesReceived
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "ccfbMessagesReceived");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "ccfbMessagesReceived", value);
    }
}

#nullable disable