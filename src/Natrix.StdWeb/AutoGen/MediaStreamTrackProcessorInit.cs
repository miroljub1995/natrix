// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaStreamTrackProcessorInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaStreamTrackProcessorInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaStreamTrackProcessorInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaStreamTrackProcessorInit global::Natrix.JSCore.IJSObjectProxy<MediaStreamTrackProcessorInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaStreamTrackProcessorInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStreamTrack, global::Natrix.StdWeb.MediaStreamTrackHandle, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStreamTrack>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStreamTrackHandle>> Track
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStreamTrack, global::Natrix.StdWeb.MediaStreamTrackHandle, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStreamTrack>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStreamTrackHandle>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStreamTrack, global::Natrix.StdWeb.MediaStreamTrackHandle, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStreamTrack>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStreamTrackHandle>>>>(JSObject, "track");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStreamTrack, global::Natrix.StdWeb.MediaStreamTrackHandle, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStreamTrack>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStreamTrackHandle>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStreamTrack, global::Natrix.StdWeb.MediaStreamTrackHandle, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStreamTrack>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaStreamTrackHandle>>>>(JSObject, "track", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort MaxBufferSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.JSCore.Generics.UInt16Accessor>(JSObject, "maxBufferSize");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ushort, global::Natrix.JSCore.Generics.UInt16Accessor>(JSObject, "maxBufferSize", value);
    }
}

#nullable disable