// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VideoFrameCallbackMetadata: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<VideoFrameCallbackMetadata>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoFrameCallbackMetadata(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static VideoFrameCallbackMetadata global::Natrix.JSCore.IJSObjectProxy<VideoFrameCallbackMetadata>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoFrameCallbackMetadata(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double PresentationTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "presentationTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "presentationTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double ExpectedDisplayTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "expectedDisplayTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "expectedDisplayTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Width
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Height
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double MediaTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "mediaTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "mediaTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint PresentedFrames
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "presentedFrames");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "presentedFrames", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ProcessingDuration
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "processingDuration");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "processingDuration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double CaptureTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "captureTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "captureTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ReceiveTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "receiveTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "receiveTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint RtpTimestamp
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "rtpTimestamp");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "rtpTimestamp", value);
    }
}

#nullable disable