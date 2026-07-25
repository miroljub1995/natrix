// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUTexelCopyBufferInfo: global::Natrix.StdWeb.GPUTexelCopyBufferLayout
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUTexelCopyBufferInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUTexelCopyBufferInfo(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUBuffer Buffer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUBuffer, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "buffer");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUBuffer, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "buffer", value);
    }
}

#nullable disable