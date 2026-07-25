// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLImageElement: global::Natrix.StdWeb.HTMLElement
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLImageElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int X
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "x");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Y
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "y");
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
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "alt");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "alt", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Src
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "src");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "src", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Srcset
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "srcset");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "srcset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Sizes
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sizes");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sizes", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? CrossOrigin
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "crossOrigin");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "crossOrigin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string UseMap
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "useMap");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "useMap", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsMap
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isMap");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isMap", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Controls
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "controls");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "controls", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Width
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "width");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Height
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "height");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint NaturalWidth
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "naturalWidth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint NaturalHeight
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "naturalHeight");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Complete
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "complete");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string CurrentSrc
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "currentSrc");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ReferrerPolicy
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "referrerPolicy");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "referrerPolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Decoding
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "decoding");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "decoding", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Loading
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "loading");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "loading", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FetchPriority
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "fetchPriority");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "fetchPriority", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise Decode()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "decode", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Promise, global::Natrix.StdWeb.PropertyAccessor>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "name");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Lowsrc
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "lowsrc");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "lowsrc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Align
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "align");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "align", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Hspace
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hspace");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hspace", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Vspace
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "vspace");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "vspace", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string LongDesc
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "longDesc");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "longDesc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Border
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "border");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "border", value);
    }
}

#nullable disable