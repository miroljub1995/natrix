// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebTransportDatagramStats: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WebTransportDatagramStats>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportDatagramStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WebTransportDatagramStats global::Natrix.JSCore.IJSObjectProxy<WebTransportDatagramStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportDatagramStats(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DroppedIncoming
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "droppedIncoming");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "droppedIncoming", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong ExpiredIncoming
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "expiredIncoming");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "expiredIncoming", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong ExpiredOutgoing
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "expiredOutgoing");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "expiredOutgoing", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong LostOutgoing
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "lostOutgoing");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "lostOutgoing", value);
    }
}

#nullable disable