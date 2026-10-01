// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUTextureDescriptor: global::Natrix.StdWeb.GPUObjectDescriptorBase, global::Natrix.JSCore.IJSObjectProxy<GPUTextureDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUTextureDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUTextureDescriptor global::Natrix.JSCore.IJSObjectProxy<GPUTextureDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUTextureDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.StdWeb.GPUExtent3DDict, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUExtent3DDict>> Size
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.StdWeb.GPUExtent3DDict, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUExtent3DDict>>>.Get(JSObject, "size");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.StdWeb.GPUExtent3DDict, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUExtent3DDict>>>.Set(JSObject, "size", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MipLevelCount
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "mipLevelCount");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "mipLevelCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SampleCount
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "sampleCount");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "sampleCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureDimension Dimension
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureDimension>.Get(JSObject, "dimension");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureDimension>.Set(JSObject, "dimension", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUTextureFormat Format
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>.Get(JSObject, "format");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>.Set(JSObject, "format", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Usage
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "usage");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "usage", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUTextureFormat, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>> ViewFormats
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUTextureFormat, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>>>.Get(JSObject, "viewFormats");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUTextureFormat, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>>>.Set(JSObject, "viewFormats", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureViewDimension TextureBindingViewDimension
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureViewDimension>.Get(JSObject, "textureBindingViewDimension");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureViewDimension>.Set(JSObject, "textureBindingViewDimension", value);
    }
}

#nullable disable