// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LayoutShift: global::Natrix.StdWeb.PerformanceEntry, global::Natrix.JSCore.IJSObjectProxy<LayoutShift>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LayoutShift(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LayoutShift global::Natrix.JSCore.IJSObjectProxy<LayoutShift>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<LayoutShift>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Value
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HadRecentInput
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "hadRecentInput");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double LastInputTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "lastInputTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.LayoutShiftAttribution, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LayoutShiftAttribution>> Sources
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.LayoutShiftAttribution, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LayoutShiftAttribution>>>.Get(JSObject, "sources");
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