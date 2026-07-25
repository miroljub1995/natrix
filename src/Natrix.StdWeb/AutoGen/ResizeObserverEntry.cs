// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ResizeObserverEntry: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ResizeObserverEntry(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element Target
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "target");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMRectReadOnly ContentRect
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DOMRectReadOnly, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "contentRect");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ResizeObserverSize, global::Natrix.StdWeb.PropertyAccessor> BorderBoxSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ResizeObserverSize, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "borderBoxSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ResizeObserverSize, global::Natrix.StdWeb.PropertyAccessor> ContentBoxSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ResizeObserverSize, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "contentBoxSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ResizeObserverSize, global::Natrix.StdWeb.PropertyAccessor> DevicePixelContentBoxSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ResizeObserverSize, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "devicePixelContentBoxSize");
    }
}

#nullable disable