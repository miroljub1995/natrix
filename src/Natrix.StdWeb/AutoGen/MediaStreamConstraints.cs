// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaStreamConstraints: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaStreamConstraints>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaStreamConstraints(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaStreamConstraints global::Natrix.JSCore.IJSObjectProxy<MediaStreamConstraints>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaStreamConstraints(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraints>> Video
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraints>>>.Get(JSObject, "video");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraints>>>.Set(JSObject, "video", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraints>> Audio
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraints>>>.Get(JSObject, "audio");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.MediaTrackConstraints, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaTrackConstraints>>>.Set(JSObject, "audio", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PreferCurrentTab
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "preferCurrentTab");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "preferCurrentTab", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PeerIdentity
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "peerIdentity");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "peerIdentity", value);
    }
}

#nullable disable