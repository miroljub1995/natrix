// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FileSystem: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<FileSystem>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FileSystem(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FileSystem global::Natrix.JSCore.IJSObjectProxy<FileSystem>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<FileSystem>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.FileSystemDirectoryEntry Root
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemDirectoryEntry>.Get(JSObject, "root");
    }
}

#nullable disable