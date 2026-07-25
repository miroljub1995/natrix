// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BluetoothLEScan: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothLEScan(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.BluetoothLEScanFilter, global::Natrix.StdWeb.PropertyAccessor> Filters
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.BluetoothLEScanFilter, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "filters");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool KeepRepeatedDevices
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "keepRepeatedDevices");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool AcceptAllAdvertisements
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "acceptAllAdvertisements");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Active
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "active");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Stop()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "stop", JSObject);
    }
}

#nullable disable