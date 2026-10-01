// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LaunchParams: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<LaunchParams>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LaunchParams(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LaunchParams global::Natrix.JSCore.IJSObjectProxy<LaunchParams>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<LaunchParams>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? TargetURL
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "targetURL");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.FileSystemHandle, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemHandle>> Files
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.FileSystemHandle, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.FileSystemHandle>>>.Get(JSObject, "files");
    }
}

#nullable disable