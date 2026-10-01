// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUBindGroupLayout: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUBindGroupLayout>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBindGroupLayout(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUBindGroupLayout global::Natrix.JSCore.IJSObjectProxy<GPUBindGroupLayout>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GPUBindGroupLayout>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Label
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "label");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "label", value);
    }
}

#nullable disable