// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSNamespaceRule: global::Natrix.StdWeb.CSSRule, global::Natrix.JSCore.IJSObjectProxy<CSSNamespaceRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSNamespaceRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSNamespaceRule global::Natrix.JSCore.IJSObjectProxy<CSSNamespaceRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSNamespaceRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string NamespaceURI
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "namespaceURI");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Prefix
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "prefix");
    }
}

#nullable disable