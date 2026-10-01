// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NetworkInformation: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<NetworkInformation>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NetworkInformation(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static NetworkInformation global::Natrix.JSCore.IJSObjectProxy<NetworkInformation>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<NetworkInformation>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ConnectionType Type
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ConnectionType>.Get(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EffectiveConnectionType EffectiveType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.EffectiveConnectionType>.Get(JSObject, "effectiveType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DownlinkMax
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "downlinkMax");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Downlink
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "downlink");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Rtt
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "rtt");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onchange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onchange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onchange", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool SaveData
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "saveData");
    }
}

#nullable disable