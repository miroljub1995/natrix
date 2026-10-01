// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BackgroundFetchRegistration: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<BackgroundFetchRegistration>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BackgroundFetchRegistration(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BackgroundFetchRegistration global::Natrix.JSCore.IJSObjectProxy<BackgroundFetchRegistration>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<BackgroundFetchRegistration>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Id
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "id");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong UploadTotal
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "uploadTotal");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Uploaded
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "uploaded");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DownloadTotal
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "downloadTotal");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Downloaded
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "downloaded");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BackgroundFetchResult Result
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.BackgroundFetchResult>.Get(JSObject, "result");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BackgroundFetchFailureReason FailureReason
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.BackgroundFetchFailureReason>.Get(JSObject, "failureReason");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RecordsAvailable
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "recordsAvailable");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onprogress
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onprogress");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onprogress", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<bool, global::Natrix.JSCore.Generics.BooleanAccessor> Abort()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "abort", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.BackgroundFetchRecord, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundFetchRecord>> Match(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Request, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Request>, global::Natrix.JSCore.Generics.StringAccessor> request)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = request.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "match", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.BackgroundFetchRecord, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundFetchRecord>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.BackgroundFetchRecord, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundFetchRecord>> Match(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Request, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Request>, global::Natrix.JSCore.Generics.StringAccessor> request, global::Natrix.StdWeb.CacheQueryOptions options)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = request.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "match", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.BackgroundFetchRecord, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundFetchRecord>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BackgroundFetchRecord, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundFetchRecord>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BackgroundFetchRecord, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundFetchRecord>>>> MatchAll()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "matchAll", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BackgroundFetchRecord, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundFetchRecord>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BackgroundFetchRecord, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundFetchRecord>>>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BackgroundFetchRecord, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundFetchRecord>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BackgroundFetchRecord, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundFetchRecord>>>> MatchAll(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Request, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Request>, global::Natrix.JSCore.Generics.StringAccessor> request)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = request.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "matchAll", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BackgroundFetchRecord, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundFetchRecord>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BackgroundFetchRecord, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundFetchRecord>>>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BackgroundFetchRecord, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundFetchRecord>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BackgroundFetchRecord, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundFetchRecord>>>> MatchAll(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Request, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Request>, global::Natrix.JSCore.Generics.StringAccessor> request, global::Natrix.StdWeb.CacheQueryOptions options)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = request.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "matchAll", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BackgroundFetchRecord, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundFetchRecord>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BackgroundFetchRecord, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.BackgroundFetchRecord>>>>>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable