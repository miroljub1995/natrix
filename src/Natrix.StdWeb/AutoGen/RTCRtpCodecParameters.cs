// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCRtpCodecParameters: global::Natrix.StdWeb.RTCRtpCodec, global::Natrix.JSCore.IJSObjectProxy<RTCRtpCodecParameters>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRtpCodecParameters(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCRtpCodecParameters global::Natrix.JSCore.IJSObjectProxy<RTCRtpCodecParameters>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCRtpCodecParameters(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required byte PayloadType
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "payloadType");
        set => global::Natrix.JSCore.Generics.ByteAccessor.Set(JSObject, "payloadType", value);
    }
}

#nullable disable