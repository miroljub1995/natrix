// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaElementAudioSourceOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaElementAudioSourceOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaElementAudioSourceOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaElementAudioSourceOptions global::Natrix.JSCore.IJSObjectProxy<MediaElementAudioSourceOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaElementAudioSourceOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.HTMLMediaElement MediaElement
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.HTMLMediaElement, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLMediaElement>>(JSObject, "mediaElement");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.HTMLMediaElement, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLMediaElement>>(JSObject, "mediaElement", value);
    }
}

#nullable disable