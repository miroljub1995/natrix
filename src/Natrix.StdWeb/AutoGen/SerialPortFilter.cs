// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SerialPortFilter: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SerialPortFilter>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SerialPortFilter(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SerialPortFilter global::Natrix.JSCore.IJSObjectProxy<SerialPortFilter>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SerialPortFilter(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort UsbVendorId
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "usbVendorId");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "usbVendorId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort UsbProductId
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "usbProductId");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "usbProductId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor> BluetoothServiceClassId
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>>.Get(JSObject, "bluetoothServiceClassId");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, uint, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.UInt32Accessor>>.Set(JSObject, "bluetoothServiceClassId", value);
    }
}

#nullable disable