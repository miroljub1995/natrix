// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FileSystemGetDirectoryOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<FileSystemGetDirectoryOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FileSystemGetDirectoryOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FileSystemGetDirectoryOptions global::Natrix.JSCore.IJSObjectProxy<FileSystemGetDirectoryOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FileSystemGetDirectoryOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Create
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "create");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "create", value);
    }
}

#nullable disable