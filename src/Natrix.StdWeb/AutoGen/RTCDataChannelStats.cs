// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCDataChannelStats: global::Natrix.StdWeb.RTCStats, global::Natrix.JSCore.IJSObjectProxy<RTCDataChannelStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCDataChannelStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCDataChannelStats global::Natrix.JSCore.IJSObjectProxy<RTCDataChannelStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCDataChannelStats(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Label
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "label");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "label", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Protocol
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "protocol");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "protocol", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort DataChannelIdentifier
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "dataChannelIdentifier");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "dataChannelIdentifier", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.RTCDataChannelState State
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCDataChannelState>.Get(JSObject, "state");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCDataChannelState>.Set(JSObject, "state", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MessagesSent
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "messagesSent");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "messagesSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesSent
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytesSent");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytesSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MessagesReceived
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "messagesReceived");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "messagesReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesReceived
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytesReceived");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytesReceived", value);
    }
}

#nullable disable