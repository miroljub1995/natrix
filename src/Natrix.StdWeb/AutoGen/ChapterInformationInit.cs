// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ChapterInformationInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ChapterInformationInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ChapterInformationInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ChapterInformationInit global::Natrix.JSCore.IJSObjectProxy<ChapterInformationInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ChapterInformationInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Title
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "title");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "title", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double StartTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "startTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "startTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaImage, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaImage>> Artwork
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaImage, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaImage>>>.Get(JSObject, "artwork");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MediaImage, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaImage>>>.Set(JSObject, "artwork", value);
    }
}

#nullable disable