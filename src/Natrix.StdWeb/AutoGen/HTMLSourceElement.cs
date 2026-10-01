// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLSourceElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLSourceElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLSourceElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLSourceElement global::Natrix.JSCore.IJSObjectProxy<HTMLSourceElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLSourceElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLSourceElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLSourceElement");
        return new global::Natrix.StdWeb.HTMLSourceElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Src
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "src");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "src", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Type
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "type", value);
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
    public string Media
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "media");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "media", value);
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
}

#nullable disable