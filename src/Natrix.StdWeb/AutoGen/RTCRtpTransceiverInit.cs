// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCRtpTransceiverInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCRtpTransceiverInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRtpTransceiverInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCRtpTransceiverInit global::Natrix.JSCore.IJSObjectProxy<RTCRtpTransceiverInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRtpTransceiverInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.RTCRtpTransceiverDirection Direction
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCRtpTransceiverDirection>.Get(JSObject, "direction");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.RTCRtpTransceiverDirection>.Set(JSObject, "direction", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaStream, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStream>> Streams
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaStream, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStream>>>.Get(JSObject, "streams");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaStream, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStream>>>.Set(JSObject, "streams", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCRtpEncodingParameters, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCRtpEncodingParameters>> SendEncodings
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCRtpEncodingParameters, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCRtpEncodingParameters>>>.Get(JSObject, "sendEncodings");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCRtpEncodingParameters, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCRtpEncodingParameters>>>.Set(JSObject, "sendEncodings", value);
    }
}

#nullable disable