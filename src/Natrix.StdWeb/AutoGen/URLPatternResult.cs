// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class URLPatternResult: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<URLPatternResult>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public URLPatternResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static URLPatternResult global::Natrix.JSCore.IJSObjectProxy<URLPatternResult>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public URLPatternResult(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.URLPatternInit, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternInit>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.URLPatternInit, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternInit>>>> Inputs
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.URLPatternInit, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternInit>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.URLPatternInit, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternInit>>>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.URLPatternInit, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternInit>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.URLPatternInit, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternInit>>>>>>(JSObject, "inputs");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.URLPatternInit, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternInit>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.URLPatternInit, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternInit>>>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.URLPatternInit, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternInit>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.URLPatternInit, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternInit>>>>>>(JSObject, "inputs", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.URLPatternComponentResult Protocol
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternComponentResult>>(JSObject, "protocol");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternComponentResult>>(JSObject, "protocol", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.URLPatternComponentResult Username
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternComponentResult>>(JSObject, "username");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternComponentResult>>(JSObject, "username", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.URLPatternComponentResult Password
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternComponentResult>>(JSObject, "password");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternComponentResult>>(JSObject, "password", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.URLPatternComponentResult Hostname
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternComponentResult>>(JSObject, "hostname");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternComponentResult>>(JSObject, "hostname", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.URLPatternComponentResult Port
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternComponentResult>>(JSObject, "port");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternComponentResult>>(JSObject, "port", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.URLPatternComponentResult Pathname
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternComponentResult>>(JSObject, "pathname");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternComponentResult>>(JSObject, "pathname", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.URLPatternComponentResult Search
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternComponentResult>>(JSObject, "search");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternComponentResult>>(JSObject, "search", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.URLPatternComponentResult Hash
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternComponentResult>>(JSObject, "hash");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.URLPatternComponentResult>>(JSObject, "hash", value);
    }
}

#nullable disable