// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLImageElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLImageElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLImageElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLImageElement global::Natrix.JSCore.IJSObjectProxy<HTMLImageElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLImageElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int X
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "x");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Y
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "y");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLImageElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLImageElement");
        return new global::Natrix.StdWeb.HTMLImageElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Alt
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "alt");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "alt", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Src
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "src");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "src", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Srcset
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "srcset");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "srcset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Sizes
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "sizes");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "sizes", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? CrossOrigin
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "crossOrigin");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "crossOrigin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string UseMap
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "useMap");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "useMap", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsMap
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isMap");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "isMap", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Controls
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "controls");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "controls", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Width
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Height
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint NaturalWidth
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "naturalWidth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint NaturalHeight
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "naturalHeight");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Complete
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "complete");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string CurrentSrc
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "currentSrc");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ReferrerPolicy
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "referrerPolicy");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "referrerPolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Decoding
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "decoding");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "decoding", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Loading
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "loading");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "loading", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FetchPriority
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "fetchPriority");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "fetchPriority", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise Decode()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "decode", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Lowsrc
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "lowsrc");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "lowsrc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Align
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "align");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "align", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Hspace
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "hspace");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "hspace", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Vspace
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "vspace");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "vspace", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string LongDesc
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "longDesc");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "longDesc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Border
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "border");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "border", value);
    }
}

#nullable disable