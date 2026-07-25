// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PerformanceResourceTiming: global::Natrix.StdWeb.PerformanceEntry
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PerformanceResourceTiming(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PerformanceServerTiming, global::Natrix.StdWeb.PropertyAccessor> ServerTiming
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PerformanceServerTiming, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "serverTiming");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string InitiatorType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "initiatorType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DeliveryType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "deliveryType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string NextHopProtocol
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "nextHopProtocol");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double WorkerStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "workerStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double RedirectStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "redirectStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double RedirectEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "redirectEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FetchStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "fetchStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DomainLookupStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "domainLookupStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double DomainLookupEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "domainLookupEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ConnectStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "connectStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ConnectEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "connectEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double SecureConnectionStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "secureConnectionStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double RequestStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "requestStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FinalResponseHeadersStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "finalResponseHeadersStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FirstInterimResponseStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "firstInterimResponseStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ResponseStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "responseStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ResponseEnd
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "responseEnd");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double WorkerRouterEvaluationStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "workerRouterEvaluationStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double WorkerCacheLookupStart
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "workerCacheLookupStart");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string WorkerMatchedRouterSource
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "workerMatchedRouterSource");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string WorkerFinalRouterSource
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "workerFinalRouterSource");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong TransferSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "transferSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong EncodedBodySize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "encodedBodySize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong DecodedBodySize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "decodedBodySize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort ResponseStatus
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "responseStatus");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RenderBlockingStatusType RenderBlockingStatus
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RenderBlockingStatusType, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "renderBlockingStatus");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ContentType
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "contentType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ContentEncoding
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "contentEncoding");
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