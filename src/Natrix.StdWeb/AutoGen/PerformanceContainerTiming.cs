// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PerformanceContainerTiming: global::Natrix.StdWeb.PerformanceEntry, global::Natrix.JSCore.IJSObjectProxy<PerformanceContainerTiming>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PerformanceContainerTiming(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PerformanceContainerTiming global::Natrix.JSCore.IJSObjectProxy<PerformanceContainerTiming>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PerformanceContainerTiming>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Identifier
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "identifier");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMRectReadOnly IntersectionRect
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRectReadOnly>.Get(JSObject, "intersectionRect");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Size
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "size");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FirstRenderTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "firstRenderTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? LastPaintedElement
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Get(JSObject, "lastPaintedElement");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? RootElement
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Get(JSObject, "rootElement");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PaintTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "paintTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? PresentationTime
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "presentationTime");
    }
}

#nullable disable