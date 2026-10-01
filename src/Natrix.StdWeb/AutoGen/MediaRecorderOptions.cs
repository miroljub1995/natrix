// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaRecorderOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaRecorderOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaRecorderOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaRecorderOptions global::Natrix.JSCore.IJSObjectProxy<MediaRecorderOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaRecorderOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string MimeType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "mimeType");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "mimeType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint AudioBitsPerSecond
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "audioBitsPerSecond");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "audioBitsPerSecond", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint VideoBitsPerSecond
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "videoBitsPerSecond");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "videoBitsPerSecond", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint BitsPerSecond
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "bitsPerSecond");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "bitsPerSecond", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.BitrateMode AudioBitrateMode
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.BitrateMode>.Get(JSObject, "audioBitrateMode");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.BitrateMode>.Set(JSObject, "audioBitrateMode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double VideoKeyFrameIntervalDuration
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "videoKeyFrameIntervalDuration");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "videoKeyFrameIntervalDuration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint VideoKeyFrameIntervalCount
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "videoKeyFrameIntervalCount");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "videoKeyFrameIntervalCount", value);
    }
}

#nullable disable