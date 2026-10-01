// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRCubeLayer: global::Natrix.StdWeb.XRCompositionLayer, global::Natrix.JSCore.IJSObjectProxy<XRCubeLayer>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRCubeLayer(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRCubeLayer global::Natrix.JSCore.IJSObjectProxy<XRCubeLayer>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRCubeLayer>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRSpace Space
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRSpace>.Get(JSObject, "space");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRSpace>.Set(JSObject, "space", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPointReadOnly Orientation
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMPointReadOnly>.Get(JSObject, "orientation");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMPointReadOnly>.Set(JSObject, "orientation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onredraw
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onredraw");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onredraw", value);
    }
}

#nullable disable