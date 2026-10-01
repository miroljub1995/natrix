// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FileSystemPermissionDescriptor: global::Natrix.StdWeb.PermissionDescriptor, global::Natrix.JSCore.IJSObjectProxy<FileSystemPermissionDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FileSystemPermissionDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FileSystemPermissionDescriptor global::Natrix.JSCore.IJSObjectProxy<FileSystemPermissionDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FileSystemPermissionDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.FileSystemHandle Handle
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemHandle>.Get(JSObject, "handle");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemHandle>.Set(JSObject, "handle", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FileSystemPermissionMode Mode
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FileSystemPermissionMode>.Get(JSObject, "mode");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FileSystemPermissionMode>.Set(JSObject, "mode", value);
    }
}

#nullable disable