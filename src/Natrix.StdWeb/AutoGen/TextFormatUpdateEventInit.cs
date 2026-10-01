// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TextFormatUpdateEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<TextFormatUpdateEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TextFormatUpdateEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TextFormatUpdateEventInit global::Natrix.JSCore.IJSObjectProxy<TextFormatUpdateEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TextFormatUpdateEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.TextFormat, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TextFormat>> TextFormats
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.TextFormat, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TextFormat>>>.Get(JSObject, "textFormats");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.TextFormat, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TextFormat>>>.Set(JSObject, "textFormats", value);
    }
}

#nullable disable