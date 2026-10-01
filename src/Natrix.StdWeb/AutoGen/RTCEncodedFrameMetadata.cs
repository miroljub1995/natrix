// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCEncodedFrameMetadata: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCEncodedFrameMetadata>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCEncodedFrameMetadata(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCEncodedFrameMetadata global::Natrix.JSCore.IJSObjectProxy<RTCEncodedFrameMetadata>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCEncodedFrameMetadata(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SynchronizationSource
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "synchronizationSource");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "synchronizationSource", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public byte PayloadType
    {
        get => global::Natrix.JSCore.Generics.ByteAccessor.Get(JSObject, "payloadType");
        set => global::Natrix.JSCore.Generics.ByteAccessor.Set(JSObject, "payloadType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor> ContributingSources
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>.Get(JSObject, "contributingSources");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>.Set(JSObject, "contributingSources", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint RtpTimestamp
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "rtpTimestamp");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "rtpTimestamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ReceiveTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "receiveTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "receiveTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double CaptureTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "captureTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "captureTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double SenderCaptureTimeOffset
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "senderCaptureTimeOffset");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "senderCaptureTimeOffset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string MimeType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "mimeType");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "mimeType", value);
    }
}

#nullable disable