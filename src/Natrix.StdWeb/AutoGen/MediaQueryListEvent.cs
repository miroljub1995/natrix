// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaQueryListEvent: global::Natrix.StdWeb.Event, global::Natrix.JSCore.IJSObjectProxy<MediaQueryListEvent>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaQueryListEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaQueryListEvent global::Natrix.JSCore.IJSObjectProxy<MediaQueryListEvent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<MediaQueryListEvent>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.MediaQueryListEvent New(string type)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "MediaQueryListEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.MediaQueryListEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.MediaQueryListEvent New(string type, global::Natrix.StdWeb.MediaQueryListEventInit eventInitDict)
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

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "MediaQueryListEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.MediaQueryListEvent(___res_2);
    }

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
}

#nullable disable