// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSSupportsRule: global::Natrix.StdWeb.CSSConditionRule
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSSupportsRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Matches
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "matches");
    }
}

#nullable disable