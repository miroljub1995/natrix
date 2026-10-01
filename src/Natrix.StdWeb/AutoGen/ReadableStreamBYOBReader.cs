// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ReadableStreamBYOBReader: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ReadableStreamBYOBReader>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ReadableStreamBYOBReader(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ReadableStreamBYOBReader global::Natrix.JSCore.IJSObjectProxy<ReadableStreamBYOBReader>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ReadableStreamBYOBReader>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.ReadableStreamBYOBReader New(global::Natrix.StdWeb.ReadableStream stream)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = stream.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "ReadableStreamBYOBReader", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.ReadableStreamBYOBReader(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.ReadableStreamReadResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ReadableStreamReadResult>> Read(global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8ClampedArray>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigInt64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigUint64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.DataView>> view)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = view.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "read", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.ReadableStreamReadResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ReadableStreamReadResult>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.ReadableStreamReadResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ReadableStreamReadResult>> Read(global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8ClampedArray>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigInt64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigUint64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.DataView>> view, global::Natrix.StdWeb.ReadableStreamBYOBReaderReadOptions options)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = view.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "read", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.ReadableStreamReadResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ReadableStreamReadResult>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void ReleaseLock()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "releaseLock", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise Closed
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(JSObject, "closed");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise Cancel()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "cancel", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise Cancel(global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? reason)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_3;
        if (reason is null)
        {
            ___propObject_3 = null;
        }
        else
        {
            ___propObject_3 = reason.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 0, ___propObject_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "cancel", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable