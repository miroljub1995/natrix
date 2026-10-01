// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioConfiguration: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AudioConfiguration>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioConfiguration(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioConfiguration global::Natrix.JSCore.IJSObjectProxy<AudioConfiguration>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioConfiguration(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string ContentType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "contentType");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "contentType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Channels
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "channels");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "channels", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Bitrate
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "bitrate");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "bitrate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Samplerate
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "samplerate");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "samplerate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool SpatialRendering
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "spatialRendering");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "spatialRendering", value);
    }
}

#nullable disable