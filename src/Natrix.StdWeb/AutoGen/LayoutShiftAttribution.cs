// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LayoutShiftAttribution: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LayoutShiftAttribution(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node? Node
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Node?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "node");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMRectReadOnly PreviousRect
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DOMRectReadOnly, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "previousRect");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMRectReadOnly CurrentRect
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DOMRectReadOnly, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "currentRect");
    }
}

#nullable disable