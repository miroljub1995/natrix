// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUExternalTexture: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUExternalTexture>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUExternalTexture(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUExternalTexture global::Natrix.JSCore.IJSObjectProxy<GPUExternalTexture>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GPUExternalTexture>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Label
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "label");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "label", value);
    }
}

#nullable disable