// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUSamplerDescriptor: global::Natrix.StdWeb.GPUObjectDescriptorBase
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUSamplerDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUSamplerDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUAddressMode AddressModeU
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUAddressMode, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "addressModeU");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUAddressMode, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "addressModeU", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUAddressMode AddressModeV
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUAddressMode, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "addressModeV");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUAddressMode, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "addressModeV", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUAddressMode AddressModeW
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUAddressMode, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "addressModeW");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUAddressMode, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "addressModeW", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUFilterMode MagFilter
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUFilterMode, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "magFilter");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUFilterMode, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "magFilter", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUFilterMode MinFilter
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUFilterMode, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "minFilter");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUFilterMode, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "minFilter", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUMipmapFilterMode MipmapFilter
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUMipmapFilterMode, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "mipmapFilter");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUMipmapFilterMode, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "mipmapFilter", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float LodMinClamp
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "lodMinClamp");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "lodMinClamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float LodMaxClamp
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "lodMaxClamp");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "lodMaxClamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUCompareFunction Compare
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUCompareFunction, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "compare");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUCompareFunction, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "compare", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort MaxAnisotropy
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "maxAnisotropy");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "maxAnisotropy", value);
    }
}

#nullable disable