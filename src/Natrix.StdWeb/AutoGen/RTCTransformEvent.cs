// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCTransformEvent: global::Natrix.StdWeb.Event
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCTransformEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCRtpScriptTransformer Transformer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.RTCRtpScriptTransformer, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "transformer");
    }
}

#nullable disable