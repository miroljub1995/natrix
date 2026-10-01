// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NotRestoredReasons: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<NotRestoredReasons>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NotRestoredReasons(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static NotRestoredReasons global::Natrix.JSCore.IJSObjectProxy<NotRestoredReasons>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<NotRestoredReasons>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Src
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "src");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Id
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "id");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Name
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Url
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "url");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasonDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NotRestoredReasonDetails>>? Reasons
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasonDetails, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NotRestoredReasonDetails>>>.Get(JSObject, "reasons");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasons, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NotRestoredReasons>>? Children
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasons, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NotRestoredReasons>>>.Get(JSObject, "children");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.JSObjectAccessor.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable