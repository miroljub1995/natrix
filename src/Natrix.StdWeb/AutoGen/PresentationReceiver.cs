// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PresentationReceiver: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PresentationReceiver>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PresentationReceiver(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PresentationReceiver global::Natrix.JSCore.IJSObjectProxy<PresentationReceiver>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PresentationReceiver>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PresentationConnectionList, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PresentationConnectionList>> ConnectionList
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.PresentationConnectionList, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PresentationConnectionList>>>.Get(JSObject, "connectionList");
    }
}

#nullable disable