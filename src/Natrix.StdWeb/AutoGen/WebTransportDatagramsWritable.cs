// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebTransportDatagramsWritable: global::Natrix.StdWeb.WritableStream, global::Natrix.JSCore.IJSObjectProxy<WebTransportDatagramsWritable>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportDatagramsWritable(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WebTransportDatagramsWritable global::Natrix.JSCore.IJSObjectProxy<WebTransportDatagramsWritable>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<WebTransportDatagramsWritable>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebTransportSendGroup? SendGroup
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.WebTransportSendGroup?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.WebTransportSendGroup>>(JSObject, "sendGroup");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.WebTransportSendGroup?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.WebTransportSendGroup>>(JSObject, "sendGroup", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public long SendOrder
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<long, global::Natrix.JSCore.Generics.Int64Accessor>(JSObject, "sendOrder");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<long, global::Natrix.JSCore.Generics.Int64Accessor>(JSObject, "sendOrder", value);
    }
}

#nullable disable