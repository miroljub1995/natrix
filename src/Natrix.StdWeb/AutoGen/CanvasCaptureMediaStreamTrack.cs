// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CanvasCaptureMediaStreamTrack: global::Natrix.StdWeb.MediaStreamTrack, global::Natrix.JSCore.IJSObjectProxy<CanvasCaptureMediaStreamTrack>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CanvasCaptureMediaStreamTrack(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CanvasCaptureMediaStreamTrack global::Natrix.JSCore.IJSObjectProxy<CanvasCaptureMediaStreamTrack>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CanvasCaptureMediaStreamTrack>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HTMLCanvasElement Canvas
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLCanvasElement>.Get(JSObject, "canvas");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void RequestFrame()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "requestFrame", JSObject);
    }
}

#nullable disable