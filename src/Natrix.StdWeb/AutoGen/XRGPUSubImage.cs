// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRGPUSubImage: global::Natrix.StdWeb.XRSubImage, global::Natrix.JSCore.IJSObjectProxy<XRGPUSubImage>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRGPUSubImage(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRGPUSubImage global::Natrix.JSCore.IJSObjectProxy<XRGPUSubImage>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRGPUSubImage>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTexture ColorTexture
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUTexture, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTexture>>(JSObject, "colorTexture");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTexture? DepthStencilTexture
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUTexture?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.GPUTexture>>(JSObject, "depthStencilTexture");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTexture? MotionVectorTexture
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUTexture?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.GPUTexture>>(JSObject, "motionVectorTexture");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureViewDescriptor GetViewDescriptor()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getViewDescriptor", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUTextureViewDescriptor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTextureViewDescriptor>>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable