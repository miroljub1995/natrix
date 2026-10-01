// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCIceCandidatePair: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCIceCandidatePair>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIceCandidatePair(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCIceCandidatePair global::Natrix.JSCore.IJSObjectProxy<RTCIceCandidatePair>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<RTCIceCandidatePair>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceCandidate Local
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCIceCandidate>.Get(JSObject, "local");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCIceCandidate Remote
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCIceCandidate>.Get(JSObject, "remote");
    }
}

#nullable disable