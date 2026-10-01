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
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>.Get(JSObject, "format");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>.Set(JSObject, "format", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool DepthWriteEnabled
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "depthWriteEnabled");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "depthWriteEnabled", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUCompareFunction DepthCompare
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUCompareFunction>.Get(JSObject, "depthCompare");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUCompareFunction>.Set(JSObject, "depthCompare", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUStencilFaceState StencilFront
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUStencilFaceState>.Get(JSObject, "stencilFront");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUStencilFaceState>.Set(JSObject, "stencilFront", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUStencilFaceState StencilBack
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUStencilFaceState>.Get(JSObject, "stencilBack");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUStencilFaceState>.Set(JSObject, "stencilBack", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint StencilReadMask
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "stencilReadMask");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "stencilReadMask", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint StencilWriteMask
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "stencilWriteMask");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "stencilWriteMask", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int DepthBias
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "depthBias");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "depthBias", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float DepthBiasSlopeScale
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "depthBiasSlopeScale");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "depthBiasSlopeScale", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float DepthBiasClamp
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "depthBiasClamp");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "depthBiasClamp", value);
    }
}

#nullable disable