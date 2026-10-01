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
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ScreenDetailed, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ScreenDetailed>>>.Get(JSObject, "screens");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ScreenDetailed CurrentScreen
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ScreenDetailed>.Get(JSObject, "currentScreen");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onscreenschange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onscreenschange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onscreenschange", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Oncurrentscreenchange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "oncurrentscreenchange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "oncurrentscreenchange", value);
    }
}

#nullable disable