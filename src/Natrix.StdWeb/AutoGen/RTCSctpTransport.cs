// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCSctpTransport: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<RTCSctpTransport>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCSctpTransport(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCSctpTransport global::Natrix.JSCore.IJSObjectProxy<RTCSctpTransport>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<RTCSctpTransport>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCDtlsTransport Transport
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCDtlsTransport, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCDtlsTransport>>(JSObject, "transport");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCSctpTransportState State
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCSctpTransportState, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCSctpTransportState>>(JSObject, "state");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? MaxMessageSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>(JSObject, "maxMessageSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort? MaxChannels
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort?, global::Natrix.JSCore.Generics.NullableUInt16Accessor>(JSObject, "maxChannels");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onstatechange
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "onstatechange");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "onstatechange", value);
    }
}

#nullable disable