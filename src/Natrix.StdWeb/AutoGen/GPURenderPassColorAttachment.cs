// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPURenderPassColorAttachment: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPURenderPassColorAttachment>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPURenderPassColorAttachment(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPURenderPassColorAttachment global::Natrix.JSCore.IJSObjectProxy<GPURenderPassColorAttachment>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPURenderPassColorAttachment(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUTexture, global::Natrix.StdWeb.GPUTextureView, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTexture>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTextureView>> View
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUTexture, global::Natrix.StdWeb.GPUTextureView, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTexture>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTextureView>>>.Get(JSObject, "view");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUTexture, global::Natrix.StdWeb.GPUTextureView, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTexture>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTextureView>>>.Set(JSObject, "view", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint DepthSlice
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "depthSlice");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "depthSlice", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUTexture, global::Natrix.StdWeb.GPUTextureView, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTexture>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTextureView>> ResolveTarget
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUTexture, global::Natrix.StdWeb.GPUTextureView, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTexture>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTextureView>>>.Get(JSObject, "resolveTarget");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUTexture, global::Natrix.StdWeb.GPUTextureView, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTexture>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUTextureView>>>.Set(JSObject, "resolveTarget", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>, global::Natrix.StdWeb.GPUColorDict, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUColorDict>> ClearValue
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>, global::Natrix.StdWeb.GPUColorDict, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUColorDict>>>.Get(JSObject, "clearValue");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>, global::Natrix.StdWeb.GPUColorDict, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.JSCore.Generics.DoubleAccessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUColorDict>>>.Set(JSObject, "clearValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPULoadOp LoadOp
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPULoadOp>.Get(JSObject, "loadOp");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPULoadOp>.Set(JSObject, "loadOp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUStoreOp StoreOp
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUStoreOp>.Get(JSObject, "storeOp");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUStoreOp>.Set(JSObject, "storeOp", value);
    }
}

#nullable disable