// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ExtendableCookieChangeEventInit: global::Natrix.StdWeb.ExtendableEventInit, global::Natrix.JSCore.IJSObjectProxy<ExtendableCookieChangeEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ExtendableCookieChangeEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ExtendableCookieChangeEventInit global::Natrix.JSCore.IJSObjectProxy<ExtendableCookieChangeEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ExtendableCookieChangeEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>> Changed
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>>>>(JSObject, "changed");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>>>>(JSObject, "changed", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>> Deleted
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>>>>(JSObject, "deleted");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CookieListItem, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CookieListItem>>>>(JSObject, "deleted", value);
    }
}

#nullable disable