// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PerformanceTiming: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PerformanceTiming>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PerformanceTiming(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PerformanceTiming global::Natrix.JSCore.IJSObjectProxy<PerformanceTiming>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PerformanceTiming>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong NavigationStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "navigationStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong UnloadEventStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "unloadEventStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong UnloadEventEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "unloadEventEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong RedirectStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "redirectStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong RedirectEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "redirectEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong FetchStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "fetchStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DomainLookupStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "domainLookupStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DomainLookupEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "domainLookupEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong ConnectStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "connectStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong ConnectEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "connectEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong SecureConnectionStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "secureConnectionStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong RequestStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "requestStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong ResponseStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "responseStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong ResponseEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "responseEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DomLoading
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "domLoading");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DomInteractive
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "domInteractive");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DomContentLoadedEventStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "domContentLoadedEventStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DomContentLoadedEventEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "domContentLoadedEventEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DomComplete
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "domComplete");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong LoadEventStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "loadEventStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong LoadEventEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "loadEventEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Runtime.InteropServices.JavaScript.JSObject, global::Natrix.JSCore.Generics.JSObjectAccessor>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable