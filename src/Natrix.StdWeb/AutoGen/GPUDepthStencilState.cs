// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUDepthStencilState: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUDepthStencilState>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUDepthStencilState(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUDepthStencilState global::Natrix.JSCore.IJSObjectProxy<GPUDepthStencilState>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUDepthStencilState(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUTextureFormat Format
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUTextureFormat, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>>(JSObject, "format");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUTextureFormat, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>>(JSObject, "format", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool DepthWriteEnabled
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "depthWriteEnabled");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "depthWriteEnabled", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUCompareFunction DepthCompare
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUCompareFunction, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUCompareFunction>>(JSObject, "depthCompare");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUCompareFunction, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUCompareFunction>>(JSObject, "depthCompare", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUStencilFaceState StencilFront
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUStencilFaceState, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUStencilFaceState>>(JSObject, "stencilFront");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUStencilFaceState, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUStencilFaceState>>(JSObject, "stencilFront", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUStencilFaceState StencilBack
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUStencilFaceState, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUStencilFaceState>>(JSObject, "stencilBack");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUStencilFaceState, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUStencilFaceState>>(JSObject, "stencilBack", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint StencilReadMask
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "stencilReadMask");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "stencilReadMask", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint StencilWriteMask
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "stencilWriteMask");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.JSCore.Generics.UInt32Accessor>(JSObject, "stencilWriteMask", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int DepthBias
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.JSCore.Generics.Int32Accessor>(JSObject, "depthBias");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.JSCore.Generics.Int32Accessor>(JSObject, "depthBias", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float DepthBiasSlopeScale
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "depthBiasSlopeScale");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "depthBiasSlopeScale", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float DepthBiasClamp
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "depthBiasClamp");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "depthBiasClamp", value);
    }
}

#nullable disable