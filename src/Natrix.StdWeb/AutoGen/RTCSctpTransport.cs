// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCSctpTransport: global::Natrix.StdWeb.EventTarget
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCSctpTransport(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCDtlsTransport Transport
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCDtlsTransport, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "transport");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCSctpTransportState State
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCSctpTransportState, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "state");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? MaxMessageSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "maxMessageSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort? MaxChannels
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "maxChannels");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onstatechange
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "onstatechange");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "onstatechange", value);
    }
}

#nullable disable