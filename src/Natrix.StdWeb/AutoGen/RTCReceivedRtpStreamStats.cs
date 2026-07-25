// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCReceivedRtpStreamStats: global::Natrix.StdWeb.RTCRtpStreamStats
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCReceivedRtpStreamStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCReceivedRtpStreamStats(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsReceived
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "packetsReceived");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "packetsReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsReceivedWithEct1
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "packetsReceivedWithEct1");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "packetsReceivedWithEct1", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsReceivedWithCe
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "packetsReceivedWithCe");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "packetsReceivedWithCe", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsReportedAsLost
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "packetsReportedAsLost");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "packetsReportedAsLost", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsReportedAsLostButRecovered
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "packetsReportedAsLostButRecovered");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "packetsReportedAsLostButRecovered", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public long PacketsLost
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<long, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "packetsLost");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<long, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "packetsLost", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Jitter
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "jitter");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "jitter", value);
    }
}

#nullable disable