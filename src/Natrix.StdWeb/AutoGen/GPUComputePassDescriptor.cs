// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUComputePassDescriptor: global::Natrix.StdWeb.GPUObjectDescriptorBase
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUComputePassDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUComputePassDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUComputePassTimestampWrites TimestampWrites
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUComputePassTimestampWrites, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "timestampWrites");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUComputePassTimestampWrites, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "timestampWrites", value);
    }
}

#nullable disable