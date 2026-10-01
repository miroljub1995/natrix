// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ExtendableCookieChangeEvent: global::Natrix.StdWeb.ExtendableEvent, global::Natrix.JSCore.IJSObjectProxy<ExtendableCookieChangeEvent>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ExtendableCookieChangeEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ExtendableCookieChangeEvent global::Natrix.JSCore.IJSObjectProxy<ExtendableCookieChangeEvent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ExtendableCookieChangeEvent>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.ExtendableCookieChangeEvent New(string type)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "ExtendableCookieChangeEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.ExtendableCookieChangeEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.ExtendableCookieChangeEvent New(string type, global::Natrix.StdWeb.ExtendableCookieChangeEventInit eventInitDict)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
        ___marshalledValue_5 = eventInitDict.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "ExtendableCookieChangeEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.ExtendableCookieChangeEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>> Changed
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>>>>(JSObject, "changed");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>> Deleted
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>>>>(JSObject, "deleted");
    }
}

#nullable disable