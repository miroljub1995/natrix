// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FilePickerOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<FilePickerOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FilePickerOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FilePickerOptions global::Natrix.JSCore.IJSObjectProxy<FilePickerOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FilePickerOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.FilePickerAcceptType, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FilePickerAcceptType>> Types
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.FilePickerAcceptType, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FilePickerAcceptType>>>.Get(JSObject, "types");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.FilePickerAcceptType, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FilePickerAcceptType>>>.Set(JSObject, "types", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ExcludeAcceptAllOption
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "excludeAcceptAllOption");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "excludeAcceptAllOption", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Id
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "id");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "id", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.WellKnownDirectory, global::Natrix.StdWeb.FileSystemHandle, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WellKnownDirectory>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemHandle>> StartIn
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.WellKnownDirectory, global::Natrix.StdWeb.FileSystemHandle, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WellKnownDirectory>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemHandle>>>.Get(JSObject, "startIn");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.WellKnownDirectory, global::Natrix.StdWeb.FileSystemHandle, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WellKnownDirectory>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemHandle>>>.Set(JSObject, "startIn", value);
    }
}

#nullable disable