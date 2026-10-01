// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DevicePosture: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<DevicePosture>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DevicePosture(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DevicePosture global::Natrix.JSCore.IJSObjectProxy<DevicePosture>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<DevicePosture>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DevicePostureType Type
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DevicePostureType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.DevicePostureType>>(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onchange
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "onchange");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "onchange", value);
    }
}

#nullable disable