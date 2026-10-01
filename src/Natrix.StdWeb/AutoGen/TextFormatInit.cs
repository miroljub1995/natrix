// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TextFormatInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TextFormatInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TextFormatInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TextFormatInit global::Natrix.JSCore.IJSObjectProxy<TextFormatInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TextFormatInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint RangeStart
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "rangeStart");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "rangeStart", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint RangeEnd
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "rangeEnd");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "rangeEnd", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.UnderlineStyle UnderlineStyle
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.UnderlineStyle>.Get(JSObject, "underlineStyle");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.UnderlineStyle>.Set(JSObject, "underlineStyle", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.UnderlineThickness UnderlineThickness
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.UnderlineThickness>.Get(JSObject, "underlineThickness");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.UnderlineThickness>.Set(JSObject, "underlineThickness", value);
    }
}

#nullable disable