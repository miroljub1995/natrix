// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public delegate void FileSystemEntriesCallbackManaged(global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.FileSystemEntry, global::Natrix.StdWeb.PropertyAccessor> entries);

public partial class FileSystemEntriesCallback: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FileSystemEntriesCallback(global::System.Runtime.InteropServices.JavaScript.JSObject obj) : base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FileSystemEntriesCallback(FileSystemEntriesCallbackManaged input): this(ToJSObject(input))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static implicit operator FileSystemEntriesCallback(FileSystemEntriesCallbackManaged input)
    {
        return new global::Natrix.StdWeb.FileSystemEntriesCallback(ToJSObject(input));
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TryGetManaged([global::System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] out global::Natrix.StdWeb.FileSystemEntriesCallbackManaged? managed, bool allowConversion = false)
    {
        managed = global::Natrix.JSCore.Extensions.JSFunctionExtensions.GetManagedFunctionFromProperty(JSObject) as global::Natrix.StdWeb.FileSystemEntriesCallbackManaged;
        if (managed is not null)
        {
            return true;
        }

        if (!allowConversion)
        {
            return false;
        }

        managed = (entries) =>
        {
            int ___argsArrayLength_3 = 1;

            using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

            // Argument 1
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = entries.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___propObject_4);

            global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunction(JSObject, null, ___argsArray_0.JSObject);
        };
        return true;
    }
    
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    private static global::System.Runtime.InteropServices.JavaScript.JSObject ToJSObject(FileSystemEntriesCallbackManaged input)
    {
        Action<global::System.Runtime.InteropServices.JavaScript.JSObject> callback = (___args_0) =>
        {
            using (___args_0)
            {
                // Argument 1
                global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.FileSystemEntry, global::Natrix.StdWeb.PropertyAccessor> ___arg_2;
                global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3;
                ___propObject_3 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(___args_0, 0);
                ___arg_2 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.FileSystemEntry, global::Natrix.StdWeb.PropertyAccessor>(___propObject_3);

                input(___arg_2);
            }
        };

        global::System.Runtime.InteropServices.JavaScript.JSObject ___funcObj_4 = global::Natrix.JSCore.Extensions.JSFunctionExtensions.WrapAsVoidFunction(callback);
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.StoreManagedFunctionToProperty(___funcObj_4, input);

        return ___funcObj_4;
    }
}

#nullable disable