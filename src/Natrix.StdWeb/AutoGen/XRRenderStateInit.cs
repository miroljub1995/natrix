// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRRenderStateInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRRenderStateInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRRenderStateInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRRenderStateInit global::Natrix.JSCore.IJSObjectProxy<XRRenderStateInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRRenderStateInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DepthNear
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "depthNear");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "depthNear", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DepthFar
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "depthFar");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "depthFar", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PassthroughFullyObscured
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "passthroughFullyObscured");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "passthroughFullyObscured", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double InlineVerticalFieldOfView
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "inlineVerticalFieldOfView");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "inlineVerticalFieldOfView", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRWebGLLayer? BaseLayer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRWebGLLayer?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.XRWebGLLayer>>(JSObject, "baseLayer");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.XRWebGLLayer?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.XRWebGLLayer>>(JSObject, "baseLayer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRLayer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRLayer>>? Layers
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRLayer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRLayer>>?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRLayer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRLayer>>>>(JSObject, "layers");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRLayer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRLayer>>?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRLayer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRLayer>>>>(JSObject, "layers", value);
    }
}

#nullable disable