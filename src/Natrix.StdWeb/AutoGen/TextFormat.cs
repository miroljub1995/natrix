// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TextFormat: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TextFormat>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TextFormat(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TextFormat global::Natrix.JSCore.IJSObjectProxy<TextFormat>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TextFormat>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.TextFormat New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "TextFormat");
        return new global::Natrix.StdWeb.TextFormat(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.TextFormat New(global::Natrix.StdWeb.TextFormatInit options)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "TextFormat", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.TextFormat(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint RangeStart
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "rangeStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint RangeEnd
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "rangeEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.UnderlineStyle UnderlineStyle
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.UnderlineStyle>.Get(JSObject, "underlineStyle");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.UnderlineThickness UnderlineThickness
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.UnderlineThickness>.Get(JSObject, "underlineThickness");
    }
}

#nullable disable