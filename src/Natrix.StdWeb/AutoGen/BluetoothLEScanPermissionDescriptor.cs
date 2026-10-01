// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BluetoothLEScanPermissionDescriptor: global::Natrix.StdWeb.PermissionDescriptor, global::Natrix.JSCore.IJSObjectProxy<BluetoothLEScanPermissionDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothLEScanPermissionDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BluetoothLEScanPermissionDescriptor global::Natrix.JSCore.IJSObjectProxy<BluetoothLEScanPermissionDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothLEScanPermissionDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothLEScanFilterInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothLEScanFilterInit>> Filters
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothLEScanFilterInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothLEScanFilterInit>>>.Get(JSObject, "filters");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothLEScanFilterInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothLEScanFilterInit>>>.Set(JSObject, "filters", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool KeepRepeatedDevices
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "keepRepeatedDevices");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "keepRepeatedDevices", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool AcceptAllAdvertisements
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "acceptAllAdvertisements");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "acceptAllAdvertisements", value);
    }
}

#nullable disable