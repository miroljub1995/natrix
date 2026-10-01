// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCRtpReceiveParameters: global::Natrix.StdWeb.RTCRtpParameters, global::Natrix.JSCore.IJSObjectProxy<RTCRtpReceiveParameters>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRtpReceiveParameters(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCRtpReceiveParameters global::Natrix.JSCore.IJSObjectProxy<RTCRtpReceiveParameters>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRtpReceiveParameters(): base()
    {
    }


}

#nullable disable