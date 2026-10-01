// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSSupportsConditionRule: global::Natrix.StdWeb.CSSGroupingRule, global::Natrix.JSCore.IJSObjectProxy<CSSSupportsConditionRule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSSupportsConditionRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSSupportsConditionRule global::Natrix.JSCore.IJSObjectProxy<CSSSupportsConditionRule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSSupportsConditionRule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "name");
    }
}

#nullable disable