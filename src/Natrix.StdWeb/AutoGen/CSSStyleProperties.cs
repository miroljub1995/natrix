// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSStyleProperties: global::Natrix.StdWeb.CSSStyleDeclaration, global::Natrix.JSCore.IJSObjectProxy<CSSStyleProperties>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSStyleProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSStyleProperties global::Natrix.JSCore.IJSObjectProxy<CSSStyleProperties>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSStyleProperties>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string CssFloat
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "cssFloat");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "cssFloat", value);
    }
}

#nullable disable