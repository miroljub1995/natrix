// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUComputePipelineDescriptor: global::Natrix.StdWeb.GPUPipelineDescriptorBase, global::Natrix.JSCore.IJSObjectProxy<GPUComputePipelineDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUComputePipelineDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUComputePipelineDescriptor global::Natrix.JSCore.IJSObjectProxy<GPUComputePipelineDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUComputePipelineDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUProgrammableStage Compute
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUProgrammableStage>.Get(JSObject, "compute");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUProgrammableStage>.Set(JSObject, "compute", value);
    }
}

#nullable disable