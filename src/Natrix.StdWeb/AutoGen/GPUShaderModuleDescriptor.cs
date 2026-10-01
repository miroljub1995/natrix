// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUShaderModuleDescriptor: global::Natrix.StdWeb.GPUObjectDescriptorBase, global::Natrix.JSCore.IJSObjectProxy<GPUShaderModuleDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUShaderModuleDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUShaderModuleDescriptor global::Natrix.JSCore.IJSObjectProxy<GPUShaderModuleDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUShaderModuleDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Code
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "code");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "code", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUShaderModuleCompilationHint, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUShaderModuleCompilationHint>> CompilationHints
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUShaderModuleCompilationHint, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUShaderModuleCompilationHint>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUShaderModuleCompilationHint, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUShaderModuleCompilationHint>>>>(JSObject, "compilationHints");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUShaderModuleCompilationHint, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUShaderModuleCompilationHint>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.GPUShaderModuleCompilationHint, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUShaderModuleCompilationHint>>>>(JSObject, "compilationHints", value);
    }
}

#nullable disable