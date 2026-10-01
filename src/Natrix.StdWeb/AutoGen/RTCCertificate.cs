// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCCertificate: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCCertificate>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCCertificate(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCCertificate global::Natrix.JSCore.IJSObjectProxy<RTCCertificate>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<RTCCertificate>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Expires
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>(JSObject, "expires");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCDtlsFingerprint, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCDtlsFingerprint>> GetFingerprints()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getFingerprints", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCDtlsFingerprint, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCDtlsFingerprint>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCDtlsFingerprint, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCDtlsFingerprint>>>>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable