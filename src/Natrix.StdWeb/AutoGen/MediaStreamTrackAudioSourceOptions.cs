// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaStreamTrackAudioSourceOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaStreamTrackAudioSourceOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaStreamTrackAudioSourceOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaStreamTrackAudioSourceOptions global::Natrix.JSCore.IJSObjectProxy<MediaStreamTrackAudioSourceOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaStreamTrackAudioSourceOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.MediaStreamTrack MediaStreamTrack
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStreamTrack>.Get(JSObject, "mediaStreamTrack");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStreamTrack>.Set(JSObject, "mediaStreamTrack", value);
    }
}

#nullable disable