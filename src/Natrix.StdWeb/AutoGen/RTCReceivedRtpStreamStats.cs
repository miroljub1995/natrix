// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCReceivedRtpStreamStats: global::Natrix.StdWeb.RTCRtpStreamStats, global::Natrix.JSCore.IJSObjectProxy<RTCReceivedRtpStreamStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCReceivedRtpStreamStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCReceivedRtpStreamStats global::Natrix.JSCore.IJSObjectProxy<RTCReceivedRtpStreamStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCReceivedRtpStreamStats(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsReceived
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "packetsReceived");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "packetsReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsReceivedWithEct1
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "packetsReceivedWithEct1");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "packetsReceivedWithEct1", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsReceivedWithCe
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "packetsReceivedWithCe");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "packetsReceivedWithCe", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsReportedAsLost
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "packetsReportedAsLost");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "packetsReportedAsLost", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsReportedAsLostButRecovered
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "packetsReportedAsLostButRecovered");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "packetsReportedAsLostButRecovered", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public long PacketsLost
    {
        get => global::Natrix.JSCore.Generics.Int64Accessor.Get(JSObject, "packetsLost");
        set => global::Natrix.JSCore.Generics.Int64Accessor.Set(JSObject, "packetsLost", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Jitter
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "jitter");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "jitter", value);
    }
}

#nullable disable