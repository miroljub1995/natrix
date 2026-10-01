// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class USBPermissionResult: global::Natrix.StdWeb.PermissionStatus, global::Natrix.JSCore.IJSObjectProxy<USBPermissionResult>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public USBPermissionResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static USBPermissionResult global::Natrix.JSCore.IJSObjectProxy<USBPermissionResult>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<USBPermissionResult>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.USBDevice, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBDevice>> Devices
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.USBDevice, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBDevice>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.USBDevice, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBDevice>>>>(JSObject, "devices");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.USBDevice, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBDevice>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.USBDevice, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.USBDevice>>>>(JSObject, "devices", value);
    }
}

#nullable disable