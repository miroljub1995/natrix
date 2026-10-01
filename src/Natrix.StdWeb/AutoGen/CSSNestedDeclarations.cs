// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSNestedDeclarations: global::Natrix.StdWeb.CSSRule, global::Natrix.JSCore.IJSObjectProxy<CSSNestedDeclarations>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSNestedDeclarations(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSNestedDeclarations global::Natrix.JSCore.IJSObjectProxy<CSSNestedDeclarations>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSNestedDeclarations>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSStyleProperties Style
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSStyleProperties>.Get(JSObject, "style");
    }
}

#nullable disable