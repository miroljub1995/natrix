// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUTextureViewDescriptor: global::Natrix.StdWeb.GPUObjectDescriptorBase, global::Natrix.JSCore.IJSObjectProxy<GPUTextureViewDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUTextureViewDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUTextureViewDescriptor global::Natrix.JSCore.IJSObjectProxy<GPUTextureViewDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUTextureViewDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureFormat Format
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>.Get(JSObject, "format");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureFormat>.Set(JSObject, "format", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureViewDimension Dimension
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureViewDimension>.Get(JSObject, "dimension");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureViewDimension>.Set(JSObject, "dimension", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Usage
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "usage");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "usage", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureAspect Aspect
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureAspect>.Get(JSObject, "aspect");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUTextureAspect>.Set(JSObject, "aspect", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint BaseMipLevel
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "baseMipLevel");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "baseMipLevel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MipLevelCount
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "mipLevelCount");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "mipLevelCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint BaseArrayLayer
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "baseArrayLayer");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "baseArrayLayer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ArrayLayerCount
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "arrayLayerCount");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "arrayLayerCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Swizzle
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "swizzle");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "swizzle", value);
    }
}

#nullable disable