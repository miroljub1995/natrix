// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ChildBreakToken: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ChildBreakToken>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ChildBreakToken(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ChildBreakToken global::Natrix.JSCore.IJSObjectProxy<ChildBreakToken>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ChildBreakToken>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BreakType BreakType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.BreakType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.BreakType>>(JSObject, "breakType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.LayoutChild Child
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.LayoutChild, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LayoutChild>>(JSObject, "child");
    }
}

#nullable disable