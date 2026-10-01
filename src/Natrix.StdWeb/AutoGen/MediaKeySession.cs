// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaKeySession: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<MediaKeySession>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaKeySession(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaKeySession global::Natrix.JSCore.IJSObjectProxy<MediaKeySession>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<MediaKeySession>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SessionId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "sessionId");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Expiration
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "expiration");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.MediaKeySessionClosedReason, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaKeySessionClosedReason>> Closed
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.MediaKeySessionClosedReason, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MediaKeySessionClosedReason>>>.Get(JSObject, "closed");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaKeyStatusMap KeyStatuses
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaKeyStatusMap>.Get(JSObject, "keyStatuses");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onkeystatuseschange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onkeystatuseschange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onkeystatuseschange", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onmessage
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onmessage");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onmessage", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise GenerateRequest(string initDataType, global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8ClampedArray>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigInt64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigUint64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.DataView>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>> initData)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = initDataType;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = initData.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "generateRequest", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<bool, global::Natrix.JSCore.Generics.BooleanAccessor> Load(string sessionId)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = sessionId;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "load", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise Update(global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8ClampedArray>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigInt64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigUint64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.DataView>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>> response)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = response.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "update", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise Close()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "close", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise Remove()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "remove", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable