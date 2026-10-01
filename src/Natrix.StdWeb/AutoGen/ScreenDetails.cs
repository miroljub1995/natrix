// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ScreenDetails: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<ScreenDetails>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ScreenDetails(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ScreenDetails global::Natrix.JSCore.IJSObjectProxy<ScreenDetails>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ScreenDetails>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ScreenDetailed, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ScreenDetailed>> Screens
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ScreenDetailed, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ScreenDetailed>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ScreenDetailed, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ScreenDetailed>>>>(JSObject, "screens");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ScreenDetailed CurrentScreen
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ScreenDetailed, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ScreenDetailed>>(JSObject, "currentScreen");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onscreenschange
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "onscreenschange");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "onscreenschange", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Oncurrentscreenchange
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "oncurrentscreenchange");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.EventHandlerNonNull?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>>(JSObject, "oncurrentscreenchange", value);
    }
}

#nullable disable