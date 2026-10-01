// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUError: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUError>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUError(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUError global::Natrix.JSCore.IJSObjectProxy<GPUError>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GPUError>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Message
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "message");
    }
}

#nullable disable