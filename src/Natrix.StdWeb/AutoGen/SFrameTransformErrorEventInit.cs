// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SFrameTransformErrorEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<SFrameTransformErrorEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SFrameTransformErrorEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SFrameTransformErrorEventInit global::Natrix.JSCore.IJSObjectProxy<SFrameTransformErrorEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SFrameTransformErrorEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.SFrameTransformErrorEventType ErrorType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SFrameTransformErrorEventType>.Get(JSObject, "errorType");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SFrameTransformErrorEventType>.Set(JSObject, "errorType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCEncodedVideoFrame, global::Natrix.StdWeb.RTCEncodedAudioFrame, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCEncodedVideoFrame>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCEncodedAudioFrame>> Frame
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCEncodedVideoFrame, global::Natrix.StdWeb.RTCEncodedAudioFrame, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCEncodedVideoFrame>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCEncodedAudioFrame>>>.Get(JSObject, "frame");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCEncodedVideoFrame, global::Natrix.StdWeb.RTCEncodedAudioFrame, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCEncodedVideoFrame>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RTCEncodedAudioFrame>>>.Set(JSObject, "frame", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<ulong, global::System.Numerics.BigInteger, global::Natrix.JSCore.Generics.UInt64Accessor, global::Natrix.JSCore.Generics.BigIntegerAccessor>? KeyID
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<ulong, global::System.Numerics.BigInteger, global::Natrix.JSCore.Generics.UInt64Accessor, global::Natrix.JSCore.Generics.BigIntegerAccessor>>.Get(JSObject, "keyID");
        set => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<ulong, global::System.Numerics.BigInteger, global::Natrix.JSCore.Generics.UInt64Accessor, global::Natrix.JSCore.Generics.BigIntegerAccessor>>.Set(JSObject, "keyID", value);
    }
}

#nullable disable