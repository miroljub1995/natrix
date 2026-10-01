// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioDataCopyToOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AudioDataCopyToOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioDataCopyToOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioDataCopyToOptions global::Natrix.JSCore.IJSObjectProxy<AudioDataCopyToOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioDataCopyToOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint PlaneIndex
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "planeIndex");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "planeIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FrameOffset
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "frameOffset");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "frameOffset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint FrameCount
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "frameCount");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "frameCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AudioSampleFormat Format
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioSampleFormat>.Get(JSObject, "format");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AudioSampleFormat>.Set(JSObject, "format", value);
    }
}

#nullable disable