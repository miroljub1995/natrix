// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUSamplerDescriptor: global::Natrix.StdWeb.GPUObjectDescriptorBase, global::Natrix.JSCore.IJSObjectProxy<GPUSamplerDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUSamplerDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUSamplerDescriptor global::Natrix.JSCore.IJSObjectProxy<GPUSamplerDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUSamplerDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUAddressMode AddressModeU
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUAddressMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAddressMode>>(JSObject, "addressModeU");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUAddressMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAddressMode>>(JSObject, "addressModeU", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUAddressMode AddressModeV
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUAddressMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAddressMode>>(JSObject, "addressModeV");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUAddressMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAddressMode>>(JSObject, "addressModeV", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUAddressMode AddressModeW
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUAddressMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAddressMode>>(JSObject, "addressModeW");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUAddressMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAddressMode>>(JSObject, "addressModeW", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUFilterMode MagFilter
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUFilterMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUFilterMode>>(JSObject, "magFilter");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUFilterMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUFilterMode>>(JSObject, "magFilter", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUFilterMode MinFilter
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUFilterMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUFilterMode>>(JSObject, "minFilter");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUFilterMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUFilterMode>>(JSObject, "minFilter", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUMipmapFilterMode MipmapFilter
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUMipmapFilterMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUMipmapFilterMode>>(JSObject, "mipmapFilter");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUMipmapFilterMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUMipmapFilterMode>>(JSObject, "mipmapFilter", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float LodMinClamp
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "lodMinClamp");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "lodMinClamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float LodMaxClamp
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "lodMaxClamp");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<float, global::Natrix.JSCore.Generics.SingleAccessor>(JSObject, "lodMaxClamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUCompareFunction Compare
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUCompareFunction, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUCompareFunction>>(JSObject, "compare");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUCompareFunction, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUCompareFunction>>(JSObject, "compare", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort MaxAnisotropy
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.JSCore.Generics.UInt16Accessor>(JSObject, "maxAnisotropy");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ushort, global::Natrix.JSCore.Generics.UInt16Accessor>(JSObject, "maxAnisotropy", value);
    }
}

#nullable disable