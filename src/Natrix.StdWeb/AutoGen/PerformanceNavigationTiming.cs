// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PerformanceNavigationTiming: global::Natrix.StdWeb.PerformanceResourceTiming
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PerformanceNavigationTiming(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double UnloadEventStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unloadEventStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double UnloadEventEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unloadEventEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DomInteractive
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "domInteractive");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DomContentLoadedEventStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "domContentLoadedEventStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DomContentLoadedEventEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "domContentLoadedEventEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DomComplete
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "domComplete");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double LoadEventStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "loadEventStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double LoadEventEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "loadEventEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NavigationTimingType Type
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NavigationTimingType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort RedirectCount
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "redirectCount");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double CriticalCHRestart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "criticalCHRestart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NotRestoredReasons? NotRestoredReasons
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.NotRestoredReasons?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "notRestoredReasons");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PerformanceTimingConfidence Confidence
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.PerformanceTimingConfidence, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "confidence");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Runtime.InteropServices.JavaScript.JSObject, global::Natrix.StdWeb.PropertyAccessor>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ActivationStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "activationStart");
    }
}

#nullable disable