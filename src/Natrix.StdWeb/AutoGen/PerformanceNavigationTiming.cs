// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PerformanceNavigationTiming: global::Natrix.StdWeb.PerformanceResourceTiming, global::Natrix.JSCore.IJSObjectProxy<PerformanceNavigationTiming>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PerformanceNavigationTiming(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PerformanceNavigationTiming global::Natrix.JSCore.IJSObjectProxy<PerformanceNavigationTiming>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PerformanceNavigationTiming>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double UnloadEventStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "unloadEventStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double UnloadEventEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "unloadEventEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DomInteractive
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "domInteractive");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DomContentLoadedEventStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "domContentLoadedEventStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DomContentLoadedEventEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "domContentLoadedEventEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DomComplete
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "domComplete");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double LoadEventStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "loadEventStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double LoadEventEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "loadEventEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationTimingType Type
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NavigationTimingType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.NavigationTimingType>>(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort RedirectCount
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.JSCore.Generics.UInt16Accessor>(JSObject, "redirectCount");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double CriticalCHRestart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "criticalCHRestart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NotRestoredReasons? NotRestoredReasons
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NotRestoredReasons?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.NotRestoredReasons>>(JSObject, "notRestoredReasons");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PerformanceTimingConfidence Confidence
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PerformanceTimingConfidence, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PerformanceTimingConfidence>>(JSObject, "confidence");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Runtime.InteropServices.JavaScript.JSObject, global::Natrix.JSCore.Generics.JSObjectAccessor>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ActivationStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "activationStart");
    }
}

#nullable disable