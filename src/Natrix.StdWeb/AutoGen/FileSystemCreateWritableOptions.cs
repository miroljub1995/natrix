// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FileSystemCreateWritableOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<FileSystemCreateWritableOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FileSystemCreateWritableOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FileSystemCreateWritableOptions global::Natrix.JSCore.IJSObjectProxy<FileSystemCreateWritableOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FileSystemCreateWritableOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool KeepExistingData
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "keepExistingData");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "keepExistingData", value);
    }
}

#nullable disable