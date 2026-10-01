// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaQueryList: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<MediaQueryList>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaQueryList(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaQueryList global::Natrix.JSCore.IJSObjectProxy<MediaQueryList>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<MediaQueryList>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Media
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "media");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Matches
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "matches");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void AddListener(global::Natrix.StdWeb.EventListener? callback)
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
            global::Natrix.StdWeb.EventListener ___notNullable_4 = (global::Natrix.StdWeb.EventListener)callback;
            ___marshalledValue_3 = ___notNullable_4.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "addListener", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void RemoveListener(global::Natrix.StdWeb.EventListener? callback)
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
            global::Natrix.StdWeb.EventListener ___notNullable_4 = (global::Natrix.StdWeb.EventListener)callback;
            ___marshalledValue_3 = ___notNullable_4.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "removeListener", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onchange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onchange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onchange", value);
    }
}

#nullable disable