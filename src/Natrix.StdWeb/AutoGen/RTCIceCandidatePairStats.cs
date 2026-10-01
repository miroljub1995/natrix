// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCIceCandidatePairStats: global::Natrix.StdWeb.RTCStats, global::Natrix.JSCore.IJSObjectProxy<RTCIceCandidatePairStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIceCandidatePairStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCIceCandidatePairStats global::Natrix.JSCore.IJSObjectProxy<RTCIceCandidatePairStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIceCandidatePairStats(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string TransportId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "transportId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "transportId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string LocalCandidateId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "localCandidateId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "localCandidateId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string RemoteCandidateId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "remoteCandidateId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "remoteCandidateId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.RTCStatsIceCandidatePairState State
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCStatsIceCandidatePairState>.Get(JSObject, "state");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCStatsIceCandidatePairState>.Set(JSObject, "state", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Nominated
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "nominated");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "nominated", value);
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
    public double LastPacketSentTimestamp
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "lastPacketSentTimestamp");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "lastPacketSentTimestamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double LastPacketReceivedTimestamp
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "lastPacketReceivedTimestamp");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "lastPacketReceivedTimestamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalRoundTripTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalRoundTripTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalRoundTripTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double CurrentRoundTripTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "currentRoundTripTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "currentRoundTripTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AvailableOutgoingBitrate
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "availableOutgoingBitrate");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "availableOutgoingBitrate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AvailableIncomingBitrate
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "availableIncomingBitrate");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "availableIncomingBitrate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong RequestsReceived
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "requestsReceived");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "requestsReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong RequestsSent
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "requestsSent");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "requestsSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong ResponsesReceived
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "responsesReceived");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "responsesReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong ResponsesSent
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "responsesSent");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "responsesSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong ConsentRequestsSent
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "consentRequestsSent");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "consentRequestsSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint PacketsDiscardedOnSend
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "packetsDiscardedOnSend");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "packetsDiscardedOnSend", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesDiscardedOnSend
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytesDiscardedOnSend");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytesDiscardedOnSend", value);
    }
}

#nullable disable