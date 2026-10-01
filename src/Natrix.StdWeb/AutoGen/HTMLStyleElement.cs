// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLStyleElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLStyleElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLStyleElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLStyleElement global::Natrix.JSCore.IJSObjectProxy<HTMLStyleElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLStyleElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLStyleElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLStyleElement");
        return new global::Natrix.StdWeb.HTMLStyleElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Disabled
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "disabled");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "disabled", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Media
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "media");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "media", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMTokenList Blocking
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMTokenList>.Get(JSObject, "blocking");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Type
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSStyleSheet? Sheet
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.CSSStyleSheet>.Get(JSObject, "sheet");
    }
}

#nullable disable