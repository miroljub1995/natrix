// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DocumentPictureInPictureEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<DocumentPictureInPictureEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DocumentPictureInPictureEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DocumentPictureInPictureEventInit global::Natrix.JSCore.IJSObjectProxy<DocumentPictureInPictureEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DocumentPictureInPictureEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.Window Window
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Window>.Get(JSObject, "window");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Window>.Set(JSObject, "window", value);
    }
}

#nullable disable