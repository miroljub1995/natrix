// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSCustomMediaRule: global::Natrix.StdWeb.CSSRule, global::Natrix.JSCore.IJSObjectProxy<CSSCustomMediaRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSCustomMediaRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSCustomMediaRule global::Natrix.JSCore.IJSObjectProxy<CSSCustomMediaRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSCustomMediaRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaList, bool, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaList>, global::Natrix.JSCore.Generics.BooleanAccessor> Query
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaList, bool, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaList>, global::Natrix.JSCore.Generics.BooleanAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaList, bool, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaList>, global::Natrix.JSCore.Generics.BooleanAccessor>>>(JSObject, "query");
    }
}

#nullable disable