// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUComputePipelineDescriptor: global::Natrix.StdWeb.GPUPipelineDescriptorBase
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUComputePipelineDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUComputePipelineDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUProgrammableStage Compute
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUProgrammableStage, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "compute");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUProgrammableStage, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "compute", value);
    }
}

#nullable disable