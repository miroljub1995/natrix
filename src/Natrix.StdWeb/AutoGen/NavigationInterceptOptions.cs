// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NavigationInterceptOptions: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigationInterceptOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NavigationInterceptOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationPrecommitHandler PrecommitHandler
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NavigationPrecommitHandler, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "precommitHandler");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.NavigationPrecommitHandler, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "precommitHandler", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationInterceptHandler Handler
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NavigationInterceptHandler, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "handler");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.NavigationInterceptHandler, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "handler", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationFocusReset FocusReset
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NavigationFocusReset, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "focusReset");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.NavigationFocusReset, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "focusReset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationScrollBehavior Scroll
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NavigationScrollBehavior, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "scroll");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.NavigationScrollBehavior, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "scroll", value);
    }
}

#nullable disable