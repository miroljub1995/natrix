// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PerformanceTimingConfidence: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PerformanceTimingConfidence>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PerformanceTimingConfidence(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PerformanceTimingConfidence global::Natrix.JSCore.IJSObjectProxy<PerformanceTimingConfidence>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PerformanceTimingConfidence>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double RandomizedTriggerRate
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "randomizedTriggerRate");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PerformanceTimingConfidenceValue Value
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PerformanceTimingConfidenceValue>.Get(JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.JSObjectAccessor.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable