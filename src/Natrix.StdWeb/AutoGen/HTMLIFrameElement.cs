// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLIFrameElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLIFrameElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLIFrameElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLIFrameElement global::Natrix.JSCore.IJSObjectProxy<HTMLIFrameElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLIFrameElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Credentialless
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "credentialless");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "credentialless", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ConnectionAllowlist
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "connectionAllowlist");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "connectionAllowlist", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Csp
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "csp");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "csp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLIFrameElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLIFrameElement");
        return new global::Natrix.StdWeb.HTMLIFrameElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Src
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "src");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "src", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedHTML, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedHTML>, global::Natrix.JSCore.Generics.StringAccessor> Srcdoc
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedHTML, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedHTML>, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "srcdoc");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedHTML, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedHTML>, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "srcdoc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMTokenList Sandbox
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMTokenList>.Get(JSObject, "sandbox");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Allow
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "allow");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "allow", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool AllowFullscreen
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "allowFullscreen");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "allowFullscreen", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Width
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Height
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ReferrerPolicy
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "referrerPolicy");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "referrerPolicy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Loading
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "loading");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "loading", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Document? ContentDocument
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Document>.Get(JSObject, "contentDocument");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Window? ContentWindow
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Window>.Get(JSObject, "contentWindow");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Document? GetSVGDocument()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getSVGDocument", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Document>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Align
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "align");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "align", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Scrolling
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "scrolling");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "scrolling", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FrameBorder
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "frameBorder");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "frameBorder", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string LongDesc
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "longDesc");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "longDesc", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string MarginHeight
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "marginHeight");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "marginHeight", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string MarginWidth
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "marginWidth");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "marginWidth", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PermissionsPolicy PermissionsPolicy
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.PermissionsPolicy>.Get(JSObject, "permissionsPolicy");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PrivateToken
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "privateToken");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "privateToken", value);
    }
}

#nullable disable