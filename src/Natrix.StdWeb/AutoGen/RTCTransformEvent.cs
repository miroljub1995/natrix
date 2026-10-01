// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCTransformEvent: global::Natrix.StdWeb.Event, global::Natrix.JSCore.IJSObjectProxy<RTCTransformEvent>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCTransformEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCTransformEvent global::Natrix.JSCore.IJSObjectProxy<RTCTransformEvent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<RTCTransformEvent>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCRtpScriptTransformer Transformer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCRtpScriptTransformer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCRtpScriptTransformer>>(JSObject, "transformer");
    }
}

#nullable disable