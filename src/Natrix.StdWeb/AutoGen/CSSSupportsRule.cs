// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSSupportsRule: global::Natrix.StdWeb.CSSConditionRule, global::Natrix.JSCore.IJSObjectProxy<CSSSupportsRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSSupportsRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSSupportsRule global::Natrix.JSCore.IJSObjectProxy<CSSSupportsRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSSupportsRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Matches
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "matches");
    }
}

#nullable disable