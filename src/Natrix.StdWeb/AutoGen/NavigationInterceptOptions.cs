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
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NavigationPrecommitHandler, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationPrecommitHandler>>(JSObject, "precommitHandler");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.NavigationPrecommitHandler, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationPrecommitHandler>>(JSObject, "precommitHandler", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationInterceptHandler Handler
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NavigationInterceptHandler, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationInterceptHandler>>(JSObject, "handler");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.NavigationInterceptHandler, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NavigationInterceptHandler>>(JSObject, "handler", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationFocusReset FocusReset
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NavigationFocusReset, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.NavigationFocusReset>>(JSObject, "focusReset");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.NavigationFocusReset, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.NavigationFocusReset>>(JSObject, "focusReset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationScrollBehavior Scroll
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NavigationScrollBehavior, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.NavigationScrollBehavior>>(JSObject, "scroll");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.NavigationScrollBehavior, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.NavigationScrollBehavior>>(JSObject, "scroll", value);
    }
}

#nullable disable