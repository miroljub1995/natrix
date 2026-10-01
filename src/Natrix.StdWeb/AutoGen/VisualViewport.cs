// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VisualViewport: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<VisualViewport>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VisualViewport(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static VisualViewport global::Natrix.JSCore.IJSObjectProxy<VisualViewport>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<VisualViewport>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double OffsetLeft
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "offsetLeft");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double OffsetTop
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "offsetTop");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PageLeft
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "pageLeft");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PageTop
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "pageTop");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Width
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "width");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Height
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "height");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Scale
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "scale");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onresize
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onresize");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onresize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onscroll
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onscroll");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onscroll", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onscrollend
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onscrollend");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onscrollend", value);
    }
}

#nullable disable