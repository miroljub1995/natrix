// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PerformanceContainerTiming: global::Natrix.StdWeb.PerformanceEntry
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PerformanceContainerTiming(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Identifier
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "identifier");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMRectReadOnly IntersectionRect
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DOMRectReadOnly, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "intersectionRect");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Size
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "size");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FirstRenderTime
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "firstRenderTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? LastPaintedElement
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Element?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "lastPaintedElement");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? RootElement
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Element?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "rootElement");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PaintTime
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "paintTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? PresentationTime
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "presentationTime");
    }
}

#nullable disable