// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUVertexBufferLayout: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUVertexBufferLayout>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUVertexBufferLayout(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUVertexBufferLayout global::Natrix.JSCore.IJSObjectProxy<GPUVertexBufferLayout>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUVertexBufferLayout(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required ulong ArrayStride
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "arrayStride");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "arrayStride", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUVertexStepMode StepMode
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUVertexStepMode>.Get(JSObject, "stepMode");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUVertexStepMode>.Set(JSObject, "stepMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUVertexAttribute, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUVertexAttribute>> Attributes
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUVertexAttribute, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUVertexAttribute>>>.Get(JSObject, "attributes");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUVertexAttribute, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUVertexAttribute>>>.Set(JSObject, "attributes", value);
    }
}

#nullable disable