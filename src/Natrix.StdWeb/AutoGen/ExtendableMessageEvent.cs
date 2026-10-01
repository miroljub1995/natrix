// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ExtendableMessageEvent: global::Natrix.StdWeb.ExtendableEvent, global::Natrix.JSCore.IJSObjectProxy<ExtendableMessageEvent>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ExtendableMessageEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ExtendableMessageEvent global::Natrix.JSCore.IJSObjectProxy<ExtendableMessageEvent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ExtendableMessageEvent>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.ExtendableMessageEvent New(string type)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "ExtendableMessageEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.ExtendableMessageEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.ExtendableMessageEvent New(string type, global::Natrix.StdWeb.ExtendableMessageEventInit eventInitDict)
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

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "ExtendableMessageEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.ExtendableMessageEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? Data
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Get(JSObject, "data");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Origin
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "origin");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string LastEventId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "lastEventId");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Client, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.MessagePort, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Client>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorker>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>>? Source
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Client, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.MessagePort, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Client>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorker>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>>>.Get(JSObject, "source");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.MessagePort, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>> Ports
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.MessagePort, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>>>.Get(JSObject, "ports");
    }
}

#nullable disable