// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ChildBreakToken: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ChildBreakToken(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BreakType BreakType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.BreakType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "breakType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.LayoutChild Child
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.LayoutChild, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "child");
    }
}

#nullable disable