// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLAnchorElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLAnchorElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLAnchorElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLAnchorElement global::Natrix.JSCore.IJSObjectProxy<HTMLAnchorElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLAnchorElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLAnchorElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLAnchorElement");
        return new global::Natrix.StdWeb.HTMLAnchorElement(___res_2);
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
    public string Text
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "text");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "text", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ReferrerPolicy
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "referrerPolicy");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "referrerPolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Coords
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "coords");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "coords", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Charset
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "charset");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "charset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Rev
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "rev");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "rev", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Shape
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "shape");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "shape", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint AttributionSourceId
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "attributionSourceId");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "attributionSourceId", value);
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
    public string Href
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "href");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "href", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Target
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "target");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "target", value);
    }
}

#nullable disable