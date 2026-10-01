// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebTransportSendStream: global::Natrix.StdWeb.WritableStream, global::Natrix.JSCore.IJSObjectProxy<WebTransportSendStream>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportSendStream(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WebTransportSendStream global::Natrix.JSCore.IJSObjectProxy<WebTransportSendStream>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<WebTransportSendStream>(obj);

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

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.WebTransportSendStreamStats, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebTransportSendStreamStats>> GetStats()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getStats", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.WebTransportSendStreamStats, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebTransportSendStreamStats>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebTransportWriter GetWriter()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getWriter", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WebTransportWriter>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable