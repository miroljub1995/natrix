// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLSpanElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLSpanElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLSpanElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLSpanElement global::Natrix.JSCore.IJSObjectProxy<HTMLSpanElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLSpanElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLSpanElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLSpanElement");
        return new global::Natrix.StdWeb.HTMLSpanElement(___res_2);
    }
}

#nullable disable