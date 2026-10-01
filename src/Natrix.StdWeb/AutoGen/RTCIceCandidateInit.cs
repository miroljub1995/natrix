// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCIceCandidateInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCIceCandidateInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIceCandidateInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCIceCandidateInit global::Natrix.JSCore.IJSObjectProxy<RTCIceCandidateInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIceCandidateInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Candidate
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "candidate");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "candidate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? SdpMid
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "sdpMid");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "sdpMid", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort? SdpMLineIndex
    {
        get => global::Natrix.JSCore.Generics.NullableUInt16Accessor.Get(JSObject, "sdpMLineIndex");
        set => global::Natrix.JSCore.Generics.NullableUInt16Accessor.Set(JSObject, "sdpMLineIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? UsernameFragment
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "usernameFragment");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "usernameFragment", value);
    }
}

#nullable disable