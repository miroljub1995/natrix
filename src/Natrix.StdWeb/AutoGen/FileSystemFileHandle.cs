// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FileSystemFileHandle: global::Natrix.StdWeb.FileSystemHandle, global::Natrix.JSCore.IJSObjectProxy<FileSystemFileHandle>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FileSystemFileHandle(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FileSystemFileHandle global::Natrix.JSCore.IJSObjectProxy<FileSystemFileHandle>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<FileSystemFileHandle>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.File, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.File>> GetFile()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getFile", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.File, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.File>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.FileSystemWritableFileStream, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemWritableFileStream>> CreateWritable()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "createWritable", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.FileSystemWritableFileStream, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemWritableFileStream>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.FileSystemWritableFileStream, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemWritableFileStream>> CreateWritable(global::Natrix.StdWeb.FileSystemCreateWritableOptions options)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "createWritable", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.FileSystemWritableFileStream, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemWritableFileStream>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.FileSystemSyncAccessHandle, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemSyncAccessHandle>> CreateSyncAccessHandle()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "createSyncAccessHandle", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.FileSystemSyncAccessHandle, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemSyncAccessHandle>>>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable