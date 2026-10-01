// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XREquirectLayer: global::Natrix.StdWeb.XRCompositionLayer, global::Natrix.JSCore.IJSObjectProxy<XREquirectLayer>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XREquirectLayer(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XREquirectLayer global::Natrix.JSCore.IJSObjectProxy<XREquirectLayer>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XREquirectLayer>(obj);

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
    public float CentralHorizontalAngle
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "centralHorizontalAngle");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "centralHorizontalAngle", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float UpperVerticalAngle
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "upperVerticalAngle");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "upperVerticalAngle", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float LowerVerticalAngle
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "lowerVerticalAngle");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "lowerVerticalAngle", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onredraw
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onredraw");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onredraw", value);
    }
}

#nullable disable