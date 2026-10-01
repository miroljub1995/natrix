// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLHtmlElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLHtmlElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLHtmlElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLHtmlElement global::Natrix.JSCore.IJSObjectProxy<HTMLHtmlElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLHtmlElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLHtmlElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLHtmlElement");
        return new global::Natrix.StdWeb.HTMLHtmlElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Version
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "version");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "version", value);
    }
}

#nullable disable