// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CanvasCaptureMediaStreamTrack: global::Natrix.StdWeb.MediaStreamTrack
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CanvasCaptureMediaStreamTrack(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HTMLCanvasElement Canvas
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.HTMLCanvasElement, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "canvas");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void RequestFrame()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "requestFrame", JSObject);
    }
}

#nullable disable