// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TextDecoderOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TextDecoderOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TextDecoderOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TextDecoderOptions global::Natrix.JSCore.IJSObjectProxy<TextDecoderOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TextDecoderOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Fatal
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "fatal");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "fatal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IgnoreBOM
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "ignoreBOM");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "ignoreBOM", value);
    }
}

#nullable disable