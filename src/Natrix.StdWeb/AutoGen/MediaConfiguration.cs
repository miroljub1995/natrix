// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaConfiguration: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaConfiguration>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaConfiguration(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaConfiguration global::Natrix.JSCore.IJSObjectProxy<MediaConfiguration>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaConfiguration(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoConfiguration Video
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.VideoConfiguration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoConfiguration>>(JSObject, "video");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.VideoConfiguration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoConfiguration>>(JSObject, "video", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AudioConfiguration Audio
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AudioConfiguration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioConfiguration>>(JSObject, "audio");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AudioConfiguration, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioConfiguration>>(JSObject, "audio", value);
    }
}

#nullable disable