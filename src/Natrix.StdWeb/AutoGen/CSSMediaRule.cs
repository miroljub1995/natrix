// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSMediaRule: global::Natrix.StdWeb.CSSConditionRule, global::Natrix.JSCore.IJSObjectProxy<CSSMediaRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSMediaRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSMediaRule global::Natrix.JSCore.IJSObjectProxy<CSSMediaRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSMediaRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaList Media
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaList>.Get(JSObject, "media");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Matches
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "matches");
    }
}

#nullable disable