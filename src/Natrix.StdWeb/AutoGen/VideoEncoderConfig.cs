// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VideoEncoderConfig: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<VideoEncoderConfig>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoEncoderConfig(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static VideoEncoderConfig global::Natrix.JSCore.IJSObjectProxy<VideoEncoderConfig>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoEncoderConfig(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AvcEncoderConfig Avc
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AvcEncoderConfig>.Get(JSObject, "avc");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AvcEncoderConfig>.Set(JSObject, "avc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HevcEncoderConfig Hevc
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HevcEncoderConfig>.Get(JSObject, "hevc");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HevcEncoderConfig>.Set(JSObject, "hevc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Codec
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "codec");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "codec", value);
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
    public uint DisplayWidth
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "displayWidth");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "displayWidth", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint DisplayHeight
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "displayHeight");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "displayHeight", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Bitrate
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bitrate");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bitrate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Framerate
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "framerate");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "framerate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HardwareAcceleration HardwareAcceleration
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HardwareAcceleration>.Get(JSObject, "hardwareAcceleration");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HardwareAcceleration>.Set(JSObject, "hardwareAcceleration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AlphaOption Alpha
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AlphaOption>.Get(JSObject, "alpha");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AlphaOption>.Set(JSObject, "alpha", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ScalabilityMode
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "scalabilityMode");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "scalabilityMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoEncoderBitrateMode BitrateMode
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.VideoEncoderBitrateMode>.Get(JSObject, "bitrateMode");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.VideoEncoderBitrateMode>.Set(JSObject, "bitrateMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.LatencyMode LatencyMode
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.LatencyMode>.Get(JSObject, "latencyMode");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.LatencyMode>.Set(JSObject, "latencyMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ContentHint
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "contentHint");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "contentHint", value);
    }
}

#nullable disable