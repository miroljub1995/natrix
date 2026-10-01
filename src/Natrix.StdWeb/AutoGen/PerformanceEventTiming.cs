// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PerformanceEventTiming: global::Natrix.StdWeb.PerformanceEntry, global::Natrix.JSCore.IJSObjectProxy<PerformanceEventTiming>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PerformanceEventTiming(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PerformanceEventTiming global::Natrix.JSCore.IJSObjectProxy<PerformanceEventTiming>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PerformanceEventTiming>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ProcessingStart
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "processingStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ProcessingEnd
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "processingEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Cancelable
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "cancelable");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node? Target
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Node>.Get(JSObject, "target");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string TargetSelector
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "targetSelector");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong InteractionId
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "interactionId");
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