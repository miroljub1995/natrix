// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BackgroundFetchRecord: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<BackgroundFetchRecord>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BackgroundFetchRecord(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BackgroundFetchRecord global::Natrix.JSCore.IJSObjectProxy<BackgroundFetchRecord>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<BackgroundFetchRecord>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Request Request
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Request, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Request>>(JSObject, "request");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.Response, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Response>> ResponseReady
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.Response, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Response>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.Response, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Response>>>>(JSObject, "responseReady");
    }
}

#nullable disable