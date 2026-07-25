// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSViewTransitionRule: global::Natrix.StdWeb.CSSRule
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSViewTransitionRule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Navigation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "navigation");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.StdWeb.PropertyAccessor> Types
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "types");
    }
}

#nullable disable