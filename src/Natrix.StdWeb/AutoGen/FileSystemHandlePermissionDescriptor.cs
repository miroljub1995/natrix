// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FileSystemHandlePermissionDescriptor: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<FileSystemHandlePermissionDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FileSystemHandlePermissionDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FileSystemHandlePermissionDescriptor global::Natrix.JSCore.IJSObjectProxy<FileSystemHandlePermissionDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FileSystemHandlePermissionDescriptor(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FileSystemPermissionMode Mode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.FileSystemPermissionMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FileSystemPermissionMode>>(JSObject, "mode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.FileSystemPermissionMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FileSystemPermissionMode>>(JSObject, "mode", value);
    }
}

#nullable disable