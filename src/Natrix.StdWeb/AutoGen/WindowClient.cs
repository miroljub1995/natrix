// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WindowClient: global::Natrix.StdWeb.Client, global::Natrix.JSCore.IJSObjectProxy<WindowClient>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WindowClient(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WindowClient global::Natrix.JSCore.IJSObjectProxy<WindowClient>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<WindowClient>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DocumentVisibilityState VisibilityState
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.DocumentVisibilityState>.Get(JSObject, "visibilityState");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Focused
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "focused");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.JSCore.Generics.StringAccessor> AncestorOrigins
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "ancestorOrigins");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.WindowClient, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WindowClient>> Focus()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "focus", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.WindowClient, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WindowClient>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.WindowClient?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.WindowClient>> Navigate(string url)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = url;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "navigate", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.WindowClient?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.WindowClient>>>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable