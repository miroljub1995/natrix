// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BluetoothPermissionDescriptor: global::Natrix.StdWeb.PermissionDescriptor, global::Natrix.JSCore.IJSObjectProxy<BluetoothPermissionDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothPermissionDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BluetoothPermissionDescriptor global::Natrix.JSCore.IJSObjectProxy<BluetoothPermissionDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothPermissionDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DeviceId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "deviceId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "deviceId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothLEScanFilterInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothLEScanFilterInit>> Filters
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothLEScanFilterInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothLEScanFilterInit>>>.Get(JSObject, "filters");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothLEScanFilterInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothLEScanFilterInit>>>.Set(JSObject, "filters", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>>> OptionalServices
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>>>>.Get(JSObject, "optionalServices");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>>>>.Set(JSObject, "optionalServices", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<ushort, global::Natrix.JSCore.Generics.UInt16Accessor> OptionalManufacturerData
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<ushort, global::Natrix.JSCore.Generics.UInt16Accessor>>.Get(JSObject, "optionalManufacturerData");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<ushort, global::Natrix.JSCore.Generics.UInt16Accessor>>.Set(JSObject, "optionalManufacturerData", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool AcceptAllDevices
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "acceptAllDevices");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "acceptAllDevices", value);
    }
}

#nullable disable