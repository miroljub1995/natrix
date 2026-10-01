// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRCylinderLayer: global::Natrix.StdWeb.XRCompositionLayer, global::Natrix.JSCore.IJSObjectProxy<XRCylinderLayer>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRCylinderLayer(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRCylinderLayer global::Natrix.JSCore.IJSObjectProxy<XRCylinderLayer>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRCylinderLayer>(obj);

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
    public float Radius
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "radius");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "radius", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float CentralAngle
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "centralAngle");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "centralAngle", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float AspectRatio
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "aspectRatio");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "aspectRatio", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onredraw
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onredraw");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onredraw", value);
    }
}

#nullable disable