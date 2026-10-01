// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PerformanceResourceTiming: global::Natrix.StdWeb.PerformanceEntry, global::Natrix.JSCore.IJSObjectProxy<PerformanceResourceTiming>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PerformanceResourceTiming(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PerformanceResourceTiming global::Natrix.JSCore.IJSObjectProxy<PerformanceResourceTiming>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PerformanceResourceTiming>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string InitiatorType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "initiatorType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DeliveryType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "deliveryType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string NextHopProtocol
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "nextHopProtocol");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double WorkerStart
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "workerStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double RedirectStart
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "redirectStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double RedirectEnd
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "redirectEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FetchStart
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "fetchStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DomainLookupStart
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "domainLookupStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DomainLookupEnd
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "domainLookupEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ConnectStart
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "connectStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ConnectEnd
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "connectEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double SecureConnectionStart
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "secureConnectionStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double RequestStart
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "requestStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FinalResponseHeadersStart
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "finalResponseHeadersStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FirstInterimResponseStart
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "firstInterimResponseStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ResponseStart
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "responseStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ResponseEnd
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "responseEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double WorkerRouterEvaluationStart
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "workerRouterEvaluationStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double WorkerCacheLookupStart
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "workerCacheLookupStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string WorkerMatchedRouterSource
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "workerMatchedRouterSource");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string WorkerFinalRouterSource
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "workerFinalRouterSource");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong TransferSize
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "transferSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong EncodedBodySize
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "encodedBodySize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DecodedBodySize
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "decodedBodySize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort ResponseStatus
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "responseStatus");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RenderBlockingStatusType RenderBlockingStatus
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RenderBlockingStatusType>.Get(JSObject, "renderBlockingStatus");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ContentType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "contentType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ContentEncoding
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "contentEncoding");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.JSObjectAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PerformanceServerTiming, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PerformanceServerTiming>> ServerTiming
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PerformanceServerTiming, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PerformanceServerTiming>>>.Get(JSObject, "serverTiming");
    }
}

#nullable disable