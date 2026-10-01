// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCCodecStats: global::Natrix.StdWeb.RTCStats, global::Natrix.JSCore.IJSObjectProxy<RTCCodecStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCCodecStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCCodecStats global::Natrix.JSCore.IJSObjectProxy<RTCCodecStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCCodecStats(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint PayloadType
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "payloadType");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "payloadType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string TransportId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "transportId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "transportId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string MimeType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "mimeType");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "mimeType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ClockRate
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "clockRate");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "clockRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Channels
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "channels");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "channels", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SdpFmtpLine
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "sdpFmtpLine");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "sdpFmtpLine", value);
    }
}

#nullable disable