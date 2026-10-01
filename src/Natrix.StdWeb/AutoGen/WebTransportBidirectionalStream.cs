// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebTransportBidirectionalStream: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WebTransportBidirectionalStream>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportBidirectionalStream(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WebTransportBidirectionalStream global::Natrix.JSCore.IJSObjectProxy<WebTransportBidirectionalStream>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<WebTransportBidirectionalStream>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebTransportReceiveStream Readable
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebTransportReceiveStream>.Get(JSObject, "readable");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebTransportSendStream Writable
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebTransportSendStream>.Get(JSObject, "writable");
    }
}

#nullable disable