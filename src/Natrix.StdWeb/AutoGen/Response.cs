// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Response: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Response>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Response(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Response global::Natrix.JSCore.IJSObjectProxy<Response>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Response>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.Response New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Response");
        return new global::Natrix.StdWeb.Response(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.Response New(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ReadableStream, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.URLSearchParams, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ReadableStream>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Blob>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8ClampedArray>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigInt64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigUint64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.DataView>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FormData>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLSearchParams>, global::Natrix.JSCore.Generics.StringAccessor>? body)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_4;
        if (body is null)
        {
            ___propObject_4 = null;
        }
        else
        {
            ___propObject_4 = body.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 0, ___propObject_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Response", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.Response(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.Response New(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ReadableStream, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.URLSearchParams, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ReadableStream>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Blob>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8ClampedArray>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigInt64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigUint64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.DataView>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FormData>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLSearchParams>, global::Natrix.JSCore.Generics.StringAccessor>? body, global::Natrix.StdWeb.ResponseInit init)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_4;
        if (body is null)
        {
            ___propObject_4 = null;
        }
        else
        {
            ___propObject_4 = body.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 0, ___propObject_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
        ___marshalledValue_5 = init.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Response", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.Response(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static global::Natrix.StdWeb.Response Error()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Response"), "error", global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Response"), ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Response>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static global::Natrix.StdWeb.Response Redirect(string url)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = url;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Response"), "redirect", global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Response"), ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Response>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static global::Natrix.StdWeb.Response Redirect(string url, ushort status)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = url;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        double ___marshalledValue_4;
        ___marshalledValue_4 = Convert.ToDouble(status);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Response"), "redirect", global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Response"), ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Response>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static global::Natrix.StdWeb.Response Json(global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? data)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_3;
        if (data is null)
        {
            ___propObject_3 = null;
        }
        else
        {
            ___propObject_3 = data.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 0, ___propObject_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Response"), "json", global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Response"), ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Response>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static global::Natrix.StdWeb.Response Json(global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? data, global::Natrix.StdWeb.ResponseInit init)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_3;
        if (data is null)
        {
            ___propObject_3 = null;
        }
        else
        {
            ___propObject_3 = data.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 0, ___propObject_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = init.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Response"), "json", global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Response"), ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Response>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ResponseType Type
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ResponseType>.Get(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Url
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "url");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Redirected
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "redirected");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Status
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "status");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Ok
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "ok");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string StatusText
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "statusText");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Headers Headers
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Headers>.Get(JSObject, "headers");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Response Clone()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "clone", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Response>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ReadableStream? Body
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.ReadableStream>.Get(JSObject, "body");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool BodyUsed
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "bodyUsed");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.ArrayBuffer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>> ArrayBuffer()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "arrayBuffer", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.ArrayBuffer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Blob>> Blob()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "blob", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Blob>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8Array>> Bytes()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "bytes", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8Array>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.FormData, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FormData>> FormData()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "formData", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.FormData, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FormData>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>?, global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>> Json()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "json", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>?, global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<string, global::Natrix.JSCore.Generics.StringAccessor> Text()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "text", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ReadableStream TextStream()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "textStream", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ReadableStream>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable