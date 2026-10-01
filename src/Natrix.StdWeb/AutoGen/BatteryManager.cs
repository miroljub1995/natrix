// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BatteryManager: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<BatteryManager>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BatteryManager(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BatteryManager global::Natrix.JSCore.IJSObjectProxy<BatteryManager>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<BatteryManager>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Charging
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "charging");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ChargingTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "chargingTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DischargingTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "dischargingTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Level
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "level");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onchargingchange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onchargingchange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onchargingchange", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onchargingtimechange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onchargingtimechange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onchargingtimechange", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Ondischargingtimechange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "ondischargingtimechange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "ondischargingtimechange", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onlevelchange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onlevelchange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onlevelchange", value);
    }
}

#nullable disable