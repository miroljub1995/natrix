// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebTransportSendStreamStats: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WebTransportSendStreamStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportSendStreamStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WebTransportSendStreamStats global::Natrix.JSCore.IJSObjectProxy<WebTransportSendStreamStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportSendStreamStats(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesWritten
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytesWritten");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytesWritten", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesSent
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytesSent");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytesSent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesAcknowledged
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytesAcknowledged");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytesAcknowledged", value);
    }
}

#nullable disable