// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUCommandBuffer: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUCommandBuffer>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUCommandBuffer(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUCommandBuffer global::Natrix.JSCore.IJSObjectProxy<GPUCommandBuffer>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GPUCommandBuffer>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Label
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "label");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "label", value);
    }
}

#nullable disable