// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSStyleRule: global::Natrix.StdWeb.CSSGroupingRule, global::Natrix.JSCore.IJSObjectProxy<CSSStyleRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSStyleRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSStyleRule global::Natrix.JSCore.IJSObjectProxy<CSSStyleRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSStyleRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.StylePropertyMap StyleMap
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.StylePropertyMap, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.StylePropertyMap>>(JSObject, "styleMap");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SelectorText
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "selectorText");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "selectorText", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSStyleProperties Style
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSStyleProperties, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSStyleProperties>>(JSObject, "style");
    }
}

#nullable disable