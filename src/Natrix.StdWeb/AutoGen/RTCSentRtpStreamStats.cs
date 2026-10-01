// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCSentRtpStreamStats: global::Natrix.StdWeb.RTCRtpStreamStats, global::Natrix.JSCore.IJSObjectProxy<RTCSentRtpStreamStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCSentRtpStreamStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCSentRtpStreamStats global::Natrix.JSCore.IJSObjectProxy<RTCSentRtpStreamStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCSentRtpStreamStats(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsSent
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "packetsSent");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "packetsSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesSent
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytesSent");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytesSent", value);
    }
}

#nullable disable