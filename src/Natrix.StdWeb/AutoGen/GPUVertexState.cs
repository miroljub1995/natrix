// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUVertexState: global::Natrix.StdWeb.GPUProgrammableStage, global::Natrix.JSCore.IJSObjectProxy<GPUVertexState>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUVertexState(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUVertexState global::Natrix.JSCore.IJSObjectProxy<GPUVertexState>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUVertexState(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUVertexBufferLayout?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.GPUVertexBufferLayout>> Buffers
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUVertexBufferLayout?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.GPUVertexBufferLayout>>>.Get(JSObject, "buffers");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUVertexBufferLayout?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.GPUVertexBufferLayout>>>.Set(JSObject, "buffers", value);
    }
}

#nullable disable