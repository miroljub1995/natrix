// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUShaderModuleCompilationHint: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUShaderModuleCompilationHint>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUShaderModuleCompilationHint(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUShaderModuleCompilationHint global::Natrix.JSCore.IJSObjectProxy<GPUShaderModuleCompilationHint>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUShaderModuleCompilationHint(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string EntryPoint
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "entryPoint");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "entryPoint", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUPipelineLayout, global::Natrix.StdWeb.GPUAutoLayoutMode, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUPipelineLayout>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAutoLayoutMode>> Layout
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUPipelineLayout, global::Natrix.StdWeb.GPUAutoLayoutMode, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUPipelineLayout>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAutoLayoutMode>>>.Get(JSObject, "layout");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.GPUPipelineLayout, global::Natrix.StdWeb.GPUAutoLayoutMode, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUPipelineLayout>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUAutoLayoutMode>>>.Set(JSObject, "layout", value);
    }
}

#nullable disable