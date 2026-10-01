// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WorkletAnimationEffect: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WorkletAnimationEffect>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WorkletAnimationEffect(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WorkletAnimationEffect global::Natrix.JSCore.IJSObjectProxy<WorkletAnimationEffect>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<WorkletAnimationEffect>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EffectTiming GetTiming()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getTiming", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.EffectTiming>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ComputedEffectTiming GetComputedTiming()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getComputedTiming", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ComputedEffectTiming>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? LocalTime
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "localTime");
        set => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Set(JSObject, "localTime", value);
    }
}

#nullable disable