// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ChapterInformation: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ChapterInformation>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ChapterInformation(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ChapterInformation global::Natrix.JSCore.IJSObjectProxy<ChapterInformation>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ChapterInformation>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Title
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "title");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double StartTime
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.JSCore.Generics.DoubleAccessor>(JSObject, "startTime");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.MediaImage, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaImage>> Artwork
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.MediaImage, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaImage>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.MediaImage, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MediaImage>>>>(JSObject, "artwork");
    }
}

#nullable disable