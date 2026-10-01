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
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAddressMode>.Get(JSObject, "addressModeU");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAddressMode>.Set(JSObject, "addressModeU", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUAddressMode AddressModeV
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAddressMode>.Get(JSObject, "addressModeV");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAddressMode>.Set(JSObject, "addressModeV", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUAddressMode AddressModeW
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAddressMode>.Get(JSObject, "addressModeW");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAddressMode>.Set(JSObject, "addressModeW", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUFilterMode MagFilter
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUFilterMode>.Get(JSObject, "magFilter");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUFilterMode>.Set(JSObject, "magFilter", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUFilterMode MinFilter
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUFilterMode>.Get(JSObject, "minFilter");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUFilterMode>.Set(JSObject, "minFilter", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUMipmapFilterMode MipmapFilter
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUMipmapFilterMode>.Get(JSObject, "mipmapFilter");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUMipmapFilterMode>.Set(JSObject, "mipmapFilter", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float LodMinClamp
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "lodMinClamp");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "lodMinClamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float LodMaxClamp
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "lodMaxClamp");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "lodMaxClamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUCompareFunction Compare
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUCompareFunction>.Get(JSObject, "compare");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUCompareFunction>.Set(JSObject, "compare", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort MaxAnisotropy
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "maxAnisotropy");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "maxAnisotropy", value);
    }
}

#nullable disable