// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MimeType: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MimeType>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MimeType(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MimeType global::Natrix.JSCore.IJSObjectProxy<MimeType>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<MimeType>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Type
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Description
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "description");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Suffixes
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "suffixes");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Plugin EnabledPlugin
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Plugin, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Plugin>>(JSObject, "enabledPlugin");
    }
}

#nullable disable