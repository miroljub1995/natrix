// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUStencilFaceState: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUStencilFaceState>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUStencilFaceState(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUStencilFaceState global::Natrix.JSCore.IJSObjectProxy<GPUStencilFaceState>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUStencilFaceState(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUCompareFunction Compare
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUCompareFunction, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUCompareFunction>>(JSObject, "compare");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUCompareFunction, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUCompareFunction>>(JSObject, "compare", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUStencilOperation FailOp
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUStencilOperation, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUStencilOperation>>(JSObject, "failOp");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUStencilOperation, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUStencilOperation>>(JSObject, "failOp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUStencilOperation DepthFailOp
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUStencilOperation, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUStencilOperation>>(JSObject, "depthFailOp");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUStencilOperation, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUStencilOperation>>(JSObject, "depthFailOp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUStencilOperation PassOp
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUStencilOperation, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUStencilOperation>>(JSObject, "passOp");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUStencilOperation, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUStencilOperation>>(JSObject, "passOp", value);
    }
}

#nullable disable