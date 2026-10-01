// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WindowControlsOverlay: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<WindowControlsOverlay>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WindowControlsOverlay(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WindowControlsOverlay global::Natrix.JSCore.IJSObjectProxy<WindowControlsOverlay>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<WindowControlsOverlay>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Visible
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "visible");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMRect GetTitlebarAreaRect()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getTitlebarAreaRect", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRect>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Ongeometrychange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "ongeometrychange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "ongeometrychange", value);
    }
}

#nullable disable