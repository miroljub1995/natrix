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
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.WebTransportSendGroup>.Get(JSObject, "sendGroup");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.WebTransportSendGroup>.Set(JSObject, "sendGroup", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public long SendOrder
    {
        get => global::Natrix.JSCore.Generics.Int64Accessor.Get(JSObject, "sendOrder");
        set => global::Natrix.JSCore.Generics.Int64Accessor.Set(JSObject, "sendOrder", value);
    }
}

#nullable disable