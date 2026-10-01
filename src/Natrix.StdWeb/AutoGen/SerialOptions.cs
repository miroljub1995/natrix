// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SerialOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SerialOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SerialOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SerialOptions global::Natrix.JSCore.IJSObjectProxy<SerialOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SerialOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint BaudRate
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "baudRate");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "baudRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte DataBits
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "dataBits");
        set => global::Natrix.JSCore.Generics.ByteAccessor.Set(JSObject, "dataBits", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte StopBits
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "stopBits");
        set => global::Natrix.JSCore.Generics.ByteAccessor.Set(JSObject, "stopBits", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ParityType Parity
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ParityType>.Get(JSObject, "parity");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ParityType>.Set(JSObject, "parity", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint BufferSize
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "bufferSize");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "bufferSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FlowControlType FlowControl
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FlowControlType>.Get(JSObject, "flowControl");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FlowControlType>.Set(JSObject, "flowControl", value);
    }
}

#nullable disable