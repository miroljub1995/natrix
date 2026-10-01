// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PerformancePaintTiming: global::Natrix.StdWeb.PerformanceEntry, global::Natrix.JSCore.IJSObjectProxy<PerformancePaintTiming>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PerformancePaintTiming(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PerformancePaintTiming global::Natrix.JSCore.IJSObjectProxy<PerformancePaintTiming>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PerformancePaintTiming>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.JSObjectAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PaintTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "paintTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? PresentationTime
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "presentationTime");
    }
}

#nullable disable