// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLMetaElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLMetaElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLMetaElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLMetaElement global::Natrix.JSCore.IJSObjectProxy<HTMLMetaElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLMetaElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLMetaElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLMetaElement");
        return new global::Natrix.StdWeb.HTMLMetaElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string HttpEquiv
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "httpEquiv");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "httpEquiv", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Content
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "content");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "content", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Media
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "media");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "media", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Scheme
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "scheme");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "scheme", value);
    }
}

#nullable disable