// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCInboundRtpStreamStats: global::Natrix.StdWeb.RTCReceivedRtpStreamStats, global::Natrix.JSCore.IJSObjectProxy<RTCInboundRtpStreamStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCInboundRtpStreamStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCInboundRtpStreamStats global::Natrix.JSCore.IJSObjectProxy<RTCInboundRtpStreamStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCInboundRtpStreamStats(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string TrackIdentifier
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "trackIdentifier");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "trackIdentifier", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Mid
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "mid");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "mid", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string RemoteId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "remoteId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "remoteId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FramesDecoded
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "framesDecoded");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "framesDecoded", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint KeyFramesDecoded
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "keyFramesDecoded");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "keyFramesDecoded", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FramesRendered
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "framesRendered");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "framesRendered", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FramesDropped
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "framesDropped");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "framesDropped", value);
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
    public ulong QpSum
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "qpSum");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "qpSum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalDecodeTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalDecodeTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalDecodeTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalInterFrameDelay
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalInterFrameDelay");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalInterFrameDelay", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalSquaredInterFrameDelay
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalSquaredInterFrameDelay");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalSquaredInterFrameDelay", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint PauseCount
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "pauseCount");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "pauseCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalPausesDuration
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalPausesDuration");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalPausesDuration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FreezeCount
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "freezeCount");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "freezeCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalFreezesDuration
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalFreezesDuration");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalFreezesDuration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double LastPacketReceivedTimestamp
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "lastPacketReceivedTimestamp");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "lastPacketReceivedTimestamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong HeaderBytesReceived
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "headerBytesReceived");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "headerBytesReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsDiscarded
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "packetsDiscarded");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "packetsDiscarded", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong FecBytesReceived
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "fecBytesReceived");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "fecBytesReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong FecPacketsReceived
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "fecPacketsReceived");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "fecPacketsReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong FecPacketsDiscarded
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "fecPacketsDiscarded");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "fecPacketsDiscarded", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesReceived
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytesReceived");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytesReceived", value);
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
    public double TotalProcessingDelay
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalProcessingDelay");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalProcessingDelay", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double EstimatedPlayoutTimestamp
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "estimatedPlayoutTimestamp");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "estimatedPlayoutTimestamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double JitterBufferDelay
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "jitterBufferDelay");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "jitterBufferDelay", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double JitterBufferTargetDelay
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "jitterBufferTargetDelay");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "jitterBufferTargetDelay", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong JitterBufferEmittedCount
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "jitterBufferEmittedCount");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "jitterBufferEmittedCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double JitterBufferMinimumDelay
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "jitterBufferMinimumDelay");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "jitterBufferMinimumDelay", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong TotalSamplesReceived
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "totalSamplesReceived");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "totalSamplesReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong ConcealedSamples
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "concealedSamples");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "concealedSamples", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong SilentConcealedSamples
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "silentConcealedSamples");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "silentConcealedSamples", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong ConcealmentEvents
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "concealmentEvents");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "concealmentEvents", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong InsertedSamplesForDeceleration
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "insertedSamplesForDeceleration");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "insertedSamplesForDeceleration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong RemovedSamplesForAcceleration
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "removedSamplesForAcceleration");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "removedSamplesForAcceleration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AudioLevel
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "audioLevel");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "audioLevel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalAudioEnergy
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalAudioEnergy");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalAudioEnergy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalSamplesDuration
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalSamplesDuration");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalSamplesDuration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FramesReceived
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "framesReceived");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "framesReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DecoderImplementation
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "decoderImplementation");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "decoderImplementation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PlayoutId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "playoutId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "playoutId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PowerEfficientDecoder
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "powerEfficientDecoder");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "powerEfficientDecoder", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FramesAssembledFromMultiplePackets
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "framesAssembledFromMultiplePackets");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "framesAssembledFromMultiplePackets", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalAssemblyTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalAssemblyTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalAssemblyTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong RetransmittedPacketsReceived
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "retransmittedPacketsReceived");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "retransmittedPacketsReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong RetransmittedBytesReceived
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "retransmittedBytesReceived");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "retransmittedBytesReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint RtxSsrc
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "rtxSsrc");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "rtxSsrc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FecSsrc
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "fecSsrc");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "fecSsrc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalCorruptionProbability
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalCorruptionProbability");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalCorruptionProbability", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalSquaredCorruptionProbability
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalSquaredCorruptionProbability");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "totalSquaredCorruptionProbability", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong CorruptionMeasurements
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "corruptionMeasurements");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "corruptionMeasurements", value);
    }
}

#nullable disable