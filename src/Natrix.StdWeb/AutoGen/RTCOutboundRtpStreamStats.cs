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
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "mid");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "mid", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string MediaSourceId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "mediaSourceId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "mediaSourceId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string RemoteId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "remoteId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "remoteId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Rid
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "rid");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "rid", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint EncodingIndex
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "encodingIndex");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "encodingIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong HeaderBytesSent
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "headerBytesSent");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "headerBytesSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong RetransmittedPacketsSent
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "retransmittedPacketsSent");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "retransmittedPacketsSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong RetransmittedBytesSent
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "retransmittedBytesSent");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "retransmittedBytesSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint RtxSsrc
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "rtxSsrc");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "rtxSsrc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TargetBitrate
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "targetBitrate");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "targetBitrate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FrameWidth
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "frameWidth");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "frameWidth", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FrameHeight
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "frameHeight");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "frameHeight", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FramesPerSecond
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "framesPerSecond");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "framesPerSecond", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FramesSent
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "framesSent");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "framesSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint HugeFramesSent
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "hugeFramesSent");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "hugeFramesSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FramesEncoded
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "framesEncoded");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "framesEncoded", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint KeyFramesEncoded
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "keyFramesEncoded");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "keyFramesEncoded", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong QpSum
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "qpSum");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "qpSum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor> PsnrSum
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor>>.Get(JSObject, "psnrSum");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor>>.Set(JSObject, "psnrSum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PsnrMeasurements
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "psnrMeasurements");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "psnrMeasurements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalEncodeTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalEncodeTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalEncodeTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalPacketSendDelay
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalPacketSendDelay");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalPacketSendDelay", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCQualityLimitationReason QualityLimitationReason
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCQualityLimitationReason>.Get(JSObject, "qualityLimitationReason");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCQualityLimitationReason>.Set(JSObject, "qualityLimitationReason", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor> QualityLimitationDurations
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor>>.Get(JSObject, "qualityLimitationDurations");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor>>.Set(JSObject, "qualityLimitationDurations", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint QualityLimitationResolutionChanges
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "qualityLimitationResolutionChanges");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "qualityLimitationResolutionChanges", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint NackCount
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "nackCount");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "nackCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FirCount
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "firCount");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "firCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint PliCount
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "pliCount");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "pliCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string EncoderImplementation
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "encoderImplementation");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "encoderImplementation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PowerEfficientEncoder
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "powerEfficientEncoder");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "powerEfficientEncoder", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Active
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "active");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "active", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ScalabilityMode
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "scalabilityMode");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "scalabilityMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsSentWithEct1
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "packetsSentWithEct1");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "packetsSentWithEct1", value);
    }
}

#nullable disable