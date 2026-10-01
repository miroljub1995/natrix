// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSConditionRule: global::Natrix.StdWeb.CSSGroupingRule, global::Natrix.JSCore.IJSObjectProxy<CSSConditionRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSConditionRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSConditionRule global::Natrix.JSCore.IJSObjectProxy<CSSConditionRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSConditionRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ConditionText
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "conditionText");
    }
}

#nullable disable