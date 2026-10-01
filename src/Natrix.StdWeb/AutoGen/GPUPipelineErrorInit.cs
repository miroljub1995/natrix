// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUPipelineErrorInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUPipelineErrorInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUPipelineErrorInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUPipelineErrorInit global::Natrix.JSCore.IJSObjectProxy<GPUPipelineErrorInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUPipelineErrorInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUPipelineErrorReason Reason
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.GPUPipelineErrorReason, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUPipelineErrorReason>>(JSObject, "reason");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.GPUPipelineErrorReason, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUPipelineErrorReason>>(JSObject, "reason", value);
    }
}

#nullable disable