// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SharedWorker: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<SharedWorker>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SharedWorker(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SharedWorker global::Natrix.JSCore.IJSObjectProxy<SharedWorker>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SharedWorker>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.SharedWorker New(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedScriptURL, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedScriptURL>, global::Natrix.JSCore.Generics.StringAccessor> scriptURL)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = scriptURL.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "SharedWorker", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.SharedWorker(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.SharedWorker New(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedScriptURL, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedScriptURL>, global::Natrix.JSCore.Generics.StringAccessor> scriptURL, global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.SharedWorkerOptions, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SharedWorkerOptions>> options)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = scriptURL.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "SharedWorker", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.SharedWorker(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MessagePort Port
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>.Get(JSObject, "port");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onerror
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onerror");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onerror", value);
    }
}

#nullable disable