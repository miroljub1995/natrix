// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ReadableStreamGetReaderOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ReadableStreamGetReaderOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ReadableStreamGetReaderOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ReadableStreamGetReaderOptions global::Natrix.JSCore.IJSObjectProxy<ReadableStreamGetReaderOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ReadableStreamGetReaderOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ReadableStreamReaderMode Mode
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ReadableStreamReaderMode>.Get(JSObject, "mode");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ReadableStreamReaderMode>.Set(JSObject, "mode", value);
    }
}

#nullable disable