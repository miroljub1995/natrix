// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BluetoothAdvertisingEventInit: global::Natrix.StdWeb.EventInit
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothAdvertisingEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothAdvertisingEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.BluetoothDevice Device
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.BluetoothDevice, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "device");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.BluetoothDevice, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "device", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor> Uuids
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "uuids");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "uuids", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "name");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Appearance
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "appearance");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "appearance", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte TxPower
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<sbyte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "txPower");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<sbyte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "txPower", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte Rssi
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<sbyte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "rssi");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<sbyte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "rssi", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BluetoothManufacturerDataMap ManufacturerData
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.BluetoothManufacturerDataMap, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "manufacturerData");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.BluetoothManufacturerDataMap, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "manufacturerData", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BluetoothServiceDataMap ServiceData
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.BluetoothServiceDataMap, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "serviceData");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.BluetoothServiceDataMap, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "serviceData", value);
    }
}

#nullable disable