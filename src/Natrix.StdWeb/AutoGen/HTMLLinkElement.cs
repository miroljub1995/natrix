// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLLinkElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLLinkElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLLinkElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLLinkElement global::Natrix.JSCore.IJSObjectProxy<HTMLLinkElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLLinkElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLLinkElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLLinkElement");
        return new global::Natrix.StdWeb.HTMLLinkElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Href
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "href");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "href", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? CrossOrigin
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "crossOrigin");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "crossOrigin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Rel
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "rel");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "rel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string As
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "as");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "as", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMTokenList RelList
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMTokenList>.Get(JSObject, "relList");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Media
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "media");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "media", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Integrity
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "integrity");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "integrity", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Hreflang
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "hreflang");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "hreflang", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Type
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMTokenList Sizes
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMTokenList>.Get(JSObject, "sizes");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ImageSrcset
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "imageSrcset");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "imageSrcset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ImageSizes
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "imageSizes");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "imageSizes", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ReferrerPolicy
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "referrerPolicy");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "referrerPolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMTokenList Blocking
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMTokenList>.Get(JSObject, "blocking");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Disabled
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "disabled");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "disabled", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FetchPriority
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "fetchPriority");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "fetchPriority", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Charset
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "charset");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "charset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Rev
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "rev");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "rev", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Target
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "target");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "target", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSStyleSheet? Sheet
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.CSSStyleSheet>.Get(JSObject, "sheet");
    }
}

#nullable disable