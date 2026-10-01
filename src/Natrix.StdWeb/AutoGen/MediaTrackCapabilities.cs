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
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "whiteBalanceMode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "whiteBalanceMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> ExposureMode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "exposureMode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "exposureMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> FocusMode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "focusMode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "focusMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange ExposureCompensation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "exposureCompensation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "exposureCompensation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange ExposureTime
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "exposureTime");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "exposureTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange ColorTemperature
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "colorTemperature");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "colorTemperature", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange Iso
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "iso");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "iso", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange Brightness
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "brightness");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "brightness", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange Contrast
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "contrast");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "contrast", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange Saturation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "saturation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "saturation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange Sharpness
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "sharpness");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "sharpness", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange FocusDistance
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "focusDistance");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "focusDistance", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange Pan
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "pan");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "pan", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange Tilt
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "tilt");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "tilt", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MediaSettingsRange Zoom
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "zoom");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MediaSettingsRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaSettingsRange>>(JSObject, "zoom", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor> Torch
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>>(JSObject, "torch");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>>(JSObject, "torch", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ULongRange Width
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ULongRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>>(JSObject, "width");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ULongRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>>(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ULongRange Height
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ULongRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>>(JSObject, "height");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ULongRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>>(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DoubleRange AspectRatio
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DoubleRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DoubleRange>>(JSObject, "aspectRatio");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.DoubleRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DoubleRange>>(JSObject, "aspectRatio", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DoubleRange FrameRate
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DoubleRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DoubleRange>>(JSObject, "frameRate");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.DoubleRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DoubleRange>>(JSObject, "frameRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> FacingMode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "facingMode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "facingMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> ResizeMode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "resizeMode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "resizeMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ULongRange SampleRate
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ULongRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>>(JSObject, "sampleRate");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ULongRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>>(JSObject, "sampleRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ULongRange SampleSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ULongRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>>(JSObject, "sampleSize");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ULongRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>>(JSObject, "sampleSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>>> EchoCancellation
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>>>>>(JSObject, "echoCancellation");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, string, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.StringAccessor>>>>>(JSObject, "echoCancellation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor> AutoGainControl
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>>(JSObject, "autoGainControl");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>>(JSObject, "autoGainControl", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor> NoiseSuppression
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>>(JSObject, "noiseSuppression");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>>(JSObject, "noiseSuppression", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DoubleRange Latency
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.DoubleRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DoubleRange>>(JSObject, "latency");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.DoubleRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DoubleRange>>(JSObject, "latency", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ULongRange ChannelCount
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ULongRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>>(JSObject, "channelCount");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.ULongRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ULongRange>>(JSObject, "channelCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DeviceId
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "deviceId");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "deviceId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string GroupId
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "groupId");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "groupId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor> BackgroundBlur
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>>(JSObject, "backgroundBlur");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<bool, global::Natrix.JSCore.Generics.BooleanAccessor>>>(JSObject, "backgroundBlur", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DisplaySurface
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "displaySurface");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "displaySurface", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool LogicalSurface
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "logicalSurface");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "logicalSurface", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> Cursor
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "cursor");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "cursor", value);
    }
}

#nullable disable