// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCRtpStreamStats: global::Natrix.StdWeb.RTCStats, global::Natrix.JSCore.IJSObjectProxy<RTCRtpStreamStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRtpStreamStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCRtpStreamStats global::Natrix.JSCore.IJSObjectProxy<RTCRtpStreamStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRtpStreamStats(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Ssrc
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "ssrc");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "ssrc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Kind
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "kind");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "kind", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string TransportId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "transportId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "transportId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string CodecId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "codecId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "codecId", value);
    }
}

#nullable disable