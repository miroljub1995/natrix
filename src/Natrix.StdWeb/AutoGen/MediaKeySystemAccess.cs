// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaKeySystemAccess: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaKeySystemAccess>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaKeySystemAccess(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaKeySystemAccess global::Natrix.JSCore.IJSObjectProxy<MediaKeySystemAccess>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<MediaKeySystemAccess>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string KeySystem
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "keySystem");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaKeySystemConfiguration GetConfiguration()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getConfiguration", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaKeySystemConfiguration>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.MediaKeys, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaKeys>> CreateMediaKeys()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "createMediaKeys", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.MediaKeys, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaKeys>>>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable