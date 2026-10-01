// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FilePropertyBag: global::Natrix.StdWeb.BlobPropertyBag, global::Natrix.JSCore.IJSObjectProxy<FilePropertyBag>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FilePropertyBag(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FilePropertyBag global::Natrix.JSCore.IJSObjectProxy<FilePropertyBag>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FilePropertyBag(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public long LastModified
    {
        get => global::Natrix.JSCore.Generics.Int64Accessor.Get(JSObject, "lastModified");
        set => global::Natrix.JSCore.Generics.Int64Accessor.Set(JSObject, "lastModified", value);
    }
}

#nullable disable