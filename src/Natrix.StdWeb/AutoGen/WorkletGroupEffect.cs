// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WorkletGroupEffect: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WorkletGroupEffect>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WorkletGroupEffect(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WorkletGroupEffect global::Natrix.JSCore.IJSObjectProxy<WorkletGroupEffect>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<WorkletGroupEffect>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.WorkletAnimationEffect, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WorkletAnimationEffect>> GetChildren()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getChildren", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.WorkletAnimationEffect, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WorkletAnimationEffect>>>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable