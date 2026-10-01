// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PresentationConnectionList: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<PresentationConnectionList>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PresentationConnectionList(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PresentationConnectionList global::Natrix.JSCore.IJSObjectProxy<PresentationConnectionList>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PresentationConnectionList>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PresentationConnection, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PresentationConnection>> Connections
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PresentationConnection, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PresentationConnection>>>.Get(JSObject, "connections");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onconnectionavailable
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onconnectionavailable");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onconnectionavailable", value);
    }
}

#nullable disable