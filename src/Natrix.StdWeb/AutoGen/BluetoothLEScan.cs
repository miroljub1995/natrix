// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BluetoothLEScan: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<BluetoothLEScan>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothLEScan(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BluetoothLEScan global::Natrix.JSCore.IJSObjectProxy<BluetoothLEScan>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<BluetoothLEScan>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.BluetoothLEScanFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothLEScanFilter>> Filters
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.BluetoothLEScanFilter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothLEScanFilter>>>.Get(JSObject, "filters");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool KeepRepeatedDevices
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "keepRepeatedDevices");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool AcceptAllAdvertisements
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "acceptAllAdvertisements");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Active
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "active");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Stop()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "stop", JSObject);
    }
}

#nullable disable