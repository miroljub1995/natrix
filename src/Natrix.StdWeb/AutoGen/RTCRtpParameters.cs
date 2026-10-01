// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCRtpParameters: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCRtpParameters>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRtpParameters(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCRtpParameters global::Natrix.JSCore.IJSObjectProxy<RTCRtpParameters>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRtpParameters(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCRtpHeaderExtensionParameters, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCRtpHeaderExtensionParameters>> HeaderExtensions
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCRtpHeaderExtensionParameters, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCRtpHeaderExtensionParameters>>>.Get(JSObject, "headerExtensions");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCRtpHeaderExtensionParameters, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCRtpHeaderExtensionParameters>>>.Set(JSObject, "headerExtensions", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.RTCRtcpParameters Rtcp
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCRtcpParameters>.Get(JSObject, "rtcp");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCRtcpParameters>.Set(JSObject, "rtcp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCRtpCodecParameters, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCRtpCodecParameters>> Codecs
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCRtpCodecParameters, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCRtpCodecParameters>>>.Get(JSObject, "codecs");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RTCRtpCodecParameters, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCRtpCodecParameters>>>.Set(JSObject, "codecs", value);
    }
}

#nullable disable