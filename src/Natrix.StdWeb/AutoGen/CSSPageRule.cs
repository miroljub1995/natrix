// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSPageRule: global::Natrix.StdWeb.CSSGroupingRule
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSPageRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SelectorText
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "selectorText");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "selectorText", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSPageDescriptors Style
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSPageDescriptors, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "style");
    }
}

#nullable disable