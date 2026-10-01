// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VirtualKeyboard: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<VirtualKeyboard>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VirtualKeyboard(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static VirtualKeyboard global::Natrix.JSCore.IJSObjectProxy<VirtualKeyboard>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<VirtualKeyboard>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Show()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "show", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Hide()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "hide", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMRect BoundingRect
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRect>.Get(JSObject, "boundingRect");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool OverlaysContent
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "overlaysContent");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "overlaysContent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Ongeometrychange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "ongeometrychange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "ongeometrychange", value);
    }
}

#nullable disable