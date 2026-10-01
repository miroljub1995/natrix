// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebTransportReceiveStream: global::Natrix.StdWeb.ReadableStream, global::Natrix.JSCore.IJSObjectProxy<WebTransportReceiveStream>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportReceiveStream(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WebTransportReceiveStream global::Natrix.JSCore.IJSObjectProxy<WebTransportReceiveStream>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<WebTransportReceiveStream>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.WebTransportReceiveStreamStats, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebTransportReceiveStreamStats>> GetStats()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getStats", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.WebTransportReceiveStreamStats, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebTransportReceiveStreamStats>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.WebTransportReceiveStreamStats, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebTransportReceiveStreamStats>>>>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable