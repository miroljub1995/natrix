// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VideoTrackGenerator: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<VideoTrackGenerator>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoTrackGenerator(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static VideoTrackGenerator global::Natrix.JSCore.IJSObjectProxy<VideoTrackGenerator>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<VideoTrackGenerator>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.VideoTrackGenerator New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "VideoTrackGenerator");
        return new global::Natrix.StdWeb.VideoTrackGenerator(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WritableStream Writable
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.WritableStream>.Get(JSObject, "writable");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Muted
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "muted");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "muted", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaStreamTrack Track
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStreamTrack>.Get(JSObject, "track");
    }
}

#nullable disable