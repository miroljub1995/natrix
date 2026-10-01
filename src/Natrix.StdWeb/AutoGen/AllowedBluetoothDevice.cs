// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AllowedBluetoothDevice: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AllowedBluetoothDevice>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AllowedBluetoothDevice(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AllowedBluetoothDevice global::Natrix.JSCore.IJSObjectProxy<AllowedBluetoothDevice>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AllowedBluetoothDevice(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string DeviceId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "deviceId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "deviceId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required bool MayUseGATT
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "mayUseGATT");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "mayUseGATT", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>> AllowedServices
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>>.Get(JSObject, "allowedServices");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>>.Set(JSObject, "allowedServices", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<ushort, global::Natrix.JSCore.Generics.UInt16Accessor> AllowedManufacturerData
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<ushort, global::Natrix.JSCore.Generics.UInt16Accessor>>.Get(JSObject, "allowedManufacturerData");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<ushort, global::Natrix.JSCore.Generics.UInt16Accessor>>.Set(JSObject, "allowedManufacturerData", value);
    }
}

#nullable disable