// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRRenderState: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRRenderState>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRRenderState(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRRenderState global::Natrix.JSCore.IJSObjectProxy<XRRenderState>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRRenderState>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DepthNear
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "depthNear");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DepthFar
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "depthFar");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool? PassthroughFullyObscured
    {
        get => global::Natrix.JSCore.Generics.NullableBooleanAccessor.Get(JSObject, "passthroughFullyObscured");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? InlineVerticalFieldOfView
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "inlineVerticalFieldOfView");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRWebGLLayer? BaseLayer
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.XRWebGLLayer>.Get(JSObject, "baseLayer");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.XRLayer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRLayer>> Layers
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.XRLayer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRLayer>>>.Get(JSObject, "layers");
    }
}

#nullable disable