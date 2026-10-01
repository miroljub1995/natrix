// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MessageEvent: global::Natrix.StdWeb.Event, global::Natrix.JSCore.IJSObjectProxy<MessageEvent>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MessageEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MessageEvent global::Natrix.JSCore.IJSObjectProxy<MessageEvent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<MessageEvent>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.MessageEvent New(string type)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "MessageEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.MessageEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.MessageEvent New(string type, global::Natrix.StdWeb.MessageEventInit eventInitDict)
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

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "MessageEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.MessageEvent(___res_2);
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
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Window, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.ServiceWorker, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Window>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorker>>? Source
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Window, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.ServiceWorker, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Window>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorker>>>.Get(JSObject, "source");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.MessagePort, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>> Ports
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.MessagePort, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>>>.Get(JSObject, "ports");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMessageEvent(string type)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMessageEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMessageEvent(string type, bool bubbles)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubbles;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMessageEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMessageEvent(string type, bool bubbles, bool cancelable)
    {
        int ___argsArrayLength_2 = 3;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubbles;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelable;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMessageEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMessageEvent(string type, bool bubbles, bool cancelable, global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? data)
    {
        int ___argsArrayLength_2 = 4;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubbles;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelable;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_6;
        if (data is null)
        {
            ___propObject_6 = null;
        }
        else
        {
            ___propObject_6 = data.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 3, ___propObject_6);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMessageEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMessageEvent(string type, bool bubbles, bool cancelable, global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? data, string origin)
    {
        int ___argsArrayLength_2 = 5;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubbles;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelable;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_6;
        if (data is null)
        {
            ___propObject_6 = null;
        }
        else
        {
            ___propObject_6 = data.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 3, ___propObject_6);

        // Argument 5
        string ___marshalledValue_7;
        ___marshalledValue_7 = origin;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 4, ___marshalledValue_7);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMessageEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMessageEvent(string type, bool bubbles, bool cancelable, global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? data, string origin, string lastEventId)
    {
        int ___argsArrayLength_2 = 6;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubbles;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelable;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_6;
        if (data is null)
        {
            ___propObject_6 = null;
        }
        else
        {
            ___propObject_6 = data.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 3, ___propObject_6);

        // Argument 5
        string ___marshalledValue_7;
        ___marshalledValue_7 = origin;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 4, ___marshalledValue_7);

        // Argument 6
        string ___marshalledValue_8;
        ___marshalledValue_8 = lastEventId;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 5, ___marshalledValue_8);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMessageEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMessageEvent(string type, bool bubbles, bool cancelable, global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? data, string origin, string lastEventId, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Window, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.ServiceWorker, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Window>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorker>>? source)
    {
        int ___argsArrayLength_2 = 7;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubbles;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelable;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_6;
        if (data is null)
        {
            ___propObject_6 = null;
        }
        else
        {
            ___propObject_6 = data.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 3, ___propObject_6);

        // Argument 5
        string ___marshalledValue_7;
        ___marshalledValue_7 = origin;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 4, ___marshalledValue_7);

        // Argument 6
        string ___marshalledValue_8;
        ___marshalledValue_8 = lastEventId;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 5, ___marshalledValue_8);

        // Argument 7
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_9;
        if (source is null)
        {
            ___propObject_9 = null;
        }
        else
        {
            ___propObject_9 = source.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 6, ___propObject_9);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMessageEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMessageEvent(string type, bool bubbles, bool cancelable, global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? data, string origin, string lastEventId, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Window, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.ServiceWorker, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Window>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorker>>? source, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MessagePort, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>> ports)
    {
        int ___argsArrayLength_2 = 8;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubbles;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelable;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_6;
        if (data is null)
        {
            ___propObject_6 = null;
        }
        else
        {
            ___propObject_6 = data.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 3, ___propObject_6);

        // Argument 5
        string ___marshalledValue_7;
        ___marshalledValue_7 = origin;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 4, ___marshalledValue_7);

        // Argument 6
        string ___marshalledValue_8;
        ___marshalledValue_8 = lastEventId;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 5, ___marshalledValue_8);

        // Argument 7
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_9;
        if (source is null)
        {
            ___propObject_9 = null;
        }
        else
        {
            ___propObject_9 = source.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 6, ___propObject_9);

        // Argument 8
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_10 = ports.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 7, ___propObject_10);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMessageEvent", JSObject, ___argsArray_0.JSObject);
    }
}

#nullable disable