// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaTrackCapabilities: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaTrackCapabilities>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaTrackCapabilities(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaTrackCapabilities global::Natrix.JSCore.IJSObjectProxy<MediaTrackCapabilities>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaTrackCapabilities(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> WhiteBalanceMode
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "whiteBalanceMode");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "whiteBalanceMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> ExposureMode
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "exposureMode");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "exposureMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> FocusMode
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "focusMode");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "focusMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange ExposureCompensation
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Get(JSObject, "exposureCompensation");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Set(JSObject, "exposureCompensation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange ExposureTime
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Get(JSObject, "exposureTime");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Set(JSObject, "exposureTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange ColorTemperature
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Get(JSObject, "colorTemperature");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Set(JSObject, "colorTemperature", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange Iso
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Get(JSObject, "iso");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Set(JSObject, "iso", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange Brightness
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Get(JSObject, "brightness");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Set(JSObject, "brightness", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange Contrast
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Get(JSObject, "contrast");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Set(JSObject, "contrast", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange Saturation
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Get(JSObject, "saturation");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Set(JSObject, "saturation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange Sharpness
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Get(JSObject, "sharpness");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Set(JSObject, "sharpness", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange FocusDistance
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Get(JSObject, "focusDistance");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Set(JSObject, "focusDistance", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange Pan
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Get(JSObject, "pan");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Set(JSObject, "pan", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange Tilt
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Get(JSObject, "tilt");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Set(JSObject, "tilt", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange Zoom
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Get(JSObject, "zoom");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>.Set(JSObject, "zoom", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor> Torch
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>.Get(JSObject, "torch");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>.Set(JSObject, "torch", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ULongRange Width
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ULongRange Height
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>.Set(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DoubleRange AspectRatio
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DoubleRange>.Get(JSObject, "aspectRatio");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DoubleRange>.Set(JSObject, "aspectRatio", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DoubleRange FrameRate
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DoubleRange>.Get(JSObject, "frameRate");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DoubleRange>.Set(JSObject, "frameRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> FacingMode
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "facingMode");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "facingMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> ResizeMode
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "resizeMode");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "resizeMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ULongRange SampleRate
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>.Get(JSObject, "sampleRate");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>.Set(JSObject, "sampleRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ULongRange SampleSize
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>.Get(JSObject, "sampleSize");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>.Set(JSObject, "sampleSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>>> EchoCancellation
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>>>>.Get(JSObject, "echoCancellation");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>>>>.Set(JSObject, "echoCancellation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor> AutoGainControl
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>.Get(JSObject, "autoGainControl");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>.Set(JSObject, "autoGainControl", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor> NoiseSuppression
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>.Get(JSObject, "noiseSuppression");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>.Set(JSObject, "noiseSuppression", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DoubleRange Latency
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DoubleRange>.Get(JSObject, "latency");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DoubleRange>.Set(JSObject, "latency", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ULongRange ChannelCount
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>.Get(JSObject, "channelCount");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>.Set(JSObject, "channelCount", value);
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
    public global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor> BackgroundBlur
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>.Get(JSObject, "backgroundBlur");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>.Set(JSObject, "backgroundBlur", value);
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
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> Cursor
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "cursor");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "cursor", value);
    }
}

#nullable disable