// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ResizeObserverEntry: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ResizeObserverEntry>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ResizeObserverEntry(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ResizeObserverEntry global::Natrix.JSCore.IJSObjectProxy<ResizeObserverEntry>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ResizeObserverEntry>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element Target
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>.Get(JSObject, "target");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMRectReadOnly ContentRect
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRectReadOnly>.Get(JSObject, "contentRect");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ResizeObserverSize, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ResizeObserverSize>> BorderBoxSize
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ResizeObserverSize, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ResizeObserverSize>>>.Get(JSObject, "borderBoxSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ResizeObserverSize, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ResizeObserverSize>> ContentBoxSize
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ResizeObserverSize, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ResizeObserverSize>>>.Get(JSObject, "contentBoxSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ResizeObserverSize, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ResizeObserverSize>> DevicePixelContentBoxSize
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.ResizeObserverSize, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ResizeObserverSize>>>.Get(JSObject, "devicePixelContentBoxSize");
    }
}

#nullable disable