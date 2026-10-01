// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FullscreenOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<FullscreenOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FullscreenOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FullscreenOptions global::Natrix.JSCore.IJSObjectProxy<FullscreenOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FullscreenOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FullscreenKeyboardLock KeyboardLock
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FullscreenKeyboardLock>.Get(JSObject, "keyboardLock");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FullscreenKeyboardLock>.Set(JSObject, "keyboardLock", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FullscreenNavigationUI NavigationUI
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FullscreenNavigationUI>.Get(JSObject, "navigationUI");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FullscreenNavigationUI>.Set(JSObject, "navigationUI", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ScreenDetailed Screen
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ScreenDetailed>.Get(JSObject, "screen");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ScreenDetailed>.Set(JSObject, "screen", value);
    }
}

#nullable disable