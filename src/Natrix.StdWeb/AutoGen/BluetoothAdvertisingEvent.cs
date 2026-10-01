// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BluetoothAdvertisingEvent: global::Natrix.StdWeb.Event, global::Natrix.JSCore.IJSObjectProxy<BluetoothAdvertisingEvent>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothAdvertisingEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BluetoothAdvertisingEvent global::Natrix.JSCore.IJSObjectProxy<BluetoothAdvertisingEvent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<BluetoothAdvertisingEvent>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.BluetoothAdvertisingEvent New(string type, global::Natrix.StdWeb.BluetoothAdvertisingEventInit init)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
        ___marshalledValue_5 = init.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "BluetoothAdvertisingEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.BluetoothAdvertisingEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BluetoothDevice Device
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.BluetoothDevice, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothDevice>>(JSObject, "device");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.JSCore.Generics.StringAccessor> Uuids
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "uuids");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort? Appearance
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort?, global::Natrix.JSCore.Generics.NullableUInt16Accessor>(JSObject, "appearance");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte? TxPower
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<sbyte?, global::Natrix.JSCore.Generics.NullableSByteAccessor>(JSObject, "txPower");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte? Rssi
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<sbyte?, global::Natrix.JSCore.Generics.NullableSByteAccessor>(JSObject, "rssi");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BluetoothManufacturerDataMap ManufacturerData
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.BluetoothManufacturerDataMap, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothManufacturerDataMap>>(JSObject, "manufacturerData");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BluetoothServiceDataMap ServiceData
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.BluetoothServiceDataMap, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothServiceDataMap>>(JSObject, "serviceData");
    }
}

#nullable disable