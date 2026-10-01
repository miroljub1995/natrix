// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSKeyframeRule: global::Natrix.StdWeb.CSSRule, global::Natrix.JSCore.IJSObjectProxy<CSSKeyframeRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSKeyframeRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSKeyframeRule global::Natrix.JSCore.IJSObjectProxy<CSSKeyframeRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSKeyframeRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string KeyText
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "keyText");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "keyText", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSStyleProperties Style
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSStyleProperties>.Get(JSObject, "style");
    }
}

#nullable disable