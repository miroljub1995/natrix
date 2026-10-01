// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaMetadataInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaMetadataInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaMetadataInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaMetadataInit global::Natrix.JSCore.IJSObjectProxy<MediaMetadataInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaMetadataInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Title
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "title");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "title", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Artist
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "artist");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "artist", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Album
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "album");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "album", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaImage, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaImage>> Artwork
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaImage, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaImage>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaImage, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaImage>>>>(JSObject, "artwork");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaImage, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaImage>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaImage, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaImage>>>>(JSObject, "artwork", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ChapterInformationInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ChapterInformationInit>> ChapterInfo
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ChapterInformationInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ChapterInformationInit>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ChapterInformationInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ChapterInformationInit>>>>(JSObject, "chapterInfo");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ChapterInformationInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ChapterInformationInit>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ChapterInformationInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ChapterInformationInit>>>>(JSObject, "chapterInfo", value);
    }
}

#nullable disable