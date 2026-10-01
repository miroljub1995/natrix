// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSPageRule: global::Natrix.StdWeb.CSSGroupingRule, global::Natrix.JSCore.IJSObjectProxy<CSSPageRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSPageRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSPageRule global::Natrix.JSCore.IJSObjectProxy<CSSPageRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSPageRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SelectorText
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "selectorText");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "selectorText", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSPageDescriptors Style
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSPageDescriptors, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSPageDescriptors>>(JSObject, "style");
    }
}

#nullable disable