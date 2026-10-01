// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NavigationInterceptOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<NavigationInterceptOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigationInterceptOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static NavigationInterceptOptions global::Natrix.JSCore.IJSObjectProxy<NavigationInterceptOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigationInterceptOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationPrecommitHandler PrecommitHandler
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationPrecommitHandler>.Get(JSObject, "precommitHandler");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationPrecommitHandler>.Set(JSObject, "precommitHandler", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationInterceptHandler Handler
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationInterceptHandler>.Get(JSObject, "handler");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationInterceptHandler>.Set(JSObject, "handler", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationFocusReset FocusReset
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.NavigationFocusReset>.Get(JSObject, "focusReset");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.NavigationFocusReset>.Set(JSObject, "focusReset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationScrollBehavior Scroll
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.NavigationScrollBehavior>.Get(JSObject, "scroll");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.NavigationScrollBehavior>.Set(JSObject, "scroll", value);
    }
}

#nullable disable