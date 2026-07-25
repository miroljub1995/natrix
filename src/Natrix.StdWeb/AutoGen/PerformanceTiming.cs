// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PerformanceTiming: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PerformanceTiming(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong NavigationStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "navigationStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong UnloadEventStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unloadEventStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong UnloadEventEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unloadEventEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong RedirectStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "redirectStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong RedirectEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "redirectEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong FetchStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "fetchStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DomainLookupStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "domainLookupStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DomainLookupEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "domainLookupEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong ConnectStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "connectStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong ConnectEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "connectEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong SecureConnectionStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "secureConnectionStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong RequestStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "requestStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong ResponseStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "responseStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong ResponseEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "responseEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DomLoading
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "domLoading");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DomInteractive
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "domInteractive");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DomContentLoadedEventStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "domContentLoadedEventStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DomContentLoadedEventEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "domContentLoadedEventEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DomComplete
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "domComplete");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong LoadEventStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "loadEventStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong LoadEventEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "loadEventEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Runtime.InteropServices.JavaScript.JSObject, global::Natrix.StdWeb.PropertyAccessor>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable