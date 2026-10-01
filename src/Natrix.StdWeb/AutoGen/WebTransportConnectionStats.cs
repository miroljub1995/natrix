// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebTransportConnectionStats: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WebTransportConnectionStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportConnectionStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WebTransportConnectionStats global::Natrix.JSCore.IJSObjectProxy<WebTransportConnectionStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportConnectionStats(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesSent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "bytesSent");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "bytesSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesSentOverhead
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "bytesSentOverhead");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "bytesSentOverhead", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesAcknowledged
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "bytesAcknowledged");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "bytesAcknowledged", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsSent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "packetsSent");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "packetsSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesLost
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "bytesLost");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "bytesLost", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsLost
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "packetsLost");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "packetsLost", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesReceived
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "bytesReceived");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "bytesReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsReceived
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "packetsReceived");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "packetsReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double SmoothedRtt
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "smoothedRtt");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "smoothedRtt", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double RttVariation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "rttVariation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "rttVariation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MinRtt
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "minRtt");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "minRtt", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.WebTransportDatagramStats Datagrams
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.WebTransportDatagramStats, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebTransportDatagramStats>>(JSObject, "datagrams");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.WebTransportDatagramStats, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebTransportDatagramStats>>(JSObject, "datagrams", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong? EstimatedSendRate
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong?, global::Natrix.JSCore.Generics.NullableUInt64Accessor>(JSObject, "estimatedSendRate");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ulong?, global::Natrix.JSCore.Generics.NullableUInt64Accessor>(JSObject, "estimatedSendRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool AtSendCapacity
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "atSendCapacity");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "atSendCapacity", value);
    }
}

#nullable disable