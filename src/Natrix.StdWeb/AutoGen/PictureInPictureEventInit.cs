// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PictureInPictureEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<PictureInPictureEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PictureInPictureEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PictureInPictureEventInit global::Natrix.JSCore.IJSObjectProxy<PictureInPictureEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PictureInPictureEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.PictureInPictureWindow PictureInPictureWindow
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PictureInPictureWindow>.Get(JSObject, "pictureInPictureWindow");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PictureInPictureWindow>.Set(JSObject, "pictureInPictureWindow", value);
    }
}

#nullable disable