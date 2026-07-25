// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AllowedUSBDevice: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AllowedUSBDevice(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AllowedUSBDevice(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required byte VendorId
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<byte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "vendorId");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<byte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "vendorId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required byte ProductId
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<byte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "productId");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<byte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "productId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SerialNumber
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "serialNumber");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "serialNumber", value);
    }
}

#nullable disable