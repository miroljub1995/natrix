// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FontFaceSetLoadEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<FontFaceSetLoadEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FontFaceSetLoadEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FontFaceSetLoadEventInit global::Natrix.JSCore.IJSObjectProxy<FontFaceSetLoadEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FontFaceSetLoadEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.FontFace, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FontFace>> Fontfaces
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.FontFace, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FontFace>>>.Get(JSObject, "fontfaces");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.FontFace, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FontFace>>>.Set(JSObject, "fontfaces", value);
    }
}

#nullable disable