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
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ConnectionType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ConnectionType>>(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EffectiveConnectionType EffectiveType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EffectiveConnectionType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.EffectiveConnectionType>>(JSObject, "effectiveType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DownlinkMax
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "downlinkMax");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Downlink
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "downlink");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Rtt
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "rtt");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onchange
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "onchange");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "onchange", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool SaveData
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "saveData");
    }
}

#nullable disable