// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ColorSelectionResult: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ColorSelectionResult>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ColorSelectionResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ColorSelectionResult global::Natrix.JSCore.IJSObjectProxy<ColorSelectionResult>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ColorSelectionResult(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SRGBHex
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "sRGBHex");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "sRGBHex", value);
    }
}

#nullable disable