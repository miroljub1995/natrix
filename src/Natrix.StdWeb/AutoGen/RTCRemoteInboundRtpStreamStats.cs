// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCRemoteInboundRtpStreamStats: global::Natrix.StdWeb.RTCReceivedRtpStreamStats, global::Natrix.JSCore.IJSObjectProxy<RTCRemoteInboundRtpStreamStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRemoteInboundRtpStreamStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCRemoteInboundRtpStreamStats global::Natrix.JSCore.IJSObjectProxy<RTCRemoteInboundRtpStreamStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRemoteInboundRtpStreamStats(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string LocalId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "localId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "localId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double RoundTripTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "roundTripTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "roundTripTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalRoundTripTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalRoundTripTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalRoundTripTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FractionLost
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "fractionLost");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "fractionLost", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong RoundTripTimeMeasurements
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "roundTripTimeMeasurements");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "roundTripTimeMeasurements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsWithBleachedEct1Marking
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "packetsWithBleachedEct1Marking");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "packetsWithBleachedEct1Marking", value);
    }
}

#nullable disable