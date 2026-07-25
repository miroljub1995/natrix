// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUVertexState: global::Natrix.StdWeb.GPUProgrammableStage
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUVertexState(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUVertexState(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUVertexBufferLayout?, global::Natrix.StdWeb.PropertyAccessorNullable> Buffers
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUVertexBufferLayout?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "buffers");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUVertexBufferLayout?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "buffers", value);
    }
}

#nullable disable