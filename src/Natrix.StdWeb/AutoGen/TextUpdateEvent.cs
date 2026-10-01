// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TextUpdateEvent: global::Natrix.StdWeb.Event, global::Natrix.JSCore.IJSObjectProxy<TextUpdateEvent>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TextUpdateEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TextUpdateEvent global::Natrix.JSCore.IJSObjectProxy<TextUpdateEvent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TextUpdateEvent>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.TextUpdateEvent New(string type)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "TextUpdateEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.TextUpdateEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.TextUpdateEvent New(string type, global::Natrix.StdWeb.TextUpdateEventInit options)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
        ___marshalledValue_5 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "TextUpdateEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.TextUpdateEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint UpdateRangeStart
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "updateRangeStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint UpdateRangeEnd
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "updateRangeEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Text
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "text");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SelectionStart
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "selectionStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SelectionEnd
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "selectionEnd");
    }
}

#nullable disable