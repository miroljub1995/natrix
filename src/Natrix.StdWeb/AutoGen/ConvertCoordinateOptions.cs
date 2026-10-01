// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ConvertCoordinateOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ConvertCoordinateOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ConvertCoordinateOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ConvertCoordinateOptions global::Natrix.JSCore.IJSObjectProxy<ConvertCoordinateOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ConvertCoordinateOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSBoxType FromBox
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CSSBoxType>.Get(JSObject, "fromBox");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CSSBoxType>.Set(JSObject, "fromBox", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSBoxType ToBox
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CSSBoxType>.Get(JSObject, "toBox");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CSSBoxType>.Set(JSObject, "toBox", value);
    }
}

#nullable disable