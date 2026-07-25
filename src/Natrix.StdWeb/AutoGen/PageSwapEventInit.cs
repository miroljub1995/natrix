// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PageSwapEventInit: global::Natrix.StdWeb.EventInit
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PageSwapEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PageSwapEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationActivation? Activation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NavigationActivation?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "activation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.NavigationActivation?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "activation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ViewTransition? ViewTransition
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ViewTransition?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "viewTransition");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ViewTransition?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "viewTransition", value);
    }
}

#nullable disable