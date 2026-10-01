// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TrackEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<TrackEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TrackEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TrackEventInit global::Natrix.JSCore.IJSObjectProxy<TrackEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TrackEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.VideoTrack, global::Natrix.StdWeb.AudioTrack, global::Natrix.StdWeb.TextTrack, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoTrack>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioTrack>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TextTrack>>? Track
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.VideoTrack, global::Natrix.StdWeb.AudioTrack, global::Natrix.StdWeb.TextTrack, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoTrack>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioTrack>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TextTrack>>?, global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.VideoTrack, global::Natrix.StdWeb.AudioTrack, global::Natrix.StdWeb.TextTrack, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoTrack>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioTrack>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TextTrack>>>>(JSObject, "track");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.VideoTrack, global::Natrix.StdWeb.AudioTrack, global::Natrix.StdWeb.TextTrack, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoTrack>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioTrack>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TextTrack>>?, global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.VideoTrack, global::Natrix.StdWeb.AudioTrack, global::Natrix.StdWeb.TextTrack, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoTrack>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioTrack>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TextTrack>>>>(JSObject, "track", value);
    }
}

#nullable disable