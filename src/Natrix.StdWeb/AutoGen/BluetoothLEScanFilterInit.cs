// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BluetoothLEScanFilterInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<BluetoothLEScanFilterInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothLEScanFilterInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BluetoothLEScanFilterInit global::Natrix.JSCore.IJSObjectProxy<BluetoothLEScanFilterInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BluetoothLEScanFilterInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>>> Services
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>>>>.Get(JSObject, "services");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>>>>.Set(JSObject, "services", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string NamePrefix
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "namePrefix");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "namePrefix", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothManufacturerDataFilterInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothManufacturerDataFilterInit>> ManufacturerData
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothManufacturerDataFilterInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothManufacturerDataFilterInit>>>.Get(JSObject, "manufacturerData");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothManufacturerDataFilterInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothManufacturerDataFilterInit>>>.Set(JSObject, "manufacturerData", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothServiceDataFilterInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothServiceDataFilterInit>> ServiceData
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothServiceDataFilterInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothServiceDataFilterInit>>>.Get(JSObject, "serviceData");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BluetoothServiceDataFilterInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BluetoothServiceDataFilterInit>>>.Set(JSObject, "serviceData", value);
    }
}

#nullable disable