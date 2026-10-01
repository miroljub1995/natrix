// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NavigatorUAData: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<NavigatorUAData>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigatorUAData(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static NavigatorUAData global::Natrix.JSCore.IJSObjectProxy<NavigatorUAData>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<NavigatorUAData>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NavigatorUABrandVersion, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigatorUABrandVersion>> Brands
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NavigatorUABrandVersion, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigatorUABrandVersion>>>.Get(JSObject, "brands");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Mobile
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "mobile");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Platform
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "platform");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.UADataValues, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.UADataValues>> GetHighEntropyValues(global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> hints)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = hints.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___propObject_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getHighEntropyValues", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.UADataValues, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.UADataValues>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.UALowEntropyJSON ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.UALowEntropyJSON>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable