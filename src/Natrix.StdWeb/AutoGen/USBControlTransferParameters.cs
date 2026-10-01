// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class USBControlTransferParameters: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<USBControlTransferParameters>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public USBControlTransferParameters(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static USBControlTransferParameters global::Natrix.JSCore.IJSObjectProxy<USBControlTransferParameters>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public USBControlTransferParameters(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.USBRequestType RequestType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.USBRequestType>.Get(JSObject, "requestType");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.USBRequestType>.Set(JSObject, "requestType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.USBRecipient Recipient
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.USBRecipient>.Get(JSObject, "recipient");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.USBRecipient>.Set(JSObject, "recipient", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required byte Request
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "request");
        set => global::Natrix.JSCore.Generics.ByteAccessor.Set(JSObject, "request", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required ushort Value
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "value");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "value", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required ushort Index
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "index");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "index", value);
    }
}

#nullable disable