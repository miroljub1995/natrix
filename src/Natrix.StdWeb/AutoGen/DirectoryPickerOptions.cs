// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DirectoryPickerOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<DirectoryPickerOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DirectoryPickerOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DirectoryPickerOptions global::Natrix.JSCore.IJSObjectProxy<DirectoryPickerOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DirectoryPickerOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Id
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "id");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "id", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.WellKnownDirectory, global::Natrix.StdWeb.FileSystemHandle, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WellKnownDirectory>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemHandle>> StartIn
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.WellKnownDirectory, global::Natrix.StdWeb.FileSystemHandle, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WellKnownDirectory>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemHandle>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.WellKnownDirectory, global::Natrix.StdWeb.FileSystemHandle, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WellKnownDirectory>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemHandle>>>>(JSObject, "startIn");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.WellKnownDirectory, global::Natrix.StdWeb.FileSystemHandle, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WellKnownDirectory>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemHandle>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.WellKnownDirectory, global::Natrix.StdWeb.FileSystemHandle, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WellKnownDirectory>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemHandle>>>>(JSObject, "startIn", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FileSystemPermissionMode Mode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.FileSystemPermissionMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FileSystemPermissionMode>>(JSObject, "mode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.FileSystemPermissionMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.FileSystemPermissionMode>>(JSObject, "mode", value);
    }
}

#nullable disable