// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaTrackSettings: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaTrackSettings>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaTrackSettings(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaTrackSettings global::Natrix.JSCore.IJSObjectProxy<MediaTrackSettings>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaTrackSettings(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string WhiteBalanceMode
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "whiteBalanceMode");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "whiteBalanceMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ExposureMode
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "exposureMode");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "exposureMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FocusMode
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "focusMode");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "focusMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Point2D, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Point2D>> PointsOfInterest
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Point2D, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Point2D>>>.Get(JSObject, "pointsOfInterest");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Point2D, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Point2D>>>.Set(JSObject, "pointsOfInterest", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ExposureCompensation
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "exposureCompensation");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "exposureCompensation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ExposureTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "exposureTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "exposureTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ColorTemperature
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "colorTemperature");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "colorTemperature", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Iso
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "iso");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "iso", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Brightness
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "brightness");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "brightness", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Contrast
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "contrast");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "contrast", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Saturation
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "saturation");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "saturation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Sharpness
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "sharpness");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "sharpness", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FocusDistance
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "focusDistance");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "focusDistance", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Pan
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "pan");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "pan", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Tilt
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "tilt");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "tilt", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Zoom
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "zoom");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "zoom", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Torch
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "torch");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "torch", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Width
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Height
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AspectRatio
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "aspectRatio");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "aspectRatio", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FrameRate
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "frameRate");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "frameRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FacingMode
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "facingMode");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "facingMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ResizeMode
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "resizeMode");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "resizeMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SampleRate
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "sampleRate");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "sampleRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SampleSize
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "sampleSize");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "sampleSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor> EchoCancellation
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "echoCancellation");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "echoCancellation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool AutoGainControl
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "autoGainControl");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "autoGainControl", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool NoiseSuppression
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "noiseSuppression");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "noiseSuppression", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Latency
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "latency");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "latency", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ChannelCount
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "channelCount");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "channelCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DeviceId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "deviceId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "deviceId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string GroupId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "groupId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "groupId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool BackgroundBlur
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "backgroundBlur");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "backgroundBlur", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DisplaySurface
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "displaySurface");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "displaySurface", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool LogicalSurface
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "logicalSurface");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "logicalSurface", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Cursor
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "cursor");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "cursor", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RestrictOwnAudio
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "restrictOwnAudio");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "restrictOwnAudio", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool SuppressLocalAudioPlayback
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "suppressLocalAudioPlayback");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "suppressLocalAudioPlayback", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ScreenPixelRatio
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "screenPixelRatio");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "screenPixelRatio", value);
    }
}

#nullable disable