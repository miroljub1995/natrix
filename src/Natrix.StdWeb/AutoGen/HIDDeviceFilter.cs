// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HIDDeviceFilter: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<HIDDeviceFilter>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HIDDeviceFilter(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HIDDeviceFilter global::Natrix.JSCore.IJSObjectProxy<HIDDeviceFilter>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HIDDeviceFilter(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint VendorId
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "vendorId");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "vendorId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort ProductId
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "productId");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "productId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort UsagePage
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "usagePage");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "usagePage", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Usage
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "usage");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "usage", value);
    }
}

#nullable disable