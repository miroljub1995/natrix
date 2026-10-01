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
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytesSent");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytesSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesSentOverhead
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytesSentOverhead");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytesSentOverhead", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesAcknowledged
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytesAcknowledged");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytesAcknowledged", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsSent
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "packetsSent");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "packetsSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesLost
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytesLost");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytesLost", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsLost
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "packetsLost");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "packetsLost", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesReceived
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytesReceived");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytesReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong PacketsReceived
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "packetsReceived");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "packetsReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double SmoothedRtt
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "smoothedRtt");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "smoothedRtt", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double RttVariation
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "rttVariation");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "rttVariation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MinRtt
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "minRtt");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "minRtt", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.WebTransportDatagramStats Datagrams
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebTransportDatagramStats>.Get(JSObject, "datagrams");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebTransportDatagramStats>.Set(JSObject, "datagrams", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong? EstimatedSendRate
    {
        get => global::Natrix.JSCore.Generics.NullableUInt64Accessor.Get(JSObject, "estimatedSendRate");
        set => global::Natrix.JSCore.Generics.NullableUInt64Accessor.Set(JSObject, "estimatedSendRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool AtSendCapacity
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "atSendCapacity");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "atSendCapacity", value);
    }
}

#nullable disable