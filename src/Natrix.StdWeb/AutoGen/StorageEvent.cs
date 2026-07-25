// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class StorageEvent: global::Natrix.StdWeb.Event
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public StorageEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.StorageEvent New(string type)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "StorageEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.StorageEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.StorageEvent New(string type, global::Natrix.StdWeb.StorageEventInit eventInitDict)
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

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "StorageEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.StorageEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Key
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "key");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? OldValue
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "oldValue");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? NewValue
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "newValue");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Url
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "url");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Storage? StorageArea
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Storage?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "storageArea");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitStorageEvent(string type)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initStorageEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitStorageEvent(string type, bool bubbles)
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

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initStorageEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitStorageEvent(string type, bool bubbles, bool cancelable)
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

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initStorageEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitStorageEvent(string type, bool bubbles, bool cancelable, string? key)
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
        string? ___marshalledValue_6;
        if (key is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            string ___notNullable_7 = (string)key;
            ___marshalledValue_6 = ___notNullable_7;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initStorageEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitStorageEvent(string type, bool bubbles, bool cancelable, string? key, string? oldValue)
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
        string? ___marshalledValue_6;
        if (key is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            string ___notNullable_7 = (string)key;
            ___marshalledValue_6 = ___notNullable_7;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        // Argument 5
        string? ___marshalledValue_8;
        if (oldValue is null)
        {
            ___marshalledValue_8 = null;
        }
        else
        {
            string ___notNullable_9 = (string)oldValue;
            ___marshalledValue_8 = ___notNullable_9;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 4, ___marshalledValue_8);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initStorageEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitStorageEvent(string type, bool bubbles, bool cancelable, string? key, string? oldValue, string? newValue)
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
        string? ___marshalledValue_6;
        if (key is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            string ___notNullable_7 = (string)key;
            ___marshalledValue_6 = ___notNullable_7;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        // Argument 5
        string? ___marshalledValue_8;
        if (oldValue is null)
        {
            ___marshalledValue_8 = null;
        }
        else
        {
            string ___notNullable_9 = (string)oldValue;
            ___marshalledValue_8 = ___notNullable_9;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 4, ___marshalledValue_8);

        // Argument 6
        string? ___marshalledValue_10;
        if (newValue is null)
        {
            ___marshalledValue_10 = null;
        }
        else
        {
            string ___notNullable_11 = (string)newValue;
            ___marshalledValue_10 = ___notNullable_11;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 5, ___marshalledValue_10);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initStorageEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitStorageEvent(string type, bool bubbles, bool cancelable, string? key, string? oldValue, string? newValue, string url)
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
        string? ___marshalledValue_6;
        if (key is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            string ___notNullable_7 = (string)key;
            ___marshalledValue_6 = ___notNullable_7;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        // Argument 5
        string? ___marshalledValue_8;
        if (oldValue is null)
        {
            ___marshalledValue_8 = null;
        }
        else
        {
            string ___notNullable_9 = (string)oldValue;
            ___marshalledValue_8 = ___notNullable_9;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 4, ___marshalledValue_8);

        // Argument 6
        string? ___marshalledValue_10;
        if (newValue is null)
        {
            ___marshalledValue_10 = null;
        }
        else
        {
            string ___notNullable_11 = (string)newValue;
            ___marshalledValue_10 = ___notNullable_11;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 5, ___marshalledValue_10);

        // Argument 7
        string ___marshalledValue_12;
        ___marshalledValue_12 = url;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 6, ___marshalledValue_12);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initStorageEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitStorageEvent(string type, bool bubbles, bool cancelable, string? key, string? oldValue, string? newValue, string url, global::Natrix.StdWeb.Storage? storageArea)
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
        string? ___marshalledValue_6;
        if (key is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            string ___notNullable_7 = (string)key;
            ___marshalledValue_6 = ___notNullable_7;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        // Argument 5
        string? ___marshalledValue_8;
        if (oldValue is null)
        {
            ___marshalledValue_8 = null;
        }
        else
        {
            string ___notNullable_9 = (string)oldValue;
            ___marshalledValue_8 = ___notNullable_9;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 4, ___marshalledValue_8);

        // Argument 6
        string? ___marshalledValue_10;
        if (newValue is null)
        {
            ___marshalledValue_10 = null;
        }
        else
        {
            string ___notNullable_11 = (string)newValue;
            ___marshalledValue_10 = ___notNullable_11;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 5, ___marshalledValue_10);

        // Argument 7
        string ___marshalledValue_12;
        ___marshalledValue_12 = url;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 6, ___marshalledValue_12);

        // Argument 8
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_13;
        if (storageArea is null)
        {
            ___marshalledValue_13 = null;
        }
        else
        {
            global::Natrix.StdWeb.Storage ___notNullable_14 = (global::Natrix.StdWeb.Storage)storageArea;
            ___marshalledValue_13 = ___notNullable_14.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 7, ___marshalledValue_13);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initStorageEvent", JSObject, ___argsArray_0.JSObject);
    }
}

#nullable disable