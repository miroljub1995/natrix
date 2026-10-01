// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SharedWorkerGlobalScope: global::Natrix.StdWeb.WorkerGlobalScope, global::Natrix.JSCore.IJSObjectProxy<SharedWorkerGlobalScope>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SharedWorkerGlobalScope(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SharedWorkerGlobalScope global::Natrix.JSCore.IJSObjectProxy<SharedWorkerGlobalScope>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SharedWorkerGlobalScope>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Close()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "close", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onconnect
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onconnect");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onconnect", value);
    }
}

#nullable disable