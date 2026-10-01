// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCTrackEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<RTCTrackEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCTrackEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCTrackEventInit global::Natrix.JSCore.IJSObjectProxy<RTCTrackEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCTrackEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.RTCRtpReceiver Receiver
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCRtpReceiver>.Get(JSObject, "receiver");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCRtpReceiver>.Set(JSObject, "receiver", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.MediaStreamTrack Track
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStreamTrack>.Get(JSObject, "track");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStreamTrack>.Set(JSObject, "track", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaStream, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStream>> Streams
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaStream, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStream>>>.Get(JSObject, "streams");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaStream, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStream>>>.Set(JSObject, "streams", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.RTCRtpTransceiver Transceiver
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCRtpTransceiver>.Get(JSObject, "transceiver");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCRtpTransceiver>.Set(JSObject, "transceiver", value);
    }
}

#nullable disable