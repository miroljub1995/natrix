// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUShaderModule: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUShaderModule>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUShaderModule(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUShaderModule global::Natrix.JSCore.IJSObjectProxy<GPUShaderModule>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GPUShaderModule>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.GPUCompilationInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUCompilationInfo>> GetCompilationInfo()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getCompilationInfo", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.GPUCompilationInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUCompilationInfo>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Label
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "label");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "label", value);
    }
}

#nullable disable