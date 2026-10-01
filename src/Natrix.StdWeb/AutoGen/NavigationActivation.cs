// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NavigationActivation: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<NavigationActivation>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigationActivation(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static NavigationActivation global::Natrix.JSCore.IJSObjectProxy<NavigationActivation>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<NavigationActivation>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationHistoryEntry? From
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.NavigationHistoryEntry>.Get(JSObject, "from");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationHistoryEntry Entry
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationHistoryEntry>.Get(JSObject, "entry");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationType NavigationType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.NavigationType>.Get(JSObject, "navigationType");
    }
}

#nullable disable