// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSMediaRule: global::Natrix.StdWeb.CSSConditionRule
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSMediaRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaList Media
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaList, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "media");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Matches
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "matches");
    }
}

#nullable disable