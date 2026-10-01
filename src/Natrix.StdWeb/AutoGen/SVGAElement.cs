// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGAElement: global::Natrix.StdWeb.SVGGraphicsElement, global::Natrix.JSCore.IJSObjectProxy<SVGAElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGAElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGAElement global::Natrix.JSCore.IJSObjectProxy<SVGAElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGAElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedString Target
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedString>.Get(JSObject, "target");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Download
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "download");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "download", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Ping
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "ping");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "ping", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Rel
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "rel");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "rel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMTokenList RelList
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMTokenList>.Get(JSObject, "relList");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Hreflang
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "hreflang");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "hreflang", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Type
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ReferrerPolicy
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "referrerPolicy");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "referrerPolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Origin
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "origin");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Protocol
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "protocol");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "protocol", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Username
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "username");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "username", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Password
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "password");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "password", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Host
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "host");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "host", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Hostname
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "hostname");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "hostname", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Port
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "port");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "port", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Pathname
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "pathname");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "pathname", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Search
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "search");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "search", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Hash
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "hash");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "hash", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.SVGAnimatedString Href
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SVGAnimatedString>.Get(JSObject, "href");
    }
}

#nullable disable