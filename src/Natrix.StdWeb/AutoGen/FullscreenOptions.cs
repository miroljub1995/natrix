// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FullscreenOptions: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FullscreenOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FullscreenOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FullscreenKeyboardLock KeyboardLock
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.FullscreenKeyboardLock, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "keyboardLock");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.FullscreenKeyboardLock, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "keyboardLock", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FullscreenNavigationUI NavigationUI
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.FullscreenNavigationUI, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "navigationUI");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.FullscreenNavigationUI, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "navigationUI", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ScreenDetailed Screen
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ScreenDetailed, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "screen");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ScreenDetailed, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "screen", value);
    }
}

#nullable disable