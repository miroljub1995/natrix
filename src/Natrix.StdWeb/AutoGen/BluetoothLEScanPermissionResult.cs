// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BluetoothLEScanPermissionResult: global::Natrix.StdWeb.PermissionStatus, global::Natrix.JSCore.IJSObjectProxy<BluetoothLEScanPermissionResult>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothLEScanPermissionResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BluetoothLEScanPermissionResult global::Natrix.JSCore.IJSObjectProxy<BluetoothLEScanPermissionResult>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<BluetoothLEScanPermissionResult>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.BluetoothLEScan, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothLEScan>> Scans
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.BluetoothLEScan, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothLEScan>>>.Get(JSObject, "scans");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.BluetoothLEScan, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothLEScan>>>.Set(JSObject, "scans", value);
    }
}

#nullable disable