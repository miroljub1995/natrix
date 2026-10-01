// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUCompilationInfo: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUCompilationInfo>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUCompilationInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUCompilationInfo global::Natrix.JSCore.IJSObjectProxy<GPUCompilationInfo>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GPUCompilationInfo>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.GPUCompilationMessage, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUCompilationMessage>> Messages
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.GPUCompilationMessage, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUCompilationMessage>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.GPUCompilationMessage, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUCompilationMessage>>>>(JSObject, "messages");
    }
}

#nullable disable