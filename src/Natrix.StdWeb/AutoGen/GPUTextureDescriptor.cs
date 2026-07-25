// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUTextureDescriptor: global::Natrix.StdWeb.GPUObjectDescriptorBase
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUTextureDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUTextureDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GPUExtent3DDict, global::Natrix.StdWeb.GenericMarshaller.Union> Size
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GPUExtent3DDict, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "size");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GPUExtent3DDict, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "size", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MipLevelCount
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "mipLevelCount");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "mipLevelCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SampleCount
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sampleCount");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sampleCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureDimension Dimension
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUTextureDimension, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "dimension");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUTextureDimension, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "dimension", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUTextureFormat Format
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUTextureFormat, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "format");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUTextureFormat, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "format", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Usage
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "usage");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "usage", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUTextureFormat, global::Natrix.StdWeb.PropertyAccessor> ViewFormats
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUTextureFormat, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "viewFormats");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUTextureFormat, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "viewFormats", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUTextureViewDimension TextureBindingViewDimension
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUTextureViewDimension, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "textureBindingViewDimension");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUTextureViewDimension, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "textureBindingViewDimension", value);
    }
}

#nullable disable