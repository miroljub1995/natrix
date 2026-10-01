// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebTransportReceiveStreamStats: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WebTransportReceiveStreamStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportReceiveStreamStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WebTransportReceiveStreamStats global::Natrix.JSCore.IJSObjectProxy<WebTransportReceiveStreamStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportReceiveStreamStats(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesReceived
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytesReceived");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytesReceived", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong BytesRead
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bytesRead");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bytesRead", value);
    }
}

#nullable disable