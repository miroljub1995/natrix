// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LayoutShiftAttribution: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<LayoutShiftAttribution>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LayoutShiftAttribution(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LayoutShiftAttribution global::Natrix.JSCore.IJSObjectProxy<LayoutShiftAttribution>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<LayoutShiftAttribution>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node? Node
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Node>.Get(JSObject, "node");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMRectReadOnly PreviousRect
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRectReadOnly>.Get(JSObject, "previousRect");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMRectReadOnly CurrentRect
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRectReadOnly>.Get(JSObject, "currentRect");
    }
}

#nullable disable