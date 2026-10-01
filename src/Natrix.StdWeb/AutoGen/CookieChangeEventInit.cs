// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CookieChangeEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<CookieChangeEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CookieChangeEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CookieChangeEventInit global::Natrix.JSCore.IJSObjectProxy<CookieChangeEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CookieChangeEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>> Changed
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>>>.Get(JSObject, "changed");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>>>.Set(JSObject, "changed", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>> Deleted
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>>>.Get(JSObject, "deleted");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>>>.Set(JSObject, "deleted", value);
    }
}

#nullable disable