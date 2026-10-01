// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUPipelineLayoutDescriptor: global::Natrix.StdWeb.GPUObjectDescriptorBase, global::Natrix.JSCore.IJSObjectProxy<GPUPipelineLayoutDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUPipelineLayoutDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUPipelineLayoutDescriptor global::Natrix.JSCore.IJSObjectProxy<GPUPipelineLayoutDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUPipelineLayoutDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUBindGroupLayout?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.GPUBindGroupLayout>> BindGroupLayouts
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUBindGroupLayout?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.GPUBindGroupLayout>>>.Get(JSObject, "bindGroupLayouts");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUBindGroupLayout?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.GPUBindGroupLayout>>>.Set(JSObject, "bindGroupLayouts", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ImmediateSize
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "immediateSize");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "immediateSize", value);
    }
}

#nullable disable