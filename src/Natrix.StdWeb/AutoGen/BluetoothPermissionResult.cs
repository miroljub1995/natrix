// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BluetoothPermissionResult: global::Natrix.StdWeb.PermissionStatus
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothPermissionResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.BluetoothDevice, global::Natrix.StdWeb.PropertyAccessor> Devices
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.BluetoothDevice, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "devices");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.BluetoothDevice, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "devices", value);
    }
}

#nullable disable