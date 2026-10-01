// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSImportRule: global::Natrix.StdWeb.CSSRule, global::Natrix.JSCore.IJSObjectProxy<CSSImportRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSImportRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSImportRule global::Natrix.JSCore.IJSObjectProxy<CSSImportRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSImportRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Href
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "href");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaList Media
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaList>.Get(JSObject, "media");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSStyleSheet? StyleSheet
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.CSSStyleSheet>.Get(JSObject, "styleSheet");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? LayerName
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "layerName");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? SupportsText
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "supportsText");
    }
}

#nullable disable