// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUPipelineLayout: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUPipelineLayout>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUPipelineLayout(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUPipelineLayout global::Natrix.JSCore.IJSObjectProxy<GPUPipelineLayout>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GPUPipelineLayout>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Label
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "label");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "label", value);
    }
}

#nullable disable