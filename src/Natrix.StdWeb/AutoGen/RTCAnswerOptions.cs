// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCAnswerOptions: global::Natrix.StdWeb.RTCOfferAnswerOptions, global::Natrix.JSCore.IJSObjectProxy<RTCAnswerOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCAnswerOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCAnswerOptions global::Natrix.JSCore.IJSObjectProxy<RTCAnswerOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCAnswerOptions(): base()
    {
    }


}

#nullable disable