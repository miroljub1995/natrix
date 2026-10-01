// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUDeviceLostInfo: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUDeviceLostInfo>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUDeviceLostInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUDeviceLostInfo global::Natrix.JSCore.IJSObjectProxy<GPUDeviceLostInfo>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GPUDeviceLostInfo>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUDeviceLostReason Reason
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUDeviceLostReason>.Get(JSObject, "reason");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Message
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "message");
    }
}

#nullable disable