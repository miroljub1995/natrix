// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VideoFrameCallbackMetadata: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoFrameCallbackMetadata(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoFrameCallbackMetadata(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double PresentationTime
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "presentationTime");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "presentationTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double ExpectedDisplayTime
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "expectedDisplayTime");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "expectedDisplayTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Width
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "width");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Height
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "height");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double MediaTime
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "mediaTime");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "mediaTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint PresentedFrames
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "presentedFrames");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "presentedFrames", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ProcessingDuration
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "processingDuration");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "processingDuration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double CaptureTime
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "captureTime");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "captureTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ReceiveTime
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "receiveTime");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "receiveTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint RtpTimestamp
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "rtpTimestamp");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "rtpTimestamp", value);
    }
}

#nullable disable