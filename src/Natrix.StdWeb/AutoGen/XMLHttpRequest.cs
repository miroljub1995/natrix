// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XMLHttpRequest: global::Natrix.StdWeb.XMLHttpRequestEventTarget, global::Natrix.JSCore.IJSObjectProxy<XMLHttpRequest>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XMLHttpRequest(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XMLHttpRequest global::Natrix.JSCore.IJSObjectProxy<XMLHttpRequest>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XMLHttpRequest>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetPrivateToken(global::Natrix.StdWeb.PrivateToken privateToken)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = privateToken.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setPrivateToken", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.XMLHttpRequest New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "XMLHttpRequest");
        return new global::Natrix.StdWeb.XMLHttpRequest(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onreadystatechange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onreadystatechange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onreadystatechange", value);
    }

    public const ushort UNSENT = 0;

    public const ushort OPENED = 1;

    public const ushort HEADERS_RECEIVED = 2;

    public const ushort LOADING = 3;

    public const ushort DONE = 4;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort ReadyState
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "readyState");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Open(string method, string url)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = method;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        string ___marshalledValue_4;
        ___marshalledValue_4 = url;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "open", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Open(string method, string url, bool async)
    {
        int ___argsArrayLength_2 = 3;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = method;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        string ___marshalledValue_4;
        ___marshalledValue_4 = url;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = async;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "open", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Open(string method, string url, bool async, string? username)
    {
        int ___argsArrayLength_2 = 4;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = method;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        string ___marshalledValue_4;
        ___marshalledValue_4 = url;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = async;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        string? ___marshalledValue_6;
        if (username is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            string ___notNullable_7 = (string)username;
            ___marshalledValue_6 = ___notNullable_7;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "open", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Open(string method, string url, bool async, string? username, string? password)
    {
        int ___argsArrayLength_2 = 5;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = method;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        string ___marshalledValue_4;
        ___marshalledValue_4 = url;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = async;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        string? ___marshalledValue_6;
        if (username is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            string ___notNullable_7 = (string)username;
            ___marshalledValue_6 = ___notNullable_7;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        // Argument 5
        string? ___marshalledValue_8;
        if (password is null)
        {
            ___marshalledValue_8 = null;
        }
        else
        {
            string ___notNullable_9 = (string)password;
            ___marshalledValue_8 = ___notNullable_9;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 4, ___marshalledValue_8);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "open", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetRequestHeader(string name, string value)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = name;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        string ___marshalledValue_4;
        ___marshalledValue_4 = value;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setRequestHeader", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Timeout
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "timeout");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "timeout", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool WithCredentials
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "withCredentials");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "withCredentials", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XMLHttpRequestUpload Upload
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XMLHttpRequestUpload>.Get(JSObject, "upload");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Send()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "send", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Send(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Document, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.URLSearchParams, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Document>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Blob>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8ClampedArray>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigInt64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigUint64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.DataView>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FormData>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLSearchParams>, global::Natrix.JSCore.Generics.StringAccessor>? body)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_3;
        if (body is null)
        {
            ___propObject_3 = null;
        }
        else
        {
            ___propObject_3 = body.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 0, ___propObject_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "send", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Abort()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "abort", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ResponseURL
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "responseURL");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Status
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "status");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string StatusText
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "statusText");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? GetResponseHeader(string name)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = name;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getResponseHeader", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableStringAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string GetAllResponseHeaders()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getAllResponseHeaders", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.StringAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void OverrideMimeType(string mime)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = mime;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "overrideMimeType", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XMLHttpRequestResponseType ResponseType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XMLHttpRequestResponseType>.Get(JSObject, "responseType");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XMLHttpRequestResponseType>.Set(JSObject, "responseType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? Response
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Get(JSObject, "response");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ResponseText
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "responseText");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Document? ResponseXML
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Document>.Get(JSObject, "responseXML");
    }
}

#nullable disable