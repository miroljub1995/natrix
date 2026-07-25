// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSConditionRule: global::Natrix.StdWeb.CSSGroupingRule
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSConditionRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ConditionText
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "conditionText");
    }
}

#nullable disable