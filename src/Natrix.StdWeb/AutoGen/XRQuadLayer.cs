// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRQuadLayer: global::Natrix.StdWeb.XRCompositionLayer, global::Natrix.JSCore.IJSObjectProxy<XRQuadLayer>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRQuadLayer(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRQuadLayer global::Natrix.JSCore.IJSObjectProxy<XRQuadLayer>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRQuadLayer>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRSpace Space
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRSpace>.Get(JSObject, "space");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRSpace>.Set(JSObject, "space", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRRigidTransform Transform
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRRigidTransform>.Get(JSObject, "transform");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRRigidTransform>.Set(JSObject, "transform", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Width
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Height
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onredraw
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onredraw");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onredraw", value);
    }
}

#nullable disable