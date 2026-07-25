// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRGPUSubImage: global::Natrix.StdWeb.XRSubImage
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRGPUSubImage(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTexture ColorTexture
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUTexture, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "colorTexture");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTexture? DepthStencilTexture
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUTexture?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "depthStencilTexture");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTexture? MotionVectorTexture
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUTexture?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "motionVectorTexture");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureViewDescriptor GetViewDescriptor()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getViewDescriptor", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUTextureViewDescriptor, global::Natrix.StdWeb.PropertyAccessor>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable