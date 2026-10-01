// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLBaseElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLBaseElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLBaseElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLBaseElement global::Natrix.JSCore.IJSObjectProxy<HTMLBaseElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLBaseElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLBaseElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLBaseElement");
        return new global::Natrix.StdWeb.HTMLBaseElement(___res_2);
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