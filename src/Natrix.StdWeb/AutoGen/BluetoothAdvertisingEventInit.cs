// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BluetoothAdvertisingEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<BluetoothAdvertisingEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothAdvertisingEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BluetoothAdvertisingEventInit global::Natrix.JSCore.IJSObjectProxy<BluetoothAdvertisingEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothAdvertisingEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.BluetoothDevice Device
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothDevice>.Get(JSObject, "device");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothDevice>.Set(JSObject, "device", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>>> Uuids
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>>>>.Get(JSObject, "uuids");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>>>>.Set(JSObject, "uuids", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Appearance
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "appearance");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "appearance", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte TxPower
    {
        get => global::Natrix.JSCore.Generics.SByteAccessor.Get(JSObject, "txPower");
        set => global::Natrix.JSCore.Generics.SByteAccessor.Set(JSObject, "txPower", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte Rssi
    {
        get => global::Natrix.JSCore.Generics.SByteAccessor.Get(JSObject, "rssi");
        set => global::Natrix.JSCore.Generics.SByteAccessor.Set(JSObject, "rssi", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BluetoothManufacturerDataMap ManufacturerData
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothManufacturerDataMap>.Get(JSObject, "manufacturerData");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothManufacturerDataMap>.Set(JSObject, "manufacturerData", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BluetoothServiceDataMap ServiceData
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothServiceDataMap>.Get(JSObject, "serviceData");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothServiceDataMap>.Set(JSObject, "serviceData", value);
    }
}

#nullable disable