// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DataTransferItem: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<DataTransferItem>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DataTransferItem(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DataTransferItem global::Natrix.JSCore.IJSObjectProxy<DataTransferItem>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<DataTransferItem>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FileSystemEntry? WebkitGetAsEntry()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "webkitGetAsEntry", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.FileSystemEntry>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.FileSystemHandle?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.FileSystemHandle>> GetAsFileSystemHandle()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getAsFileSystemHandle", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.FileSystemHandle?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.FileSystemHandle>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Kind
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "kind");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Type
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void GetAsString(global::Natrix.StdWeb.FunctionStringCallback? callback)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_3;
        if (callback is null)
        {
            ___marshalledValue_3 = null;
        }
        else
        {
            global::Natrix.StdWeb.FunctionStringCallback ___notNullable_4 = (global::Natrix.StdWeb.FunctionStringCallback)callback;
            ___marshalledValue_3 = ___notNullable_4.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "getAsString", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.File? GetAsFile()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getAsFile", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.File>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable