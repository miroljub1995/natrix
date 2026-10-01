// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCOutboundRtpStreamStats: global::Natrix.StdWeb.RTCSentRtpStreamStats, global::Natrix.JSCore.IJSObjectProxy<RTCOutboundRtpStreamStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCOutboundRtpStreamStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCOutboundRtpStreamStats global::Natrix.JSCore.IJSObjectProxy<RTCOutboundRtpStreamStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCOutboundRtpStreamStats(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Mid
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "mid");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "mid", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string MediaSourceId
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "mediaSourceId");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "mediaSourceId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string RemoteId
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "remoteId");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "remoteId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Rid
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "rid");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "rid", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint EncodingIndex
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "encodingIndex");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "encodingIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong HeaderBytesSent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "headerBytesSent");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "headerBytesSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong RetransmittedPacketsSent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "retransmittedPacketsSent");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "retransmittedPacketsSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong RetransmittedBytesSent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "retransmittedBytesSent");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "retransmittedBytesSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint RtxSsrc
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "rtxSsrc");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "rtxSsrc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TargetBitrate
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "targetBitrate");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "targetBitrate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong TotalEncodedBytesTarget
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "totalEncodedBytesTarget");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "totalEncodedBytesTarget", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FrameWidth
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "frameWidth");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "frameWidth", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FrameHeight
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "frameHeight");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "frameHeight", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FramesPerSecond
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "framesPerSecond");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "framesPerSecond", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FramesSent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "framesSent");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "framesSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint HugeFramesSent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "hugeFramesSent");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "hugeFramesSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FramesEncoded
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "framesEncoded");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "framesEncoded", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint KeyFramesEncoded
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "keyFramesEncoded");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "keyFramesEncoded", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong QpSum
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "qpSum");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "qpSum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor> PsnrSum
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor>>>(JSObject, "psnrSum");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor>>>(JSObject, "psnrSum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PsnrMeasurements
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "psnrMeasurements");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "psnrMeasurements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalEncodeTime
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "totalEncodeTime");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "totalEncodeTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalPacketSendDelay
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "totalPacketSendDelay");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "totalPacketSendDelay", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCQualityLimitationReason QualityLimitationReason
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCQualityLimitationReason, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCQualityLimitationReason>>(JSObject, "qualityLimitationReason");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.RTCQualityLimitationReason, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCQualityLimitationReason>>(JSObject, "qualityLimitationReason", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor> QualityLimitationDurations
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor>>>(JSObject, "qualityLimitationDurations");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor>>>(JSObject, "qualityLimitationDurations", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint QualityLimitationResolutionChanges
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "qualityLimitationResolutionChanges");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "qualityLimitationResolutionChanges", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint NackCount
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "nackCount");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "nackCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FirCount
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "firCount");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "firCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint PliCount
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "pliCount");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "pliCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string EncoderImplementation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "encoderImplementation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "encoderImplementation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PowerEfficientEncoder
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "powerEfficientEncoder");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "powerEfficientEncoder", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Active
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "active");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "active", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ScalabilityMode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "scalabilityMode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "scalabilityMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsSentWithEct1
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "packetsSentWithEct1");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "packetsSentWithEct1", value);
    }
}

#nullable disable