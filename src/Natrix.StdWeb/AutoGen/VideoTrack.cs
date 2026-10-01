// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VideoTrack: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<VideoTrack>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoTrack(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static VideoTrack global::Natrix.JSCore.IJSObjectProxy<VideoTrack>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<VideoTrack>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Id
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "id");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Kind
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "kind");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Label
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "label");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Language
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "language");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Selected
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "selected");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "selected", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SourceBuffer? SourceBuffer
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.SourceBuffer>.Get(JSObject, "sourceBuffer");
    }
}

#nullable disable