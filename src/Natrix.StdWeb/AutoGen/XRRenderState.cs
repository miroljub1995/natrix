// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRRenderState: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRRenderState(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.XRLayer, global::Natrix.StdWeb.PropertyAccessor> Layers
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.XRLayer, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "layers");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DepthNear
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "depthNear");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DepthFar
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "depthFar");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool? PassthroughFullyObscured
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "passthroughFullyObscured");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? InlineVerticalFieldOfView
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "inlineVerticalFieldOfView");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRWebGLLayer? BaseLayer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRWebGLLayer?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "baseLayer");
    }
}

#nullable disable