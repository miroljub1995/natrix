// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPURenderPassDepthStencilAttachment: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPURenderPassDepthStencilAttachment>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPURenderPassDepthStencilAttachment(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPURenderPassDepthStencilAttachment global::Natrix.JSCore.IJSObjectProxy<GPURenderPassDepthStencilAttachment>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPURenderPassDepthStencilAttachment(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUTexture, global::Natrix.StdWeb.GPUTextureView, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTexture>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTextureView>> View
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUTexture, global::Natrix.StdWeb.GPUTextureView, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTexture>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTextureView>>>.Get(JSObject, "view");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUTexture, global::Natrix.StdWeb.GPUTextureView, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTexture>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTextureView>>>.Set(JSObject, "view", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float DepthClearValue
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "depthClearValue");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "depthClearValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPULoadOp DepthLoadOp
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPULoadOp>.Get(JSObject, "depthLoadOp");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPULoadOp>.Set(JSObject, "depthLoadOp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUStoreOp DepthStoreOp
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUStoreOp>.Get(JSObject, "depthStoreOp");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUStoreOp>.Set(JSObject, "depthStoreOp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool DepthReadOnly
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "depthReadOnly");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "depthReadOnly", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint StencilClearValue
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "stencilClearValue");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "stencilClearValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPULoadOp StencilLoadOp
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPULoadOp>.Get(JSObject, "stencilLoadOp");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPULoadOp>.Set(JSObject, "stencilLoadOp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUStoreOp StencilStoreOp
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUStoreOp>.Get(JSObject, "stencilStoreOp");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUStoreOp>.Set(JSObject, "stencilStoreOp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool StencilReadOnly
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "stencilReadOnly");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "stencilReadOnly", value);
    }
}

#nullable disable