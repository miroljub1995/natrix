// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLFontElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLFontElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLFontElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLFontElement global::Natrix.JSCore.IJSObjectProxy<HTMLFontElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLFontElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLFontElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLFontElement");
        return new global::Natrix.StdWeb.HTMLFontElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Color
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "color");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "color", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Face
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "face");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "face", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Size
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "size");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "size", value);
    }
}

#nullable disable