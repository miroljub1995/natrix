// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class StyleSheet: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<StyleSheet>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public StyleSheet(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static StyleSheet global::Natrix.JSCore.IJSObjectProxy<StyleSheet>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<StyleSheet>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Type
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Href
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "href");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.ProcessingInstruction, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProcessingInstruction>>? OwnerNode
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.ProcessingInstruction, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProcessingInstruction>>>.Get(JSObject, "ownerNode");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSStyleSheet? ParentStyleSheet
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.CSSStyleSheet>.Get(JSObject, "parentStyleSheet");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Title
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "title");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaList Media
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaList>.Get(JSObject, "media");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Disabled
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "disabled");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "disabled", value);
    }
}

#nullable disable