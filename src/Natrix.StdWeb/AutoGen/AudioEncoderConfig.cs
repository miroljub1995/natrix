// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioEncoderConfig: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AudioEncoderConfig>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioEncoderConfig(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioEncoderConfig global::Natrix.JSCore.IJSObjectProxy<AudioEncoderConfig>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioEncoderConfig(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AacEncoderConfig Aac
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AacEncoderConfig>.Get(JSObject, "aac");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AacEncoderConfig>.Set(JSObject, "aac", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FlacEncoderConfig Flac
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FlacEncoderConfig>.Get(JSObject, "flac");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FlacEncoderConfig>.Set(JSObject, "flac", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.OpusEncoderConfig Opus
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.OpusEncoderConfig>.Get(JSObject, "opus");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.OpusEncoderConfig>.Set(JSObject, "opus", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Codec
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "codec");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "codec", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint SampleRate
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "sampleRate");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "sampleRate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint NumberOfChannels
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "numberOfChannels");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "numberOfChannels", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Bitrate
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bitrate");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bitrate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BitrateMode BitrateMode
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.BitrateMode>.Get(JSObject, "bitrateMode");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.BitrateMode>.Set(JSObject, "bitrateMode", value);
    }
}

#nullable disable