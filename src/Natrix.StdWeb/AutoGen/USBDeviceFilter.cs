// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class USBDeviceFilter: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<USBDeviceFilter>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public USBDeviceFilter(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static USBDeviceFilter global::Natrix.JSCore.IJSObjectProxy<USBDeviceFilter>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public USBDeviceFilter(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort VendorId
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "vendorId");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "vendorId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort ProductId
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "productId");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "productId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte ClassCode
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "classCode");
        set => global::Natrix.JSCore.Generics.ByteAccessor.Set(JSObject, "classCode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte SubclassCode
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "subclassCode");
        set => global::Natrix.JSCore.Generics.ByteAccessor.Set(JSObject, "subclassCode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte ProtocolCode
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "protocolCode");
        set => global::Natrix.JSCore.Generics.ByteAccessor.Set(JSObject, "protocolCode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SerialNumber
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "serialNumber");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "serialNumber", value);
    }
}

#nullable disable