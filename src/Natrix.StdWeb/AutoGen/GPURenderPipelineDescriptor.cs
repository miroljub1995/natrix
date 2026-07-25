// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPURenderPipelineDescriptor: global::Natrix.StdWeb.GPUPipelineDescriptorBase
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPURenderPipelineDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPURenderPipelineDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUVertexState Vertex
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUVertexState, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "vertex");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUVertexState, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "vertex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUPrimitiveState Primitive
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUPrimitiveState, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "primitive");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUPrimitiveState, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "primitive", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUDepthStencilState DepthStencil
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUDepthStencilState, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "depthStencil");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUDepthStencilState, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "depthStencil", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUMultisampleState Multisample
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUMultisampleState, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "multisample");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUMultisampleState, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "multisample", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUFragmentState Fragment
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUFragmentState, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "fragment");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUFragmentState, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "fragment", value);
    }
}

#nullable disable