// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FileSystemPermissionDescriptor: global::Natrix.StdWeb.PermissionDescriptor
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FileSystemPermissionDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FileSystemPermissionDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.FileSystemHandle Handle
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.FileSystemHandle, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "handle");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.FileSystemHandle, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "handle", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FileSystemPermissionMode Mode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.FileSystemPermissionMode, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "mode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.FileSystemPermissionMode, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "mode", value);
    }
}

#nullable disable