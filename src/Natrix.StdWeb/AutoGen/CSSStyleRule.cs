// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSStyleRule: global::Natrix.StdWeb.CSSGroupingRule
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSStyleRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.StylePropertyMap StyleMap
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.StylePropertyMap, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "styleMap");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SelectorText
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "selectorText");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "selectorText", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSStyleProperties Style
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSStyleProperties, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "style");
    }
}

#nullable disable