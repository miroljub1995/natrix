// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSMarginRule: global::Natrix.StdWeb.CSSRule, global::Natrix.JSCore.IJSObjectProxy<CSSMarginRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSMarginRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSMarginRule global::Natrix.JSCore.IJSObjectProxy<CSSMarginRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSMarginRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSStyleDeclaration Style
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSStyleDeclaration>.Get(JSObject, "style");
    }
}

#nullable disable