// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUPipelineDescriptorBase: global::Natrix.StdWeb.GPUObjectDescriptorBase, global::Natrix.JSCore.IJSObjectProxy<GPUPipelineDescriptorBase>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUPipelineDescriptorBase(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUPipelineDescriptorBase global::Natrix.JSCore.IJSObjectProxy<GPUPipelineDescriptorBase>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUPipelineDescriptorBase(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUPipelineLayout, global::Natrix.StdWeb.GPUAutoLayoutMode, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUPipelineLayout>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAutoLayoutMode>> Layout
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUPipelineLayout, global::Natrix.StdWeb.GPUAutoLayoutMode, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUPipelineLayout>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAutoLayoutMode>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUPipelineLayout, global::Natrix.StdWeb.GPUAutoLayoutMode, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUPipelineLayout>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAutoLayoutMode>>>>(JSObject, "layout");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUPipelineLayout, global::Natrix.StdWeb.GPUAutoLayoutMode, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUPipelineLayout>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAutoLayoutMode>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUPipelineLayout, global::Natrix.StdWeb.GPUAutoLayoutMode, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUPipelineLayout>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAutoLayoutMode>>>>(JSObject, "layout", value);
    }
}

#nullable disable